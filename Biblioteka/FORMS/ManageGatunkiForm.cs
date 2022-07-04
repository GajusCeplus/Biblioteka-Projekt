using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka.FORMS
{
    public partial class ManageGatunkiForm : Form
    {
        CLASSES.GATUNEK gatunek = new CLASSES.GATUNEK();

        public ManageGatunkiForm(string userType)
        {
            InitializeComponent();

            //ograniczenia zwyklego usera
            if(userType.Equals("user"))
            {
                Dodaj.Enabled = false;
                Edit.Enabled = false;
                del.Enabled = false;
            }
        }
        //x
        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //zaladowanie okna / aktualizacja
        private void ManageGatunkiForm_Load(object sender, EventArgs e)
        {
            //wypełnienie grida
            dataGridView_gatunek.DataSource = gatunek.ListaGatunek();
            //clear
            textBox_nazwa.Text = "";
            textBox_id.Text = "";

        }

        //dodaj gatunek button
        private void Dodaj_Click(object sender, EventArgs e)
        {
            string name = textBox_nazwa.Text;
            if(name.Trim().Equals(""))
            {
                MessageBox.Show("Wpisz nazwę gatunku", "Pusta nazwa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(gatunek.addGatunek(name))
                {
                    MessageBox.Show("Nowy gatunek dodany", "Nowy gatunek", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //wypełnienie grida
                    dataGridView_gatunek.DataSource = gatunek.ListaGatunek();
                }
                else
                {
                    MessageBox.Show("Nie dodano gatunku", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        //edytuj dany gatunek button
        private void Edit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox_id.Text);
                string name = textBox_nazwa.Text;

                if (name.Trim().Equals(""))
                {
                    MessageBox.Show("Wpisz nazwę gatunku", "Pusta nazwa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (gatunek.editGatunek(id, name))
                    {
                        MessageBox.Show("gatunek zaktualizowano", "Edycja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //wypełnienie grida
                        dataGridView_gatunek.DataSource = gatunek.ListaGatunek();
                    }
                    else
                    {
                        MessageBox.Show("nie zaktualizowano gatunku", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //usun gatunek button
        private void del_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox_id.Text);
                if (MessageBox.Show("Czy jesteś pewien, że chcesz usunąć ten gatunek?", "Jesteś pewny?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (gatunek.removeGatunek(id))
                    {
                        MessageBox.Show("gatunek usunięto", "Usuwanie", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //clear
                        textBox_id.Text = "";
                        textBox_nazwa.Text = "";
                        //wypełnienie grida
                        dataGridView_gatunek.DataSource = gatunek.ListaGatunek();
                    }
                    else
                    {
                        MessageBox.Show("nie usunięto gatunku", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //cell click - wyswietlenie danych w textboxach
        private void dataGridView_gatunek_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_id.Text = dataGridView_gatunek.CurrentRow.Cells[0].Value.ToString();
            textBox_nazwa.Text = dataGridView_gatunek.CurrentRow.Cells[1].Value.ToString();
        }

        //wyswietlenie ksiazek danego gatunku button
        private void button_listaKsiazek_Click(object sender, EventArgs e)
        {
            try
            {
                int gatunekID = Convert.ToInt32(dataGridView_gatunek.CurrentRow.Cells[0].Value);
                string nazwa = dataGridView_gatunek.CurrentRow.Cells[1].Value.ToString();
                ListaGatunkowForm lgf = new ListaGatunkowForm(gatunekID, nazwa);
                lgf.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
