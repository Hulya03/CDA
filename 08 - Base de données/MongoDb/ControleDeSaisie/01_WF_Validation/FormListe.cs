using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _01_CL_Achat;
using _01_CL_Api_Client;


namespace _01_WF_Validation
{
    public partial class FormListe : Form
    {
        private List<Achat> achats;
        public FormListe()
        {
            achats = new();
            InitializeComponent();
            //this.Load += Form_Load;       ligne a ajouter si on arrive pas le faire automatiquement 
        }

        private async void FormListe_Load(object sender, EventArgs e)
        {
            achats = await ApiClient.GetAchatsAsync();    //? = potentionnelement le résulat peut etre nul
        
            bindingSource1.DataSource = achats;             // permet de creer les colonnes...

            dataGridView1.DataSource = bindingSource1;

            // Ne pas afficher la premiere colonne
            dataGridView1.Columns[0].Visible = false;

            // Changer le nom de la colonne
            dataGridView1.Columns[1].HeaderText = "isim";

            dataGridView1.CellDoubleClick += Cell_DoubleClick;
        
        }

        public async void Cell_DoubleClick(object? sender, EventArgs args)
        {
            
        }
    }
}
