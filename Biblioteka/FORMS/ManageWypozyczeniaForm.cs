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
    public partial class ManageWypozyczeniaForm : Form
    {
        CLASSES.KSIAZKA ksiazka = new CLASSES.KSIAZKA();
        CLASSES.CZYTELNIK czytelnik = new CLASSES.CZYTELNIK();
        CLASSES.WYPOZYCZENIE wypozyczenie = new CLASSES.WYPOZYCZENIE();

        public ManageWypozyczeniaForm()
        {
            InitializeComponent();

            panel_wypozycz.BringToFront();
        }
        //x
        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Load
        private void ManageWypozyczeniaForm_Load(object sender, EventArgs e)
        {
            //wypelnienie grida
            dataGridView_wyp.DataSource = wypozyczenie.ListaWypozyczen("");
        }

        //pokaz panel wypozyczenia
        private void button_wypozyczPanel_Click(object sender, EventArgs e)
        {
            panel_wypozycz.BringToFront();
        }

        //pokaz panel zwrotu
        private void button_zwrocPanel_Click(object sender, EventArgs e)
        {
            panel_zwroc.BringToFront();

            //refresh
            ManageWypozyczeniaForm_Load(sender, e);
        }

        //wybierz id ksiazki i pokaz tytul
        private void button_wybierzIdKsiazki_Click(object sender, EventArgs e)
        {
            string dostepne = "Nie";//default
            int id = Convert.ToInt32(numericUpDown1.Value);

            DataTable table = ksiazka.SzukajKsiazkiPo_id_lub_isbn("id", id, "");

            if(table.Rows.Count > 0)
            {
                label_tytulKsiazki.Text = table.Rows[0][2].ToString();
                label_tytulKsiazki.ForeColor = Color.DarkGreen;
                int ilosc = Convert.ToInt32(table.Rows[0][5]);
                label_ileNaStanie.Text = ilosc.ToString();

                if(wypozyczenie.czyKsiazkaDostepna(id))
                {
                    dostepne = "Tak";
                    label_dostepna.ForeColor = Color.Teal;
                }
                else
                {
                    label_dostepna.ForeColor = Color.Red;
                }
                label_dostepna.Text = dostepne;
            }
            else
            {
                label_tytulKsiazki.Text = "Nie ma książki z takim ID";
                label_tytulKsiazki.ForeColor = Color.Red;
                label_ileNaStanie.Text = "";
                label_dostepna.Text = "";
            }
        }

        //wybierz id czytelnika i pokaz imie nazwisko
        private void button_wybierzIdCzytelnika_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(numericUpDown2.Value);
            DataTable table = czytelnik.getCzytelnikPoID(id);
            if (table.Rows.Count > 0)
            {
                string nazwa = table.Rows[0][1].ToString() + " " + table.Rows[0][2].ToString();
                label_Czytelnik.Text = nazwa;
                label_Czytelnik.ForeColor = Color.DarkGreen;
            }
            else
            {
                label_Czytelnik.Text = "Nie ma czytelnika o takim ID";
                label_Czytelnik.ForeColor = Color.Red;
            }
        }

        //wypozycz ksiazke
        private void button_wypozycz_Click(object sender, EventArgs e)
        {
            try
            {
                int IdKsiazki = Convert.ToInt32(numericUpDown1.Value);
                int IdCzytelnika = Convert.ToInt32(numericUpDown2.Value);
                DateTime Dwypozyczenia = dateTimePicker1.Value;
                DateTime Doddania = dateTimePicker2.Value;

                //sprawdzenie czy juz nie wypozyczyl ksiazki
                if (wypozyczenie.czyKsiazkaWypozyczonaCzytelnikowi(IdCzytelnika, IdKsiazki))
                {
                    MessageBox.Show("Czytelnik już wypożyczył tę książkę");
                }
                else
                {
                    //sprawdzenie czy ksiazka jest dostepna
                    if (wypozyczenie.czyKsiazkaDostepna(IdKsiazki))
                    {
                        //data oddania nie powinna byc mniejsza od daty pozyczenia
                        if (Dwypozyczenia < Doddania)
                        {
                            if (wypozyczenie.addWypozyczenie(IdKsiazki, IdCzytelnika, "wypożyczono", Dwypozyczenia, Doddania))
                            {
                                MessageBox.Show("Wypożyczono książkę");
                            }
                            else
                            {
                                MessageBox.Show("Błąd podczas wykonywania akcji");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Data oddania nie może być przed datą wypożyczenia!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Książka nie jest obecnie dostępna");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Źle podane Id książki i czytelnika |" + ex.Message);
            }
        }

        //cell click -- przekazanie danych do texboxow
        private void dataGridView_wyp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numericUpDown_idCzytelnika_ret.Value = Convert.ToInt32(dataGridView_wyp.CurrentRow.Cells[2].Value);
            numericUpDown_idKsiazki_ret.Value = Convert.ToInt32(dataGridView_wyp.CurrentRow.Cells[1].Value);
            dateTimePicker_wyp_ret.Value = (DateTime)dataGridView_wyp.CurrentRow.Cells[4].Value;
            dateTimePicker_zwrot_ret.Value = (DateTime)dataGridView_wyp.CurrentRow.Cells[5].Value;
            button_szukajKsiazki_ret_Click(sender, e);
            button_szukajCzytelnika_ret_Click(sender, e);
        }

        //
        //przyciski koniec koncow nie uzywane, zmienic w cell click
        private void button_szukajKsiazki_ret_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(numericUpDown_idKsiazki_ret.Value);
            DataTable table = ksiazka.SzukajKsiazkiPo_id_lub_isbn("id", id, "");
            if (table.Rows.Count > 0)
            {
                label_tytul_ret.Text = table.Rows[0][2].ToString();
                label_tytul_ret.ForeColor = Color.DarkGreen;
                int ilosc = Convert.ToInt32(table.Rows[0][5]);
            }
            else
            {
                label_tytul_ret.Text = "Nie ma książki z takim ID";
                label_tytul_ret.ForeColor = Color.Red;
            }
        }
        private void button_szukajCzytelnika_ret_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(numericUpDown_idCzytelnika_ret.Value);
            DataTable table = czytelnik.getCzytelnikPoID(id);
            if (table.Rows.Count > 0)
            {
                string nazwa = table.Rows[0][1].ToString() + " " + table.Rows[0][2].ToString();
                label_czytelnik_ret.Text = nazwa;
                label_czytelnik_ret.ForeColor = Color.DarkGreen;
            }
            else
            {
                label_czytelnik_ret.Text = "Nie ma czytelnika o takim ID";
                label_czytelnik_ret.ForeColor = Color.Red;
            }
        }
        //
        //

        //zwrot ksiazki
        private void button_retbtn_ret_Click(object sender, EventArgs e)
        {
            //user zmienia tylko status i return date
            int IdKsiazki = Convert.ToInt32(numericUpDown_idKsiazki_ret.Value);
            int IdCzytelnika = Convert.ToInt32(numericUpDown_idCzytelnika_ret.Value);
            DateTime Dwypozyczenia = dateTimePicker_wyp_ret.Value;
            DateTime Doddania = dateTimePicker_zwrot_ret.Value;
            if (Dwypozyczenia < Doddania)
            {
                if (wypozyczenie.zwrocKsiazke(IdKsiazki, IdCzytelnika,"zwrócono", Dwypozyczenia, Doddania))
                {
                    MessageBox.Show("Zwrócono książkę");
                    //refresh
                    ManageWypozyczeniaForm_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Błąd podczas wykonywania akcji");
                }
            }
            else
            {
                MessageBox.Show("Data oddania nie może być przed datą wypożyczenia!");
            }
        }

        //strata ksiazki
        private void button_lostbtn_ret_Click(object sender, EventArgs e)
        {
            int IdKsiazki = Convert.ToInt32(numericUpDown_idKsiazki_ret.Value);
            int IdCzytelnika = Convert.ToInt32(numericUpDown_idCzytelnika_ret.Value);
            DateTime Dwypozyczenia = dateTimePicker_wyp_ret.Value;
            DateTime Dzgubienia = dateTimePicker_zwrot_ret.Value;
            if (Dwypozyczenia < Dzgubienia)
            {
                if (wypozyczenie.zwrocKsiazke(IdKsiazki, IdCzytelnika, "zgubiono", Dwypozyczenia, Dzgubienia))
                {
                    if (ksiazka.iloscMinusJedenKsiazka(IdKsiazki))
                    {
                        MessageBox.Show("Zgubiono książkę");
                        //refresh
                        ManageWypozyczeniaForm_Load(sender, e);
                    }

                }
                else
                {
                    MessageBox.Show("Błąd podczas wykonywania akcji");
                }
            }
            else
            {
                MessageBox.Show("Data oddania nie może być przed datą zgubienia książki!");
            }
        }

        //usuniecie wypozyczenia z historii
        private void button_delbtn_ret_Click(object sender, EventArgs e)
        {
            int IdWypozyczenia = Convert.ToInt32(dataGridView_wyp.CurrentRow.Cells[0].Value);
            if(wypozyczenie.removeWypozyczenie(IdWypozyczenia))
            {
                MessageBox.Show("Usunięto dane wypożyczenie");
                //refresh
                ManageWypozyczeniaForm_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Coś poszło nie tak, spróbuj ponownie");
            }
        }

        //pokaz wypozyczone wypozyczenia
        private void button_wypozyczone_Click(object sender, EventArgs e)
        {
            dataGridView_wyp.DataSource = wypozyczenie.ListaWypozyczen("wypożyczono");
        }

        //pokaz oddane wypozyczenia
        private void button_oddane_Click(object sender, EventArgs e)
        {
            dataGridView_wyp.DataSource = wypozyczenie.ListaWypozyczen("zwrócono");
        }

        //pokaz zgubione wypozyczenia
        private void button_zgubione_Click(object sender, EventArgs e)
        {
            dataGridView_wyp.DataSource = wypozyczenie.ListaWypozyczen("zgubiono");
        }

        //pokaz wszystkie wypozyczenia
        private void button_all_Click(object sender, EventArgs e)
        {
            dataGridView_wyp.DataSource = wypozyczenie.ListaWypozyczen("");
        }
    }
}
