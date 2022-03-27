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
    public partial class ListStagiaire : Form
    {
        public ListStagiaire()
        {
            InitializeComponent();
        }

        Stagiaire stagiaire = new Stagiaire();
        private void ListStagiaire_Load(object sender, EventArgs e)
        {
           var listStagiaire = stagiaire.AfficherStagiaires();
           var binding = new BindingList<Stagiaire>(listStagiaire);
           var source = new BindingSource(binding, null);
           dataGridView1.DataSource = source;


        }
    }
}
