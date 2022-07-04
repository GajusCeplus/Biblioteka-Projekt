namespace Biblioteka.FORMS
{
    partial class ManageCzytelnicyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_userlogin = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.label_czytelnikCount = new System.Windows.Forms.Label();
            this.button_del = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_dodaj = new System.Windows.Forms.Button();
            this.label_close = new System.Windows.Forms.Label();
            this.textBox_nazwisko = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_imie = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_telefon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView_czytelnik = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox_gender = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_czytelnik)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox_gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_userlogin
            // 
            this.label_userlogin.BackColor = System.Drawing.Color.Gray;
            this.label_userlogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_userlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_userlogin.Location = new System.Drawing.Point(0, 0);
            this.label_userlogin.Name = "label_userlogin";
            this.label_userlogin.Size = new System.Drawing.Size(1074, 121);
            this.label_userlogin.TabIndex = 3;
            this.label_userlogin.Text = "Czytelnicy";
            this.label_userlogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.button_clear);
            this.panel1.Controls.Add(this.label_czytelnikCount);
            this.panel1.Controls.Add(this.button_del);
            this.panel1.Controls.Add(this.button_edit);
            this.panel1.Controls.Add(this.button_dodaj);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 509);
            this.panel1.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(5, 415);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 54);
            this.label11.TabIndex = 17;
            this.label11.Text = "Liczba czytelników:";
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_clear.Location = new System.Drawing.Point(10, 184);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(147, 46);
            this.button_clear.TabIndex = 3;
            this.button_clear.Text = "Wyczyść Pola";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // label_czytelnikCount
            // 
            this.label_czytelnikCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_czytelnikCount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_czytelnikCount.Location = new System.Drawing.Point(5, 469);
            this.label_czytelnikCount.Name = "label_czytelnikCount";
            this.label_czytelnikCount.Size = new System.Drawing.Size(157, 37);
            this.label_czytelnikCount.TabIndex = 16;
            this.label_czytelnikCount.Text = "99999999999";
            // 
            // button_del
            // 
            this.button_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_del.Location = new System.Drawing.Point(10, 132);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(147, 46);
            this.button_del.TabIndex = 2;
            this.button_del.Text = "Usuń";
            this.button_del.UseVisualStyleBackColor = true;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // button_edit
            // 
            this.button_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_edit.Location = new System.Drawing.Point(10, 80);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(147, 46);
            this.button_edit.TabIndex = 1;
            this.button_edit.Text = "Edytuj";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_dodaj
            // 
            this.button_dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_dodaj.Location = new System.Drawing.Point(10, 28);
            this.button_dodaj.Name = "button_dodaj";
            this.button_dodaj.Size = new System.Drawing.Size(147, 46);
            this.button_dodaj.TabIndex = 0;
            this.button_dodaj.Text = "Dodaj";
            this.button_dodaj.UseVisualStyleBackColor = true;
            this.button_dodaj.Click += new System.EventHandler(this.button_dodaj_Click);
            // 
            // label_close
            // 
            this.label_close.BackColor = System.Drawing.Color.Gray;
            this.label_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_close.ForeColor = System.Drawing.Color.Red;
            this.label_close.Location = new System.Drawing.Point(1020, 9);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(42, 35);
            this.label_close.TabIndex = 8;
            this.label_close.Text = "X";
            this.label_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            // 
            // textBox_nazwisko
            // 
            this.textBox_nazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_nazwisko.Location = new System.Drawing.Point(173, 106);
            this.textBox_nazwisko.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.textBox_nazwisko.Multiline = true;
            this.textBox_nazwisko.Name = "textBox_nazwisko";
            this.textBox_nazwisko.Size = new System.Drawing.Size(238, 35);
            this.textBox_nazwisko.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 37);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nazwisko:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_imie
            // 
            this.textBox_imie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_imie.Location = new System.Drawing.Point(173, 58);
            this.textBox_imie.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.textBox_imie.Multiline = true;
            this.textBox_imie.Name = "textBox_imie";
            this.textBox_imie.Size = new System.Drawing.Size(238, 35);
            this.textBox_imie.TabIndex = 13;
            // 
            // textBox_id
            // 
            this.textBox_id.Enabled = false;
            this.textBox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_id.Location = new System.Drawing.Point(173, 10);
            this.textBox_id.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.textBox_id.Multiline = true;
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(115, 35);
            this.textBox_id.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 37);
            this.label2.TabIndex = 11;
            this.label2.Text = "Imie:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(3, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 37);
            this.label4.TabIndex = 16;
            this.label4.Text = "Płeć:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_telefon
            // 
            this.textBox_telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_telefon.Location = new System.Drawing.Point(173, 204);
            this.textBox_telefon.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.textBox_telefon.Multiline = true;
            this.textBox_telefon.Name = "textBox_telefon";
            this.textBox_telefon.Size = new System.Drawing.Size(238, 35);
            this.textBox_telefon.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(3, 204);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 37);
            this.label5.TabIndex = 18;
            this.label5.Text = "Telefon:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_email
            // 
            this.textBox_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_email.Location = new System.Drawing.Point(173, 252);
            this.textBox_email.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.textBox_email.Multiline = true;
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(238, 35);
            this.textBox_email.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(3, 252);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 37);
            this.label6.TabIndex = 20;
            this.label6.Text = "E-mail:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView_czytelnik
            // 
            this.dataGridView_czytelnik.AllowUserToAddRows = false;
            this.dataGridView_czytelnik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_czytelnik.Location = new System.Drawing.Point(623, 138);
            this.dataGridView_czytelnik.Name = "dataGridView_czytelnik";
            this.dataGridView_czytelnik.ReadOnly = true;
            this.dataGridView_czytelnik.Size = new System.Drawing.Size(439, 480);
            this.dataGridView_czytelnik.TabIndex = 22;
            this.dataGridView_czytelnik.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_czytelnik_CellClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.textBox_id);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.textBox_imie);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.textBox_nazwisko);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.groupBox_gender);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.textBox_telefon);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.textBox_email);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(172, 138);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(436, 364);
            this.flowLayoutPanel1.TabIndex = 23;
            // 
            // groupBox_gender
            // 
            this.groupBox_gender.Controls.Add(this.radioButton2);
            this.groupBox_gender.Controls.Add(this.radioButton1);
            this.groupBox_gender.Location = new System.Drawing.Point(173, 147);
            this.groupBox_gender.Name = "groupBox_gender";
            this.groupBox_gender.Size = new System.Drawing.Size(238, 44);
            this.groupBox_gender.TabIndex = 22;
            this.groupBox_gender.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton2.Location = new System.Drawing.Point(154, 16);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(81, 25);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Kobieta";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton1.Location = new System.Drawing.Point(3, 16);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(106, 25);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Mężczyzna";
            this.radioButton1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // ManageCzytelnicyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1074, 630);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dataGridView_czytelnik);
            this.Controls.Add(this.label_close);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_userlogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageCzytelnicyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCzytelnicyForm";
            this.Load += new System.EventHandler(this.ManageCzytelnicyForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_czytelnik)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox_gender.ResumeLayout(false);
            this.groupBox_gender.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_userlogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_del;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_dodaj;
        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.TextBox textBox_nazwisko;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_imie;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_telefon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView_czytelnik;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox_gender;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label_czytelnikCount;
    }
}