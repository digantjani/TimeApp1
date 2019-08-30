namespace Time_App1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.cancel = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            this.txt_login_password = new System.Windows.Forms.TextBox();
            this.txt_login_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.Label();
            this.btn__login_exit = new System.Windows.Forms.Button();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.Turquoise;
            this.cancel.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.cancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGoldenrod;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Location = new System.Drawing.Point(329, 155);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(90, 30);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Ok
            // 
            this.Ok.BackColor = System.Drawing.Color.Turquoise;
            this.Ok.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.Ok.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Ok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Ok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGoldenrod;
            this.Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ok.Location = new System.Drawing.Point(224, 155);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(90, 30);
            this.Ok.TabIndex = 3;
            this.Ok.Text = "OK";
            this.Ok.UseVisualStyleBackColor = false;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // txt_login_password
            // 
            this.txt_login_password.Location = new System.Drawing.Point(224, 119);
            this.txt_login_password.Name = "txt_login_password";
            this.txt_login_password.PasswordChar = '*';
            this.txt_login_password.Size = new System.Drawing.Size(195, 20);
            this.txt_login_password.TabIndex = 2;
            // 
            // txt_login_username
            // 
            this.txt_login_username.Location = new System.Drawing.Point(224, 57);
            this.txt_login_username.Name = "txt_login_username";
            this.txt_login_username.Size = new System.Drawing.Size(195, 20);
            this.txt_login_username.TabIndex = 1;
            // 
            // txt_password
            // 
            this.txt_password.AutoSize = true;
            this.txt_password.Location = new System.Drawing.Point(221, 103);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(59, 13);
            this.txt_password.TabIndex = 9;
            this.txt_password.Text = "Password :";
            // 
            // txt_username
            // 
            this.txt_username.AutoSize = true;
            this.txt_username.Location = new System.Drawing.Point(221, 41);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(61, 13);
            this.txt_username.TabIndex = 8;
            this.txt_username.Text = "Username :";
            // 
            // btn__login_exit
            // 
            this.btn__login_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn__login_exit.BackgroundImage = global::Time_App1.Properties.Resources.close_iconm;
            this.btn__login_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn__login_exit.FlatAppearance.BorderSize = 0;
            this.btn__login_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn__login_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn__login_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn__login_exit.Location = new System.Drawing.Point(408, 2);
            this.btn__login_exit.Margin = new System.Windows.Forms.Padding(0);
            this.btn__login_exit.Name = "btn__login_exit";
            this.btn__login_exit.Size = new System.Drawing.Size(20, 20);
            this.btn__login_exit.TabIndex = 6;
            this.btn__login_exit.UseVisualStyleBackColor = false;
            this.btn__login_exit.Click += new System.EventHandler(this.btn__login_exit_Click);
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.BackgroundImage = global::Time_App1.Properties.Resources.minimize_icon;
            this.btn_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Location = new System.Drawing.Point(385, 2);
            this.btn_minimize.Margin = new System.Windows.Forms.Padding(2);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(20, 20);
            this.btn_minimize.TabIndex = 5;
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Time_App1.Properties.Resources.pets;
            this.pictureBox1.Location = new System.Drawing.Point(22, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Login Page";
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 202);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.btn__login_exit);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.txt_login_password);
            this.Controls.Add(this.txt_login_username);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.TextBox txt_login_password;
        private System.Windows.Forms.TextBox txt_login_username;
        private System.Windows.Forms.Label txt_password;
        private System.Windows.Forms.Label txt_username;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Button btn_minimize;
        internal System.Windows.Forms.Button btn__login_exit;
        private System.Windows.Forms.Label label1;
    }
}