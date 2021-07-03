
namespace Library
{
    partial class Form_Table_Doc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_dom_search = new System.Windows.Forms.TextBox();
            this.cb_domain = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpB_domain = new System.Windows.Forms.GroupBox();
            this.Dom_ControlPanel = new System.Windows.Forms.Panel();
            this.btn_edit_dom = new System.Windows.Forms.Button();
            this.btn_remove_dom = new System.Windows.Forms.Button();
            this.btn_add_dom = new System.Windows.Forms.Button();
            this.txt_Dom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gb_theme = new System.Windows.Forms.GroupBox();
            this.Thm_ControlPanel = new System.Windows.Forms.Panel();
            this.btn_edit_theme = new System.Windows.Forms.Button();
            this.btn_remove_theme = new System.Windows.Forms.Button();
            this.btn_add_theme = new System.Windows.Forms.Button();
            this.txt_Theme = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_theme = new System.Windows.Forms.ComboBox();
            this.txt_theme_search = new System.Windows.Forms.TextBox();
            this.dgv_docs = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_Doc = new System.Windows.Forms.GroupBox();
            this.Doc_ControlPanel = new System.Windows.Forms.Panel();
            this.btn_doc_edit = new System.Windows.Forms.Button();
            this.btn_doc_remove = new System.Windows.Forms.Button();
            this.btn_doc_add = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_doc_search_with = new System.Windows.Forms.TextBox();
            this.txt_doc_count = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpB_domain.SuspendLayout();
            this.Dom_ControlPanel.SuspendLayout();
            this.gb_theme.SuspendLayout();
            this.Thm_ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_docs)).BeginInit();
            this.gb_Doc.SuspendLayout();
            this.Doc_ControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_dom_search
            // 
            this.txt_dom_search.Location = new System.Drawing.Point(91, 21);
            this.txt_dom_search.Name = "txt_dom_search";
            this.txt_dom_search.Size = new System.Drawing.Size(130, 20);
            this.txt_dom_search.TabIndex = 0;
            this.txt_dom_search.TextChanged += new System.EventHandler(this.txt_dom_search_TextChanged);
            // 
            // cb_domain
            // 
            this.cb_domain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_domain.FormattingEnabled = true;
            this.cb_domain.Location = new System.Drawing.Point(256, 20);
            this.cb_domain.Name = "cb_domain";
            this.cb_domain.Size = new System.Drawing.Size(151, 21);
            this.cb_domain.TabIndex = 1;
            this.cb_domain.SelectedIndexChanged += new System.EventHandler(this.cb_domain_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cherche avec :";
            // 
            // grpB_domain
            // 
            this.grpB_domain.Controls.Add(this.Dom_ControlPanel);
            this.grpB_domain.Controls.Add(this.txt_Dom);
            this.grpB_domain.Controls.Add(this.label3);
            this.grpB_domain.Controls.Add(this.label1);
            this.grpB_domain.Controls.Add(this.cb_domain);
            this.grpB_domain.Controls.Add(this.txt_dom_search);
            this.grpB_domain.Location = new System.Drawing.Point(12, 25);
            this.grpB_domain.Name = "grpB_domain";
            this.grpB_domain.Size = new System.Drawing.Size(452, 100);
            this.grpB_domain.TabIndex = 0;
            this.grpB_domain.TabStop = false;
            this.grpB_domain.Text = "Domaines";
            // 
            // Dom_ControlPanel
            // 
            this.Dom_ControlPanel.Controls.Add(this.btn_edit_dom);
            this.Dom_ControlPanel.Controls.Add(this.btn_remove_dom);
            this.Dom_ControlPanel.Controls.Add(this.btn_add_dom);
            this.Dom_ControlPanel.Location = new System.Drawing.Point(4, 52);
            this.Dom_ControlPanel.Name = "Dom_ControlPanel";
            this.Dom_ControlPanel.Size = new System.Drawing.Size(273, 47);
            this.Dom_ControlPanel.TabIndex = 6;
            // 
            // btn_edit_dom
            // 
            this.btn_edit_dom.Location = new System.Drawing.Point(197, 5);
            this.btn_edit_dom.Name = "btn_edit_dom";
            this.btn_edit_dom.Size = new System.Drawing.Size(67, 27);
            this.btn_edit_dom.TabIndex = 4;
            this.btn_edit_dom.Text = "&Modifier";
            this.btn_edit_dom.UseVisualStyleBackColor = true;
            this.btn_edit_dom.Click += new System.EventHandler(this.btn_edit_dom_Click);
            // 
            // btn_remove_dom
            // 
            this.btn_remove_dom.Location = new System.Drawing.Point(101, 5);
            this.btn_remove_dom.Name = "btn_remove_dom";
            this.btn_remove_dom.Size = new System.Drawing.Size(67, 27);
            this.btn_remove_dom.TabIndex = 3;
            this.btn_remove_dom.Text = "&Supprimer";
            this.btn_remove_dom.UseVisualStyleBackColor = true;
            this.btn_remove_dom.Click += new System.EventHandler(this.btn_remove_dom_Click);
            // 
            // btn_add_dom
            // 
            this.btn_add_dom.Location = new System.Drawing.Point(5, 5);
            this.btn_add_dom.Name = "btn_add_dom";
            this.btn_add_dom.Size = new System.Drawing.Size(67, 27);
            this.btn_add_dom.TabIndex = 2;
            this.btn_add_dom.Text = "&Ajouter";
            this.btn_add_dom.UseVisualStyleBackColor = true;
            this.btn_add_dom.Click += new System.EventHandler(this.btn_add_dom_Click);
            // 
            // txt_Dom
            // 
            this.txt_Dom.Location = new System.Drawing.Point(331, 61);
            this.txt_Dom.Name = "txt_Dom";
            this.txt_Dom.ReadOnly = true;
            this.txt_Dom.Size = new System.Drawing.Size(76, 20);
            this.txt_Dom.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Count :";
            // 
            // gb_theme
            // 
            this.gb_theme.Controls.Add(this.Thm_ControlPanel);
            this.gb_theme.Controls.Add(this.txt_Theme);
            this.gb_theme.Controls.Add(this.label4);
            this.gb_theme.Controls.Add(this.label2);
            this.gb_theme.Controls.Add(this.cb_theme);
            this.gb_theme.Controls.Add(this.txt_theme_search);
            this.gb_theme.Location = new System.Drawing.Point(547, 25);
            this.gb_theme.Name = "gb_theme";
            this.gb_theme.Size = new System.Drawing.Size(452, 100);
            this.gb_theme.TabIndex = 1;
            this.gb_theme.TabStop = false;
            this.gb_theme.Text = "Themes";
            // 
            // Thm_ControlPanel
            // 
            this.Thm_ControlPanel.Controls.Add(this.btn_edit_theme);
            this.Thm_ControlPanel.Controls.Add(this.btn_remove_theme);
            this.Thm_ControlPanel.Controls.Add(this.btn_add_theme);
            this.Thm_ControlPanel.Location = new System.Drawing.Point(6, 50);
            this.Thm_ControlPanel.Name = "Thm_ControlPanel";
            this.Thm_ControlPanel.Size = new System.Drawing.Size(272, 48);
            this.Thm_ControlPanel.TabIndex = 6;
            // 
            // btn_edit_theme
            // 
            this.btn_edit_theme.Location = new System.Drawing.Point(195, 7);
            this.btn_edit_theme.Name = "btn_edit_theme";
            this.btn_edit_theme.Size = new System.Drawing.Size(67, 27);
            this.btn_edit_theme.TabIndex = 4;
            this.btn_edit_theme.Text = "&Modifier";
            this.btn_edit_theme.UseVisualStyleBackColor = true;
            this.btn_edit_theme.Click += new System.EventHandler(this.btn_edit_theme_Click);
            // 
            // btn_remove_theme
            // 
            this.btn_remove_theme.Location = new System.Drawing.Point(99, 7);
            this.btn_remove_theme.Name = "btn_remove_theme";
            this.btn_remove_theme.Size = new System.Drawing.Size(67, 27);
            this.btn_remove_theme.TabIndex = 3;
            this.btn_remove_theme.Text = "&Supprimer";
            this.btn_remove_theme.UseVisualStyleBackColor = true;
            this.btn_remove_theme.Click += new System.EventHandler(this.btn_remove_theme_Click);
            // 
            // btn_add_theme
            // 
            this.btn_add_theme.Location = new System.Drawing.Point(3, 7);
            this.btn_add_theme.Name = "btn_add_theme";
            this.btn_add_theme.Size = new System.Drawing.Size(67, 27);
            this.btn_add_theme.TabIndex = 2;
            this.btn_add_theme.Text = "&Ajouter";
            this.btn_add_theme.UseVisualStyleBackColor = true;
            this.btn_add_theme.Click += new System.EventHandler(this.btn_add_theme_Click);
            // 
            // txt_Theme
            // 
            this.txt_Theme.Location = new System.Drawing.Point(331, 61);
            this.txt_Theme.Name = "txt_Theme";
            this.txt_Theme.ReadOnly = true;
            this.txt_Theme.Size = new System.Drawing.Size(76, 20);
            this.txt_Theme.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Count :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cherche avec :";
            // 
            // cb_theme
            // 
            this.cb_theme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_theme.FormattingEnabled = true;
            this.cb_theme.Location = new System.Drawing.Point(256, 20);
            this.cb_theme.Name = "cb_theme";
            this.cb_theme.Size = new System.Drawing.Size(151, 21);
            this.cb_theme.TabIndex = 1;
            this.cb_theme.SelectedIndexChanged += new System.EventHandler(this.cb_theme_SelectedIndexChanged);
            // 
            // txt_theme_search
            // 
            this.txt_theme_search.Location = new System.Drawing.Point(91, 21);
            this.txt_theme_search.Name = "txt_theme_search";
            this.txt_theme_search.Size = new System.Drawing.Size(130, 20);
            this.txt_theme_search.TabIndex = 0;
            this.txt_theme_search.TextChanged += new System.EventHandler(this.txt_theme_search_TextChanged);
            // 
            // dgv_docs
            // 
            this.dgv_docs.AllowUserToAddRows = false;
            this.dgv_docs.AllowUserToDeleteRows = false;
            this.dgv_docs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_docs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Title,
            this.Author,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgv_docs.Location = new System.Drawing.Point(9, 77);
            this.dgv_docs.MultiSelect = false;
            this.dgv_docs.Name = "dgv_docs";
            this.dgv_docs.ReadOnly = true;
            this.dgv_docs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_docs.Size = new System.Drawing.Size(972, 355);
            this.dgv_docs.TabIndex = 2;
            // 
            // ID
            // 
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.ID.DefaultCellStyle = dataGridViewCellStyle1;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // Title
            // 
            this.Title.HeaderText = "Titre";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 300;
            // 
            // Author
            // 
            this.Author.HeaderText = "Auteur";
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            this.Author.Width = 200;
            // 
            // Column4
            // 
            dataGridViewCellStyle2.Format = "D";
            dataGridViewCellStyle2.NullValue = null;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column4.HeaderText = "Date Publication";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Pages";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 85;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Type";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 140;
            // 
            // gb_Doc
            // 
            this.gb_Doc.Controls.Add(this.Doc_ControlPanel);
            this.gb_Doc.Controls.Add(this.label6);
            this.gb_Doc.Controls.Add(this.txt_doc_search_with);
            this.gb_Doc.Controls.Add(this.dgv_docs);
            this.gb_Doc.Controls.Add(this.txt_doc_count);
            this.gb_Doc.Controls.Add(this.label5);
            this.gb_Doc.Location = new System.Drawing.Point(12, 131);
            this.gb_Doc.Name = "gb_Doc";
            this.gb_Doc.Size = new System.Drawing.Size(987, 438);
            this.gb_Doc.TabIndex = 2;
            this.gb_Doc.TabStop = false;
            this.gb_Doc.Text = "Documents";
            // 
            // Doc_ControlPanel
            // 
            this.Doc_ControlPanel.Controls.Add(this.btn_doc_edit);
            this.Doc_ControlPanel.Controls.Add(this.btn_doc_remove);
            this.Doc_ControlPanel.Controls.Add(this.btn_doc_add);
            this.Doc_ControlPanel.Location = new System.Drawing.Point(340, 21);
            this.Doc_ControlPanel.Name = "Doc_ControlPanel";
            this.Doc_ControlPanel.Size = new System.Drawing.Size(280, 41);
            this.Doc_ControlPanel.TabIndex = 12;
            // 
            // btn_doc_edit
            // 
            this.btn_doc_edit.Location = new System.Drawing.Point(204, 6);
            this.btn_doc_edit.Name = "btn_doc_edit";
            this.btn_doc_edit.Size = new System.Drawing.Size(67, 27);
            this.btn_doc_edit.TabIndex = 11;
            this.btn_doc_edit.Text = "&Modifier";
            this.btn_doc_edit.UseVisualStyleBackColor = true;
            this.btn_doc_edit.Click += new System.EventHandler(this.btn_doc_edit_Click);
            // 
            // btn_doc_remove
            // 
            this.btn_doc_remove.Location = new System.Drawing.Point(108, 6);
            this.btn_doc_remove.Name = "btn_doc_remove";
            this.btn_doc_remove.Size = new System.Drawing.Size(67, 27);
            this.btn_doc_remove.TabIndex = 10;
            this.btn_doc_remove.Text = "&Supprimer";
            this.btn_doc_remove.UseVisualStyleBackColor = true;
            this.btn_doc_remove.Click += new System.EventHandler(this.btn_doc_remove_Click);
            // 
            // btn_doc_add
            // 
            this.btn_doc_add.Location = new System.Drawing.Point(12, 6);
            this.btn_doc_add.Name = "btn_doc_add";
            this.btn_doc_add.Size = new System.Drawing.Size(67, 27);
            this.btn_doc_add.TabIndex = 9;
            this.btn_doc_add.Text = "&Ajouter";
            this.btn_doc_add.UseVisualStyleBackColor = true;
            this.btn_doc_add.Click += new System.EventHandler(this.btn_doc_add_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Cherche par :";
            // 
            // txt_doc_search_with
            // 
            this.txt_doc_search_with.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doc_search_with.Location = new System.Drawing.Point(105, 30);
            this.txt_doc_search_with.Name = "txt_doc_search_with";
            this.txt_doc_search_with.Size = new System.Drawing.Size(205, 21);
            this.txt_doc_search_with.TabIndex = 1;
            this.txt_doc_search_with.TextChanged += new System.EventHandler(this.txt_doc_search_with_TextChanged);
            // 
            // txt_doc_count
            // 
            this.txt_doc_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doc_count.Location = new System.Drawing.Point(703, 29);
            this.txt_doc_count.Name = "txt_doc_count";
            this.txt_doc_count.ReadOnly = true;
            this.txt_doc_count.Size = new System.Drawing.Size(76, 21);
            this.txt_doc_count.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(656, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Count :";
            // 
            // Form_Table_Doc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 581);
            this.Controls.Add(this.gb_theme);
            this.Controls.Add(this.gb_Doc);
            this.Controls.Add(this.grpB_domain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Table_Doc";
            this.Text = "Form_Table_Doc";
            this.Load += new System.EventHandler(this.Form_Table_Doc_Load);
            this.grpB_domain.ResumeLayout(false);
            this.grpB_domain.PerformLayout();
            this.Dom_ControlPanel.ResumeLayout(false);
            this.gb_theme.ResumeLayout(false);
            this.gb_theme.PerformLayout();
            this.Thm_ControlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_docs)).EndInit();
            this.gb_Doc.ResumeLayout(false);
            this.gb_Doc.PerformLayout();
            this.Doc_ControlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_dom_search;
        private System.Windows.Forms.ComboBox cb_domain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpB_domain;
        private System.Windows.Forms.GroupBox gb_theme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_theme;
        private System.Windows.Forms.TextBox txt_theme_search;
        private System.Windows.Forms.Button btn_edit_dom;
        private System.Windows.Forms.Button btn_remove_dom;
        private System.Windows.Forms.Button btn_add_dom;
        private System.Windows.Forms.Button btn_edit_theme;
        private System.Windows.Forms.Button btn_remove_theme;
        private System.Windows.Forms.Button btn_add_theme;
        private System.Windows.Forms.TextBox txt_Dom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Theme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_docs;
        private System.Windows.Forms.GroupBox gb_Doc;
        private System.Windows.Forms.TextBox txt_doc_count;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_doc_search_with;
        private System.Windows.Forms.Button btn_doc_edit;
        private System.Windows.Forms.Button btn_doc_remove;
        private System.Windows.Forms.Button btn_doc_add;
        private System.Windows.Forms.Panel Dom_ControlPanel;
        private System.Windows.Forms.Panel Thm_ControlPanel;
        private System.Windows.Forms.Panel Doc_ControlPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}