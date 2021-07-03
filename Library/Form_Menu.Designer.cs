
namespace Library
{
    partial class Form_Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ficherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seConnecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDocsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.domainsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterDomainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterAuteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listerLesAuteursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listerAdministrateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_currentUser = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficherToolStripMenuItem,
            this.documentToolStripMenuItem,
            this.themeToolStripMenuItem,
            this.domainsToolStripMenuItem,
            this.auteurToolStripMenuItem,
            this.administToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1014, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ficherToolStripMenuItem
            // 
            this.ficherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seConnecterToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.ficherToolStripMenuItem.Name = "ficherToolStripMenuItem";
            this.ficherToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.ficherToolStripMenuItem.Text = "Ficher";
            // 
            // seConnecterToolStripMenuItem
            // 
            this.seConnecterToolStripMenuItem.Name = "seConnecterToolStripMenuItem";
            this.seConnecterToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.seConnecterToolStripMenuItem.Text = "Login";
            this.seConnecterToolStripMenuItem.Click += new System.EventHandler(this.seConnecterToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // documentToolStripMenuItem
            // 
            this.documentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterDocumentToolStripMenuItem,
            this.listeDocsToolStripMenuItem});
            this.documentToolStripMenuItem.Name = "documentToolStripMenuItem";
            this.documentToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.documentToolStripMenuItem.Text = "Document";
            // 
            // ajouterDocumentToolStripMenuItem
            // 
            this.ajouterDocumentToolStripMenuItem.Name = "ajouterDocumentToolStripMenuItem";
            this.ajouterDocumentToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.ajouterDocumentToolStripMenuItem.Text = "Ajouter Document";
            this.ajouterDocumentToolStripMenuItem.Click += new System.EventHandler(this.ajouterDocumentToolStripMenuItem_Click);
            // 
            // listeDocsToolStripMenuItem
            // 
            this.listeDocsToolStripMenuItem.Name = "listeDocsToolStripMenuItem";
            this.listeDocsToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.listeDocsToolStripMenuItem.Text = "Lister Documents";
            this.listeDocsToolStripMenuItem.Click += new System.EventHandler(this.listeDocsToolStripMenuItem_Click);
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterThemeToolStripMenuItem});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // ajouterThemeToolStripMenuItem
            // 
            this.ajouterThemeToolStripMenuItem.Name = "ajouterThemeToolStripMenuItem";
            this.ajouterThemeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ajouterThemeToolStripMenuItem.Text = "Ajouter Theme";
            this.ajouterThemeToolStripMenuItem.Click += new System.EventHandler(this.ajouterThemeToolStripMenuItem_Click);
            // 
            // domainsToolStripMenuItem
            // 
            this.domainsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterDomainToolStripMenuItem});
            this.domainsToolStripMenuItem.Name = "domainsToolStripMenuItem";
            this.domainsToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.domainsToolStripMenuItem.Text = "Domaine";
            // 
            // ajouterDomainToolStripMenuItem
            // 
            this.ajouterDomainToolStripMenuItem.Name = "ajouterDomainToolStripMenuItem";
            this.ajouterDomainToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.ajouterDomainToolStripMenuItem.Text = "Ajouter Domaine";
            this.ajouterDomainToolStripMenuItem.Click += new System.EventHandler(this.ajouterDomainToolStripMenuItem_Click);
            // 
            // auteurToolStripMenuItem
            // 
            this.auteurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterAuteurToolStripMenuItem,
            this.listerLesAuteursToolStripMenuItem});
            this.auteurToolStripMenuItem.Name = "auteurToolStripMenuItem";
            this.auteurToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.auteurToolStripMenuItem.Text = "Auteur";
            // 
            // ajouterAuteurToolStripMenuItem
            // 
            this.ajouterAuteurToolStripMenuItem.Name = "ajouterAuteurToolStripMenuItem";
            this.ajouterAuteurToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ajouterAuteurToolStripMenuItem.Text = "Ajouter Auteur";
            this.ajouterAuteurToolStripMenuItem.Click += new System.EventHandler(this.ajouterAuteurToolStripMenuItem_Click);
            // 
            // listerLesAuteursToolStripMenuItem
            // 
            this.listerLesAuteursToolStripMenuItem.Name = "listerLesAuteursToolStripMenuItem";
            this.listerLesAuteursToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.listerLesAuteursToolStripMenuItem.Text = "Lister Auteurs";
            this.listerLesAuteursToolStripMenuItem.Click += new System.EventHandler(this.listerLesAuteursToolStripMenuItem_Click);
            // 
            // administToolStripMenuItem
            // 
            this.administToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.listerAdministrateurToolStripMenuItem});
            this.administToolStripMenuItem.Name = "administToolStripMenuItem";
            this.administToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.administToolStripMenuItem.Text = "Administrateur";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter Administrateur";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // listerAdministrateurToolStripMenuItem
            // 
            this.listerAdministrateurToolStripMenuItem.Name = "listerAdministrateurToolStripMenuItem";
            this.listerAdministrateurToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.listerAdministrateurToolStripMenuItem.Text = "Lister Administrateurs";
            this.listerAdministrateurToolStripMenuItem.Click += new System.EventHandler(this.listerAdministrateurToolStripMenuItem_Click);
            // 
            // lbl_currentUser
            // 
            this.lbl_currentUser.AutoSize = true;
            this.lbl_currentUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lbl_currentUser.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_currentUser.ForeColor = System.Drawing.Color.White;
            this.lbl_currentUser.Location = new System.Drawing.Point(812, 3);
            this.lbl_currentUser.Name = "lbl_currentUser";
            this.lbl_currentUser.Size = new System.Drawing.Size(0, 19);
            this.lbl_currentUser.TabIndex = 3;
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 621);
            this.Controls.Add(this.lbl_currentUser);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Menu_FormClosing);
            this.Load += new System.EventHandler(this.Form_Menu_Load);
            this.Shown += new System.EventHandler(this.Form_Menu_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ficherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem domainsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterDomainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterThemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterDocumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDocsToolStripMenuItem;
        private System.Windows.Forms.Label lbl_currentUser;
        private System.Windows.Forms.ToolStripMenuItem auteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterAuteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listerLesAuteursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seConnecterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listerAdministrateurToolStripMenuItem;
    }
}