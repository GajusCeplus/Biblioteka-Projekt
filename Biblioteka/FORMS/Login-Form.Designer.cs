namespace Biblioteka.FORMS
{
    partial class Login_Form
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
            this.pictureBox_user = new System.Windows.Forms.PictureBox();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_passwd = new System.Windows.Forms.TextBox();
            this.pictureBox_passwd = new System.Windows.Forms.PictureBox();
            this.button_login = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_passwd)).BeginInit();
            this.SuspendLayout();
            // 
            // label_userlogin
            // 
            this.label_userlogin.BackColor = System.Drawing.Color.Gray;
            this.label_userlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_userlogin.Location = new System.Drawing.Point(1, 1);
            this.label_userlogin.Name = "label_userlogin";
            this.label_userlogin.Size = new System.Drawing.Size(523, 121);
            this.label_userlogin.TabIndex = 0;
            this.label_userlogin.Text = "User Login";
            this.label_userlogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_close
            // 
            this.label_close.BackColor = System.Drawing.Color.Gray;
            this.label_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_close.ForeColor = System.Drawing.Color.Red;
            this.label_close.Location = new System.Drawing.Point(496, 1);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(28, 19);
            this.label_close.TabIndex = 1;
            this.label_close.Text = "X";
            this.label_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            this.label_close.MouseEnter += new System.EventHandler(this.label_close_MouseEnter);
            this.label_close.MouseLeave += new System.EventHandler(this.label_close_MouseLeave);
            // 
            // pictureBox_user
            // 
            this.pictureBox_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox_user.Location = new System.Drawing.Point(50, 162);
            this.pictureBox_user.Name = "pictureBox_user";
            this.pictureBox_user.Size = new System.Drawing.Size(60, 60);
            this.pictureBox_user.TabIndex = 2;
            this.pictureBox_user.TabStop = false;
            // 
            // textBox_username
            // 
            this.textBox_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_username.Location = new System.Drawing.Point(132, 162);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(321, 62);
            this.textBox_username.TabIndex = 3;
            // 
            // textBox_passwd
            // 
            this.textBox_passwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_passwd.Location = new System.Drawing.Point(132, 251);
            this.textBox_passwd.Name = "textBox_passwd";
            this.textBox_passwd.PasswordChar = '*';
            this.textBox_passwd.Size = new System.Drawing.Size(321, 62);
            this.textBox_passwd.TabIndex = 5;
            this.textBox_passwd.UseSystemPasswordChar = true;
            // 
            // pictureBox_passwd
            // 
            this.pictureBox_passwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox_passwd.Location = new System.Drawing.Point(50, 251);
            this.pictureBox_passwd.Name = "pictureBox_passwd";
            this.pictureBox_passwd.Size = new System.Drawing.Size(60, 60);
            this.pictureBox_passwd.TabIndex = 4;
            this.pictureBox_passwd.TabStop = false;
            // 
            // button_login
            // 
            this.button_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_login.Location = new System.Drawing.Point(135, 344);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(256, 46);
            this.button_login.TabIndex = 6;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(524, 425);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox_passwd);
            this.Controls.Add(this.pictureBox_passwd);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.pictureBox_user);
            this.Controls.Add(this.label_close);
            this.Controls.Add(this.label_userlogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_Form";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_passwd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_userlogin;
        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.PictureBox pictureBox_user;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_passwd;
        private System.Windows.Forms.PictureBox pictureBox_passwd;
        private System.Windows.Forms.Button button_login;
    }
}