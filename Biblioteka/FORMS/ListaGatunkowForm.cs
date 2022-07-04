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
    public partial class ListaGatunkowForm : Form
    {
        int gatunekID;
        string nazwa;
        public ListaGatunkowForm(int id, string nazwa)
        {
            InitializeComponent();
            this.gatunekID = id;
            this.nazwa = nazwa;
        }

        private void ListaGatunkowForm_Load(object sender, EventArgs e)
        {
            CLASSES.KSIAZKA ksiazka = new CLASSES.KSIAZKA();
            label_gatunek.Text = nazwa;
            listBox_ksiazkiGatunek.DataSource = ksiazka.ListaKsiazkaGatunek(gatunekID);
            listBox_ksiazkiGatunek.DisplayMember = "tytul";
            listBox_ksiazkiGatunek.ValueMember = "gatunek_id";
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
