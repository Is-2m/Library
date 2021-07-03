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
    public partial class Form_Login : Form
    {
        public static bool LoggedIn;
        public static int AdminId;

        List<Staff> LST = Program.LStaff;
        
        public Form_Login()
        {
            InitializeComponent();
        }

        #region Events
        private void btn_Geust_Click(object sender, EventArgs e)
        {
            Form_Login.LoggedIn =false;
            this.Close();
        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            if(LST.Count!=0)
            {
                Loggin();
            }
            else
            {
                Loggin();
                Form_Fiche_Admin f = new Form_Fiche_Admin(-1);
                f.ShowDialog();
            }

        }
        private void btn_Annuler_Click(object sender, EventArgs e)
        {
            LoginMode();
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            AdminId = Auth();
            if (AdminId != -1)
            {
                LoggedIn = true;
                MessageBox.Show("Connecté avec succès!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                this.Close();
            }
            else
            {
                MessageBox.Show("Le nom d'utilisateur ou le mot de passe sont faux!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            txt_password.PasswordChar = '●';
        }
        #endregion


        #region Methods
        private void Loggin()
        {
            Panel_LoginMode.Visible = false;
            Panel_Login.Visible = true;
        }
        private void LoginMode()
        {
            Panel_LoginMode.Visible = true;
            Panel_Login.Visible = false;
        }

        private int Auth()
        {
            string user = txt_username.Text;
            string pass = txt_password.Text;
            Staff s = null;
            s = LST.Find(obj => obj.Tologin(user, pass));
            if (s == null)
                return -1;
            else
                return s.Id;
            
            
        }                
        #endregion

    }
}
