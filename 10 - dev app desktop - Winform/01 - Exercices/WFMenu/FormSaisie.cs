using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFCheckBoxBoutonRadio;


namespace WFMenu
{
    public partial class FormSaisie : Form
    {
        public FormSaisie()
        {
            InitializeComponent();
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            string texteSaisi = textBoxSaisieTexte.Text;
            FormCheckBoxBoutonRadio formCheckBoxBoutonRadio = new FormCheckBoxBoutonRadio(texteSaisi);
            formCheckBoxBoutonRadio.MdiParent = this.MdiParent;                                 //attention le conteneur Mdi est formMenu qui est le parent de "this" càd de formSaisi
            this.Close();                                                                       //attention : ne pas fermer formSaisie avant de d'assigner le mdiParent car on passe par lui par le designer
            formCheckBoxBoutonRadio.Show();
        }

        private void textBoxSaisieTexte_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSaisieTexte.Text != string.Empty)
            {
                buttonValider.Enabled = true;
            }else
            {
                buttonValider.Enabled = false;
            }
        }
    }
}
