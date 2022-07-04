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
    public partial class ManageKsiazkiForm : Form
    {
        CLASSES.KSIAZKA ksiazka = new CLASSES.KSIAZKA();
        CLASSES.GATUNEK gatunek = new CLASSES.GATUNEK();
        CLASSES.AUTOR autor = new CLASSES.AUTOR();

        public ManageKsiazkiForm(string userType)
        {
            InitializeComponent();

            //ograniczenia zwyklego usera
            if (userType.Equals("user"))
            {
                button_dodaj.Enabled = false;
                button_edit.Enabled = false;
                button_del.Enabled = false;
                button_DelKsiazka_Cell.Enabled = false;
                button_editKsiazka_Cell.Enabled = false;
            }
        }

        //close btn
        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //zaladowanie okna / aktualizacja
        private void ManageKsiazkiForm_Load(object sender, EventArgs e)
        {
            //combobox
            //add panel
            comboBox_gatunek.DataSource = gatunek.ListaGatunek();
            comboBox_gatunek.DisplayMember = "nazwa";
            comboBox_gatunek.ValueMember = "ID";
            //edit panel
            comboBox1_edit.DataSource = gatunek.ListaGatunek();
            comboBox1_edit.DisplayMember = "nazwa";
            comboBox1_edit.ValueMember = "ID";

            label_bookCount.Text = ksiazka.ListaKsiazka().Rows.Count.ToString();

            //wyswietl ksiazki w datagridview
            button_PokazKsiazkiList_Click(sender, e);
        }
        //
        //pokaz add panel
        //
        private void button_dodaj_Click(object sender, EventArgs e)
        {
            panel_dodaj.BringToFront();

            //przycisk czyszczacy wpisane wartosci
            button3_Click(sender, e);
        }

        //wybierz autora - add panel
        private void button2_Click(object sender, EventArgs e)
        {
            ListaAutorowForm laf = new ListaAutorowForm(this);
            laf.Show();
        }
        
        //dodaj ksiazke - add panel
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //get data
                //int id = Convert.ToInt32(textBox_id.Text);
                string isbn = textBox_isbn.Text;
                string tytul = textBox_tytul.Text;
                int autor_id = Convert.ToInt32(label_autorID.Text);
                int gatunek_id = Convert.ToInt32(comboBox_gatunek.SelectedValue);
                int ilosc = Convert.ToInt32(numericUpDown_ilosc.Value);
                double cena = Convert.ToDouble(textBox_cena.Text);
                string wydawca = textBox_wydawca.Text;
                DateTime dto = dateTimePicker1.Value;

                if (!ksiazka.IsISBNExist(isbn,0))
                {
                    if (!ksiazka.isTytulExist(tytul,0) || !ksiazka.IsISBNExist(isbn, 0))
                    {
                        if (ksiazka.addKsiazka(isbn, tytul, autor_id, gatunek_id, ilosc, cena, wydawca, dto))
                        {
                            MessageBox.Show("Nowa książka dodana", "Nowa książka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            label_bookCount.Text = ksiazka.ListaKsiazka().Rows.Count.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Nie dodano książki", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nie dodano książki, tytuł już istnieje", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Nie dodano książki, ISBN już istnieje", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // clear - add panel
        private void button3_Click(object sender, EventArgs e)
        {
            textBox_autor.Text = "";
            textBox_cena.Text = "";
            textBox_id.Text = "";
            textBox_isbn.Text = "";
            textBox_tytul.Text = "";
            textBox_wydawca.Text = "";
            numericUpDown_ilosc.Value = 0;
            numericUpDown_ilosc.ResetText();
            dateTimePicker1.Value = DateTime.Now;
            comboBox_gatunek.Text = "";
            label_autorID.Text = "";
            
            int liczbaKsiazek = ksiazka.ListaKsiazka().Rows.Count;
            int ostatnieId = 0;
            if (liczbaKsiazek > 0)
            {
                ostatnieId = Convert.ToInt32(ksiazka.ListaKsiazka().Rows[liczbaKsiazek - 1][0]);
            }
            textBox_id.Text = Convert.ToString(ostatnieId + 1);
        }     
        //
        //pokaz edit panel
        //
        private void button_edit_Click(object sender, EventArgs e)
        {
            panel_edit.BringToFront();

            //clear
            textBox_autor_edit.Text = "";
            label_autorIDedit.Text = "";
            textBox_cena_edit.Text = "";
            textBox_ID_edit.Text = "";
            textBox_ISBN_edit.Text = "";
            textBox_tytul_edit.Text = "";
            textBox_wydawca_edit.Text = "";
            comboBox1_edit.Text = "";
            numericUpDown1_edit.Value = 0;
            numericUpDown1_edit.ResetText();
            dateTimePicker2_edit.Value = DateTime.Now;
            label_autorIDedit.Text = "";
        }
        
        //szukanie po ID - edit panel
        private void button_selectID_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox_ID_edit.Text);
                DataTable data = ksiazka.SzukajKsiazkiPo_id_lub_isbn("id", id, "");
                if (data.Rows.Count > 0)
                {
                    displayData(data);
                }
                else
                {
                    MessageBox.Show("Ten numer ID nie istnieje, wpisz inny", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ten numer ID nie istnieje, wpisz inny | "+ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        //szukanie po ISBN - edit panel
        private void button_selectISBN_Click(object sender, EventArgs e)
        {
            string isbn = textBox_ISBN_edit.Text.ToString();
            DataTable data = ksiazka.SzukajKsiazkiPo_id_lub_isbn("isbn", null, isbn);
            if (data.Rows.Count > 0)
            {
                displayData(data);
            }
            else
            {
                MessageBox.Show("Ten numer ISBN nie istnieje, wpisz inny", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        //wybor autora - edit panel
        private void button_autor_Click(object sender, EventArgs e)
        {
            ListaAutorowForm laf = new ListaAutorowForm(this);
            laf.Show();
        }

        //edytuj ksiazke button - edit panel
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                //get data
                int id = Convert.ToInt32(textBox_ID_edit.Text);
                string isbn = textBox_ISBN_edit.Text;
                string tytul = textBox_tytul_edit.Text;
                int autor_id = Convert.ToInt32(label_autorIDedit.Text);
                int gatunek_id = Convert.ToInt32(comboBox1_edit.SelectedValue);
                int ilosc = Convert.ToInt32(numericUpDown1_edit.Value);
                double cena = Convert.ToDouble(textBox_cena_edit.Text);
                string wydawca = textBox_wydawca_edit.Text;
                DateTime dto = dateTimePicker2_edit.Value;

                if (!ksiazka.IsISBNExist(isbn,id))
                {
                    if (!ksiazka.isTytulExist(tytul,id))
                    {
                        if (ksiazka.editKsiazka(id, isbn, tytul, autor_id, gatunek_id, ilosc, cena, wydawca, dto))
                        {
                            MessageBox.Show("Książka zmodyfikowana", "Edycja książki", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            label_bookCount.Text = ksiazka.ListaKsiazka().Rows.Count.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Nie edytowano książki", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nie edytowano książki, tytuł już istnieje", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Nie edytowano książki, ISBN już istnieje", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        //pokaz ksiazke - edit panel 
        public void displayData(DataTable data)
        {
            //
            //display data
            //
            textBox_ID_edit.Text = data.Rows[0][0].ToString();
            textBox_ISBN_edit.Text = data.Rows[0][1].ToString();
            textBox_tytul_edit.Text = data.Rows[0][2].ToString();

            //autorData
            int autorID = Convert.ToInt32(data.Rows[0][3].ToString());
            DataTable autorData = autor.ListaAutorPoID(autorID);

            textBox_autor_edit.Text = autorData.Rows[0][1].ToString() + " " + autorData.Rows[0][2].ToString();
            label_autorIDedit.Text = data.Rows[0][3].ToString();

            //gatunki
            comboBox1_edit.SelectedValue = data.Rows[0][4].ToString();

            numericUpDown1_edit.Text = data.Rows[0][5].ToString();
            textBox_cena_edit.Text = data.Rows[0][6].ToString();
            textBox_wydawca_edit.Text = data.Rows[0][7].ToString();
            dateTimePicker2_edit.Value = (DateTime)data.Rows[0][8];
        }

        //
        //pokaz delete Form
        //
        private void button_del_Click(object sender, EventArgs e)
        {
            //pokaz Delete form

            UsunKsiazkeForm ukf = new UsunKsiazkeForm();
            ukf.Show();
        }

        //
        //pokaz ksiazki panel
        //
        private void button_PokazKsiazkiList_Click(object sender, EventArgs e)
        {
            panel_PokazKsiazki.BringToFront();

            //kustomizacja datagrid
            dataGridView_Ksiazki.RowTemplate.Height = 25;
            dataGridView_Ksiazki.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            dataGridView_Ksiazki.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_Ksiazki.EnableHeadersVisualStyles = false;
            //display ksiazki w datagridview
            dataGridView_Ksiazki.DataSource = ksiazka.ListaKsiazka();
        }

        //edytuj ksiazke z listy - ksiazki panel
        private void button_editKsiazka_Cell_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView_Ksiazki.CurrentRow.Cells[0].Value);
                panel_edit.BringToFront();
                DataTable data = ksiazka.SzukajKsiazkiPo_id_lub_isbn("id", id, "");
                if (data.Rows.Count > 0)
                {
                    //przekazanie danych do edit panel
                    displayData(data);
                }
                else
                {
                    MessageBox.Show("Ten numer ID nie istnieje, wpisz inny", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Nie wybrano książki | "+ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        //usun ksiazke z listy - ksiazki panel
        private void button_DelKsiazka_Cell_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView_Ksiazki.CurrentRow.Cells[0].Value);
                if (MessageBox.Show("Czy jesteś pewien, że chcesz usunąć tę książkę?", "Jesteś pewny?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ksiazka.removeKsiazka(id))
                    {
                        MessageBox.Show("Książka została pomyślnie usunięta", "Usunięto książkę", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //display ksiazki w datagridview
                        dataGridView_Ksiazki.DataSource = ksiazka.ListaKsiazka();
                        label_bookCount.Text = ksiazka.ListaKsiazka().Rows.Count.ToString();
                    }
                    else
                    {
                        MessageBox.Show("nie usunięto książki", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("nie usunięto książki", "Anulowano akcje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie wybrano książki | "+ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
