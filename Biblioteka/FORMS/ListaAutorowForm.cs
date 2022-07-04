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
    public partial class ListaAutorowForm : Form
    {
        //manipulacja mkf z tego form
        private ManageKsiazkiForm mkf = null;

        public ListaAutorowForm(ManageKsiazkiForm sourceForm)
        {
            mkf = sourceForm as ManageKsiazkiForm;
            InitializeComponent();
        }

        //wyswietl autorow liste na listboxie
        private void ListaAutorowForm_Load(object sender, EventArgs e)
        {
            CLASSES.AUTOR autor = new CLASSES.AUTOR();
            listBox1.DataSource = autor.ListaAutor1();
            listBox1.DisplayMember = "fullname";
            listBox1.ValueMember = "id_autorzy";
        }

        //wybierz i zamknij
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //przypisanie do zmiennych
                DataRowView drv = (DataRowView)listBox1.SelectedItem;
                string nazwa = drv["fullname"].ToString();
                string id = drv["id_autorzy"].ToString();

                //przekazanie do mkf -- edit panel
                mkf.textBox_autor_edit.Text = nazwa;
                mkf.label_autorIDedit.Text = id;

                //przekazanie do mkf -- add panel
                mkf.textBox_autor.Text = nazwa;
                mkf.label_autorID.Text = id;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Nie wybrano autora | "+ex.Message, "błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.Close();
        }
    }
}
