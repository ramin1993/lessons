﻿namespace WindowsFormsPart2
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.hidePasswordIcon = new System.Windows.Forms.PictureBox();
            this.showPasswordIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidePasswordIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPasswordIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(277, 93);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(132, 35);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "Daxil ol";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.LoginMethod);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(173, 39);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(98, 20);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "İstifadəçi adı";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(277, 41);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(132, 20);
            //this.usernameTextBox.TabIndex = 1;
            //this.usernameTextBox.Enter += new System.EventHandler(this.TextboxEnterColor);
            //this.usernameTextBox.Leave += new System.EventHandler(this.TextboxLeaveColor);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şifrə";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(277, 67);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(132, 20);
            this.passwordTextBox.TabIndex = 2;
            //this.passwordTextBox.Enter += new System.EventHandler(this.TextboxEnterColor);
            //this.passwordTextBox.Leave += new System.EventHandler(this.TextboxLeaveColor);
            //// 
            // hidePasswordIcon
            // 
            this.hidePasswordIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hidePasswordIcon.Image = ((System.Drawing.Image)(resources.GetObject("hidePasswordIcon.Image")));
            this.hidePasswordIcon.Location = new System.Drawing.Point(375, 69);
            this.hidePasswordIcon.Name = "hidePasswordIcon";
            this.hidePasswordIcon.Size = new System.Drawing.Size(31, 16);
            this.hidePasswordIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hidePasswordIcon.TabIndex = 4;
            this.hidePasswordIcon.TabStop = false;
            this.hidePasswordIcon.Click += new System.EventHandler(this.hidePassword);
            // 
            // showPasswordIcon
            // 
            this.showPasswordIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPasswordIcon.Image = ((System.Drawing.Image)(resources.GetObject("showPasswordIcon.Image")));
            this.showPasswordIcon.Location = new System.Drawing.Point(375, 69);
            this.showPasswordIcon.Name = "showPasswordIcon";
            this.showPasswordIcon.Size = new System.Drawing.Size(31, 16);
            this.showPasswordIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.showPasswordIcon.TabIndex = 5;
            this.showPasswordIcon.TabStop = false;
            this.showPasswordIcon.Visible = false;
            this.showPasswordIcon.Click += new System.EventHandler(this.showPassword);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 197);
            this.Controls.Add(this.showPasswordIcon);
            this.Controls.Add(this.hidePasswordIcon);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loginBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidePasswordIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPasswordIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.PictureBox hidePasswordIcon;
        private System.Windows.Forms.PictureBox showPasswordIcon;
    }
}