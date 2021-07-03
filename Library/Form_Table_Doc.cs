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
    public partial class Form_Table_Doc : Form
    {
        int SelectedDom;
        Theme Selectedthm;
        List<Domain> LST = Program.l_dom;
        public Form_Table_Doc()
        {
            InitializeComponent();
        }
        #region Events
        
        private void Form_Table_Doc_Load(object sender, EventArgs e)
        {
            if(!Form_Login.LoggedIn)
            {
                Dom_ControlPanel.Enabled = false;
                Doc_ControlPanel.Enabled = false;
                Thm_ControlPanel.Enabled = false;
            }
            else
            {
                Dom_ControlPanel.Enabled = true;
                Doc_ControlPanel.Enabled = true;
                Thm_ControlPanel.Enabled = true;
            }
            dom_ref(LST);
        }

        private void btn_add_dom_Click(object sender, EventArgs e)
        {
            var f = new Form_Fiche_Domain(-1);
            f.ShowDialog();
            dom_ref(LST);
        }

        private void cb_domain_SelectedIndexChanged(object sender, EventArgs e)
        {

            SelectedDom = DomIndexSearch();
            thm_ref(SelectedDom,LST);
        }

        private void btn_remove_dom_Click(object sender, EventArgs e)
        {
            remove_dom();
            dom_ref(LST);
        }

        private void btn_edit_dom_Click(object sender, EventArgs e)
        {
            int pos = DomIndexSearch();
            var f = new Form_Fiche_Domain(pos);
            f.ShowDialog();
            dom_ref(LST);
        }

        // -----------------------------------------------------------------

        private void btn_add_theme_Click(object sender, EventArgs e)
        {
            var f = new Form_Fiche_Theme(-1, -1);
            f.ShowDialog();
            thm_ref(SelectedDom, LST);
        }

        private void btn_remove_theme_Click(object sender, EventArgs e)
        {
            remove_thm();
            thm_ref(LST[SelectedDom].LstT);
        }

        private void btn_edit_theme_Click(object sender, EventArgs e)
        {

            var f = new Form_Fiche_Theme(SelectedDom, Selectedthm.Id);
            f.ShowDialog();
            thm_ref(SelectedDom, LST);
        }

        private void txt_dom_search_TextChanged(object sender, EventArgs e)
        {
            dom_search();
        }

        private void txt_theme_search_TextChanged(object sender, EventArgs e)
        {
            thm_search();
        }

        private void cb_theme_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selectedthm = SelectedThmSearch();
            doc_ref(SelectedDom,Selectedthm,LST);
        }

        private void btn_doc_add_Click(object sender, EventArgs e)
        {
            var f = new Form_Fiche_Document(-1, -1, -1);
            f.ShowDialog();
            doc_ref(SelectedDom,Selectedthm,Program.l_dom);
        }
        private void btn_doc_edit_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("SelectedDom: " + SelectedDom + "\nSeletedthm: " + Selectedthm.Id +"\nThmNom : "+Selectedthm.Nom+ "\nselectedDocm"+ dgv_docs.CurrentRow.Index);
            var f = new Form_Fiche_Document(SelectedDom, Selectedthm.Id, dgv_docs.CurrentRow.Index);
            f.ShowDialog();
            doc_ref(SelectedDom, Selectedthm, Program.l_dom);
        }

        private void txt_doc_search_with_TextChanged(object sender, EventArgs e)
        {
            doc_search();
        }
        private void btn_doc_remove_Click(object sender, EventArgs e)
        {
            remove_doc();
            doc_ref(Selectedthm.LstD);
        }
        #endregion

        #region Methods

        private void dom_ref(List<Domain> lst )
        {
            cb_domain.Items.Clear();
            foreach (var d in lst)
            {
                cb_domain.Items.Add(d.Id + ": " + d.Nom);
            }
            cb_domain.SelectedIndex = lst.Count != 0 ? 0 : -1;
            txt_Dom.Text = lst.Count.ToString();
        }

        private void thm_ref(int pos,List<Domain> lst)
        {
            cb_theme.Items.Clear();
            foreach (var t in lst[pos].LstT)
            {
                cb_theme.Items.Add(t.Id + ": " + t.Nom);
            }
            cb_theme.SelectedIndex = LST[pos].TotalThemes != 0 ? 0 : -1;
            txt_Theme.Text = LST[pos].TotalThemes.ToString();
        }

        private void thm_ref(List<Theme> lst) //Required for thm_search()
        {
            cb_theme.Items.Clear();
            foreach (var t in lst)
            {
                cb_theme.Items.Add(t.Id + ": " + t.Nom);
            }
            cb_theme.SelectedIndex = lst.Count != 0 ? 0 : -1;
            txt_Theme.Text = lst.Count.ToString();
        }

        private void remove_dom()
        {
            try
            {
                if (cb_domain.SelectedIndex == -1)//If the ComboBox is Emprty
                    throw new Exception("Pas d'élément sélectionné");
                else
                {
                    if (MessageBox.Show("Voulez-vous vraiment supprimer cette sauvegarde!", "Supprission", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                        LST.RemoveAt(SelectedDom);
                }
                dom_ref(LST);        
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void remove_thm()
        {
            try
            {
                if (cb_theme.SelectedIndex == -1) //If the ComboBox is Emprty
                    throw new Exception("Pas d'élément sélectionné");
                else
                {
                    if (MessageBox.Show("Voulez-vous vraiment supprimer cette sauvegarde!", "Supprission", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                        LST[SelectedDom].LstT.Remove(Selectedthm);
                }
                thm_ref(SelectedDom, LST);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dom_search()//search for "Domains" by typing its name
        {
            try
            {
                if (txt_dom_search.Text=="")
                {
                    dom_ref(LST);
                }
                else
                {
                    var lst = LST.FindAll(obj => obj.Nom.Contains(txt_dom_search.Text));
                    dom_ref(lst);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }
        
        private void thm_search() //search for "Themes" by typing its name
        {
            try
            {
                if (txt_theme_search.Text == "")
                {
                    thm_ref(SelectedDom,LST);
                }
                else
                {
                    var lst = LST[SelectedDom].LstT.FindAll(obj => obj.Nom.Contains(txt_theme_search.Text));
                    thm_ref(lst);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private int DomIndexSearch()//search for domain's index based on ComboBox.Text 
        {
            int pos = -1;
            try
            {
                string[] s = cb_domain.Text.Split(':');
                int i = int.Parse(s[0]);
                pos = LST.IndexOf(LST.Find(obj => obj.Id == i));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return pos;
        }

        private Theme SelectedThmSearch()//search for the selected Theme based on ComboBox.Text 
        {
            Theme thm = null;
            try
            {
                string[] s = cb_theme.Text.Split(':');
                thm = LST[SelectedDom].LstT.Find(obj => obj.Id == int.Parse(s[0]));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return thm;
        }              

        private void doc_ref(int domPos,Theme thm,List<Domain> lst)
        {
            try
            {
                dgv_docs.Rows.Clear();
                foreach (var d in thm.LstD)
                {
                    dgv_docs.Rows.Add(d.Id, d.Titre, d.Auteur.Nom , d.DatePub, d.NbrPages, d.Type);
                }
                txt_doc_count.Text = lst[domPos].TotalDocs.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
        private void doc_ref(List<Doc> lst)
        {
            try
            {
                dgv_docs.Rows.Clear();
                foreach (var d in lst)
                {
                    dgv_docs.Rows.Add(d.Id, d.Titre, d.Auteur.Nom, d.DatePub, d.NbrPages, d.Type);
                }
                txt_doc_count.Text = lst.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void doc_search()
        {
            try
            {
                if (txt_doc_search_with.Text == "")
                {
                    doc_ref(SelectedDom, Selectedthm, LST);
                }
                else
                {
                    var lst = Selectedthm.LstD.FindAll(obj => obj.Titre.Contains(txt_doc_search_with.Text));
                    doc_ref(lst);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void remove_doc()
        {
            try
            {
                if (dgv_docs.Rows.Count==0)//If the DGV is Emprty
                    throw new Exception("Pas d'élément sélectionné");
                else
                {
                    if (MessageBox.Show("Voulez-vous vraiment supprimer cette sauvegarde!", "Supprission", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {
                        string t = dgv_docs.CurrentRow.Cells["Title"].Value.ToString();
                        string aut = dgv_docs.CurrentRow.Cells["Author"].Value.ToString();
                        var d = Selectedthm.LstD.Find(obj => obj.Titre == t && obj.Auteur.Nom == aut);
                        Selectedthm.LstD.Remove(d);
                    }
                }
                doc_ref(SelectedDom,Selectedthm,LST);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

        
    }
}
