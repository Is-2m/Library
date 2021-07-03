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
    public partial class Form_Fiche_Author : Form
    {
        List<Auteur> lst = Program.lstAut;
        int Index;
        public Form_Fiche_Author(int indice)
        {
            InitializeComponent();
            Index = indice;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (Index != -1)
                {
                    lst[Index].Nom = txt_Fullname.Text;
                    lst[Index].DateNaiss = dtp_dNaiss.Value;
                }
                else
                    lst.Add(new Auteur(txt_Fullname.Text, dtp_dNaiss.Value));
                MessageBox.Show("Sauvegarde réussie", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void Form_Fiche_Author_Load(object sender, EventArgs e)
        {
            try
            {
                if (Index != -1)
                {
                    txt_id.Text = lst[Index].Id.ToString();
                    txt_Fullname.Text = lst[Index].Nom;
                    dtp_dNaiss.Value = lst[Index].DateNaiss;
                }
                else
                    txt_id.Text = Auteur.LastId.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
