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
    public partial class Dashboard_Form : Form
    {
        //potrzebne do wyswietlania sum poszczegolnych sekcji
        CLASSES.KSIAZKA ksiazka = new CLASSES.KSIAZKA();
        CLASSES.AUTOR autor = new CLASSES.AUTOR();
        CLASSES.GATUNEK gatunek = new CLASSES.GATUNEK();
        CLASSES.CZYTELNIK czytelnik = new CLASSES.CZYTELNIK();
        //CLASSES.WYPOZYCZENIE wypozyczenie = new CLASSES.WYPOZYCZENIE();

        //zmienna istotna gdy logujemy sie jako zwykly user, blokuje wybrane mozliwosci, 
        //sprawdz je w Login-Form button_login_Click oraz w konstruktorach odpowiednich form
        public string TypeUser = "";

        public Dashboard_Form()
        {
            InitializeComponent();
        }

        private void Dashboard_Form_Load(object sender, EventArgs e)
        {
            //cyferki autorzy/ksiazki/czytelnicy
            label_autorzyCount.Text = autor.ListaAutor().Rows.Count.ToString();
            label_booksCount.Text = ksiazka.ListaKsiazka().Rows.Count.ToString();
            label_gatunkiCount.Text = gatunek.ListaGatunek().Rows.Count.ToString();
            label_czytelnicyCount.Text = czytelnik.ListaCzytelnik().Rows.Count.ToString();

            //logo pic
            pictureBox_Logo.Image = Image.FromFile("../../IMAGES/864685.png");

            //X btn
            button_close.Image = Image.FromFile("../../IMAGES/x.png");

            //obrazy sekcji
            button_books.Image = Image.FromFile("../../IMAGES/ksiazki.png");
            button_autor.Image = Image.FromFile("../../IMAGES/autor.png");
            button_gatunek.Image = Image.FromFile("../../IMAGES/tag.png");
            button_borrow.Image = Image.FromFile("../../IMAGES/wypozyczenia.png");
            button_czytelnicy.Image = Image.FromFile("../../IMAGES/czytelnicy.png");
            button_users.Image = Image.FromFile("../../IMAGES/user.png");

        }
        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Start
        private void Dashboard_Form_Shown(object sender, EventArgs e)
        {
            this.Enabled = false;

            //pokaz login form
            Login_Form lgf = new Login_Form(this);
            lgf.Show();
        }

        //otworz ManageGatunkiForm
        private void button_gatunek_Click(object sender, EventArgs e)
        {
            ManageGatunkiForm mgf = new ManageGatunkiForm(TypeUser);
            mgf.Show();
        }

        //otworz ManageAutorForm
        private void button_autor_Click(object sender, EventArgs e)
        {
            ManageAutorForm maf = new ManageAutorForm(TypeUser);
            maf.Show();
        }

        //otworz ManageKsiazkiForm
        private void button_books_Click(object sender, EventArgs e)
        {
            ManageKsiazkiForm mkf = new ManageKsiazkiForm(TypeUser);
            mkf.Show();
        }

        //otworz ManageUzytkownikForm
        private void button_users_Click(object sender, EventArgs e)
        {
            ManageUzytkownikForm muf = new ManageUzytkownikForm();
            muf.Show();
        }

        //otworz ManageCzytelnicyForm
        private void button_czytelnicy_Click(object sender, EventArgs e)
        {
            ManageCzytelnicyForm mcf = new ManageCzytelnicyForm();
            mcf.Show();
        }

        //otworz ManageWypozyczeniaForm
        private void button_borrow_Click(object sender, EventArgs e)
        {
            ManageWypozyczeniaForm mwf = new ManageWypozyczeniaForm();
            mwf.Show();
        }

        //aktualizacja okna po wyjsciu z jakiegos 'Manage'
        private void Dashboard_Form_MouseEnter(object sender, EventArgs e)
        {
            //cyferki autorzy/ksiazki/czytelnicy
            label_autorzyCount.Text = autor.ListaAutor().Rows.Count.ToString();
            label_booksCount.Text = ksiazka.ListaKsiazka().Rows.Count.ToString();
            label_gatunkiCount.Text = gatunek.ListaGatunek().Rows.Count.ToString();
            label_czytelnicyCount.Text = czytelnik.ListaCzytelnik().Rows.Count.ToString();
        }
    }
}
