namespace Biblioteka.FORMS
{
    partial class ManageKsiazkiForm
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
            this.label_bookCount = new System.Windows.Forms.Label();
            this.button_PokazKsiazkiList = new System.Windows.Forms.Button();
            this.button_del = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_dodaj = new System.Windows.Forms.Button();
            this.panel_dodaj = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label_autorID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_autor = new System.Windows.Forms.TextBox();
            this.numericUpDown_ilosc = new System.Windows.Forms.NumericUpDown();
            this.comboBox_gatunek = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_wydawca = new System.Windows.Forms.TextBox();
            this.textBox_cena = new System.Windows.Forms.TextBox();
            this.textBox_tytul = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_isbn = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.label_close = new System.Windows.Forms.Label();
            this.panel_PokazKsiazki = new System.Windows.Forms.Panel();
            this.button_refresh = new System.Windows.Forms.Button();
            this.button_editKsiazka_Cell = new System.Windows.Forms.Button();
            this.button_DelKsiazka_Cell = new System.Windows.Forms.Button();
            this.dataGridView_Ksiazki = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.panel_edit = new System.Windows.Forms.Panel();
            this.button_selectID = new System.Windows.Forms.Button();
            this.button_selectISBN = new System.Windows.Forms.Button();
            this.label_autorIDedit = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button_autor = new System.Windows.Forms.Button();
            this.textBox_autor_edit = new System.Windows.Forms.TextBox();
            this.numericUpDown1_edit = new System.Windows.Forms.NumericUpDown();
            this.comboBox1_edit = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dateTimePicker2_edit = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_wydawca_edit = new System.Windows.Forms.TextBox();
            this.textBox_cena_edit = new System.Windows.Forms.TextBox();
            this.textBox_tytul_edit = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox_ID_edit = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox_ISBN_edit = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel_dodaj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ilosc)).BeginInit();
            this.panel_PokazKsiazki.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ksiazki)).BeginInit();
            this.panel_edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_edit)).BeginInit();
            this.SuspendLayout();
            // 
            // label_userlogin
            // 
            this.label_userlogin.BackColor = System.Drawing.Color.Gray;
            this.label_userlogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_userlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_userlogin.Location = new System.Drawing.Point(0, 0);
            this.label_userlogin.Name = "label_userlogin";
            this.label_userlogin.Size = new System.Drawing.Size(1094, 121);
            this.label_userlogin.TabIndex = 3;
            this.label_userlogin.Text = "Książki";
            this.label_userlogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label_bookCount);
            this.panel1.Controls.Add(this.button_PokazKsiazkiList);
            this.panel1.Controls.Add(this.button_del);
            this.panel1.Controls.Add(this.button_edit);
            this.panel1.Controls.Add(this.button_dodaj);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 492);
            this.panel1.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(2, 418);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 37);
            this.label11.TabIndex = 13;
            this.label11.Text = "Liczba książek:";
            // 
            // label_bookCount
            // 
            this.label_bookCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_bookCount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_bookCount.Location = new System.Drawing.Point(3, 455);
            this.label_bookCount.Name = "label_bookCount";
            this.label_bookCount.Size = new System.Drawing.Size(163, 37);
            this.label_bookCount.TabIndex = 12;
            this.label_bookCount.Text = "99999999999";
            // 
            // button_PokazKsiazkiList
            // 
            this.button_PokazKsiazkiList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_PokazKsiazkiList.Location = new System.Drawing.Point(10, 184);
            this.button_PokazKsiazkiList.Name = "button_PokazKsiazkiList";
            this.button_PokazKsiazkiList.Size = new System.Drawing.Size(147, 46);
            this.button_PokazKsiazkiList.TabIndex = 3;
            this.button_PokazKsiazkiList.Text = "Pokaż książki";
            this.button_PokazKsiazkiList.UseVisualStyleBackColor = true;
            this.button_PokazKsiazkiList.Click += new System.EventHandler(this.button_PokazKsiazkiList_Click);
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
            // panel_dodaj
            // 
            this.panel_dodaj.BackColor = System.Drawing.Color.DimGray;
            this.panel_dodaj.Controls.Add(this.label10);
            this.panel_dodaj.Controls.Add(this.button3);
            this.panel_dodaj.Controls.Add(this.label_autorID);
            this.panel_dodaj.Controls.Add(this.label9);
            this.panel_dodaj.Controls.Add(this.button1);
            this.panel_dodaj.Controls.Add(this.button2);
            this.panel_dodaj.Controls.Add(this.textBox_autor);
            this.panel_dodaj.Controls.Add(this.numericUpDown_ilosc);
            this.panel_dodaj.Controls.Add(this.comboBox_gatunek);
            this.panel_dodaj.Controls.Add(this.label8);
            this.panel_dodaj.Controls.Add(this.dateTimePicker1);
            this.panel_dodaj.Controls.Add(this.label7);
            this.panel_dodaj.Controls.Add(this.textBox_wydawca);
            this.panel_dodaj.Controls.Add(this.textBox_cena);
            this.panel_dodaj.Controls.Add(this.textBox_tytul);
            this.panel_dodaj.Controls.Add(this.label6);
            this.panel_dodaj.Controls.Add(this.label5);
            this.panel_dodaj.Controls.Add(this.label4);
            this.panel_dodaj.Controls.Add(this.label1);
            this.panel_dodaj.Controls.Add(this.textBox_id);
            this.panel_dodaj.Controls.Add(this.label3);
            this.panel_dodaj.Controls.Add(this.label2);
            this.panel_dodaj.Controls.Add(this.textBox_isbn);
            this.panel_dodaj.Controls.Add(this.label_id);
            this.panel_dodaj.Location = new System.Drawing.Point(166, 121);
            this.panel_dodaj.Name = "panel_dodaj";
            this.panel_dodaj.Size = new System.Drawing.Size(928, 492);
            this.panel_dodaj.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(429, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(245, 18);
            this.label10.TabIndex = 40;
            this.label10.Text = "Wyczyść pola, aby wygenerować ID";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(717, 328);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 71);
            this.button3.TabIndex = 39;
            this.button3.Text = "Wyczyść pola";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label_autorID
            // 
            this.label_autorID.AutoSize = true;
            this.label_autorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_autorID.Location = new System.Drawing.Point(492, 161);
            this.label_autorID.Name = "label_autorID";
            this.label_autorID.Size = new System.Drawing.Size(0, 37);
            this.label_autorID.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(429, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 37);
            this.label9.TabIndex = 37;
            this.label9.Text = "ID:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(717, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 71);
            this.button1.TabIndex = 4;
            this.button1.Text = " Dodaj książkę";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(577, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 39);
            this.button2.TabIndex = 36;
            this.button2.Text = "Wybierz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_autor
            // 
            this.textBox_autor.Enabled = false;
            this.textBox_autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_autor.Location = new System.Drawing.Point(185, 159);
            this.textBox_autor.Multiline = true;
            this.textBox_autor.Name = "textBox_autor";
            this.textBox_autor.Size = new System.Drawing.Size(238, 39);
            this.textBox_autor.TabIndex = 35;
            // 
            // numericUpDown_ilosc
            // 
            this.numericUpDown_ilosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_ilosc.Location = new System.Drawing.Point(185, 249);
            this.numericUpDown_ilosc.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown_ilosc.Name = "numericUpDown_ilosc";
            this.numericUpDown_ilosc.Size = new System.Drawing.Size(238, 31);
            this.numericUpDown_ilosc.TabIndex = 34;
            // 
            // comboBox_gatunek
            // 
            this.comboBox_gatunek.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_gatunek.FormattingEnabled = true;
            this.comboBox_gatunek.Location = new System.Drawing.Point(185, 204);
            this.comboBox_gatunek.Name = "comboBox_gatunek";
            this.comboBox_gatunek.Size = new System.Drawing.Size(238, 33);
            this.comboBox_gatunek.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(4, 391);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(218, 37);
            this.label8.TabIndex = 28;
            this.label8.Text = "Data Odbioru:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.Location = new System.Drawing.Point(226, 397);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(284, 26);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(4, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 37);
            this.label7.TabIndex = 26;
            this.label7.Text = "Wydawca:";
            // 
            // textBox_wydawca
            // 
            this.textBox_wydawca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_wydawca.Location = new System.Drawing.Point(185, 339);
            this.textBox_wydawca.Multiline = true;
            this.textBox_wydawca.Name = "textBox_wydawca";
            this.textBox_wydawca.Size = new System.Drawing.Size(473, 39);
            this.textBox_wydawca.TabIndex = 25;
            // 
            // textBox_cena
            // 
            this.textBox_cena.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_cena.Location = new System.Drawing.Point(185, 294);
            this.textBox_cena.Multiline = true;
            this.textBox_cena.Name = "textBox_cena";
            this.textBox_cena.Size = new System.Drawing.Size(473, 39);
            this.textBox_cena.TabIndex = 24;
            // 
            // textBox_tytul
            // 
            this.textBox_tytul.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_tytul.Location = new System.Drawing.Point(185, 114);
            this.textBox_tytul.Multiline = true;
            this.textBox_tytul.Name = "textBox_tytul";
            this.textBox_tytul.Size = new System.Drawing.Size(473, 39);
            this.textBox_tytul.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(67, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 37);
            this.label6.TabIndex = 19;
            this.label6.Text = "Cena:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(78, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 37);
            this.label5.TabIndex = 18;
            this.label5.Text = "Ilość:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(65, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 37);
            this.label4.TabIndex = 17;
            this.label4.Text = "Autor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(22, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "Gatunek:";
            // 
            // textBox_id
            // 
            this.textBox_id.Enabled = false;
            this.textBox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_id.Location = new System.Drawing.Point(185, 28);
            this.textBox_id.Multiline = true;
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(238, 35);
            this.textBox_id.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(68, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 37);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tytuł:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(69, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 37);
            this.label2.TabIndex = 11;
            this.label2.Text = "ISBN:";
            // 
            // textBox_isbn
            // 
            this.textBox_isbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_isbn.Location = new System.Drawing.Point(185, 69);
            this.textBox_isbn.Multiline = true;
            this.textBox_isbn.Name = "textBox_isbn";
            this.textBox_isbn.Size = new System.Drawing.Size(473, 39);
            this.textBox_isbn.TabIndex = 13;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_id.Location = new System.Drawing.Point(102, 28);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(57, 37);
            this.label_id.TabIndex = 10;
            this.label_id.Text = "ID:";
            // 
            // label_close
            // 
            this.label_close.BackColor = System.Drawing.Color.Gray;
            this.label_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_close.ForeColor = System.Drawing.Color.Red;
            this.label_close.Location = new System.Drawing.Point(1052, 0);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(42, 35);
            this.label_close.TabIndex = 32;
            this.label_close.Text = "X";
            this.label_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            // 
            // panel_PokazKsiazki
            // 
            this.panel_PokazKsiazki.BackColor = System.Drawing.Color.SlateBlue;
            this.panel_PokazKsiazki.Controls.Add(this.button_refresh);
            this.panel_PokazKsiazki.Controls.Add(this.button_editKsiazka_Cell);
            this.panel_PokazKsiazki.Controls.Add(this.button_DelKsiazka_Cell);
            this.panel_PokazKsiazki.Controls.Add(this.dataGridView_Ksiazki);
            this.panel_PokazKsiazki.Controls.Add(this.label12);
            this.panel_PokazKsiazki.Location = new System.Drawing.Point(166, 121);
            this.panel_PokazKsiazki.Name = "panel_PokazKsiazki";
            this.panel_PokazKsiazki.Size = new System.Drawing.Size(928, 492);
            this.panel_PokazKsiazki.TabIndex = 44;
            // 
            // button_refresh
            // 
            this.button_refresh.BackColor = System.Drawing.Color.Gainsboro;
            this.button_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_refresh.Location = new System.Drawing.Point(429, 362);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(141, 66);
            this.button_refresh.TabIndex = 48;
            this.button_refresh.Text = "Odśwież";
            this.button_refresh.UseVisualStyleBackColor = false;
            this.button_refresh.Click += new System.EventHandler(this.button_PokazKsiazkiList_Click);
            // 
            // button_editKsiazka_Cell
            // 
            this.button_editKsiazka_Cell.BackColor = System.Drawing.Color.ForestGreen;
            this.button_editKsiazka_Cell.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_editKsiazka_Cell.Location = new System.Drawing.Point(587, 362);
            this.button_editKsiazka_Cell.Name = "button_editKsiazka_Cell";
            this.button_editKsiazka_Cell.Size = new System.Drawing.Size(141, 66);
            this.button_editKsiazka_Cell.TabIndex = 47;
            this.button_editKsiazka_Cell.Text = "Edytuj tę książkę";
            this.button_editKsiazka_Cell.UseVisualStyleBackColor = false;
            this.button_editKsiazka_Cell.Click += new System.EventHandler(this.button_editKsiazka_Cell_Click);
            // 
            // button_DelKsiazka_Cell
            // 
            this.button_DelKsiazka_Cell.BackColor = System.Drawing.Color.Firebrick;
            this.button_DelKsiazka_Cell.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_DelKsiazka_Cell.Location = new System.Drawing.Point(748, 362);
            this.button_DelKsiazka_Cell.Name = "button_DelKsiazka_Cell";
            this.button_DelKsiazka_Cell.Size = new System.Drawing.Size(141, 66);
            this.button_DelKsiazka_Cell.TabIndex = 46;
            this.button_DelKsiazka_Cell.Text = "Usuń tę książkę";
            this.button_DelKsiazka_Cell.UseVisualStyleBackColor = false;
            this.button_DelKsiazka_Cell.Click += new System.EventHandler(this.button_DelKsiazka_Cell_Click);
            // 
            // dataGridView_Ksiazki
            // 
            this.dataGridView_Ksiazki.AllowUserToAddRows = false;
            this.dataGridView_Ksiazki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Ksiazki.Location = new System.Drawing.Point(3, 17);
            this.dataGridView_Ksiazki.Name = "dataGridView_Ksiazki";
            this.dataGridView_Ksiazki.ReadOnly = true;
            this.dataGridView_Ksiazki.Size = new System.Drawing.Size(922, 314);
            this.dataGridView_Ksiazki.TabIndex = 39;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(475, 161);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 37);
            this.label12.TabIndex = 38;
            // 
            // panel_edit
            // 
            this.panel_edit.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel_edit.Controls.Add(this.button_selectID);
            this.panel_edit.Controls.Add(this.button_selectISBN);
            this.panel_edit.Controls.Add(this.label_autorIDedit);
            this.panel_edit.Controls.Add(this.label14);
            this.panel_edit.Controls.Add(this.button5);
            this.panel_edit.Controls.Add(this.button_autor);
            this.panel_edit.Controls.Add(this.textBox_autor_edit);
            this.panel_edit.Controls.Add(this.numericUpDown1_edit);
            this.panel_edit.Controls.Add(this.comboBox1_edit);
            this.panel_edit.Controls.Add(this.label15);
            this.panel_edit.Controls.Add(this.dateTimePicker2_edit);
            this.panel_edit.Controls.Add(this.label16);
            this.panel_edit.Controls.Add(this.textBox_wydawca_edit);
            this.panel_edit.Controls.Add(this.textBox_cena_edit);
            this.panel_edit.Controls.Add(this.textBox_tytul_edit);
            this.panel_edit.Controls.Add(this.label17);
            this.panel_edit.Controls.Add(this.label18);
            this.panel_edit.Controls.Add(this.label19);
            this.panel_edit.Controls.Add(this.label20);
            this.panel_edit.Controls.Add(this.textBox_ID_edit);
            this.panel_edit.Controls.Add(this.label21);
            this.panel_edit.Controls.Add(this.label22);
            this.panel_edit.Controls.Add(this.textBox_ISBN_edit);
            this.panel_edit.Controls.Add(this.label23);
            this.panel_edit.Location = new System.Drawing.Point(166, 121);
            this.panel_edit.Name = "panel_edit";
            this.panel_edit.Size = new System.Drawing.Size(928, 492);
            this.panel_edit.TabIndex = 41;
            // 
            // button_selectID
            // 
            this.button_selectID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_selectID.Location = new System.Drawing.Point(429, 28);
            this.button_selectID.Name = "button_selectID";
            this.button_selectID.Size = new System.Drawing.Size(133, 39);
            this.button_selectID.TabIndex = 42;
            this.button_selectID.Text = "Szukaj po ID";
            this.button_selectID.UseVisualStyleBackColor = true;
            this.button_selectID.Click += new System.EventHandler(this.button_selectID_Click);
            // 
            // button_selectISBN
            // 
            this.button_selectISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_selectISBN.Location = new System.Drawing.Point(429, 69);
            this.button_selectISBN.Name = "button_selectISBN";
            this.button_selectISBN.Size = new System.Drawing.Size(133, 39);
            this.button_selectISBN.TabIndex = 41;
            this.button_selectISBN.Text = "Szukaj po ISBN";
            this.button_selectISBN.UseVisualStyleBackColor = true;
            this.button_selectISBN.Click += new System.EventHandler(this.button_selectISBN_Click);
            // 
            // label_autorIDedit
            // 
            this.label_autorIDedit.AutoSize = true;
            this.label_autorIDedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_autorIDedit.Location = new System.Drawing.Point(475, 161);
            this.label_autorIDedit.Name = "label_autorIDedit";
            this.label_autorIDedit.Size = new System.Drawing.Size(0, 37);
            this.label_autorIDedit.TabIndex = 38;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(429, 161);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 37);
            this.label14.TabIndex = 37;
            this.label14.Text = "ID:";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Location = new System.Drawing.Point(711, 357);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(172, 71);
            this.button5.TabIndex = 4;
            this.button5.Text = "Edytuj książkę";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button_autor
            // 
            this.button_autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_autor.Location = new System.Drawing.Point(524, 157);
            this.button_autor.Name = "button_autor";
            this.button_autor.Size = new System.Drawing.Size(81, 39);
            this.button_autor.TabIndex = 36;
            this.button_autor.Text = "Wybierz";
            this.button_autor.UseVisualStyleBackColor = true;
            this.button_autor.Click += new System.EventHandler(this.button_autor_Click);
            // 
            // textBox_autor_edit
            // 
            this.textBox_autor_edit.Enabled = false;
            this.textBox_autor_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_autor_edit.Location = new System.Drawing.Point(185, 159);
            this.textBox_autor_edit.Multiline = true;
            this.textBox_autor_edit.Name = "textBox_autor_edit";
            this.textBox_autor_edit.Size = new System.Drawing.Size(238, 39);
            this.textBox_autor_edit.TabIndex = 35;
            // 
            // numericUpDown1_edit
            // 
            this.numericUpDown1_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown1_edit.Location = new System.Drawing.Point(185, 249);
            this.numericUpDown1_edit.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown1_edit.Name = "numericUpDown1_edit";
            this.numericUpDown1_edit.Size = new System.Drawing.Size(238, 31);
            this.numericUpDown1_edit.TabIndex = 34;
            // 
            // comboBox1_edit
            // 
            this.comboBox1_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox1_edit.FormattingEnabled = true;
            this.comboBox1_edit.Location = new System.Drawing.Point(185, 204);
            this.comboBox1_edit.Name = "comboBox1_edit";
            this.comboBox1_edit.Size = new System.Drawing.Size(238, 33);
            this.comboBox1_edit.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(4, 391);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(218, 37);
            this.label15.TabIndex = 28;
            this.label15.Text = "Data Odbioru:";
            // 
            // dateTimePicker2_edit
            // 
            this.dateTimePicker2_edit.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker2_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker2_edit.Location = new System.Drawing.Point(226, 399);
            this.dateTimePicker2_edit.Name = "dateTimePicker2_edit";
            this.dateTimePicker2_edit.Size = new System.Drawing.Size(282, 26);
            this.dateTimePicker2_edit.TabIndex = 27;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(4, 339);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(165, 37);
            this.label16.TabIndex = 26;
            this.label16.Text = "Wydawca:";
            // 
            // textBox_wydawca_edit
            // 
            this.textBox_wydawca_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_wydawca_edit.Location = new System.Drawing.Point(185, 339);
            this.textBox_wydawca_edit.Multiline = true;
            this.textBox_wydawca_edit.Name = "textBox_wydawca_edit";
            this.textBox_wydawca_edit.Size = new System.Drawing.Size(238, 39);
            this.textBox_wydawca_edit.TabIndex = 25;
            // 
            // textBox_cena_edit
            // 
            this.textBox_cena_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_cena_edit.Location = new System.Drawing.Point(185, 294);
            this.textBox_cena_edit.Multiline = true;
            this.textBox_cena_edit.Name = "textBox_cena_edit";
            this.textBox_cena_edit.Size = new System.Drawing.Size(238, 39);
            this.textBox_cena_edit.TabIndex = 24;
            // 
            // textBox_tytul_edit
            // 
            this.textBox_tytul_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_tytul_edit.Location = new System.Drawing.Point(185, 114);
            this.textBox_tytul_edit.Multiline = true;
            this.textBox_tytul_edit.Name = "textBox_tytul_edit";
            this.textBox_tytul_edit.Size = new System.Drawing.Size(238, 39);
            this.textBox_tytul_edit.TabIndex = 20;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.Location = new System.Drawing.Point(67, 294);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(102, 37);
            this.label17.TabIndex = 19;
            this.label17.Text = "Cena:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label18.Location = new System.Drawing.Point(78, 249);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(91, 37);
            this.label18.TabIndex = 18;
            this.label18.Text = "Ilość:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label19.Location = new System.Drawing.Point(65, 159);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(104, 37);
            this.label19.TabIndex = 17;
            this.label19.Text = "Autor:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label20.Location = new System.Drawing.Point(22, 204);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(147, 37);
            this.label20.TabIndex = 16;
            this.label20.Text = "Gatunek:";
            // 
            // textBox_ID_edit
            // 
            this.textBox_ID_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_ID_edit.Location = new System.Drawing.Point(185, 28);
            this.textBox_ID_edit.Multiline = true;
            this.textBox_ID_edit.Name = "textBox_ID_edit";
            this.textBox_ID_edit.Size = new System.Drawing.Size(238, 35);
            this.textBox_ID_edit.TabIndex = 12;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label21.Location = new System.Drawing.Point(68, 114);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(101, 37);
            this.label21.TabIndex = 14;
            this.label21.Text = "Tytuł:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label22.Location = new System.Drawing.Point(69, 69);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(100, 37);
            this.label22.TabIndex = 11;
            this.label22.Text = "ISBN:";
            // 
            // textBox_ISBN_edit
            // 
            this.textBox_ISBN_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_ISBN_edit.Location = new System.Drawing.Point(185, 69);
            this.textBox_ISBN_edit.Multiline = true;
            this.textBox_ISBN_edit.Name = "textBox_ISBN_edit";
            this.textBox_ISBN_edit.Size = new System.Drawing.Size(238, 39);
            this.textBox_ISBN_edit.TabIndex = 13;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label23.Location = new System.Drawing.Point(102, 28);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(57, 37);
            this.label23.TabIndex = 10;
            this.label23.Text = "ID:";
            // 
            // ManageKsiazkiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1094, 613);
            this.Controls.Add(this.label_close);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_userlogin);
            this.Controls.Add(this.panel_PokazKsiazki);
            this.Controls.Add(this.panel_dodaj);
            this.Controls.Add(this.panel_edit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageKsiazkiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageKsiazkiForm";
            this.Load += new System.EventHandler(this.ManageKsiazkiForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel_dodaj.ResumeLayout(false);
            this.panel_dodaj.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ilosc)).EndInit();
            this.panel_PokazKsiazki.ResumeLayout(false);
            this.panel_PokazKsiazki.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ksiazki)).EndInit();
            this.panel_edit.ResumeLayout(false);
            this.panel_edit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_edit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_userlogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_dodaj;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_wydawca;
        private System.Windows.Forms.TextBox textBox_cena;
        private System.Windows.Forms.TextBox textBox_tytul;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_isbn;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDown_ilosc;
        private System.Windows.Forms.ComboBox comboBox_gatunek;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox textBox_autor;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label_autorID;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel_edit;
        public System.Windows.Forms.Label label_autorIDedit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button_autor;
        public System.Windows.Forms.TextBox textBox_autor_edit;
        private System.Windows.Forms.NumericUpDown numericUpDown1_edit;
        private System.Windows.Forms.ComboBox comboBox1_edit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dateTimePicker2_edit;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_wydawca_edit;
        private System.Windows.Forms.TextBox textBox_cena_edit;
        private System.Windows.Forms.TextBox textBox_tytul_edit;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox_ID_edit;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox_ISBN_edit;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button button_selectID;
        private System.Windows.Forms.Button button_selectISBN;
        private System.Windows.Forms.Panel panel_PokazKsiazki;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.DataGridView dataGridView_Ksiazki;
        public System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Button button_PokazKsiazkiList;
        private System.Windows.Forms.Button button_del;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_dodaj;
        private System.Windows.Forms.Button button_editKsiazka_Cell;
        private System.Windows.Forms.Button button_DelKsiazka_Cell;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_bookCount;
    }
}