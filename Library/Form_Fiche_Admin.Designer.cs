
namespace Library
{
    partial class Form_Fiche_Admin
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_confirmPass = new System.Windows.Forms.TextBox();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_enregistrer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_AdminNom = new System.Windows.Forms.TextBox();
            this.txt_AdminUsername = new System.Windows.Forms.TextBox();
            this.txt_AdminNewPass = new System.Windows.Forms.TextBox();
            this.txt_AdminOldPass = new System.Windows.Forms.TextBox();
            this.txt_AdminPrenom = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_AdminConfNewPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Add_Pan = new System.Windows.Forms.Panel();
            this.Edit_Pan = new System.Windows.Forms.Panel();
            this.Add_Pan.SuspendLayout();
            this.Edit_Pan.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Confirmer le Mot de Passe :";
            // 
            // txt_confirmPass
            // 
            this.txt_confirmPass.Location = new System.Drawing.Point(220, 143);
            this.txt_confirmPass.Name = "txt_confirmPass";
            this.txt_confirmPass.Size = new System.Drawing.Size(222, 20);
            this.txt_confirmPass.TabIndex = 4;
            this.txt_confirmPass.TextChanged += new System.EventHandler(this.txt_confirmPass_TextChanged);
            // 
            // btn_annuler
            // 
            this.btn_annuler.Location = new System.Drawing.Point(321, 247);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(112, 41);
            this.btn_annuler.TabIndex = 1;
            this.btn_annuler.Text = "&Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // btn_enregistrer
            // 
            this.btn_enregistrer.Location = new System.Drawing.Point(128, 247);
            this.btn_enregistrer.Name = "btn_enregistrer";
            this.btn_enregistrer.Size = new System.Drawing.Size(112, 41);
            this.btn_enregistrer.TabIndex = 0;
            this.btn_enregistrer.Text = "&Enregistrer";
            this.btn_enregistrer.UseVisualStyleBackColor = true;
            this.btn_enregistrer.Click += new System.EventHandler(this.btn_enregistrer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Mot de Passe :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nom Utilisateur:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prenom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nom :";
            // 
            // txt_prenom
            // 
            this.txt_prenom.Location = new System.Drawing.Point(220, 65);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(222, 20);
            this.txt_prenom.TabIndex = 1;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(220, 117);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(222, 20);
            this.txt_password.TabIndex = 3;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(220, 91);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(222, 20);
            this.txt_username.TabIndex = 2;
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(220, 39);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(222, 20);
            this.txt_nom.TabIndex = 0;
            // 
            // txt_AdminNom
            // 
            this.txt_AdminNom.Location = new System.Drawing.Point(220, 33);
            this.txt_AdminNom.Name = "txt_AdminNom";
            this.txt_AdminNom.Size = new System.Drawing.Size(222, 20);
            this.txt_AdminNom.TabIndex = 0;
            // 
            // txt_AdminUsername
            // 
            this.txt_AdminUsername.Location = new System.Drawing.Point(220, 85);
            this.txt_AdminUsername.Name = "txt_AdminUsername";
            this.txt_AdminUsername.Size = new System.Drawing.Size(222, 20);
            this.txt_AdminUsername.TabIndex = 2;
            // 
            // txt_AdminNewPass
            // 
            this.txt_AdminNewPass.Location = new System.Drawing.Point(220, 137);
            this.txt_AdminNewPass.Name = "txt_AdminNewPass";
            this.txt_AdminNewPass.Size = new System.Drawing.Size(222, 20);
            this.txt_AdminNewPass.TabIndex = 4;
            this.txt_AdminNewPass.TextChanged += new System.EventHandler(this.txt_AdminNewPass_TextChanged);
            // 
            // txt_AdminOldPass
            // 
            this.txt_AdminOldPass.Location = new System.Drawing.Point(220, 111);
            this.txt_AdminOldPass.Name = "txt_AdminOldPass";
            this.txt_AdminOldPass.Size = new System.Drawing.Size(222, 20);
            this.txt_AdminOldPass.TabIndex = 3;
            this.txt_AdminOldPass.TextChanged += new System.EventHandler(this.txt_AdminOldPass_TextChanged);
            // 
            // txt_AdminPrenom
            // 
            this.txt_AdminPrenom.Location = new System.Drawing.Point(220, 59);
            this.txt_AdminPrenom.Name = "txt_AdminPrenom";
            this.txt_AdminPrenom.Size = new System.Drawing.Size(222, 20);
            this.txt_AdminPrenom.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(170, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Nom :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(156, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Prenom :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(124, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Nom Utilisateur:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nouveau Mot de Passe :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(94, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Mot de Passe Actuel :";
            // 
            // txt_AdminConfNewPass
            // 
            this.txt_AdminConfNewPass.Location = new System.Drawing.Point(220, 163);
            this.txt_AdminConfNewPass.Name = "txt_AdminConfNewPass";
            this.txt_AdminConfNewPass.Size = new System.Drawing.Size(222, 20);
            this.txt_AdminConfNewPass.TabIndex = 5;
            this.txt_AdminConfNewPass.TextChanged += new System.EventHandler(this.txt_AdminConfNewPass_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Confirmer Nouveau Mot de Passe :";
            // 
            // Add_Pan
            // 
            this.Add_Pan.Controls.Add(this.txt_password);
            this.Add_Pan.Controls.Add(this.txt_nom);
            this.Add_Pan.Controls.Add(this.label1);
            this.Add_Pan.Controls.Add(this.label5);
            this.Add_Pan.Controls.Add(this.label3);
            this.Add_Pan.Controls.Add(this.txt_confirmPass);
            this.Add_Pan.Controls.Add(this.label6);
            this.Add_Pan.Controls.Add(this.txt_username);
            this.Add_Pan.Controls.Add(this.label2);
            this.Add_Pan.Controls.Add(this.txt_prenom);
            this.Add_Pan.Location = new System.Drawing.Point(12, 12);
            this.Add_Pan.Name = "Add_Pan";
            this.Add_Pan.Size = new System.Drawing.Size(537, 212);
            this.Add_Pan.TabIndex = 13;
            // 
            // Edit_Pan
            // 
            this.Edit_Pan.Controls.Add(this.label4);
            this.Edit_Pan.Controls.Add(this.txt_AdminUsername);
            this.Edit_Pan.Controls.Add(this.txt_AdminOldPass);
            this.Edit_Pan.Controls.Add(this.txt_AdminConfNewPass);
            this.Edit_Pan.Controls.Add(this.txt_AdminNewPass);
            this.Edit_Pan.Controls.Add(this.label11);
            this.Edit_Pan.Controls.Add(this.txt_AdminPrenom);
            this.Edit_Pan.Controls.Add(this.label10);
            this.Edit_Pan.Controls.Add(this.label7);
            this.Edit_Pan.Controls.Add(this.txt_AdminNom);
            this.Edit_Pan.Controls.Add(this.label9);
            this.Edit_Pan.Controls.Add(this.label8);
            this.Edit_Pan.Enabled = false;
            this.Edit_Pan.Location = new System.Drawing.Point(12, 12);
            this.Edit_Pan.Name = "Edit_Pan";
            this.Edit_Pan.Size = new System.Drawing.Size(537, 212);
            this.Edit_Pan.TabIndex = 0;
            // 
            // Form_Fiche_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 307);
            this.ControlBox = false;
            this.Controls.Add(this.Edit_Pan);
            this.Controls.Add(this.Add_Pan);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_enregistrer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Fiche_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fiche Admin";
            this.Load += new System.EventHandler(this.Form_Fiche_Admin_Load);
            this.Add_Pan.ResumeLayout(false);
            this.Add_Pan.PerformLayout();
            this.Edit_Pan.ResumeLayout(false);
            this.Edit_Pan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_enregistrer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_confirmPass;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.TextBox txt_AdminNom;
        private System.Windows.Forms.TextBox txt_AdminUsername;
        private System.Windows.Forms.TextBox txt_AdminNewPass;
        private System.Windows.Forms.TextBox txt_AdminOldPass;
        private System.Windows.Forms.TextBox txt_AdminPrenom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_AdminConfNewPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel Add_Pan;
        private System.Windows.Forms.Panel Edit_Pan;
    }
}