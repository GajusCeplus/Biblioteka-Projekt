namespace Biblioteka.FORMS
{
    partial class Dashboard_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_users = new System.Windows.Forms.Button();
            this.button_czytelnicy = new System.Windows.Forms.Button();
            this.button_autor = new System.Windows.Forms.Button();
            this.button_gatunek = new System.Windows.Forms.Button();
            this.button_borrow = new System.Windows.Forms.Button();
            this.button_books = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.label_title = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label_gatunkiCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_czytelnicy = new System.Windows.Forms.Panel();
            this.label_czytelnicyCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_autorzy = new System.Windows.Forms.Panel();
            this.label_autorzyCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_ksiazki = new System.Windows.Forms.Panel();
            this.label_booksCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel_czytelnicy.SuspendLayout();
            this.panel_autorzy.SuspendLayout();
            this.panel_ksiazki.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.button_users);
            this.panel1.Controls.Add(this.button_czytelnicy);
            this.panel1.Controls.Add(this.button_autor);
            this.panel1.Controls.Add(this.button_gatunek);
            this.panel1.Controls.Add(this.button_borrow);
            this.panel1.Controls.Add(this.button_books);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 661);
            this.panel1.TabIndex = 0;
            // 
            // button_users
            // 
            this.button_users.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_users.FlatAppearance.BorderSize = 0;
            this.button_users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_users.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_users.ForeColor = System.Drawing.Color.White;
            this.button_users.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_users.Location = new System.Drawing.Point(0, 521);
            this.button_users.Name = "button_users";
            this.button_users.Size = new System.Drawing.Size(250, 67);
            this.button_users.TabIndex = 8;
            this.button_users.Text = "Użytkownicy";
            this.button_users.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_users.UseVisualStyleBackColor = true;
            this.button_users.Click += new System.EventHandler(this.button_users_Click);
            // 
            // button_czytelnicy
            // 
            this.button_czytelnicy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_czytelnicy.FlatAppearance.BorderSize = 0;
            this.button_czytelnicy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_czytelnicy.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_czytelnicy.ForeColor = System.Drawing.Color.White;
            this.button_czytelnicy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_czytelnicy.Location = new System.Drawing.Point(3, 448);
            this.button_czytelnicy.Name = "button_czytelnicy";
            this.button_czytelnicy.Size = new System.Drawing.Size(247, 67);
            this.button_czytelnicy.TabIndex = 7;
            this.button_czytelnicy.Text = "Czytelnicy";
            this.button_czytelnicy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_czytelnicy.UseVisualStyleBackColor = true;
            this.button_czytelnicy.Click += new System.EventHandler(this.button_czytelnicy_Click);
            // 
            // button_autor
            // 
            this.button_autor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_autor.FlatAppearance.BorderSize = 0;
            this.button_autor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_autor.ForeColor = System.Drawing.Color.White;
            this.button_autor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_autor.Location = new System.Drawing.Point(3, 229);
            this.button_autor.Name = "button_autor";
            this.button_autor.Size = new System.Drawing.Size(247, 67);
            this.button_autor.TabIndex = 6;
            this.button_autor.Text = "Autorzy";
            this.button_autor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_autor.UseVisualStyleBackColor = true;
            this.button_autor.Click += new System.EventHandler(this.button_autor_Click);
            // 
            // button_gatunek
            // 
            this.button_gatunek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_gatunek.FlatAppearance.BorderSize = 0;
            this.button_gatunek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_gatunek.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_gatunek.ForeColor = System.Drawing.Color.White;
            this.button_gatunek.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_gatunek.Location = new System.Drawing.Point(3, 302);
            this.button_gatunek.Name = "button_gatunek";
            this.button_gatunek.Size = new System.Drawing.Size(247, 67);
            this.button_gatunek.TabIndex = 5;
            this.button_gatunek.Text = "Gatunki";
            this.button_gatunek.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_gatunek.UseVisualStyleBackColor = true;
            this.button_gatunek.Click += new System.EventHandler(this.button_gatunek_Click);
            // 
            // button_borrow
            // 
            this.button_borrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_borrow.FlatAppearance.BorderSize = 0;
            this.button_borrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_borrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_borrow.ForeColor = System.Drawing.Color.White;
            this.button_borrow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_borrow.Location = new System.Drawing.Point(0, 375);
            this.button_borrow.Name = "button_borrow";
            this.button_borrow.Size = new System.Drawing.Size(250, 67);
            this.button_borrow.TabIndex = 4;
            this.button_borrow.Text = "Wypożyczenia";
            this.button_borrow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_borrow.UseVisualStyleBackColor = true;
            this.button_borrow.Click += new System.EventHandler(this.button_borrow_Click);
            // 
            // button_books
            // 
            this.button_books.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_books.FlatAppearance.BorderSize = 0;
            this.button_books.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_books.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_books.ForeColor = System.Drawing.Color.White;
            this.button_books.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_books.Location = new System.Drawing.Point(3, 156);
            this.button_books.Name = "button_books";
            this.button_books.Size = new System.Drawing.Size(247, 67);
            this.button_books.TabIndex = 3;
            this.button_books.Text = "Książki";
            this.button_books.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_books.UseVisualStyleBackColor = true;
            this.button_books.Click += new System.EventHandler(this.button_books_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Tan;
            this.panel2.Controls.Add(this.pictureBox_Logo);
            this.panel2.Controls.Add(this.label_title);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 91);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.BackColor = System.Drawing.Color.Tan;
            this.pictureBox_Logo.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(90, 80);
            this.pictureBox_Logo.TabIndex = 0;
            this.pictureBox_Logo.TabStop = false;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_title.ForeColor = System.Drawing.Color.Gold;
            this.label_title.Location = new System.Drawing.Point(99, 30);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(142, 31);
            this.label_title.TabIndex = 1;
            this.label_title.Text = "Biblioteka";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel_czytelnicy);
            this.panel3.Controls.Add(this.panel_autorzy);
            this.panel3.Controls.Add(this.panel_ksiazki);
            this.panel3.Controls.Add(this.button_close);
            this.panel3.Location = new System.Drawing.Point(257, 10);
            this.panel3.Margin = new System.Windows.Forms.Padding(1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(933, 641);
            this.panel3.TabIndex = 1;
            this.panel3.MouseEnter += new System.EventHandler(this.Dashboard_Form_MouseEnter);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.IndianRed;
            this.panel4.Controls.Add(this.label_gatunkiCount);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(521, 398);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(272, 180);
            this.panel4.TabIndex = 2;
            // 
            // label_gatunkiCount
            // 
            this.label_gatunkiCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_gatunkiCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_gatunkiCount.Location = new System.Drawing.Point(0, 50);
            this.label_gatunkiCount.Name = "label_gatunkiCount";
            this.label_gatunkiCount.Size = new System.Drawing.Size(272, 130);
            this.label_gatunkiCount.TabIndex = 1;
            this.label_gatunkiCount.Text = "420";
            this.label_gatunkiCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Firebrick;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 50);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gatunki";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_czytelnicy
            // 
            this.panel_czytelnicy.BackColor = System.Drawing.Color.IndianRed;
            this.panel_czytelnicy.Controls.Add(this.label_czytelnicyCount);
            this.panel_czytelnicy.Controls.Add(this.label5);
            this.panel_czytelnicy.Location = new System.Drawing.Point(521, 106);
            this.panel_czytelnicy.Name = "panel_czytelnicy";
            this.panel_czytelnicy.Size = new System.Drawing.Size(272, 180);
            this.panel_czytelnicy.TabIndex = 2;
            // 
            // label_czytelnicyCount
            // 
            this.label_czytelnicyCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_czytelnicyCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_czytelnicyCount.Location = new System.Drawing.Point(0, 50);
            this.label_czytelnicyCount.Name = "label_czytelnicyCount";
            this.label_czytelnicyCount.Size = new System.Drawing.Size(272, 130);
            this.label_czytelnicyCount.TabIndex = 3;
            this.label_czytelnicyCount.Text = "420";
            this.label_czytelnicyCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Firebrick;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 50);
            this.label5.TabIndex = 2;
            this.label5.Text = "Czytelnicy";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_autorzy
            // 
            this.panel_autorzy.BackColor = System.Drawing.Color.IndianRed;
            this.panel_autorzy.Controls.Add(this.label_autorzyCount);
            this.panel_autorzy.Controls.Add(this.label3);
            this.panel_autorzy.Location = new System.Drawing.Point(104, 325);
            this.panel_autorzy.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.panel_autorzy.Name = "panel_autorzy";
            this.panel_autorzy.Size = new System.Drawing.Size(272, 180);
            this.panel_autorzy.TabIndex = 2;
            // 
            // label_autorzyCount
            // 
            this.label_autorzyCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_autorzyCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_autorzyCount.Location = new System.Drawing.Point(0, 50);
            this.label_autorzyCount.Name = "label_autorzyCount";
            this.label_autorzyCount.Size = new System.Drawing.Size(272, 130);
            this.label_autorzyCount.TabIndex = 3;
            this.label_autorzyCount.Text = "420";
            this.label_autorzyCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Firebrick;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 50);
            this.label3.TabIndex = 2;
            this.label3.Text = "Autorzy";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_ksiazki
            // 
            this.panel_ksiazki.BackColor = System.Drawing.Color.IndianRed;
            this.panel_ksiazki.Controls.Add(this.label_booksCount);
            this.panel_ksiazki.Controls.Add(this.label1);
            this.panel_ksiazki.Location = new System.Drawing.Point(104, 33);
            this.panel_ksiazki.Name = "panel_ksiazki";
            this.panel_ksiazki.Size = new System.Drawing.Size(272, 180);
            this.panel_ksiazki.TabIndex = 1;
            // 
            // label_booksCount
            // 
            this.label_booksCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_booksCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_booksCount.Location = new System.Drawing.Point(0, 50);
            this.label_booksCount.Name = "label_booksCount";
            this.label_booksCount.Size = new System.Drawing.Size(272, 130);
            this.label_booksCount.TabIndex = 1;
            this.label_booksCount.Text = "420";
            this.label_booksCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Firebrick;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Książki";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_close
            // 
            this.button_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_close.Location = new System.Drawing.Point(903, 3);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(25, 25);
            this.button_close.TabIndex = 0;
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // Dashboard_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1200, 661);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "Dashboard_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Dashboard_Form_Load);
            this.Shown += new System.EventHandler(this.Dashboard_Form_Shown);
            this.MouseEnter += new System.EventHandler(this.Dashboard_Form_MouseEnter);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel_czytelnicy.ResumeLayout(false);
            this.panel_autorzy.ResumeLayout(false);
            this.panel_ksiazki.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Panel panel_czytelnicy;
        private System.Windows.Forms.Label label_czytelnicyCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel_autorzy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_ksiazki;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_books;
        private System.Windows.Forms.Button button_autor;
        private System.Windows.Forms.Button button_gatunek;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label_gatunkiCount;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button button_users;
        public System.Windows.Forms.Button button_borrow;
        public System.Windows.Forms.Button button_czytelnicy;
        private System.Windows.Forms.Label label_autorzyCount;
        private System.Windows.Forms.Label label_booksCount;
    }
}