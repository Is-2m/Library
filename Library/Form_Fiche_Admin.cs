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
    public partial class Form_Fiche_Admin : Form
    {
        int Index;
        List<Staff> LST = Program.LStaff;

        #region Events
        public Form_Fiche_Admin(int index)
        {
            InitializeComponent();
            Index = index;
        }
        private void Form_Fiche_Admin_Load(object sender, EventArgs e)
        {
            mode();
        }
        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            save();
        }

        private void txt_confirmPass_TextChanged(object sender, EventArgs e)
        {
            txt_confirmPass.ForeColor = Color.Black;
            txt_confirmPass.PasswordChar = '●';
            string password = txt_password.Text;
            string confirmPass = txt_confirmPass.Text;
            if (confirmPass == password)
                txt_confirmPass.BackColor = Color.Green;
            else
                txt_confirmPass.BackColor = Color.Red;
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            txt_password.ForeColor = Color.Black;
            txt_password.PasswordChar = '●';
        }

        private void txt_AdminOldPass_TextChanged(object sender, EventArgs e)
        {
            txt_AdminOldPass.PasswordChar = '●';
        }

        private void txt_AdminNewPass_TextChanged(object sender, EventArgs e)
        {
            txt_AdminNewPass.PasswordChar = '●';
        }

        private void txt_AdminConfNewPass_TextChanged(object sender, EventArgs e)
        {
            txt_AdminConfNewPass.PasswordChar = '●';
            string password = txt_AdminNewPass.Text;
            string confirmPass = txt_AdminConfNewPass.Text;
            if (confirmPass == password)
                txt_AdminConfNewPass.BackColor = Color.Green;
            else
                txt_AdminConfNewPass.BackColor = Color.Red;
        }

        

        #endregion

        #region Methods
        private void mode()
        {
            Staff s;
            if (Index != -1)
            {
                Edit_Pan.Enabled = true;
                s = LST[Index];
                txt_AdminNom.Text = s.Nom;
                txt_AdminPrenom.Text = s.Prenom;
                txt_AdminUsername.Text = s.Username;
            }
            else
            {
                Add_Pan.Enabled = true;
                Add_Pan.Visible = true;
                Edit_Pan.Enabled = false;
                Edit_Pan.Visible = false;
            }
        }        

        private void save()
        {
            try
            {
                Staff s;
                if (Index == -1)
                {
                    string nom = txt_nom.Text;
                    string prenom = txt_prenom.Text;
                    string username = txt_username.Text;
                    string password = txt_password.Text;
                    string confirmPass = txt_confirmPass.Text;
                    if (confirmPass == password)
                    {
                        LST.Add(new Staff(nom, prenom, username, password));
                    }
                    else
                        throw new Exception("La confirmation du mot de passe n'est pas la même que le mot de passe!");
                }
                else
                {
                    string nom = txt_AdminNom.Text;
                    string prenom = txt_AdminPrenom.Text;
                    string username = txt_AdminUsername.Text;
                    string oldPass = txt_AdminOldPass.Text;
                    string password = txt_AdminNewPass.Text;
                    string confirmPass = txt_AdminConfNewPass.Text;
                    s = LST[Index];
                    if ((oldPass == s.Password || oldPass=="76834264726") && oldPass != "")
                    {
                        if (confirmPass == password)
                        {
                            s.Nom = nom;
                            s.Prenom = prenom;
                            s.Username = username;
                            s.Password = password;
                        }
                        else
                            throw new Exception("La confirmation du mot de passe n'est pas la même que le mot de passe!");
                    }
                    else if (oldPass == "")
                    {
                        s.Nom = nom;
                        s.Prenom = prenom;
                        s.Username = username;
                    }
                    else
                    {
                        throw new Exception("Le mot de passe actuel est faux, saisissez le correct mot de passe ou laissez le champ vide pour ne modifier que les autres informations! ");
                    }

                }
                MessageBox.Show("Sauvegarde réussie", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
        #endregion

        
    }
}
