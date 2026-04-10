using CL_Achat;
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
using WFNouvelleFenetre; 

namespace WFValidationSaisieEP            //Version avec utilisation de "errorProvider"
{
    public partial class FormValidationSaisieEP : Form
    {
        public FormValidationSaisieEP()
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
            if(this.ValidateChildren())                                 //"Filet de Sécurité" de ValidateChildren() =rôle de "Filet de Sécurité"
                                                                        // Quand on appelle this.ValidateChildren() dans le clic du bouton :
                                                                        //- Le formulaire parcourt tous ses contrôles (Nom, Date, Montant, CP)
                                                                        //- Il force l'exécution de chaque méthode _Validating associée
                                                                        //- Si l'une de ces méthodes contient e.Cancel = true, alors ValidateChildren() renverra false
            {

                // Si on est ici, c'est que TOUT est valide. 
                // 1. on fait les vraies conversions pour l'objet.
                // 2. création de l'objet : 

                //txtNom et TxtCP sont du type string donc on peut les prendre tel quel, alors pour la date et le montant, le constructeur demande un dateTime etun decimal
                //donc on fait une conversion : 

            BoiteAOutilsDeRegles.IsFormatDateValid(txtDate.Text, out DateTime dateOutput);
            BoiteAOutilsDeRegles.IsMontantValid(txtMontant.Text, out decimal montantOutput);

            Achat achat1 = new Achat(txtNom.Text, dateOutput, montantOutput, txtCP.Text);

               // 3.instancier nouvelle fenetre 
               // 4. afficher 

            FormNouvelleFenetre maNouvelleFenetre = new FormNouvelleFenetre(achat1);

            DialogResult dr = maNouvelleFenetre.ShowDialog();
            }
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            txtNom.Clear();
            txtDate.Clear();
            txtMontant.Clear();
            txtCP.Clear();

            //Dû à l'utilisation de _validating, puisque j'ai mis e.Cancel=true, j'interdis au focus de sortir du controle ou il y a l'erreur
            // j'ai donc changé la propriété CausesValidation du bouton annulé, j'ai mis à false. Windows ne déclenche plus l'évènement validating 
            //je peux donc cliquer sur un autre bouton meme si un champs est vide ou faux 

            errorProviderCP.Clear();
            errorProviderDate.Clear();
            errorProviderMontant.Clear();
            errorProviderNom.Clear();
        }

        protected override void WndProc(ref Message m)
        /*WndProc (pour Windows Procedure) est la fonction "cerveau" d'une fenêtre Windows. 
         * Chaque action effectuée sur une fenêtre (clic, déplacement, touche clavier, fermeture) envoie un Message numérique au système. 
         * Ce code intercepte ces messages avant qu'ils ne soient traités par le comportement par défaut de Windows Forms.*/
        {
            if (m.Msg == 0x10)  // Le nombre hexadécimal 0x10 correspond au message système WM_CLOSE. Ce message est envoyé spécifiquement quand :

            //L'utilisateur clique sur la croix rouge (X) en haut à droite.
            {
                AutoValidate = AutoValidate.Disable; //Desactive toutes les validations 
            }
            base.WndProc(ref m);
        }

        /*
         * Résumé du fonctionnement
        L'utilisateur clique sur le X.

        Le message 0x10 arrive dans la méthode.

        Le code coupe la sécurité de validation (AutoValidate.Disable).

        Le programme continue sa fermeture normalement, sans être bloqué par le focus de txtAge.
        */


        /*
        c'est donc unr interception du message 0x10 (WM_CLOSE) pour désactiver la validation : 
        C'est une solution pour éviter un bug classique où l'utilisateur ne peut pas fermer la fenêtre 
        parce qu'un champ est invalide (le fameux "Je suis coincé dans le champ Nom !").

        Une alternative plus simple au WndProc ?
        pour le bouton "Annuler" ou la croix rouge, 
        on peut aussi mettre la propriété CausesValidation = false sur le bouton "Annuler"
        pour qu'il ignore les erreurs de saisie. Mais l'approche via WndProc est très robuste.
         */

        private void txtNom_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (!BoiteAOutilsDeRegles.IsNameValid(txtNom.Text))
                {
                    e.Cancel = true;                                          // annule la demande de changement de focus le temps de la validation
                                                                              // On reste bloqué dans la champs s'il y a une erreur
                    errorProviderNom.SetError(txtNom, "Saisie nom invalide");

                }
                else
                {
                    errorProviderNom.SetError(txtNom, "");
                }
            }
            catch
            {
                e.Cancel = true;
                errorProviderNom.SetError(txtNom, "Saisie invalide");
            }

        }

        private void txtDate_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (!BoiteAOutilsDeRegles.IsFormatDateValid(txtDate.Text, out DateTime dateOutput))
                {
                    e.Cancel = true;
                    errorProviderDate.SetError(txtDate, "Saisie date invalide");

                }
                else
                {
                    errorProviderDate.SetError(txtDate, "");
                }
            }
            catch
            {
                e.Cancel = true;
                errorProviderDate.SetError(txtDate, "Saisie invalide");
            }
        }

        private void txtMontant_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (!BoiteAOutilsDeRegles.IsMontantValid(txtMontant.Text, out decimal montantOutput))
                {
                    e.Cancel = true;
                    errorProviderMontant.SetError(txtMontant, "Saisie montant invalide");

                }
                else
                {
                    errorProviderMontant.SetError(txtMontant, "");
                }
            }
            catch
            {
                e.Cancel = true;
                errorProviderMontant.SetError(txtMontant, "Saisie invalide");
            }
        }

        private void txtCP_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (!BoiteAOutilsDeRegles.IsCPValid(txtCP.Text))
                {
                    e.Cancel = true;
                    errorProviderCP.SetError(txtCP, "Saisie CP invalide");

                }
                else
                {
                    errorProviderCP.SetError(txtCP, "");
                }
            }
            catch
            {
                e.Cancel = true;
                errorProviderCP.SetError(txtCP, "Saisie invalide");
            }
        }
    }
}
