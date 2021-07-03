
namespace Library
{
    partial class Form_Login
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
            this.Panel_LoginMode = new System.Windows.Forms.Panel();
            this.btn_Geust = new System.Windows.Forms.Button();
            this.btn_Admin = new System.Windows.Forms.Button();
            this.Panel_Login = new System.Windows.Forms.Panel();
            this.btn_Annuler = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.Panel_LoginMode.SuspendLayout();
            this.Panel_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_LoginMode
            // 
            this.Panel_LoginMode.Controls.Add(this.btn_Geust);
            this.Panel_LoginMode.Controls.Add(this.btn_Admin);
            this.Panel_LoginMode.Location = new System.Drawing.Point(12, 12);
            this.Panel_LoginMode.Name = "Panel_LoginMode";
            this.Panel_LoginMode.Size = new System.Drawing.Size(516, 317);
            this.Panel_LoginMode.TabIndex = 2;
            // 
            // btn_Geust
            // 
            this.btn_Geust.Location = new System.Drawing.Point(203, 170);
            this.btn_Geust.Name = "btn_Geust";
            this.btn_Geust.Size = new System.Drawing.Size(110, 48);
            this.btn_Geust.TabIndex = 1;
            this.btn_Geust.Text = "&Invité";
            this.btn_Geust.UseVisualStyleBackColor = true;
            this.btn_Geust.Click += new System.EventHandler(this.btn_Geust_Click);
            // 
            // btn_Admin
            // 
            this.btn_Admin.Location = new System.Drawing.Point(203, 98);
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Size = new System.Drawing.Size(110, 48);
            this.btn_Admin.TabIndex = 0;
            this.btn_Admin.Text = "&Administrateur";
            this.btn_Admin.UseVisualStyleBackColor = true;
            this.btn_Admin.Click += new System.EventHandler(this.btn_Admin_Click);
            // 
            // Panel_Login
            // 
            this.Panel_Login.Controls.Add(this.btn_Annuler);
            this.Panel_Login.Controls.Add(this.btn_login);
            this.Panel_Login.Controls.Add(this.label2);
            this.Panel_Login.Controls.Add(this.label1);
            this.Panel_Login.Controls.Add(this.txt_password);
            this.Panel_Login.Controls.Add(this.txt_username);
            this.Panel_Login.Location = new System.Drawing.Point(12, 12);
            this.Panel_Login.Name = "Panel_Login";
            this.Panel_Login.Size = new System.Drawing.Size(516, 317);
            this.Panel_Login.TabIndex = 3;
            this.Panel_Login.Visible = false;
            // 
            // btn_Annuler
            // 
            this.btn_Annuler.Location = new System.Drawing.Point(318, 205);
            this.btn_Annuler.Name = "btn_Annuler";
            this.btn_Annuler.Size = new System.Drawing.Size(83, 33);
            this.btn_Annuler.TabIndex = 3;
            this.btn_Annuler.Text = "&Annuler";
            this.btn_Annuler.UseVisualStyleBackColor = true;
            this.btn_Annuler.Click += new System.EventHandler(this.btn_Annuler_Click);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(189, 205);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(83, 33);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "&Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mot de Passe :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom Utilisateur :";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(206, 145);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(178, 20);
            this.txt_password.TabIndex = 1;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(206, 79);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(178, 20);
            this.txt_username.TabIndex = 0;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 341);
            this.Controls.Add(this.Panel_Login);
            this.Controls.Add(this.Panel_LoginMode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Login";
            this.Panel_LoginMode.ResumeLayout(false);
            this.Panel_Login.ResumeLayout(false);
            this.Panel_Login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_LoginMode;
        private System.Windows.Forms.Panel Panel_Login;
        private System.Windows.Forms.Button btn_Annuler;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Button btn_Geust;
        private System.Windows.Forms.Button btn_Admin;
    }
}