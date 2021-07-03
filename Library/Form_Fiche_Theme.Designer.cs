
namespace Library
{
    partial class Form_Fiche_Theme
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
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.cb_domains = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_dom_search = new System.Windows.Forms.Label();
            this.txt_dom_search = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(238, 143);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(94, 56);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "&Annuler";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(117, 143);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(94, 56);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "&Enregistrer";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID :";
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(90, 85);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(215, 20);
            this.txt_nom.TabIndex = 3;
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(90, 59);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(82, 20);
            this.txt_id.TabIndex = 2;
            // 
            // cb_domains
            // 
            this.cb_domains.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_domains.FormattingEnabled = true;
            this.cb_domains.Location = new System.Drawing.Point(90, 32);
            this.cb_domains.Name = "cb_domains";
            this.cb_domains.Size = new System.Drawing.Size(121, 21);
            this.cb_domains.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Domaines :";
            // 
            // lbl_dom_search
            // 
            this.lbl_dom_search.AutoSize = true;
            this.lbl_dom_search.Location = new System.Drawing.Point(225, 35);
            this.lbl_dom_search.Name = "lbl_dom_search";
            this.lbl_dom_search.Size = new System.Drawing.Size(80, 13);
            this.lbl_dom_search.TabIndex = 8;
            this.lbl_dom_search.Text = "Cherche avec :";
            // 
            // txt_dom_search
            // 
            this.txt_dom_search.Location = new System.Drawing.Point(311, 32);
            this.txt_dom_search.Name = "txt_dom_search";
            this.txt_dom_search.Size = new System.Drawing.Size(93, 20);
            this.txt_dom_search.TabIndex = 1;
            this.txt_dom_search.TextChanged += new System.EventHandler(this.txt_dom_search_TextChanged);
            // 
            // Form_Fiche_Theme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 238);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_dom_search);
            this.Controls.Add(this.txt_dom_search);
            this.Controls.Add(this.cb_domains);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.txt_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Fiche_Theme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fiche Theme";
            this.Load += new System.EventHandler(this.Form_Fiche_Theme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.ComboBox cb_domains;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_dom_search;
        private System.Windows.Forms.TextBox txt_dom_search;
    }
}