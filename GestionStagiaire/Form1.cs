using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionStagiaire
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
        private void textMoy_TextChanged(object sender, EventArgs e)
        {
           
        }
        Stagiaire stagiaire = new Stagiaire();
      
        private void btnAjout_Click(object sender, EventArgs e)
        {

            int numIns = int.Parse(textNum.Text);
            string nom = textNom.Text;
            string prenom = textPre.Text;
            double note1 = double.Parse(textNote1.Text);
            double note2 = double.Parse(textNote2.Text);
            double Moyenne = stagiaire.CalculMoy(note1, note2);
            if (textNote1.Text != "" && textNote2.Text != "")
            {
                textMoy.Text = Moyenne.ToString();
            }
            else
            {
                MessageBox.Show("Veuillez saisie les deux notes!!");
            }
            bool trouvé = stagiaire.Chercher(numIns);
            if (trouvé == true)
            {
                MessageBox.Show("Il existe le meme numéro d'inscription ,Veuillez réssayer avec d'autre numéro..","Erreur Saisie",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                Stagiaire st = new Stagiaire(numIns, nom, prenom, note1, note2, Moyenne);
                stagiaire.Ajouter(st);
            }

        }

        private void btnAff_Click(object sender, EventArgs e)
        {
            using(ListStagiaire lst = new ListStagiaire()) {
                lst.ShowDialog();
            }
        }

        private void btnQui_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
