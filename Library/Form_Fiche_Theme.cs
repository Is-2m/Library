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
    public partial class Form_Fiche_Theme : Form
    {
        int Index_dom;
        Theme Thm;
        public Form_Fiche_Theme(int indice_dom, int thm)
        {
            InitializeComponent();
            Thm = thm != -1 ? Program.l_dom[indice_dom].LstT.Find(obj => obj.Id == thm) : null;
            Index_dom = indice_dom;
        }

        #region Events
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (Index_dom != -1 && Thm != null)
                {
                    Thm.Nom = txt_nom.Text;
                }
                else
                {                   
                    int i = DomIndexSearch();
                    if (i == -1)
                        throw new Exception("veuillez choisir un domaine");
                    Program.l_dom[i].LstT.Add(new Theme(txt_nom.Text));
                }
                MessageBox.Show("Sauvegarde réussie", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Form_Fiche_Theme_Load(object sender, EventArgs e)
        {
            mode();
            CBox_refresh(Program.l_dom);                       
        }

        private void txt_dom_search_TextChanged(object sender, EventArgs e)
        {
            dom_search();
        }

        #endregion

        #region Methods
        private void mode() // Mode of Editing/Adding
        {
            
            if (Index_dom != -1 && Thm!=null)
            {
                var d = Program.l_dom[Index_dom];

                cb_domains.Text = d.Id+": "+d.Nom;
                cb_domains.Enabled = false;
                txt_dom_search.Visible = false;
                lbl_dom_search.Visible = false;

                

                txt_id.Text = Thm.Id.ToString();
                txt_nom.Text = Thm.Nom;
            }
            else
            {
                txt_id.Text = Theme.NextID.ToString();
                
            }
        }

        private void CBox_refresh(List<Domain> lst)
        {
            cb_domains.Items.Clear();
            foreach (var d in lst)
            {
                cb_domains.Items.Add(d.Id + ": " + d.Nom);
            }
            cb_domains.SelectedIndex = lst.Count != 0 ? 0 : -1;
        }

        private int DomIndexSearch()  //search for domain's index based on ComboBox.Text 
        {
            int pos = -1;
            try
            {                
                string[] s = cb_domains.Text.Split(':');
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
                if (txt_dom_search.Text == "")
                {
                    CBox_refresh(Program.l_dom);
                }
                else
                {
                    var lst = Program.l_dom.FindAll(obj => obj.Nom.Contains(txt_dom_search.Text));
                    CBox_refresh(lst);
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
