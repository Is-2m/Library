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
    public partial class Form_Table_Admin : Form
    {
        List<Staff> LST = Program.LStaff;
        public Form_Table_Admin()
        {
            InitializeComponent();
        }

        private void Form_Table_Admin_Load(object sender, EventArgs e)
        {
            if (!Form_Login.LoggedIn)
                ControlPanel.Enabled = false;
            else
                ControlPanel.Enabled = true;
            refresh(LST);
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            var f = new Form_Fiche_Admin(-1);
            f.ShowDialog();
            refresh(LST);
        }
        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_admin.Rows.Count == 0)//If the DGV is Emprty
                    throw new Exception("Pas d'élément sélectionné");
                else
                {
                    if (MessageBox.Show("Voulez-vous vraiment supprimer cette sauvegarde!", "Supprission", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {
                        int i = dgv_admin.CurrentCell.RowIndex;
                        LST.RemoveAt(i);
                    }
                }refresh(LST);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void refresh(List<Staff> lst)
        {
            dgv_admin.Rows.Clear();
            foreach(var a in lst )
            {
                dgv_admin.Rows.Add(a.Id, a.Nom, a.Prenom, a.Username);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            int i = dgv_admin.CurrentCell.RowIndex;
            var f = new Form_Fiche_Admin(i);
            f.ShowDialog();
            refresh(LST);
        }
    }
}
