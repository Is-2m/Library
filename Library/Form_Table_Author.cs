using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Form_Table_Author : Form
    {
        List<Auteur> LST = Program.lstAut;
        Auteur Aut;
        public Form_Table_Author()
        {
            InitializeComponent();
        }
        #region Events
        private void btn_aut_add_Click(object sender, EventArgs e)
        {
            var f = new Form_Fiche_Author(-1);
            f.ShowDialog();
            aut_ref(LST);
        }
        private void btn_aut_edit_Click(object sender, EventArgs e)
        {
            var f = new Form_Fiche_Author(dgv_auts.CurrentRow.Index);
            f.ShowDialog();
            aut_ref(LST);
        }
        private void Form_Table_Author_Load(object sender, EventArgs e)
        {
            if (!Form_Login.LoggedIn)
                ControlPanel.Enabled = false;
            else
                ControlPanel.Enabled = true;
            aut_ref(LST);
        }       

        private void dgv_auts_SelectionChanged(object sender, EventArgs e)
        {
            Aut = LST[dgv_auts.CurrentRow.Index];
            doc_ref(Aut.ListDoc);
        }
        private void txt_aut_search_with_TextChanged(object sender, EventArgs e)
        {
            aut_search();
        }
        private void txt_dox_search_TextChanged(object sender, EventArgs e)
        {
            doc_search();
        }
        private void btn_aut_remove_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_auts.Rows.Count == 0)//If the DGV is Emprty
                    throw new Exception("Pas d'élément sélectionné");
                else
                {
                    if (MessageBox.Show("Voulez-vous vraiment supprimer cette sauvegarde!", "Supprission", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {
                        int i = (int)dgv_auts.CurrentRow.Cells["ID"].Value;
                        var a=LST.Find(obj => obj.Id == i);
                        LST.Remove(a);
                    }
                    aut_ref(LST);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Methods
        private void aut_ref(List<Auteur> lst)
        {
            dgv_auts.Rows.Clear();
            foreach (var a in lst)
            {
                dgv_auts.Rows.Add(a.Id, a.Nom, a.age, a.nbrDocs);
            }

            txt_aut_count.Text = lst.Count.ToString();
        }
        private void doc_ref(List<Doc> lst)
        {
            dgv_doc.Rows.Clear();
            foreach (var d in lst)
            {
                dgv_doc.Rows.Add(d.Id, d.Titre, d.DatePub, d.NbrPages, d.Type);
            }
            txt_doc_count.Text = lst.Count.ToString();
        }        

        private void aut_search() //search for "Author" by typing his/her name
        {
            try
            {
                if (txt_aut_search_with.Text == "")
                {
                    aut_ref(LST);
                }
                else
                {
                    var lst = LST.FindAll(obj => obj.Nom.Contains(txt_aut_search_with.Text.ToUpper()));
                    aut_ref(lst);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }         

        }
        private List<Auteur> aut_search(int i) //search for "Author" by typing his/her name
        {
            try
            {
                if (txt_aut_search_with.Text != "")
                {
                    var lst = LST.FindAll(obj => obj.Nom.Contains(txt_aut_search_with.Text.ToUpper()));
                    return lst;
                }                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
            private void doc_search() //search for "Doc" by typing his/her name
        {
            try
            {
                if (txt_dox_search.Text == "")
                {
                    doc_ref(Aut.ListDoc);
                }
                else
                {
                    var lst = Aut.ListDoc.FindAll(obj => obj.Titre.Contains(txt_dox_search.Text));
                    doc_ref(lst);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        #endregion

        
    }
}
