using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Theme
    {
        int id;
        string nom;
        static int cpt;
        List<Doc> lstD = new List<Doc>();
        public Theme()
        {

        }
        public Theme(string nom)
        {
            id = ++Theme.cpt;
            Nom = nom;
        }
        public int Id { get => id; set => id = value; }
        public static int NextID { get => cpt + 1; set => cpt = value; }
        public string Nom
        {
            get => nom; set
            {
                if (value == "")
                    throw new Exception("Le nom ne peut pas être vide");
                else
                    nom = value;
            }
        }
        public List<Doc> LstD { get => lstD; set => lstD = value; }
        public int TotalDocs { get => lstD.Count; }
    }
}
