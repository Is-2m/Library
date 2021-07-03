using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace Library
{
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
        }

        private void ajouterDomainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Form_Fiche_Domain(-1);
            f.ShowDialog();
        }

        private void listeDocsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Form_Table_Doc();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void ajouterThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Form_Fiche_Theme(-1,-1);
            f.ShowDialog();
        }

        private void ajouterDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Form_Fiche_Document(-1, -1, -1);
            f.ShowDialog();
        }

        private void ajouterAuteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Form_Fiche_Author(-1);
            f.ShowDialog();
        }

        private void listerLesAuteursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Form_Table_Author();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }
        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Form_Fiche_Admin(-1);
            f.ShowDialog();
        }

        private void Form_Menu_Shown(object sender, EventArgs e)
        {
            Login();
        }
        private void seConnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Geust()
        {
            lbl_currentUser.Text = "Invité";
            ajouterAuteurToolStripMenuItem.Enabled = false;
            ajouterDocumentToolStripMenuItem.Enabled = false;
            ajouterDomainToolStripMenuItem.Enabled = false;
            ajouterThemeToolStripMenuItem.Enabled = false;
            ajouterToolStripMenuItem.Enabled = false;
            

        }
        private void Admin()
        {
            ajouterAuteurToolStripMenuItem.Enabled = true;
            ajouterDocumentToolStripMenuItem.Enabled = true;
            ajouterDomainToolStripMenuItem.Enabled = true;
            ajouterThemeToolStripMenuItem.Enabled = true;
            ajouterToolStripMenuItem.Enabled = true;

            var S = Program.LStaff.Find(obj => obj.Id == Form_Login.AdminId);
            lbl_currentUser.Text = S.Nom + " " + S.Prenom;
        }



        private void Login()
        {
            Form_Login f = new Form_Login();
            //f.MdiParent = this;
            f.ShowDialog();
            if (!Form_Login.LoggedIn)
                Geust();
            else
                Admin();
        }

        private void listerAdministrateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Form_Table_Admin();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void Form_Menu_Load(object sender, EventArgs e)
        {
            load();
        }

        private void Form_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("voulez-vous enregistrer votre changement?", "Sauvgarde", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                save();
            else if (r == DialogResult.Cancel)
                e.Cancel = true;
        }
        void save()
        {
            StreamWriter swDom = new StreamWriter("DomainesList.xml");
            StreamWriter swStaff = new StreamWriter("StaffList.xml");
            StreamWriter swAuteur = new StreamWriter("AuteurList.xml");
            try
            {
                XmlSerializer xsDom = new XmlSerializer(typeof(List<Domain>));
                XmlSerializer xsStaff = new XmlSerializer(typeof(List<Staff>));
                XmlSerializer xsAuteur = new XmlSerializer(typeof(List<Auteur>));                

                xsDom.Serialize(swDom, Program.l_dom);
                xsStaff.Serialize(swStaff, Program.LStaff);
                xsAuteur.Serialize(swAuteur, Program.lstAut);

                swAuteur.Flush();
                swDom.Flush();
                swStaff.Flush();

                MessageBox.Show("Sauvgarde faite avec succes ", "Sauvgarde", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erreur lors de la sauvgarde!! "+ex.Message, "SauvgardeErreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                swAuteur.Close();
                swDom.Close();
                swStaff.Close();
            }
        }

        void load()
        {
            if (File.Exists("DomainesList.xml") && File.Exists("StaffList.xml") && File.Exists("AuteurList.xml"))
            {
                StreamReader swDom = new StreamReader("DomainesList.xml");
                StreamReader swStaff = new StreamReader("StaffList.xml");
                StreamReader swAuteur = new StreamReader("AuteurList.xml");


                try
                {
                    XmlSerializer xsDom = new XmlSerializer(typeof(List<Domain>));
                    XmlSerializer xsStaff = new XmlSerializer(typeof(List<Staff>));
                    XmlSerializer xsAuteur = new XmlSerializer(typeof(List<Auteur>));

                    Program.LStaff = (List<Staff>)xsStaff.Deserialize(swStaff);
                    Program.lstAut = (List<Auteur>)xsAuteur.Deserialize(swAuteur);
                    Program.l_dom = (List<Domain>)xsDom.Deserialize(swDom);

                    var s = Program.LStaff.Count != 0 ? Program.LStaff.Last() : null;
                    var dom = Program.l_dom.Count != 0 ? Program.l_dom.Last() : null;
                    var t = dom != null && dom.LstT.Count != 0 ? dom.LstT.Last() : null;
                    var doc = t != null && t.LstD.Count != 0 ? t.LstD.Last() : null;
                    var a = Program.lstAut.Count != 0 ? Program.lstAut.Last() : null;

                    Staff.NextId = s != null ? s.Id : 0;
                    Domain.NextID = dom != null ? dom.Id : 0;
                    Theme.NextID = t != null ? t.Id : 0;
                    Doc.NextID = doc != null ? doc.Id : 0;
                    Auteur.LastId = a != null ? a.Id : 0;
                    
                    
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.GetType() + ex.Message, "SauvgardeErreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    swAuteur.Close();
                    swDom.Close();
                    swStaff.Close();
                }
            }
        }

    }
}
