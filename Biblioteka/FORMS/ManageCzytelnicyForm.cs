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
    public partial class ManageCzytelnicyForm : Form
    {
        CLASSES.CZYTELNIK czytelnik = new CLASSES.CZYTELNIK();

        public ManageCzytelnicyForm()
        {
            InitializeComponent();
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //zaladowanie okna / aktualizacja
        private void ManageCzytelnicyForm_Load(object sender, EventArgs e)
        {
            //liczba czytelnikow
            label_czytelnikCount.Text = czytelnik.ListaCzytelnik().Rows.Count.ToString();
            //wypełnienie grida
            dataGridView_czytelnik.DataSource = czytelnik.ListaCzytelnik();
            //clear
            button_clear_Click(sender, e);
        }

        //dodaj czytelnika
        private void button_dodaj_Click(object sender, EventArgs e)
        {
            
            string imie = textBox_imie.Text;
            string nazwisko = textBox_nazwisko.Text;
            string gender = "Brak";//default
            string telefon = textBox_telefon.Text;
            string email = textBox_email.Text;
            if(radioButton1.Checked)
            {
                gender = "Mężczyzna";
            }
            else if(radioButton2.Checked)
            {
                gender = "Kobieta";
            }
           
            if (imie.Trim().Equals("") || nazwisko.Trim().Equals(""))
            {
                MessageBox.Show("Wpisz imie oraz nazwisko czytelnika", "Brak danych", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (czytelnik.addCzytelnik(imie, nazwisko, gender, telefon, email))
                {
                    MessageBox.Show("Nowy czytelnik dodany", "Nowy czytelnik", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //aktualizacja okna
                    ManageCzytelnicyForm_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Nie dodano czytelnika", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        //edytuj czytelnika
        private void button_edit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox_id.Text);
                string imie = textBox_imie.Text;
                string nazwisko = textBox_nazwisko.Text;
                string gender = "Brak";//default
                string telefon = textBox_telefon.Text;
                string email = textBox_email.Text;
                if (radioButton1.Checked)
                {
                    gender = "Mężczyzna";
                }
                else if (radioButton2.Checked)
                {
                    gender = "Kobieta";
                }
                if (imie.Trim().Equals("") || nazwisko.Trim().Equals(""))
                {
                    MessageBox.Show("Wpisz imie oraz nazwisko czytelnika", "Brak danych", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (czytelnik.editCzytelnik(id, imie, nazwisko, gender, telefon, email))
                    {
                        MessageBox.Show("Dane czytelnika edytowano", "Edycja czytelnik", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //aktualizacja okna
                        ManageCzytelnicyForm_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Nie edytowano czytelnika", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //usun czytelnika
        private void button_del_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox_id.Text);
                if (MessageBox.Show("Czy jesteś pewien, że chcesz usunąć tego czytelnika?", "Jesteś pewny?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (czytelnik.removeCzytelnik(id))
                    {
                        MessageBox.Show("Czytelnika usunięto", "Usuwanie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //aktualizacja okna
                        ManageCzytelnicyForm_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("nie usunięto czytelnika", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //cell click
        private void dataGridView_czytelnik_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_id.Text = dataGridView_czytelnik.CurrentRow.Cells[0].Value.ToString();
            textBox_imie.Text = dataGridView_czytelnik.CurrentRow.Cells[1].Value.ToString();
            textBox_nazwisko.Text = dataGridView_czytelnik.CurrentRow.Cells[2].Value.ToString();
            string gender = dataGridView_czytelnik.CurrentRow.Cells[3].Value.ToString();
            if(gender == "Mężczyzna")
            {
                radioButton1.Checked = true;
            }
            else if(gender == "Kobieta")
            {
                radioButton2.Checked = true;
            }
            else
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }
            textBox_telefon.Text = dataGridView_czytelnik.CurrentRow.Cells[4].Value.ToString();
            textBox_email.Text = dataGridView_czytelnik.CurrentRow.Cells[5].Value.ToString();
        }

        //clear
        private void button_clear_Click(object sender, EventArgs e)
        {
            //clear textboxes, radiobuttons
            textBox_id.Text = "";
            textBox_imie.Text = "";
            textBox_nazwisko.Text = "";
            textBox_telefon.Text = "";
            textBox_email.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
    }
}
