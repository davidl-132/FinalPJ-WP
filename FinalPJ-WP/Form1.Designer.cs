namespace FinalPJ_WP
{
    partial class Form1
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
            this.leftPanel = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.passwordBg1 = new System.Windows.Forms.Panel();
            this.passwordBg2 = new System.Windows.Forms.Panel();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameBg1 = new System.Windows.Forms.Panel();
            this.usernameBg2 = new System.Windows.Forms.Panel();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.exitLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.panelRight.SuspendLayout();
            this.passwordBg1.SuspendLayout();
            this.passwordBg2.SuspendLayout();
            this.usernameBg1.SuspendLayout();
            this.usernameBg2.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackgroundImage = global::FinalPJ_WP.Properties.Resources.loginPanel;
            this.leftPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(6);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(800, 865);
            this.leftPanel.TabIndex = 0;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelRight.Controls.Add(this.passwordBg1);
            this.panelRight.Controls.Add(this.loginButton);
            this.panelRight.Controls.Add(this.passwordLabel);
            this.panelRight.Controls.Add(this.usernameBg1);
            this.panelRight.Controls.Add(this.usernameLabel);
            this.panelRight.Controls.Add(this.exitLabel);
            this.panelRight.Controls.Add(this.titleLabel);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(800, 0);
            this.panelRight.Margin = new System.Windows.Forms.Padding(6);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(900, 865);
            this.panelRight.TabIndex = 1;
            // 
            // passwordBg1
            // 
            this.passwordBg1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.passwordBg1.Controls.Add(this.passwordBg2);
            this.passwordBg1.Location = new System.Drawing.Point(173, 471);
            this.passwordBg1.Margin = new System.Windows.Forms.Padding(6);
            this.passwordBg1.Name = "passwordBg1";
            this.passwordBg1.Size = new System.Drawing.Size(600, 69);
            this.passwordBg1.TabIndex = 19;
            // 
            // passwordBg2
            // 
            this.passwordBg2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.passwordBg2.Controls.Add(this.passwordTextBox);
            this.passwordBg2.Location = new System.Drawing.Point(2, 2);
            this.passwordBg2.Margin = new System.Windows.Forms.Padding(6);
            this.passwordBg2.Name = "passwordBg2";
            this.passwordBg2.Size = new System.Drawing.Size(596, 65);
            this.passwordBg2.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.White;
            this.passwordTextBox.Location = new System.Drawing.Point(20, 12);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(550, 43);
            this.passwordTextBox.TabIndex = 0;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(173, 625);
            this.loginButton.Margin = new System.Windows.Forms.Padding(6);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(600, 87);
            this.loginButton.TabIndex = 21;
            this.loginButton.Text = "ĐĂNG NHẬP";
            this.loginButton.UseVisualStyleBackColor = false;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.LightGray;
            this.passwordLabel.Location = new System.Drawing.Point(173, 423);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(123, 36);
            this.passwordLabel.TabIndex = 20;
            this.passwordLabel.Text = "Mật khẩu";
            // 
            // usernameBg1
            // 
            this.usernameBg1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.usernameBg1.Controls.Add(this.usernameBg2);
            this.usernameBg1.Location = new System.Drawing.Point(173, 308);
            this.usernameBg1.Margin = new System.Windows.Forms.Padding(6);
            this.usernameBg1.Name = "usernameBg1";
            this.usernameBg1.Size = new System.Drawing.Size(600, 69);
            this.usernameBg1.TabIndex = 18;
            // 
            // usernameBg2
            // 
            this.usernameBg2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.usernameBg2.Controls.Add(this.usernameTextBox);
            this.usernameBg2.Location = new System.Drawing.Point(2, 2);
            this.usernameBg2.Margin = new System.Windows.Forms.Padding(6);
            this.usernameBg2.Name = "usernameBg2";
            this.usernameBg2.Size = new System.Drawing.Size(596, 65);
            this.usernameBg2.TabIndex = 0;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.ForeColor = System.Drawing.Color.White;
            this.usernameTextBox.Location = new System.Drawing.Point(20, 12);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(550, 43);
            this.usernameTextBox.TabIndex = 0;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.LightGray;
            this.usernameLabel.Location = new System.Drawing.Point(173, 259);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(123, 36);
            this.usernameLabel.TabIndex = 17;
            this.usernameLabel.Text = "Tài khoản";
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.ForeColor = System.Drawing.Color.Gray;
            this.exitLabel.Location = new System.Drawing.Point(853, 0);
            this.exitLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(47, 51);
            this.exitLabel.TabIndex = 16;
            this.exitLabel.Text = "X";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(293, 106);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(359, 72);
            this.titleLabel.TabIndex = 15;
            this.titleLabel.Text = "ĐĂNG NHẬP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1700, 865);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.passwordBg1.ResumeLayout(false);
            this.passwordBg2.ResumeLayout(false);
            this.passwordBg2.PerformLayout();
            this.usernameBg1.ResumeLayout(false);
            this.usernameBg2.ResumeLayout(false);
            this.usernameBg2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel passwordBg1;
        private System.Windows.Forms.Panel passwordBg2;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Panel usernameBg1;
        private System.Windows.Forms.Panel usernameBg2;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Label titleLabel;
    }
}

