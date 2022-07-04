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
    public partial class KsiazkiAutoraLista : Form
    {
        //zmienna do funkcji
        int autorID;
        //zmienna do wyswietlenia w labelu
        string pelneImie;

        public KsiazkiAutoraLista(int id,string nazwa)
        {
            InitializeComponent();
            this.autorID = id;
            this.pelneImie = nazwa;
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KsiazkiAutoraLista_Load(object sender, EventArgs e)
        {
            //wyswietlenie w listboxie
            CLASSES.KSIAZKA ksiazka = new CLASSES.KSIAZKA();
            label1.Text = pelneImie;
            listBox_ksiazki.DataSource = ksiazka.ListaKsiazkaAutor(autorID);
            listBox_ksiazki.DisplayMember = "tytul";
            listBox_ksiazki.ValueMember = "id_ksiazki";
        }
    }
}
