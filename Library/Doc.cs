using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Doc
    {
        int id;
        string titre;
        DateTime datePub;
        int nbrPages;
        Auteur auteur;
        string type;
        static string [] types = { "Rapport", "Livre", "Article" };
        static int cpt;
        public Doc()
        {

        }
        public Doc(string titre, DateTime datePub, int nbrPages,Auteur auteur,string type)
        {
            id = ++Doc.cpt;
            Titre = titre;
            DatePub = datePub;
            NbrPages = nbrPages;
            Auteur = auteur;
            Type = type;
        }

        public int Id { get => id; set => id = value; }
        public static int NextID { get => cpt + 1; set => cpt = value; }
        public string Titre { get => titre; set
            {
                if (value == "")
                    throw new Exception("Le titre ne peut pas être vide");
                else
                    titre = value;
            }
        }
        public DateTime DatePub { get => datePub; set
            {
                if (value >= DateTime.Today)
                    throw new Exception("La date de publication n'est pas valide");
                else
                    this.datePub = value;
            }
        }
        public int NbrPages { get => nbrPages; set => nbrPages = value; }
        internal Auteur Auteur { get => auteur; set => auteur = value; }
        public string Type { get => type; set
            {
                if (value == "")
                    throw new Exception("Le type ne peut pas être vide");
                else
                    type = value;
            }
        }

        public static string[] Types { get => types; set => types = value; }
    }
}
