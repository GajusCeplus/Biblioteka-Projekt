using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Biblioteka.FORMS
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            //obrazki
            pictureBox_user.Image = Image.FromFile("../../IMAGES/profile.png");
            pictureBox_passwd.Image = Image.FromFile("../../IMAGES/1224190.png");
        }

        //taki jakis bajer do 'x' button
        private void label_close_MouseEnter(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.Black;
        }
        private void label_close_MouseLeave(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.Red;
        }
        //'x'
        private void label_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //manipulacja dashboardem z login screena
        private Dashboard_Form dashF = null;

        public Login_Form(Dashboard_Form sourceForm)
        {
            dashF = sourceForm as Dashboard_Form;
            InitializeComponent();
        }

        //login btn
        private void button_login_Click(object sender, EventArgs e)
        {
            //login funkcja
            //nie tworze osobnej klasy dla tej funkcji jako ze wykozystywana jest tylko i wylacznie tutaj
            //oraz to okno nie posiada zadnej innej funkcji
            DATABASE.Database db = new DATABASE.Database();
            string LoginQuery = "SELECT * FROM `uzytkownicy` WHERE `login`= @usn AND `haslo`= @pass";
            string username = textBox_username.Text;
            string password = textBox_passwd.Text;

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand(LoginQuery, db.GetConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            //
            //
            //

            //sprawdzenie czy uzytkownik istnieje
            if(table.Rows.Count > 0) //tak
            {
                //sprawdz `typ_uzytkownika` w bazie danych
                //bibliotekarz ma dostep do wszystkiego
                if (table.Rows[0][5].ToString().Equals("bibliotekarz"))
                {
                    dashF.Enabled = true;
                    this.Close();
                }
                //admin nie ma dostepu do danych innych kont
                else if(table.Rows[0][5].ToString().Equals("admin"))
                {
                    dashF.Enabled = true;
                    dashF.button_users.Visible = false;
                    dashF.button_users.Enabled = false;
                    this.Close();
                }
                //user moze tylko przegladac ksiazki
                else if (table.Rows[0][5].ToString().Equals("user"))
                {
                    //nie dotykac tej zmiennej
                    dashF.TypeUser = "user";

                    //dashboard
                    dashF.Enabled = true;
                    dashF.button_users.Visible = false;
                    dashF.button_users.Enabled = false;
                    dashF.button_borrow.Enabled = false;
                    dashF.button_borrow.Visible = false;
                    dashF.button_czytelnicy.Enabled = false;
                    dashF.button_czytelnicy.Visible = false;
                    this.Close();
                }

            }
            else 
            {
                if(username.Trim().Equals(""))
                {
                    MessageBox.Show("Wpisz Login","Pusty Login",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else if(password.Trim().Equals(""))
                {
                    MessageBox.Show("Wpisz Hasło", "Puste Hasło", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Błędny login lub hasło", "Złe dane", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
