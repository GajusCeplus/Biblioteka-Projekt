namespace Biblioteka.FORMS
{
    partial class ManageAutorForm
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
            this.label_autorCount = new System.Windows.Forms.Label();
            this.button_autorShow = new System.Windows.Forms.Button();
            this.button_del = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_dodaj = new System.Windows.Forms.Button();
            this.label_close = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_autor = new System.Windows.Forms.DataGridView();
            this.textBox_nazwisko = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_imie = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_autor)).BeginInit();
            this.SuspendLayout();
            // 
            // label_userlogin
            // 
            this.label_userlogin.BackColor = System.Drawing.Color.Gray;
            this.label_userlogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_userlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_userlogin.Location = new System.Drawing.Point(0, 0);
            this.label_userlogin.Name = "label_userlogin";
            this.label_userlogin.Size = new System.Drawing.Size(981, 121);
            this.label_userlogin.TabIndex = 2;
            this.label_userlogin.Text = "Autorzy";
            this.label_userlogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label_autorCount);
            this.panel1.Controls.Add(this.button_autorShow);
            this.panel1.Controls.Add(this.button_del);
            this.panel1.Controls.Add(this.button_edit);
            this.panel1.Controls.Add(this.button_dodaj);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 376);
            this.panel1.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(0, 298);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 37);
            this.label11.TabIndex = 15;
            this.label11.Text = "Liczba autorów:";
            // 
            // label_autorCount
            // 
            this.label_autorCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_autorCount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_autorCount.Location = new System.Drawing.Point(1, 335);
            this.label_autorCount.Name = "label_autorCount";
            this.label_autorCount.Size = new System.Drawing.Size(163, 37);
            this.label_autorCount.TabIndex = 14;
            this.label_autorCount.Text = "99999999999";
            // 
            // button_autorShow
            // 
            this.button_autorShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_autorShow.Location = new System.Drawing.Point(10, 184);
            this.button_autorShow.Name = "button_autorShow";
            this.button_autorShow.Size = new System.Drawing.Size(147, 54);
            this.button_autorShow.TabIndex = 3;
            this.button_autorShow.Text = "Pokaż książki autora";
            this.button_autorShow.UseVisualStyleBackColor = true;
            this.button_autorShow.Click += new System.EventHandler(this.button_autorShow_Click);
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
            this.label_close.Location = new System.Drawing.Point(939, 0);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(42, 35);
            this.label_close.TabIndex = 7;
            this.label_close.Text = "X";
            this.label_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView_autor);
            this.panel2.Controls.Add(this.textBox_nazwisko);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox_imie);
            this.panel2.Controls.Add(this.textBox_id);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(166, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(815, 376);
            this.panel2.TabIndex = 8;
            // 
            // dataGridView_autor
            // 
            this.dataGridView_autor.AllowUserToAddRows = false;
            this.dataGridView_autor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_autor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_autor.Location = new System.Drawing.Point(420, 17);
            this.dataGridView_autor.Name = "dataGridView_autor";
            this.dataGridView_autor.ReadOnly = true;
            this.dataGridView_autor.Size = new System.Drawing.Size(383, 336);
            this.dataGridView_autor.TabIndex = 10;
            this.dataGridView_autor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_autor_CellClick);
            // 
            // textBox_nazwisko
            // 
            this.textBox_nazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_nazwisko.Location = new System.Drawing.Point(176, 124);
            this.textBox_nazwisko.Name = "textBox_nazwisko";
            this.textBox_nazwisko.Size = new System.Drawing.Size(238, 31);
            this.textBox_nazwisko.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(6, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 37);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nazwisko:";
            // 
            // textBox_imie
            // 
            this.textBox_imie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_imie.Location = new System.Drawing.Point(176, 81);
            this.textBox_imie.Name = "textBox_imie";
            this.textBox_imie.Size = new System.Drawing.Size(238, 31);
            this.textBox_imie.TabIndex = 7;
            // 
            // textBox_id
            // 
            this.textBox_id.Enabled = false;
            this.textBox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_id.Location = new System.Drawing.Point(176, 40);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(115, 31);
            this.textBox_id.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(110, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(82, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Imie:";
            // 
            // ManageAutorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(981, 497);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label_close);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_userlogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageAutorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageAutorForm";
            this.Load += new System.EventHandler(this.ManageAutorForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_autor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_userlogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_imie;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_nazwisko;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView_autor;
        private System.Windows.Forms.Button button_autorShow;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label_autorCount;
        public System.Windows.Forms.Button button_del;
        public System.Windows.Forms.Button button_edit;
        public System.Windows.Forms.Button button_dodaj;
    }
}