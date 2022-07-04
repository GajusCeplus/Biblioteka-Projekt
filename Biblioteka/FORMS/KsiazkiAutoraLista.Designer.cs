namespace Biblioteka.FORMS
{
    partial class KsiazkiAutoraLista
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_ksiazki = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label_userlogin
            // 
            this.label_userlogin.BackColor = System.Drawing.Color.Gray;
            this.label_userlogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_userlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_userlogin.Location = new System.Drawing.Point(0, 0);
            this.label_userlogin.Name = "label_userlogin";
            this.label_userlogin.Size = new System.Drawing.Size(442, 121);
            this.label_userlogin.TabIndex = 4;
            this.label_userlogin.Text = "Książki Autora:";
            this.label_userlogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_close
            // 
            this.label_close.BackColor = System.Drawing.Color.Gray;
            this.label_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_close.ForeColor = System.Drawing.Color.Red;
            this.label_close.Location = new System.Drawing.Point(400, 0);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(42, 35);
            this.label_close.TabIndex = 9;
            this.label_close.Text = "X";
            this.label_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "imie nazwisko";
            // 
            // listBox_ksiazki
            // 
            this.listBox_ksiazki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox_ksiazki.FormattingEnabled = true;
            this.listBox_ksiazki.ItemHeight = 20;
            this.listBox_ksiazki.Location = new System.Drawing.Point(10, 152);
            this.listBox_ksiazki.Name = "listBox_ksiazki";
            this.listBox_ksiazki.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox_ksiazki.Size = new System.Drawing.Size(420, 404);
            this.listBox_ksiazki.Sorted = true;
            this.listBox_ksiazki.TabIndex = 12;
            // 
            // KsiazkiAutoraLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(442, 571);
            this.Controls.Add(this.listBox_ksiazki);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_close);
            this.Controls.Add(this.label_userlogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KsiazkiAutoraLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KsiazkiAutoraLista";
            this.Load += new System.EventHandler(this.KsiazkiAutoraLista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_userlogin;
        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_ksiazki;
    }
}