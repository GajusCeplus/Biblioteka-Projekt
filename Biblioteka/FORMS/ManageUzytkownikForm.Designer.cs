namespace Biblioteka.FORMS
{
    partial class ManageUzytkownikForm
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
            this.label_close = new System.Windows.Forms.Label();
            this.button_edytuj = new System.Windows.Forms.Button();
            this.button_dodaj = new System.Windows.Forms.Button();
            this.dataGridView_user = new System.Windows.Forms.DataGridView();
            this.textBox_nazwisko = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_imie = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_haslo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_rehaslo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox_admin = new System.Windows.Forms.CheckBox();
            this.button_del = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_user)).BeginInit();
            this.SuspendLayout();
            // 
            // label_userlogin
            // 
            this.label_userlogin.BackColor = System.Drawing.Color.Gray;
            this.label_userlogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_userlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_userlogin.Location = new System.Drawing.Point(0, 0);
            this.label_userlogin.Name = "label_userlogin";
            this.label_userlogin.Size = new System.Drawing.Size(1079, 121);
            this.label_userlogin.TabIndex = 5;
            this.label_userlogin.Text = "Użytkownicy";
            this.label_userlogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_close
            // 
            this.label_close.BackColor = System.Drawing.Color.Gray;
            this.label_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_close.ForeColor = System.Drawing.Color.Red;
            this.label_close.Location = new System.Drawing.Point(1037, 0);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(42, 35);
            this.label_close.TabIndex = 10;
            this.label_close.Text = "X";
            this.label_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            // 
            // button_edytuj
            // 
            this.button_edytuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_edytuj.Location = new System.Drawing.Point(173, 538);
            this.button_edytuj.Name = "button_edytuj";
            this.button_edytuj.Size = new System.Drawing.Size(120, 46);
            this.button_edytuj.TabIndex = 1;
            this.button_edytuj.Text = "Edytuj";
            this.button_edytuj.UseVisualStyleBackColor = true;
            this.button_edytuj.Click += new System.EventHandler(this.button_edytuj_Click);
            // 
            // button_dodaj
            // 
            this.button_dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_dodaj.Location = new System.Drawing.Point(47, 538);
            this.button_dodaj.Name = "button_dodaj";
            this.button_dodaj.Size = new System.Drawing.Size(120, 46);
            this.button_dodaj.TabIndex = 0;
            this.button_dodaj.Text = "Dodaj";
            this.button_dodaj.UseVisualStyleBackColor = true;
            this.button_dodaj.Click += new System.EventHandler(this.button_dodaj_Click);
            // 
            // dataGridView_user
            // 
            this.dataGridView_user.AllowUserToAddRows = false;
            this.dataGridView_user.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_user.Location = new System.Drawing.Point(450, 135);
            this.dataGridView_user.Name = "dataGridView_user";
            this.dataGridView_user.ReadOnly = true;
            this.dataGridView_user.Size = new System.Drawing.Size(617, 449);
            this.dataGridView_user.TabIndex = 18;
            this.dataGridView_user.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_user_CellClick);
            // 
            // textBox_nazwisko
            // 
            this.textBox_nazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_nazwisko.Location = new System.Drawing.Point(176, 249);
            this.textBox_nazwisko.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.textBox_nazwisko.Multiline = true;
            this.textBox_nazwisko.Name = "textBox_nazwisko";
            this.textBox_nazwisko.Size = new System.Drawing.Size(238, 35);
            this.textBox_nazwisko.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(6, 247);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 37);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nazwisko:";
            // 
            // textBox_imie
            // 
            this.textBox_imie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_imie.Location = new System.Drawing.Point(176, 196);
            this.textBox_imie.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.textBox_imie.Multiline = true;
            this.textBox_imie.Name = "textBox_imie";
            this.textBox_imie.Size = new System.Drawing.Size(238, 35);
            this.textBox_imie.TabIndex = 15;
            // 
            // textBox_id
            // 
            this.textBox_id.Enabled = false;
            this.textBox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_id.Location = new System.Drawing.Point(176, 148);
            this.textBox_id.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.textBox_id.Multiline = true;
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(115, 35);
            this.textBox_id.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(110, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(82, 199);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 37);
            this.label2.TabIndex = 13;
            this.label2.Text = "Imie:";
            // 
            // textBox_login
            // 
            this.textBox_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_login.Location = new System.Drawing.Point(176, 297);
            this.textBox_login.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.textBox_login.Multiline = true;
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(238, 35);
            this.textBox_login.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(6, 295);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 37);
            this.label4.TabIndex = 19;
            this.label4.Text = "Login:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_haslo
            // 
            this.textBox_haslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_haslo.Location = new System.Drawing.Point(176, 345);
            this.textBox_haslo.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.textBox_haslo.Multiline = true;
            this.textBox_haslo.Name = "textBox_haslo";
            this.textBox_haslo.Size = new System.Drawing.Size(238, 35);
            this.textBox_haslo.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(6, 343);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 37);
            this.label5.TabIndex = 21;
            this.label5.Text = "Hasło:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_rehaslo
            // 
            this.textBox_rehaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_rehaslo.Location = new System.Drawing.Point(173, 435);
            this.textBox_rehaslo.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.textBox_rehaslo.Multiline = true;
            this.textBox_rehaslo.Name = "textBox_rehaslo";
            this.textBox_rehaslo.Size = new System.Drawing.Size(238, 35);
            this.textBox_rehaslo.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(3, 390);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 80);
            this.label6.TabIndex = 23;
            this.label6.Text = "Powtórz hasło:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBox_admin
            // 
            this.checkBox_admin.AutoSize = true;
            this.checkBox_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_admin.Location = new System.Drawing.Point(173, 476);
            this.checkBox_admin.Name = "checkBox_admin";
            this.checkBox_admin.Size = new System.Drawing.Size(91, 29);
            this.checkBox_admin.TabIndex = 25;
            this.checkBox_admin.Text = "Admin";
            this.checkBox_admin.UseVisualStyleBackColor = true;
            // 
            // button_del
            // 
            this.button_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_del.Location = new System.Drawing.Point(299, 538);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(120, 46);
            this.button_del.TabIndex = 2;
            this.button_del.Text = "Usuń";
            this.button_del.UseVisualStyleBackColor = true;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // ManageUzytkownikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1079, 597);
            this.Controls.Add(this.button_del);
            this.Controls.Add(this.checkBox_admin);
            this.Controls.Add(this.button_edytuj);
            this.Controls.Add(this.textBox_rehaslo);
            this.Controls.Add(this.button_dodaj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_haslo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView_user);
            this.Controls.Add(this.textBox_nazwisko);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_imie);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_close);
            this.Controls.Add(this.label_userlogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageUzytkownikForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageUzytkownikForm";
            this.Load += new System.EventHandler(this.ManageUzytkownikForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_userlogin;
        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.Button button_edytuj;
        private System.Windows.Forms.Button button_dodaj;
        private System.Windows.Forms.DataGridView dataGridView_user;
        private System.Windows.Forms.TextBox textBox_nazwisko;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_imie;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_haslo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_rehaslo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox_admin;
        private System.Windows.Forms.Button button_del;
    }
}