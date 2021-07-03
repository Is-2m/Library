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
    public partial class Form_Fiche_Domain : Form
    {
        int Index;
        public Form_Fiche_Domain(int indice)
        {
            InitializeComponent();
            Index = indice;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (Index != -1)                               
                    Program.l_dom[Index].Nom = txt_nom.Text;                
                else
                    Program.l_dom.Add(new Domain(txt_nom.Text));
                MessageBox.Show("Sauvegarde réussie", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void Form_Fiche_Domain_Load(object sender, EventArgs e)
        {
            if (Index != -1)
            {
                txt_id.Text = Program.l_dom[Index].Id.ToString();
                txt_nom.Text = Program.l_dom[Index].Nom;
            }
            else
                txt_id.Text = Domain.NextID.ToString();
        }
    }
}
