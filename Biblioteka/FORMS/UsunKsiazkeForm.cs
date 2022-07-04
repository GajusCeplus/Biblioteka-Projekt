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
    public partial class UsunKsiazkeForm : Form
    {
        CLASSES.KSIAZKA ksiazka = new CLASSES.KSIAZKA();

        public UsunKsiazkeForm()
        {
            InitializeComponent();
        }

        //X
        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //del button
        private void button_selectID_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)numericUpDown_DEL.Value;

                //zapytanie przed usunieciem
                if (MessageBox.Show("Czy jesteś pewien, że chcesz usunąć tę książkę?", "Jesteś pewny?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //usuwanie ksiazki
                    if (ksiazka.removeKsiazka(id))
                    {
                        MessageBox.Show("Książka została pomyślnie usunięta", "Usunięto książkę", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
