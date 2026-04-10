using CL_RegleDeControle;
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
using static System.Net.Mime.MediaTypeNames;

namespace WFValidationSaisie
{
    public partial class FormValidationSaisie : Form
    {
        public FormValidationSaisie()
        {
            InitializeComponent();


        }

        private void FormValidationSaisie_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                                "Fin de l'application",
                                "FIN",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);

            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string donnees = "";

            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                Control ctrl = this.Controls[i];

                //jms comparer texte car parfois on modifie en un endroit et c'est pas pris en compte partout

                if (ctrl.Name == this.txtNom.Name || (ctrl.Name == "txtDate") || (ctrl.Name == "txtMontant") || (ctrl.Name == "txtCP"))
                {
                    donnees += ctrl.Tag + " : " + ctrl.Text + "\n";     //utilisation du Tag (entrer la valeur qu'on veut afficher avec la données dans les propriété)
                }
            }

            string errors = "";

            if (!BoiteAOutilsDeRegles.IsNameValid(txtNom.Text))
            {
                errors += "La saisie du nom n'est pas valide. \n";
            }

            if (!BoiteAOutilsDeRegles.IsFormatDateValid(txtDate.Text, out DateTime dateOutput))
            {
                errors += "La saisie de la date n'est pas valide \n";
            }
            
            if (!BoiteAOutilsDeRegles.IsMontantValid(txtMontant.Text, out decimal montantOutput))
            {
                errors += "La saisie du montant n'est pas valide \n";
            }
            
            if (!BoiteAOutilsDeRegles.IsCPValid(txtCP.Text))
            {
                errors += "La saisie du code postal n'est pas valide";
            }

            if (errors == String.Empty)
            {
                MessageBox.Show(
                        donnees,
                        "Validation effectuée",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show(
                             errors,
                             "Erreurs",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error);
            }        

        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            txtNom.Clear();
            txtDate.Clear();
            txtMontant.Clear();
            txtCP.Clear();
        }
    }
}
