using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Auteur
    {
        int id;
        string nom;
        DateTime dateNaiss;
        static int cpt;
        List<Doc> listDoc = new List<Doc>();

        public Auteur()
        {
                
        }
        public Auteur(string nom, DateTime dateNaiss)
        {
            id = ++Auteur.cpt;
            Nom = nom;
            DateNaiss = dateNaiss;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set
            {
                if (value == "")
                    throw new Exception("Le nom ne peut pas être vide");
                else
                    nom = value.ToUpper();
            }
        }
        public DateTime DateNaiss { get => dateNaiss; set
            {
                if (value > DateTime.Today)
                    throw new Exception("La date de naissance est fausse");
                else
                    dateNaiss = value;
            }
        }
        public static int LastId { get => cpt+1 ; set => cpt = value; }
        public List<Doc> ListDoc { get => listDoc; set => listDoc = value; }
        public int age
        {
            get {
                int age = DateTime.Today.Year - DateNaiss.Year;
                if (DateTime.Today.DayOfYear < DateNaiss.DayOfYear)
                    age -= 1;
                return age;
            }
        }
        public int nbrDocs { get => listDoc.Count; }
    }
}
