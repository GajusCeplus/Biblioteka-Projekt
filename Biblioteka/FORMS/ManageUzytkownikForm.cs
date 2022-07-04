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
    public partial class ManageUzytkownikForm : Form
    {
        CLASSES.UZYTKOWNIK uzytkownik = new CLASSES.UZYTKOWNIK();

        public ManageUzytkownikForm()
        {
            InitializeComponent();
        }
        //x
        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //load
        private void ManageUzytkownikForm_Load(object sender, EventArgs e)
        {
            dataGridView_user.DataSource = uzytkownik.ListaUser();

            //clear
            textBox_id.Text = "";
            textBox_imie.Text = "";
            textBox_nazwisko.Text = "";
            textBox_login.Text = "";
            textBox_haslo.Text = "";
            textBox_rehaslo.Text = "";
            checkBox_admin.Checked = false;
        }

        //pobranie danych z tabeli
        private void dataGridView_user_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_id.Text = dataGridView_user.CurrentRow.Cells[0].Value.ToString();
            textBox_imie.Text = dataGridView_user.CurrentRow.Cells[1].Value.ToString();
            textBox_nazwisko.Text = dataGridView_user.CurrentRow.Cells[2].Value.ToString();
            textBox_login.Text = dataGridView_user.CurrentRow.Cells[3].Value.ToString();
            textBox_haslo.Text = dataGridView_user.CurrentRow.Cells[4].Value.ToString();
            string userType = dataGridView_user.CurrentRow.Cells[5].Value.ToString();
            if (userType.Equals("admin"))
            {
                checkBox_admin.Checked = true;
            }
            else
            {
                checkBox_admin.Checked = false;
            }

        }

        //dodaj uzytkownika btn
        private void button_dodaj_Click(object sender, EventArgs e)
        {
            string imie = textBox_imie.Text.ToString();
            string nazwisko = textBox_nazwisko.Text.ToString();
            string login = textBox_login.Text.ToString();
            string haslo = textBox_haslo.Text.ToString();
            string rehaslo = textBox_rehaslo.Text.ToString();
            string userType = "user";
            if (checkBox_admin.Checked)
            {
                userType = "admin";
            }

            if (uzytkownik.Weryfikacja(imie, nazwisko, login, haslo, rehaslo))
            {
                if (uzytkownik.czyLoginJuzIstnieje(login,0))
                {
                    MessageBox.Show("Ten login jest już zajęty", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (uzytkownik.addUser(imie, nazwisko, login, haslo, userType))
                    {
                        MessageBox.Show("Nowy użytkownik dodany", "Nowy użytkownik", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //czyszczenie pol/aktualizacja grida
                        ManageUzytkownikForm_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Nie dodano użytkownika", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nie dodano użytkownika, złe dane wejściowe", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //edytuj uzytkownika btn
        private void button_edytuj_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox_id.Text);
                string imie = textBox_imie.Text;
                string nazwisko = textBox_nazwisko.Text;
                string login = textBox_login.Text.ToString();
                string haslo = textBox_haslo.Text.ToString();
                string rehaslo = textBox_rehaslo.Text.ToString();
                string userType = "user";
                if (checkBox_admin.Checked)
                {
                    userType = "admin";
                }

                if (uzytkownik.czyLoginJuzIstnieje(login,id))
                {
                    MessageBox.Show("Ten login jest już zajęty", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (uzytkownik.Weryfikacja(imie, nazwisko, login, haslo, rehaslo))
                    {
                        if (uzytkownik.editUser(id, imie, nazwisko, login, haslo, userType))
                        {
                            MessageBox.Show("zaktualizowano dane uzytkownika", "Edycja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //czyszczenie pol/aktualizacja grida
                            ManageUzytkownikForm_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("nie zaktualizowano uzytkownika", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nie edytowano użytkownika, złe dane wejściowe", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //usun uzytkownika btn
        private void button_del_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox_id.Text);
                if (MessageBox.Show("Czy jesteś pewien, że chcesz usunąć tego użytkownika?", "Jesteś pewny?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (uzytkownik.removeUser(id))
                    {
                        MessageBox.Show("Usunięto użytkownika", "Usuwanie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //czyszczenie pol/aktualizacja grida
                        ManageUzytkownikForm_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Nie udało się usunąć użytkownika", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
