namespace Biblioteka.FORMS
{
    partial class ListaGatunkowForm
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
            this.label_gatunek = new System.Windows.Forms.Label();
            this.listBox_ksiazkiGatunek = new System.Windows.Forms.ListBox();
            this.label_close = new System.Windows.Forms.Label();
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
            this.label_userlogin.TabIndex = 5;
            this.label_userlogin.Text = "Gatunek:";
            this.label_userlogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_gatunek
            // 
            this.label_gatunek.AutoSize = true;
            this.label_gatunek.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_gatunek.ForeColor = System.Drawing.Color.White;
            this.label_gatunek.Location = new System.Drawing.Point(5, 121);
            this.label_gatunek.Name = "label_gatunek";
            this.label_gatunek.Size = new System.Drawing.Size(74, 25);
            this.label_gatunek.TabIndex = 12;
            this.label_gatunek.Text = "nazwa";
            // 
            // listBox_ksiazkiGatunek
            // 
            this.listBox_ksiazkiGatunek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox_ksiazkiGatunek.FormattingEnabled = true;
            this.listBox_ksiazkiGatunek.ItemHeight = 20;
            this.listBox_ksiazkiGatunek.Location = new System.Drawing.Point(10, 149);
            this.listBox_ksiazkiGatunek.Name = "listBox_ksiazkiGatunek";
            this.listBox_ksiazkiGatunek.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox_ksiazkiGatunek.Size = new System.Drawing.Size(420, 404);
            this.listBox_ksiazkiGatunek.Sorted = true;
            this.listBox_ksiazkiGatunek.TabIndex = 13;
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
            this.label_close.TabIndex = 14;
            this.label_close.Text = "X";
            this.label_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            // 
            // ListaGatunkowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(442, 571);
            this.Controls.Add(this.label_close);
            this.Controls.Add(this.listBox_ksiazkiGatunek);
            this.Controls.Add(this.label_gatunek);
            this.Controls.Add(this.label_userlogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaGatunkowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaGatunkowForm";
            this.Load += new System.EventHandler(this.ListaGatunkowForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_userlogin;
        private System.Windows.Forms.Label label_gatunek;
        private System.Windows.Forms.ListBox listBox_ksiazkiGatunek;
        private System.Windows.Forms.Label label_close;
    }
}