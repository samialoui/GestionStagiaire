using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStagiaire
{
    class Stagiaire
    {
        public int NumInsc { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public double Note1 { get; set; }
        public double Note2 { get; set; }
        public double Moyenne { get; set; }

        public Stagiaire()
        {

        }

        public static List<Stagiaire> listStagiaire = new List<Stagiaire>();
      

        public Stagiaire(int NumInsc, string Nom, string Prenom, double Note1, double Note2, double Moyenne)
        {
            this.NumInsc = NumInsc;
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.Note1 = Note1;
            this.Note2 = Note2;
            this.Moyenne = Moyenne;
        }

        public List<Stagiaire> AfficherStagiaires()
        {
            return listStagiaire;
        }

        public bool Chercher(int numIns)
        {
            bool isSuccess = false;
            var val = listStagiaire.FirstOrDefault(p => p.NumInsc == numIns);
            if(val != null)
            {
                isSuccess = true;
            }
            else
            {
                isSuccess = false;
            }
            return isSuccess;

        }
        public double CalculMoy(double note1,double note2)
        {
            return (note1 + note2) / 2;
        }

        public void Ajouter(Stagiaire s)
        {

            listStagiaire.Add(s);
        }
    }
}
