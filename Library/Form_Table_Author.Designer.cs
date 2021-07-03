
namespace Library
{
    partial class Form_Table_Author
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
            this.gb_auteur = new System.Windows.Forms.GroupBox();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.btn_aut_edit = new System.Windows.Forms.Button();
            this.btn_aut_remove = new System.Windows.Forms.Button();
            this.btn_aut_add = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_aut_search_with = new System.Windows.Forms.TextBox();
            this.dgv_auts = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_aut_count = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gb_doc = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_dox_search = new System.Windows.Forms.TextBox();
            this.dgv_doc = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_doc_count = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_auteur.SuspendLayout();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_auts)).BeginInit();
            this.gb_doc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doc)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_auteur
            // 
            this.gb_auteur.Controls.Add(this.ControlPanel);
            this.gb_auteur.Controls.Add(this.label6);
            this.gb_auteur.Controls.Add(this.txt_aut_search_with);
            this.gb_auteur.Controls.Add(this.dgv_auts);
            this.gb_auteur.Controls.Add(this.txt_aut_count);
            this.gb_auteur.Controls.Add(this.label5);
            this.gb_auteur.Location = new System.Drawing.Point(12, 12);
            this.gb_auteur.Name = "gb_auteur";
            this.gb_auteur.Size = new System.Drawing.Size(987, 283);
            this.gb_auteur.TabIndex = 0;
            this.gb_auteur.TabStop = false;
            this.gb_auteur.Text = "Auteurs";
            // 
            // ControlPanel
            // 
            this.ControlPanel.Controls.Add(this.btn_aut_edit);
            this.ControlPanel.Controls.Add(this.btn_aut_remove);
            this.ControlPanel.Controls.Add(this.btn_aut_add);
            this.ControlPanel.Location = new System.Drawing.Point(343, 23);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(280, 39);
            this.ControlPanel.TabIndex = 9;
            // 
            // btn_aut_edit
            // 
            this.btn_aut_edit.Location = new System.Drawing.Point(201, 4);
            this.btn_aut_edit.Name = "btn_aut_edit";
            this.btn_aut_edit.Size = new System.Drawing.Size(67, 27);
            this.btn_aut_edit.TabIndex = 4;
            this.btn_aut_edit.Text = "&Modifier";
            this.btn_aut_edit.UseVisualStyleBackColor = true;
            this.btn_aut_edit.Click += new System.EventHandler(this.btn_aut_edit_Click);
            // 
            // btn_aut_remove
            // 
            this.btn_aut_remove.Location = new System.Drawing.Point(105, 4);
            this.btn_aut_remove.Name = "btn_aut_remove";
            this.btn_aut_remove.Size = new System.Drawing.Size(67, 27);
            this.btn_aut_remove.TabIndex = 3;
            this.btn_aut_remove.Text = "&Supprimer";
            this.btn_aut_remove.UseVisualStyleBackColor = true;
            this.btn_aut_remove.Click += new System.EventHandler(this.btn_aut_remove_Click);
            // 
            // btn_aut_add
            // 
            this.btn_aut_add.Location = new System.Drawing.Point(9, 4);
            this.btn_aut_add.Name = "btn_aut_add";
            this.btn_aut_add.Size = new System.Drawing.Size(67, 27);
            this.btn_aut_add.TabIndex = 2;
            this.btn_aut_add.Text = "&Ajouter";
            this.btn_aut_add.UseVisualStyleBackColor = true;
            this.btn_aut_add.Click += new System.EventHandler(this.btn_aut_add_Click);
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
            // txt_aut_search_with
            // 
            this.txt_aut_search_with.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_aut_search_with.Location = new System.Drawing.Point(91, 30);
            this.txt_aut_search_with.Name = "txt_aut_search_with";
            this.txt_aut_search_with.Size = new System.Drawing.Size(230, 21);
            this.txt_aut_search_with.TabIndex = 1;
            this.txt_aut_search_with.TextChanged += new System.EventHandler(this.txt_aut_search_with_TextChanged);
            // 
            // dgv_auts
            // 
            this.dgv_auts.AllowUserToAddRows = false;
            this.dgv_auts.AllowUserToDeleteRows = false;
            this.dgv_auts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_auts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FullName,
            this.Column3,
            this.Column4});
            this.dgv_auts.Location = new System.Drawing.Point(9, 77);
            this.dgv_auts.MultiSelect = false;
            this.dgv_auts.Name = "dgv_auts";
            this.dgv_auts.ReadOnly = true;
            this.dgv_auts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_auts.Size = new System.Drawing.Size(972, 182);
            this.dgv_auts.TabIndex = 2;
            this.dgv_auts.SelectionChanged += new System.EventHandler(this.dgv_auts_SelectionChanged);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Nom et Prenom";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 673;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Age";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nombre Docs";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // txt_aut_count
            // 
            this.txt_aut_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_aut_count.Location = new System.Drawing.Point(703, 29);
            this.txt_aut_count.Name = "txt_aut_count";
            this.txt_aut_count.ReadOnly = true;
            this.txt_aut_count.Size = new System.Drawing.Size(76, 21);
            this.txt_aut_count.TabIndex = 5;
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
            // gb_doc
            // 
            this.gb_doc.Controls.Add(this.label1);
            this.gb_doc.Controls.Add(this.txt_dox_search);
            this.gb_doc.Controls.Add(this.dgv_doc);
            this.gb_doc.Controls.Add(this.txt_doc_count);
            this.gb_doc.Controls.Add(this.label2);
            this.gb_doc.Location = new System.Drawing.Point(12, 301);
            this.gb_doc.Name = "gb_doc";
            this.gb_doc.Size = new System.Drawing.Size(987, 268);
            this.gb_doc.TabIndex = 1;
            this.gb_doc.TabStop = false;
            this.gb_doc.Text = "Documents";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cherche par :";
            // 
            // txt_dox_search
            // 
            this.txt_dox_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dox_search.Location = new System.Drawing.Point(332, 30);
            this.txt_dox_search.Name = "txt_dox_search";
            this.txt_dox_search.Size = new System.Drawing.Size(230, 21);
            this.txt_dox_search.TabIndex = 1;
            this.txt_dox_search.TextChanged += new System.EventHandler(this.txt_dox_search_TextChanged);
            // 
            // dgv_doc
            // 
            this.dgv_doc.AllowUserToAddRows = false;
            this.dgv_doc.AllowUserToDeleteRows = false;
            this.dgv_doc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_doc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgv_doc.Location = new System.Drawing.Point(9, 77);
            this.dgv_doc.MultiSelect = false;
            this.dgv_doc.Name = "dgv_doc";
            this.dgv_doc.ReadOnly = true;
            this.dgv_doc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_doc.Size = new System.Drawing.Size(972, 182);
            this.dgv_doc.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Titre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 500;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewCellStyle1.Format = "D";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn4.HeaderText = "Date Publication";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Pages";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 85;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Type";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 140;
            // 
            // txt_doc_count
            // 
            this.txt_doc_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doc_count.Location = new System.Drawing.Point(656, 30);
            this.txt_doc_count.Name = "txt_doc_count";
            this.txt_doc_count.ReadOnly = true;
            this.txt_doc_count.Size = new System.Drawing.Size(76, 21);
            this.txt_doc_count.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(609, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Count :";
            // 
            // Form_Table_Author
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 581);
            this.Controls.Add(this.gb_doc);
            this.Controls.Add(this.gb_auteur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Table_Author";
            this.Text = "Form_Table_Author";
            this.Load += new System.EventHandler(this.Form_Table_Author_Load);
            this.gb_auteur.ResumeLayout(false);
            this.gb_auteur.PerformLayout();
            this.ControlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_auts)).EndInit();
            this.gb_doc.ResumeLayout(false);
            this.gb_doc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_auteur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_aut_search_with;
        private System.Windows.Forms.DataGridView dgv_auts;
        private System.Windows.Forms.TextBox txt_aut_count;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gb_doc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_dox_search;
        private System.Windows.Forms.DataGridView dgv_doc;
        private System.Windows.Forms.TextBox txt_doc_count;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button btn_aut_edit;
        private System.Windows.Forms.Button btn_aut_remove;
        private System.Windows.Forms.Button btn_aut_add;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}