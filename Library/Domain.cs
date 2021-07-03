using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Domain
    {
        int id;
        string nom;
        static int cpt;
        List<Theme> lstT = new List<Theme>();

        public Domain( string nom)
        {
            id = ++Domain.cpt;
            Nom = nom;
        }
        public Domain()
        {

        }
        public int Id { get => id; set => id = value; }
        public static int NextID { get => cpt + 1; set => cpt = value; }
        public string Nom { get => nom; set
            {
                if (value == "")
                    throw new Exception("Le nom ne peut pas être vide");
                else
                    nom = value;
            }
        }
        public List<Theme> LstT { get => lstT; set => lstT = value; }
        public int TotalThemes
        {
            get { return lstT.Count; }
        }
        public int TotalDocs
        {
            get
            {
                int res = 0;
                foreach (var doc in LstT)
                {
                    res += doc.LstD.Count;
                }
                return res;
            }
        }
        
    }
}
