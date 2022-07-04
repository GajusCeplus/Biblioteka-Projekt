namespace Biblioteka.FORMS
{
    partial class ManageWypozyczeniaForm
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
            this.button_zwrocPanel = new System.Windows.Forms.Button();
            this.button_wypozyczPanel = new System.Windows.Forms.Button();
            this.label_close = new System.Windows.Forms.Label();
            this.panel_wypozycz = new System.Windows.Forms.Panel();
            this.label_ileNaStanie = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_wypozycz = new System.Windows.Forms.Button();
            this.button_wybierzIdCzytelnika = new System.Windows.Forms.Button();
            this.button_wybierzIdKsiazki = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label_dataZwrotu = new System.Windows.Forms.Label();
            this.label_dataWypozyczenia = new System.Windows.Forms.Label();
            this.label_dostepna = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Czytelnik = new System.Windows.Forms.Label();
            this.label_tytulKsiazki = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_zwroc = new System.Windows.Forms.Panel();
            this.button_all = new System.Windows.Forms.Button();
            this.button_zgubione = new System.Windows.Forms.Button();
            this.button_oddane = new System.Windows.Forms.Button();
            this.button_wypozyczone = new System.Windows.Forms.Button();
            this.dataGridView_wyp = new System.Windows.Forms.DataGridView();
            this.button_lostbtn_ret = new System.Windows.Forms.Button();
            this.button_retbtn_ret = new System.Windows.Forms.Button();
            this.button_delbtn_ret = new System.Windows.Forms.Button();
            this.button_szukajCzytelnika_ret = new System.Windows.Forms.Button();
            this.button_szukajKsiazki_ret = new System.Windows.Forms.Button();
            this.dateTimePicker_zwrot_ret = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_wyp_ret = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_czytelnik_ret = new System.Windows.Forms.Label();
            this.label_tytul_ret = new System.Windows.Forms.Label();
            this.numericUpDown_idCzytelnika_ret = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.numericUpDown_idKsiazki_ret = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel_wypozycz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel_zwroc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_wyp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_idCzytelnika_ret)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_idKsiazki_ret)).BeginInit();
            this.SuspendLayout();
            // 
            // label_userlogin
            // 
            this.label_userlogin.BackColor = System.Drawing.Color.Gray;
            this.label_userlogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_userlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_userlogin.Location = new System.Drawing.Point(0, 0);
            this.label_userlogin.Name = "label_userlogin";
            this.label_userlogin.Size = new System.Drawing.Size(1140, 121);
            this.label_userlogin.TabIndex = 4;
            this.label_userlogin.Text = "Wypożyczenia";
            this.label_userlogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.button_zwrocPanel);
            this.panel1.Controls.Add(this.button_wypozyczPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 538);
            this.panel1.TabIndex = 8;
            // 
            // button_zwrocPanel
            // 
            this.button_zwrocPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_zwrocPanel.Location = new System.Drawing.Point(10, 80);
            this.button_zwrocPanel.Name = "button_zwrocPanel";
            this.button_zwrocPanel.Size = new System.Drawing.Size(147, 46);
            this.button_zwrocPanel.TabIndex = 1;
            this.button_zwrocPanel.Text = "Zwróć";
            this.button_zwrocPanel.UseVisualStyleBackColor = true;
            this.button_zwrocPanel.Click += new System.EventHandler(this.button_zwrocPanel_Click);
            // 
            // button_wypozyczPanel
            // 
            this.button_wypozyczPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_wypozyczPanel.Location = new System.Drawing.Point(10, 28);
            this.button_wypozyczPanel.Name = "button_wypozyczPanel";
            this.button_wypozyczPanel.Size = new System.Drawing.Size(147, 46);
            this.button_wypozyczPanel.TabIndex = 0;
            this.button_wypozyczPanel.Text = "Wypożycz";
            this.button_wypozyczPanel.UseVisualStyleBackColor = true;
            this.button_wypozyczPanel.Click += new System.EventHandler(this.button_wypozyczPanel_Click);
            // 
            // label_close
            // 
            this.label_close.BackColor = System.Drawing.Color.Gray;
            this.label_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_close.ForeColor = System.Drawing.Color.Red;
            this.label_close.Location = new System.Drawing.Point(1098, 0);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(42, 35);
            this.label_close.TabIndex = 9;
            this.label_close.Text = "X";
            this.label_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            // 
            // panel_wypozycz
            // 
            this.panel_wypozycz.BackColor = System.Drawing.Color.LightGray;
            this.panel_wypozycz.Controls.Add(this.label_ileNaStanie);
            this.panel_wypozycz.Controls.Add(this.label4);
            this.panel_wypozycz.Controls.Add(this.button_wypozycz);
            this.panel_wypozycz.Controls.Add(this.button_wybierzIdCzytelnika);
            this.panel_wypozycz.Controls.Add(this.button_wybierzIdKsiazki);
            this.panel_wypozycz.Controls.Add(this.dateTimePicker2);
            this.panel_wypozycz.Controls.Add(this.dateTimePicker1);
            this.panel_wypozycz.Controls.Add(this.label_dataZwrotu);
            this.panel_wypozycz.Controls.Add(this.label_dataWypozyczenia);
            this.panel_wypozycz.Controls.Add(this.label_dostepna);
            this.panel_wypozycz.Controls.Add(this.label3);
            this.panel_wypozycz.Controls.Add(this.label_Czytelnik);
            this.panel_wypozycz.Controls.Add(this.label_tytulKsiazki);
            this.panel_wypozycz.Controls.Add(this.numericUpDown2);
            this.panel_wypozycz.Controls.Add(this.label2);
            this.panel_wypozycz.Controls.Add(this.numericUpDown1);
            this.panel_wypozycz.Controls.Add(this.label1);
            this.panel_wypozycz.Location = new System.Drawing.Point(172, 138);
            this.panel_wypozycz.Name = "panel_wypozycz";
            this.panel_wypozycz.Size = new System.Drawing.Size(956, 509);
            this.panel_wypozycz.TabIndex = 10;
            // 
            // label_ileNaStanie
            // 
            this.label_ileNaStanie.AutoSize = true;
            this.label_ileNaStanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_ileNaStanie.ForeColor = System.Drawing.Color.Teal;
            this.label_ileNaStanie.Location = new System.Drawing.Point(302, 175);
            this.label_ileNaStanie.Name = "label_ileNaStanie";
            this.label_ileNaStanie.Size = new System.Drawing.Size(0, 24);
            this.label_ileNaStanie.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(27, 238);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 40, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Czy książka jest dostępna:";
            // 
            // button_wypozycz
            // 
            this.button_wypozycz.BackColor = System.Drawing.Color.Green;
            this.button_wypozycz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_wypozycz.ForeColor = System.Drawing.Color.White;
            this.button_wypozycz.Location = new System.Drawing.Point(3, 444);
            this.button_wypozycz.Name = "button_wypozycz";
            this.button_wypozycz.Size = new System.Drawing.Size(950, 62);
            this.button_wypozycz.TabIndex = 16;
            this.button_wypozycz.Text = "Wypożycz";
            this.button_wypozycz.UseVisualStyleBackColor = false;
            this.button_wypozycz.Click += new System.EventHandler(this.button_wypozycz_Click);
            // 
            // button_wybierzIdCzytelnika
            // 
            this.button_wybierzIdCzytelnika.Location = new System.Drawing.Point(395, 103);
            this.button_wybierzIdCzytelnika.Name = "button_wybierzIdCzytelnika";
            this.button_wybierzIdCzytelnika.Size = new System.Drawing.Size(122, 31);
            this.button_wybierzIdCzytelnika.TabIndex = 15;
            this.button_wybierzIdCzytelnika.Text = "Szukaj ID";
            this.button_wybierzIdCzytelnika.UseVisualStyleBackColor = true;
            this.button_wybierzIdCzytelnika.Click += new System.EventHandler(this.button_wybierzIdCzytelnika_Click);
            // 
            // button_wybierzIdKsiazki
            // 
            this.button_wybierzIdKsiazki.Location = new System.Drawing.Point(395, 38);
            this.button_wybierzIdKsiazki.Name = "button_wybierzIdKsiazki";
            this.button_wybierzIdKsiazki.Size = new System.Drawing.Size(122, 31);
            this.button_wybierzIdKsiazki.TabIndex = 14;
            this.button_wybierzIdKsiazki.Text = "Szukaj Książki";
            this.button_wybierzIdKsiazki.UseVisualStyleBackColor = true;
            this.button_wybierzIdKsiazki.Click += new System.EventHandler(this.button_wybierzIdKsiazki_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker2.Location = new System.Drawing.Point(306, 369);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.Location = new System.Drawing.Point(306, 304);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // label_dataZwrotu
            // 
            this.label_dataZwrotu.AutoSize = true;
            this.label_dataZwrotu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_dataZwrotu.Location = new System.Drawing.Point(164, 369);
            this.label_dataZwrotu.Margin = new System.Windows.Forms.Padding(3, 40, 3, 0);
            this.label_dataZwrotu.Name = "label_dataZwrotu";
            this.label_dataZwrotu.Size = new System.Drawing.Size(132, 25);
            this.label_dataZwrotu.TabIndex = 9;
            this.label_dataZwrotu.Text = "Data zwrotu:";
            // 
            // label_dataWypozyczenia
            // 
            this.label_dataWypozyczenia.AutoSize = true;
            this.label_dataWypozyczenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_dataWypozyczenia.Location = new System.Drawing.Point(92, 304);
            this.label_dataWypozyczenia.Margin = new System.Windows.Forms.Padding(3, 40, 3, 0);
            this.label_dataWypozyczenia.Name = "label_dataWypozyczenia";
            this.label_dataWypozyczenia.Size = new System.Drawing.Size(204, 25);
            this.label_dataWypozyczenia.TabIndex = 8;
            this.label_dataWypozyczenia.Text = "Data wypożyczenia:";
            // 
            // label_dostepna
            // 
            this.label_dostepna.AutoSize = true;
            this.label_dostepna.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_dostepna.ForeColor = System.Drawing.Color.Teal;
            this.label_dostepna.Location = new System.Drawing.Point(302, 239);
            this.label_dostepna.Name = "label_dostepna";
            this.label_dostepna.Size = new System.Drawing.Size(0, 24);
            this.label_dostepna.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(34, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 40, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ilość egzemplarzy książki:";
            // 
            // label_Czytelnik
            // 
            this.label_Czytelnik.AutoSize = true;
            this.label_Czytelnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Czytelnik.ForeColor = System.Drawing.Color.DarkGreen;
            this.label_Czytelnik.Location = new System.Drawing.Point(302, 137);
            this.label_Czytelnik.Name = "label_Czytelnik";
            this.label_Czytelnik.Size = new System.Drawing.Size(0, 24);
            this.label_Czytelnik.TabIndex = 5;
            // 
            // label_tytulKsiazki
            // 
            this.label_tytulKsiazki.AutoSize = true;
            this.label_tytulKsiazki.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_tytulKsiazki.ForeColor = System.Drawing.Color.DarkGreen;
            this.label_tytulKsiazki.Location = new System.Drawing.Point(302, 72);
            this.label_tytulKsiazki.Name = "label_tytulKsiazki";
            this.label_tytulKsiazki.Size = new System.Drawing.Size(0, 24);
            this.label_tytulKsiazki.TabIndex = 4;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown2.Location = new System.Drawing.Point(306, 103);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(83, 31);
            this.numericUpDown2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(72, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 40, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wybierz ID czytelnika:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown1.Location = new System.Drawing.Point(306, 38);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(83, 31);
            this.numericUpDown1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(102, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wybierz ID książki:";
            // 
            // panel_zwroc
            // 
            this.panel_zwroc.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel_zwroc.Controls.Add(this.button_all);
            this.panel_zwroc.Controls.Add(this.button_zgubione);
            this.panel_zwroc.Controls.Add(this.button_oddane);
            this.panel_zwroc.Controls.Add(this.button_wypozyczone);
            this.panel_zwroc.Controls.Add(this.dataGridView_wyp);
            this.panel_zwroc.Controls.Add(this.button_lostbtn_ret);
            this.panel_zwroc.Controls.Add(this.button_retbtn_ret);
            this.panel_zwroc.Controls.Add(this.button_delbtn_ret);
            this.panel_zwroc.Controls.Add(this.button_szukajCzytelnika_ret);
            this.panel_zwroc.Controls.Add(this.button_szukajKsiazki_ret);
            this.panel_zwroc.Controls.Add(this.dateTimePicker_zwrot_ret);
            this.panel_zwroc.Controls.Add(this.dateTimePicker_wyp_ret);
            this.panel_zwroc.Controls.Add(this.label7);
            this.panel_zwroc.Controls.Add(this.label8);
            this.panel_zwroc.Controls.Add(this.label_czytelnik_ret);
            this.panel_zwroc.Controls.Add(this.label_tytul_ret);
            this.panel_zwroc.Controls.Add(this.numericUpDown_idCzytelnika_ret);
            this.panel_zwroc.Controls.Add(this.label14);
            this.panel_zwroc.Controls.Add(this.numericUpDown_idKsiazki_ret);
            this.panel_zwroc.Controls.Add(this.label15);
            this.panel_zwroc.Location = new System.Drawing.Point(172, 138);
            this.panel_zwroc.Name = "panel_zwroc";
            this.panel_zwroc.Size = new System.Drawing.Size(956, 509);
            this.panel_zwroc.TabIndex = 19;
            // 
            // button_all
            // 
            this.button_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_all.Location = new System.Drawing.Point(463, 26);
            this.button_all.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button_all.Name = "button_all";
            this.button_all.Size = new System.Drawing.Size(100, 31);
            this.button_all.TabIndex = 25;
            this.button_all.Text = "Wszystkie";
            this.button_all.UseVisualStyleBackColor = true;
            this.button_all.Click += new System.EventHandler(this.button_all_Click);
            // 
            // button_zgubione
            // 
            this.button_zgubione.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_zgubione.Location = new System.Drawing.Point(833, 26);
            this.button_zgubione.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.button_zgubione.Name = "button_zgubione";
            this.button_zgubione.Size = new System.Drawing.Size(120, 31);
            this.button_zgubione.TabIndex = 24;
            this.button_zgubione.Text = "Zgubione";
            this.button_zgubione.UseVisualStyleBackColor = true;
            this.button_zgubione.Click += new System.EventHandler(this.button_zgubione_Click);
            // 
            // button_oddane
            // 
            this.button_oddane.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_oddane.Location = new System.Drawing.Point(703, 26);
            this.button_oddane.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button_oddane.Name = "button_oddane";
            this.button_oddane.Size = new System.Drawing.Size(120, 31);
            this.button_oddane.TabIndex = 23;
            this.button_oddane.Text = "Oddane";
            this.button_oddane.UseVisualStyleBackColor = true;
            this.button_oddane.Click += new System.EventHandler(this.button_oddane_Click);
            // 
            // button_wypozyczone
            // 
            this.button_wypozyczone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_wypozyczone.Location = new System.Drawing.Point(573, 26);
            this.button_wypozyczone.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button_wypozyczone.Name = "button_wypozyczone";
            this.button_wypozyczone.Size = new System.Drawing.Size(120, 31);
            this.button_wypozyczone.TabIndex = 22;
            this.button_wypozyczone.Text = "Wypożyczone";
            this.button_wypozyczone.UseVisualStyleBackColor = true;
            this.button_wypozyczone.Click += new System.EventHandler(this.button_wypozyczone_Click);
            // 
            // dataGridView_wyp
            // 
            this.dataGridView_wyp.AllowUserToAddRows = false;
            this.dataGridView_wyp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_wyp.Location = new System.Drawing.Point(454, 63);
            this.dataGridView_wyp.Name = "dataGridView_wyp";
            this.dataGridView_wyp.ReadOnly = true;
            this.dataGridView_wyp.Size = new System.Drawing.Size(500, 353);
            this.dataGridView_wyp.TabIndex = 21;
            this.dataGridView_wyp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_wyp_CellClick);
            // 
            // button_lostbtn_ret
            // 
            this.button_lostbtn_ret.BackColor = System.Drawing.Color.OrangeRed;
            this.button_lostbtn_ret.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_lostbtn_ret.ForeColor = System.Drawing.Color.White;
            this.button_lostbtn_ret.Location = new System.Drawing.Point(483, 422);
            this.button_lostbtn_ret.Name = "button_lostbtn_ret";
            this.button_lostbtn_ret.Size = new System.Drawing.Size(470, 39);
            this.button_lostbtn_ret.TabIndex = 20;
            this.button_lostbtn_ret.Text = "Zgubiono książkę";
            this.button_lostbtn_ret.UseVisualStyleBackColor = false;
            this.button_lostbtn_ret.Click += new System.EventHandler(this.button_lostbtn_ret_Click);
            // 
            // button_retbtn_ret
            // 
            this.button_retbtn_ret.BackColor = System.Drawing.Color.Green;
            this.button_retbtn_ret.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_retbtn_ret.ForeColor = System.Drawing.Color.White;
            this.button_retbtn_ret.Location = new System.Drawing.Point(3, 422);
            this.button_retbtn_ret.Name = "button_retbtn_ret";
            this.button_retbtn_ret.Size = new System.Drawing.Size(470, 39);
            this.button_retbtn_ret.TabIndex = 19;
            this.button_retbtn_ret.Text = "Zwróć książkę";
            this.button_retbtn_ret.UseVisualStyleBackColor = false;
            this.button_retbtn_ret.Click += new System.EventHandler(this.button_retbtn_ret_Click);
            // 
            // button_delbtn_ret
            // 
            this.button_delbtn_ret.BackColor = System.Drawing.Color.Red;
            this.button_delbtn_ret.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_delbtn_ret.ForeColor = System.Drawing.Color.White;
            this.button_delbtn_ret.Location = new System.Drawing.Point(3, 467);
            this.button_delbtn_ret.Name = "button_delbtn_ret";
            this.button_delbtn_ret.Size = new System.Drawing.Size(950, 39);
            this.button_delbtn_ret.TabIndex = 16;
            this.button_delbtn_ret.Text = "Usuń";
            this.button_delbtn_ret.UseVisualStyleBackColor = false;
            this.button_delbtn_ret.Click += new System.EventHandler(this.button_delbtn_ret_Click);
            // 
            // button_szukajCzytelnika_ret
            // 
            this.button_szukajCzytelnika_ret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_szukajCzytelnika_ret.Location = new System.Drawing.Point(326, 97);
            this.button_szukajCzytelnika_ret.Name = "button_szukajCzytelnika_ret";
            this.button_szukajCzytelnika_ret.Size = new System.Drawing.Size(122, 31);
            this.button_szukajCzytelnika_ret.TabIndex = 15;
            this.button_szukajCzytelnika_ret.Text = "Szukaj ID";
            this.button_szukajCzytelnika_ret.UseVisualStyleBackColor = true;
            this.button_szukajCzytelnika_ret.Visible = false;
            this.button_szukajCzytelnika_ret.Click += new System.EventHandler(this.button_szukajCzytelnika_ret_Click);
            // 
            // button_szukajKsiazki_ret
            // 
            this.button_szukajKsiazki_ret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_szukajKsiazki_ret.Location = new System.Drawing.Point(326, 32);
            this.button_szukajKsiazki_ret.Name = "button_szukajKsiazki_ret";
            this.button_szukajKsiazki_ret.Size = new System.Drawing.Size(122, 31);
            this.button_szukajKsiazki_ret.TabIndex = 14;
            this.button_szukajKsiazki_ret.Text = "Szukaj Książki";
            this.button_szukajKsiazki_ret.UseVisualStyleBackColor = true;
            this.button_szukajKsiazki_ret.Visible = false;
            this.button_szukajKsiazki_ret.Click += new System.EventHandler(this.button_szukajKsiazki_ret_Click);
            // 
            // dateTimePicker_zwrot_ret
            // 
            this.dateTimePicker_zwrot_ret.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker_zwrot_ret.Location = new System.Drawing.Point(237, 236);
            this.dateTimePicker_zwrot_ret.Name = "dateTimePicker_zwrot_ret";
            this.dateTimePicker_zwrot_ret.Size = new System.Drawing.Size(211, 20);
            this.dateTimePicker_zwrot_ret.TabIndex = 11;
            // 
            // dateTimePicker_wyp_ret
            // 
            this.dateTimePicker_wyp_ret.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker_wyp_ret.Enabled = false;
            this.dateTimePicker_wyp_ret.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker_wyp_ret.Location = new System.Drawing.Point(237, 173);
            this.dateTimePicker_wyp_ret.Name = "dateTimePicker_wyp_ret";
            this.dateTimePicker_wyp_ret.Size = new System.Drawing.Size(211, 20);
            this.dateTimePicker_wyp_ret.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(101, 233);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 40, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Data zwrotu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(23, 167);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 40, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Data wypożyczenia:";
            // 
            // label_czytelnik_ret
            // 
            this.label_czytelnik_ret.AutoSize = true;
            this.label_czytelnik_ret.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_czytelnik_ret.ForeColor = System.Drawing.Color.DarkGreen;
            this.label_czytelnik_ret.Location = new System.Drawing.Point(233, 131);
            this.label_czytelnik_ret.Name = "label_czytelnik_ret";
            this.label_czytelnik_ret.Size = new System.Drawing.Size(0, 24);
            this.label_czytelnik_ret.TabIndex = 5;
            // 
            // label_tytul_ret
            // 
            this.label_tytul_ret.AutoSize = true;
            this.label_tytul_ret.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_tytul_ret.ForeColor = System.Drawing.Color.DarkGreen;
            this.label_tytul_ret.Location = new System.Drawing.Point(233, 66);
            this.label_tytul_ret.Name = "label_tytul_ret";
            this.label_tytul_ret.Size = new System.Drawing.Size(0, 24);
            this.label_tytul_ret.TabIndex = 4;
            // 
            // numericUpDown_idCzytelnika_ret
            // 
            this.numericUpDown_idCzytelnika_ret.Enabled = false;
            this.numericUpDown_idCzytelnika_ret.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_idCzytelnika_ret.Location = new System.Drawing.Point(237, 97);
            this.numericUpDown_idCzytelnika_ret.Name = "numericUpDown_idCzytelnika_ret";
            this.numericUpDown_idCzytelnika_ret.Size = new System.Drawing.Size(83, 31);
            this.numericUpDown_idCzytelnika_ret.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(3, 103);
            this.label14.Margin = new System.Windows.Forms.Padding(3, 40, 3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(224, 25);
            this.label14.TabIndex = 2;
            this.label14.Text = "Wybierz ID czytelnika:";
            // 
            // numericUpDown_idKsiazki_ret
            // 
            this.numericUpDown_idKsiazki_ret.Enabled = false;
            this.numericUpDown_idKsiazki_ret.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_idKsiazki_ret.Location = new System.Drawing.Point(237, 32);
            this.numericUpDown_idKsiazki_ret.Name = "numericUpDown_idKsiazki_ret";
            this.numericUpDown_idKsiazki_ret.Size = new System.Drawing.Size(83, 31);
            this.numericUpDown_idKsiazki_ret.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(33, 38);
            this.label15.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(194, 25);
            this.label15.TabIndex = 0;
            this.label15.Text = "Wybierz ID książki:";
            // 
            // ManageWypozyczeniaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1140, 659);
            this.Controls.Add(this.label_close);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_userlogin);
            this.Controls.Add(this.panel_zwroc);
            this.Controls.Add(this.panel_wypozycz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageWypozyczeniaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageWypozyczeniaForm";
            this.Load += new System.EventHandler(this.ManageWypozyczeniaForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel_wypozycz.ResumeLayout(false);
            this.panel_wypozycz.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel_zwroc.ResumeLayout(false);
            this.panel_zwroc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_wyp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_idCzytelnika_ret)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_idKsiazki_ret)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_userlogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_zwrocPanel;
        private System.Windows.Forms.Button button_wypozyczPanel;
        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.Panel panel_wypozycz;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label_dataZwrotu;
        private System.Windows.Forms.Label label_dataWypozyczenia;
        private System.Windows.Forms.Label label_dostepna;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_Czytelnik;
        private System.Windows.Forms.Label label_tytulKsiazki;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_wypozycz;
        private System.Windows.Forms.Button button_wybierzIdCzytelnika;
        private System.Windows.Forms.Button button_wybierzIdKsiazki;
        private System.Windows.Forms.Label label_ileNaStanie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel_zwroc;
        private System.Windows.Forms.Button button_delbtn_ret;
        private System.Windows.Forms.Button button_szukajCzytelnika_ret;
        private System.Windows.Forms.Button button_szukajKsiazki_ret;
        private System.Windows.Forms.DateTimePicker dateTimePicker_zwrot_ret;
        private System.Windows.Forms.DateTimePicker dateTimePicker_wyp_ret;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_czytelnik_ret;
        private System.Windows.Forms.Label label_tytul_ret;
        private System.Windows.Forms.NumericUpDown numericUpDown_idCzytelnika_ret;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numericUpDown_idKsiazki_ret;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button_lostbtn_ret;
        private System.Windows.Forms.Button button_retbtn_ret;
        private System.Windows.Forms.DataGridView dataGridView_wyp;
        private System.Windows.Forms.Button button_zgubione;
        private System.Windows.Forms.Button button_oddane;
        private System.Windows.Forms.Button button_wypozyczone;
        private System.Windows.Forms.Button button_all;
    }
}