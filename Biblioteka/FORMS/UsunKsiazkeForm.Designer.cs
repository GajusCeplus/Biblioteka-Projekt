namespace Biblioteka.FORMS
{
    partial class UsunKsiazkeForm
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
            this.numericUpDown_DEL = new System.Windows.Forms.NumericUpDown();
            this.button_DelKsiazka = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label_close = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DEL)).BeginInit();
            this.SuspendLayout();
            // 
            // label_userlogin
            // 
            this.label_userlogin.BackColor = System.Drawing.Color.Gray;
            this.label_userlogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_userlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_userlogin.Location = new System.Drawing.Point(0, 0);
            this.label_userlogin.Name = "label_userlogin";
            this.label_userlogin.Size = new System.Drawing.Size(577, 153);
            this.label_userlogin.TabIndex = 1;
            this.label_userlogin.Text = "Usuń książkę";
            this.label_userlogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericUpDown_DEL);
            this.panel1.Controls.Add(this.button_DelKsiazka);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 211);
            this.panel1.TabIndex = 2;
            // 
            // numericUpDown_DEL
            // 
            this.numericUpDown_DEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_DEL.Location = new System.Drawing.Point(302, 17);
            this.numericUpDown_DEL.Name = "numericUpDown_DEL";
            this.numericUpDown_DEL.Size = new System.Drawing.Size(238, 35);
            this.numericUpDown_DEL.TabIndex = 46;
            // 
            // button_DelKsiazka
            // 
            this.button_DelKsiazka.BackColor = System.Drawing.Color.Firebrick;
            this.button_DelKsiazka.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_DelKsiazka.Location = new System.Drawing.Point(34, 113);
            this.button_DelKsiazka.Name = "button_DelKsiazka";
            this.button_DelKsiazka.Size = new System.Drawing.Size(506, 66);
            this.button_DelKsiazka.TabIndex = 45;
            this.button_DelKsiazka.Text = "Usuń tę książkę";
            this.button_DelKsiazka.UseVisualStyleBackColor = false;
            this.button_DelKsiazka.Click += new System.EventHandler(this.button_selectID_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label23.Location = new System.Drawing.Point(27, 17);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(260, 37);
            this.label23.TabIndex = 43;
            this.label23.Text = "Wpisz ID książki:";
            // 
            // label_close
            // 
            this.label_close.BackColor = System.Drawing.Color.Gray;
            this.label_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_close.ForeColor = System.Drawing.Color.Red;
            this.label_close.Location = new System.Drawing.Point(537, 9);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(28, 19);
            this.label_close.TabIndex = 2;
            this.label_close.Text = "X";
            this.label_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            // 
            // UsunKsiazkeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(577, 364);
            this.Controls.Add(this.label_close);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_userlogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsunKsiazkeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsunKsiazkeForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DEL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_userlogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.Button button_DelKsiazka;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.NumericUpDown numericUpDown_DEL;
    }
}