using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsControlUserControls
{
    public partial class UC_DisBonjour : UserControl
    {
        private string nomDestinataire;


        public string NomDestinataire
        {
            get { return nomDestinataire; }
            set { nomDestinataire = value; }
        }


        //2 autres notations des accesseurs et modifieurs :

        //public string NomDestinataire { get => nomDestinataire; set => nomDestinataire = value; }

        //public string NomDestinataire { get; set; } //on donne plus l'attribue

        private static readonly object s_textEvent = new object();

        public event EventHandler? NomIdentified;
        /*{
            add => Events.AddHandler(s_textEvent, value);
            remove => Events.RemoveHandler(s_textEvent, value);
        }*/

        public UC_DisBonjour()
        {
            InitializeComponent();
        }

        private void textBoxReponseNom_TextChanged(object sender, EventArgs e)
        {
            if (this.textBoxReponseNom.Text.Equals(nomDestinataire))
            {
                this.BackColor = Color.Blue;
                //génère évènement si qqn s'est enregistré sur l'évènement 
                if (NomIdentified != null)   
                {

                    NomIdentified(this, new EventArgs());
                }
            }
        }
    }
}
