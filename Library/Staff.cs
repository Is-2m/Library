using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Staff
    {
        int id;
        string username;
        string password;
        string nom;
        string prenom;
        static int cpt;

        public Staff()
        {

        }

        
        public Staff(string nom, string prenom, string username, string password)
        {
            id = ++Staff.cpt;
            Nom = nom;
            Prenom = prenom;            
            Username = username;
            Password = password;
        }

        public string Username { get => username; set
            {
                if (value == "")
                    throw new Exception("le champ du nom d'utilisateur ne peut pas être laissé vide!!");
                else
                    this.username = value;
            }
        }

        public string Password { get => password;   
            set{
                if (value == "")
                    throw new Exception("le champ du nom de mot de passe ne peut pas être laissé vide!!");
                else
                    this.password = value;
            }
        }
        public string Prenom
        {
            get => prenom; set
            {
                if (value == "")
                    throw new Exception("le champ de prenom ne peut pas être laissé vide!!");
                else
                    this.prenom = value;
            }
        }
        public string Nom
        {
            get => nom;
            set
            {
                if (value == "")
                    throw new Exception("le champ de nom ne peut pas être laissé vide!!");
                else
                    this.nom = value;
            }

        }

        public bool Tologin(string username,string password)
        {
            if (this.Username == username && this.Password == password) 
                return true;
            else
                return false;
        }        
        
        public int Id { get => id; set => id = value; }
        public static int NextId { get => cpt + 1; set => cpt = value; }


        //---------------useless for now---------------------------------------------------------------------

        private static string encrypt(string word) //kinda good for encrypting but the problem is that evrey time the xml file get loaded to the datebase (The Lists
        {                                          // I made in Programe class) the passwords gots encrypted again and again with no stop, and if i used the decrypting 
            List<int> lst = new List<int>();       // method in the get property the whole process becomes meaningless cuz th stored pass in the xml file will
                                                   // becomes visible and readable som i still have to think of a way to make it useful
            foreach (var c in word)
            {
                int i = (int)c;
                lst.Add(i * 1000 + 15);
            }
            List<char> s = new List<char>();
            foreach (var i in lst)
            {
                s.Add((char)i);
            }
            string S = new string(s.ToArray());
            return S;
        }
        static string decrypt(string word)
        {
            List<int> lst = new List<int>();
            foreach (var c in word)
            {
                int i = (int)c;
                lst.Add((i - 15) / 1000);
            }
            List<char> s = new List<char>();
            foreach (var i in lst)
            {
                s.Add((char)i);
            }
            string S = new string(s.ToArray());
            return S;
        }
    }
}
