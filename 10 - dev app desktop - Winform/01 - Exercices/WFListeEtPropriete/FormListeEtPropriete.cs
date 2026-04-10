using System.Text.RegularExpressions;

namespace WFListeEtPropriete
{
    public partial class FormListeEtPropriete : Form
    {
        //private List<string> prenom;       //déclaration Liste = "ouverture d'une case mémoire"   //pas besoin car j'ai utilisé directement listBox 
        public FormListeEtPropriete()
        {
            InitializeComponent();
            //prenom = new List<string>();    //instanciaton obligatoire sinon par référence l'intérieur est "null"
        }


        //pour ajouter du texte en appuyant le bouton 'Ajout Liste'
        private void buttonAjouterListe_Click(object sender, EventArgs e)
        {
            string patternPasDespace = @"^\S.*\S$";

            try
            {
                if(!Regex.IsMatch(textBoxNouvelElement.Text,patternPasDespace))
                {
                    ePPasDespace.SetError(textBoxNouvelElement, "tout caractère accepté sauf espace en début et fin ");
                    textBoxNouvelElement.Focus();
                }
                else if (lbxElement.Items.Contains(textBoxNouvelElement.Text))
                {
                    ePDoublon.SetError(textBoxNouvelElement, "Ce nom existe déjà");
                    textBoxNouvelElement.Focus();
                }
                else if (!string.IsNullOrEmpty(textBoxNouvelElement.Text))                              //vérification si vide puis ajout d'élément
                {
                    lbxElement.Items.Add(textBoxNouvelElement.Text);
                    textBoxNouvelElement.Clear();
                    textBoxItemsCount.Text = lbxElement.Items.Count.ToString();             //mise à jour du compteur 

                    if (lbxElement.Items.Count == 0)                                       //changement des accessibilités des boutons en fonction de la valeur du compteur 
                    {
                        buttonViderListe.Enabled = false;
                        textBoxIndexElement.Enabled = false;
                    }
                    else
                    {
                        buttonViderListe.Enabled = true;
                        textBoxIndexElement.Enabled = true;
                        textBoxNouvelElement.Focus();
                    }
                }
                else
                {
                    ePDoublon.SetError(textBoxNouvelElement, "");                           //on remet à zéro l'error provider
                    ePPasDespace.Clear();
                }
            }
            catch
            {
                ePDoublon.SetError(textBoxNouvelElement, "Saisie nom invalide");                // utile pour gérer des erreurs qu'on aurait oublier
            }
        }

        //gestion de l'activation et de la désactivation du bouton 'Ajouter Liste'
        private void textBoxNouvelElement_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxNouvelElement.Text))
            {
                ePDoublon.Clear();                                                              //effacer le signe erreur quand le texte est modifié
                buttonAjouterListe.Enabled = true;
            }
            else
            {
                buttonAjouterListe.Enabled = false;
            }
        }


        //se déclenche quand un utilisateur clique sur un élément de la liste
        private void lbxElement_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxSelectedIndex.Text = lbxElement.SelectedIndex.ToString();
            textBoxTextSelectionne.Text = lbxElement.Text.ToString();
            textBoxIndexElement.Clear();
        }

        //permet de sélectionner un élément de la liste par son index
        private void buttonSelectionner_Click(object sender, EventArgs e)
        {
            try
            {
                int index = int.Parse(textBoxIndexElement.Text);

                if (index < 0 || index > lbxElement.Items.Count )
                {
                    ePIndexNonAutorise.SetError(textBoxIndexElement, "index invalide : il doit être compris entre 0 et nombre d'éléments moins 1 inclus");
                    textBoxIndexElement.Focus();

                }else
                {
                    lbxElement.SelectedIndex = index;
                    textBoxIndexElement.Focus();
                    ePIndexNonAutorise.Clear();
                }
            }
            catch 
            {
                ePIndexNonAutorise.SetError(textBoxIndexElement, "saisie non Valide");
                textBoxIndexElement.Focus();
            }
        }

        //active ou désactive le bouton de sélection 
        private void textBoxIndexElement_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxIndexElement.Text))
            {
                buttonSelectionner.Enabled = false;
            }
            else
            {
                ePIndexNonAutorise.Clear();
                buttonSelectionner.Enabled = true;
            }
        }

        //réinitialiser les champs 
        private void buttonViderListe_Click(object sender, EventArgs e)
        {
            lbxElement.Items.Clear();
            textBoxItemsCount.Text = "0";
            textBoxSelectedIndex.Clear();
            textBoxTextSelectionne.Clear();
            textBoxIndexElement.Clear();


            if (lbxElement.Items.Count == 0)
            {
                buttonViderListe.Enabled = false;
            }
            else
            {
                buttonViderListe.Enabled = true;
            }
        }
    }
}
