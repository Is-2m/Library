
namespace Library
{
    partial class Form_Fiche_Document
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
            this.components = new System.ComponentModel.Container();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_dPub = new System.Windows.Forms.DateTimePicker();
            this.cb_domain = new System.Windows.Forms.ComboBox();
            this.cb_theme = new System.Windows.Forms.ComboBox();
            this.cb_auteur = new System.Windows.Forms.ComboBox();
            this.txt_NbrPages = new System.Windows.Forms.TextBox();
            this.txt_search_author = new System.Windows.Forms.TextBox();
            this.txt_search_Theme = new System.Windows.Forms.TextBox();
            this.txt_search_dom = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.gb_Dom = new System.Windows.Forms.GroupBox();
            this.gb_Thm = new System.Windows.Forms.GroupBox();
            this.gb_aut = new System.Windows.Forms.GroupBox();
            this.gb_type = new System.Windows.Forms.GroupBox();
            this.PB_info = new System.Windows.Forms.PictureBox();
            this.btn_remove_type = new System.Windows.Forms.Button();
            this.btn_add_type = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_type = new System.Windows.Forms.TextBox();
            this.Remove_type_tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.gb_Dom.SuspendLayout();
            this.gb_Thm.SuspendLayout();
            this.gb_aut.SuspendLayout();
            this.gb_type.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_info)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(195, 305);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(314, 20);
            this.txt_title.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID :";
            // 
            // dtp_dPub
            // 
            this.dtp_dPub.Location = new System.Drawing.Point(195, 331);
            this.dtp_dPub.Name = "dtp_dPub";
            this.dtp_dPub.Size = new System.Drawing.Size(200, 20);
            this.dtp_dPub.TabIndex = 6;
            // 
            // cb_domain
            // 
            this.cb_domain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_domain.FormattingEnabled = true;
            this.cb_domain.Location = new System.Drawing.Point(28, 19);
            this.cb_domain.Name = "cb_domain";
            this.cb_domain.Size = new System.Drawing.Size(126, 21);
            this.cb_domain.TabIndex = 0;
            this.cb_domain.SelectedIndexChanged += new System.EventHandler(this.cb_domain_SelectedIndexChanged);
            // 
            // cb_theme
            // 
            this.cb_theme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_theme.FormattingEnabled = true;
            this.cb_theme.Location = new System.Drawing.Point(28, 19);
            this.cb_theme.Name = "cb_theme";
            this.cb_theme.Size = new System.Drawing.Size(126, 21);
            this.cb_theme.TabIndex = 0;
            this.cb_theme.SelectedIndexChanged += new System.EventHandler(this.cb_theme_SelectedIndexChanged);
            // 
            // cb_auteur
            // 
            this.cb_auteur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_auteur.FormattingEnabled = true;
            this.cb_auteur.Location = new System.Drawing.Point(27, 19);
            this.cb_auteur.Name = "cb_auteur";
            this.cb_auteur.Size = new System.Drawing.Size(126, 21);
            this.cb_auteur.TabIndex = 0;
            this.cb_auteur.SelectedIndexChanged += new System.EventHandler(this.cb_auteur_SelectedIndexChanged);
            // 
            // txt_NbrPages
            // 
            this.txt_NbrPages.Location = new System.Drawing.Point(195, 357);
            this.txt_NbrPages.Name = "txt_NbrPages";
            this.txt_NbrPages.Size = new System.Drawing.Size(65, 20);
            this.txt_NbrPages.TabIndex = 7;
            this.txt_NbrPages.Text = "1";
            this.txt_NbrPages.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_search_author
            // 
            this.txt_search_author.Location = new System.Drawing.Point(263, 17);
            this.txt_search_author.Name = "txt_search_author";
            this.txt_search_author.Size = new System.Drawing.Size(156, 20);
            this.txt_search_author.TabIndex = 1;
            this.txt_search_author.TextChanged += new System.EventHandler(this.txt_search_author_TextChanged);
            // 
            // txt_search_Theme
            // 
            this.txt_search_Theme.Location = new System.Drawing.Point(264, 18);
            this.txt_search_Theme.Name = "txt_search_Theme";
            this.txt_search_Theme.Size = new System.Drawing.Size(155, 20);
            this.txt_search_Theme.TabIndex = 1;
            this.txt_search_Theme.TextChanged += new System.EventHandler(this.txt_search_Theme_TextChanged);
            // 
            // txt_search_dom
            // 
            this.txt_search_dom.Location = new System.Drawing.Point(264, 19);
            this.txt_search_dom.Name = "txt_search_dom";
            this.txt_search_dom.Size = new System.Drawing.Size(156, 20);
            this.txt_search_dom.TabIndex = 1;
            this.txt_search_dom.TextChanged += new System.EventHandler(this.txt_search_dom_TextChanged);
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(117, 21);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(46, 20);
            this.txt_id.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Titre :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Date Publication :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Pages :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(169, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Cherche avec :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(169, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Cherche avec :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(168, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Cherche avec :";
            // 
            // cb_type
            // 
            this.cb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Location = new System.Drawing.Point(27, 19);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(126, 21);
            this.cb_type.TabIndex = 0;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(317, 402);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(94, 56);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "&Annuler";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(196, 402);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(94, 56);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "&Enregistrer";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // gb_Dom
            // 
            this.gb_Dom.Controls.Add(this.label8);
            this.gb_Dom.Controls.Add(this.txt_search_dom);
            this.gb_Dom.Controls.Add(this.cb_domain);
            this.gb_Dom.Location = new System.Drawing.Point(90, 47);
            this.gb_Dom.Name = "gb_Dom";
            this.gb_Dom.Size = new System.Drawing.Size(460, 50);
            this.gb_Dom.TabIndex = 1;
            this.gb_Dom.TabStop = false;
            this.gb_Dom.Text = "Domaine";
            // 
            // gb_Thm
            // 
            this.gb_Thm.Controls.Add(this.label9);
            this.gb_Thm.Controls.Add(this.txt_search_Theme);
            this.gb_Thm.Controls.Add(this.cb_theme);
            this.gb_Thm.Location = new System.Drawing.Point(90, 103);
            this.gb_Thm.Name = "gb_Thm";
            this.gb_Thm.Size = new System.Drawing.Size(460, 50);
            this.gb_Thm.TabIndex = 2;
            this.gb_Thm.TabStop = false;
            this.gb_Thm.Text = "Theme";
            // 
            // gb_aut
            // 
            this.gb_aut.Controls.Add(this.label10);
            this.gb_aut.Controls.Add(this.txt_search_author);
            this.gb_aut.Controls.Add(this.cb_auteur);
            this.gb_aut.Location = new System.Drawing.Point(90, 155);
            this.gb_aut.Name = "gb_aut";
            this.gb_aut.Size = new System.Drawing.Size(460, 50);
            this.gb_aut.TabIndex = 3;
            this.gb_aut.TabStop = false;
            this.gb_aut.Text = "Auteur";
            // 
            // gb_type
            // 
            this.gb_type.Controls.Add(this.PB_info);
            this.gb_type.Controls.Add(this.btn_remove_type);
            this.gb_type.Controls.Add(this.btn_add_type);
            this.gb_type.Controls.Add(this.label2);
            this.gb_type.Controls.Add(this.txt_type);
            this.gb_type.Controls.Add(this.cb_type);
            this.gb_type.Location = new System.Drawing.Point(90, 210);
            this.gb_type.Name = "gb_type";
            this.gb_type.Size = new System.Drawing.Size(460, 89);
            this.gb_type.TabIndex = 4;
            this.gb_type.TabStop = false;
            this.gb_type.Text = "Type Document";
            // 
            // PB_info
            // 
            this.PB_info.Image = global::Library.Properties.Resources.information_icon_preview_33ec;
            this.PB_info.Location = new System.Drawing.Point(401, 56);
            this.PB_info.Name = "PB_info";
            this.PB_info.Size = new System.Drawing.Size(18, 23);
            this.PB_info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_info.TabIndex = 12;
            this.PB_info.TabStop = false;
            this.Remove_type_tooltip.SetToolTip(this.PB_info, "cela supprimera le type sélectionné dans la liste déroulante");
            // 
            // btn_remove_type
            // 
            this.btn_remove_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove_type.Location = new System.Drawing.Point(354, 56);
            this.btn_remove_type.Name = "btn_remove_type";
            this.btn_remove_type.Size = new System.Drawing.Size(41, 23);
            this.btn_remove_type.TabIndex = 3;
            this.btn_remove_type.Text = "-";
            this.btn_remove_type.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_remove_type.UseVisualStyleBackColor = true;
            this.btn_remove_type.Click += new System.EventHandler(this.btn_remove_type_Click);
            // 
            // btn_add_type
            // 
            this.btn_add_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_type.Location = new System.Drawing.Point(264, 56);
            this.btn_add_type.Name = "btn_add_type";
            this.btn_add_type.Size = new System.Drawing.Size(41, 23);
            this.btn_add_type.TabIndex = 2;
            this.btn_add_type.Text = "+";
            this.btn_add_type.UseVisualStyleBackColor = true;
            this.btn_add_type.Click += new System.EventHandler(this.btn_add_type_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ajouter/Supprimer :";
            // 
            // txt_type
            // 
            this.txt_type.Location = new System.Drawing.Point(263, 20);
            this.txt_type.Name = "txt_type";
            this.txt_type.Size = new System.Drawing.Size(156, 20);
            this.txt_type.TabIndex = 1;
            // 
            // Form_Fiche_Document
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 487);
            this.ControlBox = false;
            this.Controls.Add(this.gb_type);
            this.Controls.Add(this.gb_aut);
            this.Controls.Add(this.gb_Thm);
            this.Controls.Add(this.gb_Dom);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.dtp_dPub);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_NbrPages);
            this.Controls.Add(this.txt_title);
            this.Name = "Form_Fiche_Document";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fiche Document";
            this.Load += new System.EventHandler(this.Form_Fiche_Document_Load);
            this.gb_Dom.ResumeLayout(false);
            this.gb_Dom.PerformLayout();
            this.gb_Thm.ResumeLayout(false);
            this.gb_Thm.PerformLayout();
            this.gb_aut.ResumeLayout(false);
            this.gb_aut.PerformLayout();
            this.gb_type.ResumeLayout(false);
            this.gb_type.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_dPub;
        private System.Windows.Forms.ComboBox cb_domain;
        private System.Windows.Forms.ComboBox cb_theme;
        private System.Windows.Forms.ComboBox cb_auteur;
        private System.Windows.Forms.TextBox txt_NbrPages;
        private System.Windows.Forms.TextBox txt_search_author;
        private System.Windows.Forms.TextBox txt_search_Theme;
        private System.Windows.Forms.TextBox txt_search_dom;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.GroupBox gb_Dom;
        private System.Windows.Forms.GroupBox gb_Thm;
        private System.Windows.Forms.GroupBox gb_aut;
        private System.Windows.Forms.GroupBox gb_type;
        private System.Windows.Forms.Button btn_remove_type;
        private System.Windows.Forms.Button btn_add_type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_type;
        private System.Windows.Forms.PictureBox PB_info;
        private System.Windows.Forms.ToolTip Remove_type_tooltip;
    }
}