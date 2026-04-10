using CL_Emprunt;
using System.Globalization;
using System.Security.Claims;
using System.Text.RegularExpressions;

namespace WFEmprunts
{
    public partial class FormEmprunts : Form
    {
        //instancier un objet 
        Emprunt emprunt = new Emprunt();        // maintenant que mon objet est instancié, j'ai acces à ses attributs et ses opérations
                                                // faire cette instanciation en dehors de toute fonction, pour que'il soir acessible à tout
        public FormEmprunts()
        {
            InitializeComponent();
        }


        private void FormEmprunts_Load(object sender, EventArgs e)
        {
            textBoxNom.Focus();

            radioButton7.Checked = true;
            textBoxDureeMoisRemb.Text = "1";
            labelNbRemb.Text = "1";

            listBoxPeriodicite.Items.Add("Mensuelle");
            listBoxPeriodicite.Items.Add("Bimestrielle");
            listBoxPeriodicite.Items.Add("Trimestrielle");
            listBoxPeriodicite.Items.Add("Semestrielle");
            listBoxPeriodicite.Items.Add("Annuelle");

            listBoxPeriodicite.SelectedIndex = 0;

            //ActualisationPret();
        }


        private void ActualisationPret()
        {
            //Récupération capital
            string pattern = @"^[0-9]+$";

            try
            {
                if(string.IsNullOrEmpty(textBoxCapEmprunte.Text))
                {
                    errorProviderCapital.Clear();
                    emprunt.CapitalEmprunte = 0;

                }
                else if (!Regex.IsMatch(textBoxCapEmprunte.Text, pattern))
                {
                    
                    errorProviderCapital.SetError(textBoxCapEmprunte, "saisie lettre non autorisée");
                    emprunt.CapitalEmprunte = 0;
                }
                else
                {
                    errorProviderCapital.Clear();
                    emprunt.CapitalEmprunte = int.Parse(textBoxCapEmprunte.Text);          //on parse le string en int 
                }
            }
            catch 
            {
                errorProviderCapital.SetError(textBoxCapEmprunte, "saisie capital emprunté incorrect");
            }

            // Variation du taux
            if (radioButton7.Checked)
            {
                emprunt.Taux = 0.07;
            }
            else if (radioButton8.Checked)
            {
                emprunt.Taux = 0.08;
            }
            else if (radioButton9.Checked)
            {
                emprunt.Taux = 0.09;
            }


            // Variation de la periodicité

            switch (listBoxPeriodicite.SelectedIndex)
            {
                case 1:
                    emprunt.Periodicite = 2;
                    break;
                case 2:
                    emprunt.Periodicite = 3;
                    break;
                case 3:
                    emprunt.Periodicite = 6;
                    break;
                case 4:
                    emprunt.Periodicite = 12;
                    break;
                default:
                    emprunt.Periodicite = 1;
                    break;
            }

            //réglage des pas 

            hScrollBarDureeMoisRemb.Minimum = emprunt.Periodicite;
            hScrollBarDureeMoisRemb.SmallChange = emprunt.Periodicite;
            hScrollBarDureeMoisRemb.LargeChange = emprunt.Periodicite;

            if (hScrollBarDureeMoisRemb.Value % emprunt.Periodicite != 0)
            {
                hScrollBarDureeMoisRemb.Value = hScrollBarDureeMoisRemb.Value - (hScrollBarDureeMoisRemb.Value % emprunt.Periodicite) ;   //si le modulo fait des restes, on descend au multiple inferieur en enlevant le reste
            }

            //Variation de la duree de remboursement

            emprunt.DureeMoisRemb = hScrollBarDureeMoisRemb.Value;
            textBoxDureeMoisRemb.Text = emprunt.DureeMoisRemb.ToString();

            //maJ des textxBox donc affichage des résultats du nombre de remboursement et du capital 

            labelNbRemb.Text = emprunt.CalculNbRemboursement().ToString();
            labelMontantRemb.Text = emprunt.CalculerMensualite().ToString("C", CultureInfo.CurrentCulture);    //permet d'utiliser la monnaie et le nombre de digit apres la virgule, enregistré dans le système d'exploitation

        }

        private void hScrollBarDureeMoisRemb_Scroll(object sender, ScrollEventArgs e)
        {

            ActualisationPret();
        }

        private void listBoxPeriodicite_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualisationPret();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            ActualisationPret();
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            ActualisationPret();
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            ActualisationPret();
        }

        private void textBoxCapEmprunte_TextChanged(object sender, EventArgs e)
        {
            ActualisationPret();
        }
    }
}
