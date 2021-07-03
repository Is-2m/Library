using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public static class Program
    {
        public static List<Staff> LStaff = new List<Staff>();
        public static List<Domain> l_dom = new List<Domain>();
        public static List<Auteur> lstAut = new List<Auteur>();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]        
        static void Main()
        {
            //lstAut.Add(new Auteur("Saul Nelson", new DateTime(1980, 04, 11)));
            //lstAut.Add(new Auteur("R.Anderson John", new DateTime(1947, 05, 23)));
            //lstAut.Add(new Auteur("T.Beck Aaron", new DateTime(1921, 08, 7)));
            //lstAut.Add(new Auteur("Siri Driessen", new DateTime(1987, 12, 17)));

            //l_dom.Add(new Domain("Chemistry"));
            //l_dom[0].LstT.Add(new Theme("Analytical Chemistry"));
            //l_dom[0].LstT.Add(new Theme("Biochemistry"));
            //l_dom[0].LstT.Add(new Theme("Catalysis"));
            //l_dom[0].LstT.Add(new Theme("Chemical Engineering"));
            //l_dom[0].LstT.Add(new Theme("Computational Chemistry & Molecular Modelling"));
            //l_dom[0].LstT.Add(new Theme("Environmental Chemistry"));

            //l_dom.Add(new Domain("Art & Applied"));
            //l_dom[1].LstT.Add(new Theme("Art & Photography"));
            //l_dom[1].LstT.Add(new Theme("Clothing & Fashion"));
            //l_dom[1].LstT.Add(new Theme("Museum & Heritage Studies"));

            //l_dom.Add(new Domain("Psychology"));
            //l_dom[2].LstT.Add(new Theme("Applied Psychology"));
            //l_dom[2].LstT.Add(new Theme("General Psychology"));
            //l_dom[2].LstT.Add(new Theme("Personality & Individual Differences"));
            //l_dom[2].LstT.Add(new Theme("Social Psychology"));
            //l_dom[2].LstT.Add(new Theme("Clinical Psychology"));
            //l_dom[2].LstT[4].LstD.Add(new Doc("Doc1", new DateTime(2005, 05, 16), 16, lstAut[0], "test"));
            //l_dom[2].LstT[4].LstD.Add(new Doc("Doc2", new DateTime(2005, 05, 16), 16, lstAut[2], "test"));
            //l_dom[2].LstT[4].LstD.Add(new Doc("Doc3", new DateTime(2005, 05, 16), 16, lstAut[3], "test"));
            //l_dom[2].LstT[4].LstD.Add(new Doc("Doc4", new DateTime(2005, 05, 16), 16, lstAut[1], "test"));



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Menu());
        }
    }
}
