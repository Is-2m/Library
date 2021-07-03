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
    public partial class Form_Fiche_Document : Form
    {
        List<Domain> lstDom = Program.l_dom;
        List<Auteur> LstAut = Program.lstAut;
        
        int IndexDom,IdThm,IndexDoc;//for modification
        
        int SelectedDom,SelectedAut;// for creating
        
        Theme SelectedTheme;


        #region Events
        public Form_Fiche_Document(int IndiceDom, int Idthm,int IndiceDoc)
        {
            InitializeComponent();
            IndexDom = IndiceDom;
            IdThm = Idthm;
            IndexDoc = IndiceDoc;

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (IndexDom != -1 )
                {
                    var d = SelectedTheme.LstD[IndexDoc];

                    d.NbrPages = int.Parse(txt_NbrPages.Text);
                    d.Titre = txt_title.Text;
                    d.DatePub = dtp_dPub.Value;
                }
                else
                {
                    LstAut[SelectedAut].ListDoc.Add(new Doc(txt_title.Text, dtp_dPub.Value, int.Parse(txt_NbrPages.Text), LstAut[SelectedAut], cb_type.Text));
                    SelectedTheme.LstD.Add(LstAut[SelectedAut].ListDoc.Last());
                    MessageBox.Show("Sauvegarde réussie", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Fiche_Document_Load(object sender, EventArgs e)
        {
            
            cb_aut_ref(LstAut);
            cb_dom_ref(lstDom);
            cb_thm_ref(lstDom[SelectedDom].LstT);
            cb_type_ref();
            mode();
        }
        private void cb_domain_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedDom = DomIndexSearch();
            cb_thm_ref(lstDom[SelectedDom].LstT);
        }
        private void cb_theme_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedTheme = SelectedThmSearch();
        }

        private void cb_auteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedAut = AutIndexSearch();
        }
        private void txt_search_dom_TextChanged(object sender, EventArgs e)
        {
            dom_search();
        }

        private void txt_search_Theme_TextChanged(object sender, EventArgs e)
        {
            thm_search();
        }

        private void txt_search_author_TextChanged(object sender, EventArgs e)
        {
            aut_search();
        }
        private void btn_add_type_Click(object sender, EventArgs e)
        {
            List<string> s = new List<string>();
            s.AddRange(Doc.Types);
            s.Add(txt_type.Text);
            Doc.Types = s.ToArray();
            cb_type_ref();
        }

        private void btn_remove_type_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> s = new List<string>();
                s.AddRange(Doc.Types);
                s.Remove(cb_type.Text);
                Doc.Types = s.ToArray();
                cb_type_ref();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

        #region Methods
        private void mode()
        {
            try
            {
                if (IndexDom != -1 )
                {
                    SelectedTheme = lstDom[IndexDom].LstT.Find(obj => obj.Id == IdThm);
                    //MessageBox.Show("SelectedDom: " + IndexDom + "\nThmNom : " + SelectedTheme.Nom + "\nSeletedthm: " + SelectedTheme.Id + "\nselectedThm" + IndexDoc);
                    var d = SelectedTheme.LstD[IndexDoc];

                    txt_NbrPages.Text = d.NbrPages.ToString();
                    txt_title.Text = d.Titre;
                    dtp_dPub.Value = d.DatePub;

                    //----------Disabled Tools-------------------------------
                    txt_id.Text = d.Id.ToString();
                    txt_id.Enabled = false;

                    cb_auteur.DropDownStyle = ComboBoxStyle.DropDown;
                    cb_auteur.Text = d.Auteur.Id+": "+d.Auteur.Nom;
                    cb_auteur.DropDownStyle = ComboBoxStyle.DropDownList;
                    gb_aut.Enabled = false;

                    cb_domain.SelectedIndex = IndexDom;
                    gb_Dom.Enabled = false;

                    cb_theme.DropDownStyle = ComboBoxStyle.DropDown;
                    cb_theme.Text = SelectedTheme.Id+": "+SelectedTheme.Nom;
                    cb_theme.DropDownStyle = ComboBoxStyle.DropDownList;
                    gb_Thm.Enabled = false;

                    cb_type.Text = d.Type;
                    gb_type.Enabled = false;
                    //-------------------------------------------------------

                }
                else
                {
                    txt_id.Text = Doc.NextID.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                       
        }

        private void cb_aut_ref(List<Auteur> lst)
        {
            cb_auteur.Items.Clear();
            foreach ( var a in lst)
            {
                cb_auteur.Items.Add(a.Id + ": "+a.Nom);
            }
            cb_auteur.SelectedIndex = lst.Count == 0 ? -1 : 0;
        }
        private void cb_type_ref()
        {
            cb_type.Items.Clear();
            cb_type.Items.AddRange(Doc.Types);
            cb_type.SelectedIndex = 0;
        }
        private void cb_dom_ref(List<Domain> lst)
        {
            cb_domain.Items.Clear();
            foreach (var d in lst)
            {
                cb_domain.Items.Add(d.Id+": "+d.Nom);
            }
            cb_domain.SelectedIndex = lst.Count == 0 ? -1 : 0;
        }

        

        private void cb_thm_ref(List<Theme> lst)
        {
            cb_theme.Items.Clear();
            foreach (var t in lst)
            {
                cb_theme.Items.Add(t.Id + ": " + t.Nom);
            }
            cb_theme.SelectedIndex = lst.Count == 0 ? -1 : 0;
        }

        

        private int DomIndexSearch()//search for domain's index based on ComboBox.Text 
        {
            int pos = -1;
            try
            {
                string[] s = cb_domain.Text.Split(':');
                pos = int.Parse(s[0]) - 1;
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
                thm = lstDom[SelectedDom].LstT.Find(obj => obj.Id == int.Parse(s[0]));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return thm;
        }
        private int AutIndexSearch()//search for Author's index based on ComboBox.Text 
        {
            int pos = -1;
            try
            {
                string[] s = cb_auteur.Text.Split(':');
                pos = int.Parse(s[0]) - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return pos;
        }

        private void dom_search()//search for "Domains" by typing its name
        {
            try
            {
                if (txt_search_dom.Text == "")
                {
                    cb_dom_ref(lstDom);
                }
                else
                {
                    var lst = lstDom.FindAll(obj => obj.Nom.Contains(txt_search_dom.Text));
                    cb_dom_ref(lst);
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
                if (txt_search_Theme.Text == "")
                {
                    cb_thm_ref(lstDom[SelectedDom].LstT);
                }
                else
                {
                    var lst = lstDom[SelectedDom].LstT.FindAll(obj => obj.Nom.Contains(txt_search_Theme.Text));
                    cb_thm_ref(lst);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void aut_search() //search for "Author" by typing his/her name
        {
            try
            {
                if (txt_search_author.Text == "")
                {
                    cb_aut_ref(LstAut);
                }
                else
                {
                    var lst = LstAut.FindAll(obj => obj.Nom.Contains(txt_search_author.Text.ToUpper()));
                    cb_aut_ref(lst);
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
