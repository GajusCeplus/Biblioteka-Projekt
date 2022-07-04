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
    public partial class ManageAutorForm : Form
    {
        CLASSES.AUTOR autor = new CLASSES.AUTOR();

        public ManageAutorForm(string userType)
        {
            InitializeComponent();

            //ograniczenia zwyklego usera
            if (userType.Equals("user"))
            {
                button_dodaj.Enabled = false;
                button_edit.Enabled = false;
                button_del.Enabled = false;
            }
        }
        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //zaladowanie okna / aktualizacja okna
        private void ManageAutorForm_Load(object sender, EventArgs e)
        {
            //liczba autorow
            label_autorCount.Text = autor.ListaAutor().Rows.Count.ToString();

            //wypełnienie grida
            dataGridView_autor.DataSource = autor.ListaAutor();

            //clear textboxes
            textBox_id.Text = "";
            textBox_imie.Text = "";
            textBox_nazwisko.Text = "";
        }

        //dodaj autora button
        private void button_dodaj_Click(object sender, EventArgs e)
        {
            string imie = textBox_imie.Text;
            string nazwisko = textBox_nazwisko.Text;
            if(imie.Trim().Equals("") || nazwisko.Trim().Equals(""))
            {
                MessageBox.Show("Wpisz imie oraz nazwisko autora","Brak danych",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (autor.addAutor(imie,nazwisko))
                {
                    MessageBox.Show("Nowy autor dodany", "Nowy autor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //aktualizacja okna
                    ManageAutorForm_Load(sender, e);
                    ////liczba autorow
                    //label_autorCount.Text = autor.ListaAutor().Rows.Count.ToString();
                    ////wypełnienie grida
                    //dataGridView_autor.DataSource = autor.ListaAutor();

                }
                else
                {
                    MessageBox.Show("Nie dodano autora", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        //edycja danych autora button
        private void button_edit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox_id.Text);
                string imie = textBox_imie.Text;
                string nazwisko = textBox_nazwisko.Text;

                if (imie.Equals("") || nazwisko.Equals(""))
                {
                    MessageBox.Show("Wpisz imie oraz nazwisko autora", "Pusta nazwa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (autor.editAutor(id, imie, nazwisko))
                    {
                        MessageBox.Show("autora zaktualizowano", "Edycja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //wypełnienie grida
                        dataGridView_autor.DataSource = autor.ListaAutor();
                    }
                    else
                    {
                        MessageBox.Show("nie zaktualizowano autora", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //usuniecie autora button
        private void button_del_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox_id.Text);
                if(MessageBox.Show("Czy jesteś pewien, że chcesz usunąć tego autora?","Jesteś pewny?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (autor.removeAutor(id))
                    {
                        MessageBox.Show("autora usunięto", "Usuwanie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //aktualizacja okna
                        ManageAutorForm_Load(sender, e);
                        ////clear
                        //textBox_id.Text = "";
                        //textBox_imie.Text = "";
                        //textBox_nazwisko.Text = "";
                        ////wypełnienie grida
                        //dataGridView_autor.DataSource = autor.ListaAutor();
                    }
                    else
                    {
                        MessageBox.Show("nie usunięto autora", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // cell click
        private void dataGridView_autor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_id.Text = dataGridView_autor.CurrentRow.Cells[0].Value.ToString();
            textBox_imie.Text = dataGridView_autor.CurrentRow.Cells[1].Value.ToString();
            textBox_nazwisko.Text = dataGridView_autor.CurrentRow.Cells[2].Value.ToString();
        }

        //wyswietlenie ksiazek zaznaczonego autora
        private void button_autorShow_Click(object sender, EventArgs e)
        {
            try
            {
                int autorID = Convert.ToInt32(dataGridView_autor.CurrentRow.Cells[0].Value);
                string pelneImie = dataGridView_autor.CurrentRow.Cells[1].Value.ToString()
                    + " " + dataGridView_autor.CurrentRow.Cells[2].Value.ToString();
                KsiazkiAutoraLista kal = new KsiazkiAutoraLista(autorID, pelneImie);
                kal.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
