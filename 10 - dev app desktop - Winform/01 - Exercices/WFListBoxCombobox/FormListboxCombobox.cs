using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace WFListBoxCombobox
{
    public partial class FormListboxCombobox : Form
    {
        public FormListboxCombobox()
        {
            InitializeComponent();
        }

        List<string> paysSource = new List<string>();                               //déclaration d'une liste
        List<string> paysCible = new List<string>();

        // au moment du chargement de la fenêtre
        private void FormListboxCombobox_Load(object sender, EventArgs e)          
        {
            paysSource.Add("France");                                              //remplissage de la liste
            paysSource.Add("Belgique");
            paysSource.Add("Japon");
            paysSource.Add("Portugal");
            paysSource.Add("Grèce");
            paysSource.Add("Bulgarie");
            paysSource.Add("Espagne");

            //association de la liste à la comboliste

            foreach (string valeurs in paysSource)
            {
                comboBoxSource.Items.Add(valeurs);
            }

            actualiserListes();
        }

        // Dropdown = affiche la partie déroulante d'un combobox et permet d'ajouter des éléments dans liste en cliquand sur la fleche déroulante
        private void comboBoxSource_DropDown(object sender, EventArgs e)
        {
            string patternEspaceEnDebutOuFin = @"^\s|\s$";                                              //pattern pour interdire espace au début et à la fin 

            if (Regex.IsMatch(comboBoxSource.Text, patternEspaceEnDebutOuFin) || String.IsNullOrEmpty(comboBoxSource.Text))
            {
                ePPresenceEspaceDebutFin.SetError(comboBoxSource, "Saisie vide Ou Espace en début ou fin non accepté");
            }
            else if (paysSource.Contains(comboBoxSource.Text, StringComparer.OrdinalIgnoreCase)
                     ||
                     paysCible.Contains(comboBoxSource.Text, StringComparer.OrdinalIgnoreCase))         // permet de comparer en ignorant la casse
            {
                ePDoublon.SetError(comboBoxSource, "Ce nom existe déja");
            }
            else
            {
                ePPresenceEspaceDebutFin.Clear();
                ePDoublon.Clear();
                paysSource.Add(comboBoxSource.Text);                                    //ajout dans la liste
                comboBoxSource.Items.Add(comboBoxSource.Text);                          //ajout dans l'affichage de la liste déroulante
            }
            actualiserListes();
        }

        //évènement déclenché quand le contenu de comboBox change
        private void comboBoxSource_TextChanged(object sender, EventArgs e)
        {
            string patternEspaceEnDebutOuFin = @"^\s|\s$";

            if (Regex.IsMatch(comboBoxSource.Text, patternEspaceEnDebutOuFin))
            {
                ePPresenceEspaceDebutFin.SetError(comboBoxSource, "Espace en début ou fin non accepté");
            }
            else
            {
                ePPresenceEspaceDebutFin.Clear();
            }
        }

        //évènement déclenché quand changement d'index dans comboBox
        private void comboBoxSource_SelectedIndexChanged(object sender, EventArgs e)                // SelectedIndexChanged : utilisé pour détecter quand un utilisateur change la sélection dans une ComboBox
        {
            actualiserBoutons();
        }

        //évènement déclenché quand changement d'index dans la listBox
        private void listBoxCible_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualiserBoutons();
        }

        //pour ajouter les éléments un par un vers les pays cibles
        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            string paysSelectionne = comboBoxSource.SelectedItem.ToString();   // nom du pays s"lectionné dan comboBox
            int index = comboBoxSource.SelectedIndex;                          // index actuel de l'élément selectionné

            paysCible.Add(paysSelectionne);                                    //Ajout dans pays cible
            paysSource.Remove(paysSelectionne);                                //supression de la liste paysSource
            actualiserListes();                                                // faire attention a l'endroit où on actualise, celà son importance 

            //verifier si l'ancien index est maintnant hors des limites de la liste, cela peut arriver si on commence à supprimer par la fin de la liste 
            if (index + 1 > comboBoxSource.Items.Count)                 
            {
                index = comboBoxSource.Items.Count - 1;                     //permet de prendre le dernier de la liste car on repositionne l'index sur le dernier élément

            }

            comboBoxSource.SelectedIndex = index;                           //permet de mettre la sélection pour éviter à l'utilisateur de recliquer

            if (comboBoxSource.Items.Count == 0)                            //si liste vide, on efface le texte afficher dans la comboBox
            {
                comboBoxSource.Text = string.Empty;
            }
        }

        //pour ajouter tous les paysSource d'un coup
        private void buttonAjouterTout_Click(object sender, EventArgs e)
        {

            listBoxCible.Items.Clear();
            paysCible.AddRange(paysSource);                         //permet de prendre tout ce qu'il y a dans paysSource et les mettre dans paysCible
            paysSource.Clear();
            comboBoxSource.Items.Clear();
            comboBoxSource.Text= string.Empty;

            foreach (string pays in paysCible)
            {
                listBoxCible.Items.Add(pays);
            }
            actualiserListes();
        }

        //Pour supprimer un élément de la liste cible
        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            string paysSelectionne = listBoxCible.SelectedItem.ToString();
            int index = listBoxCible.SelectedIndex;

            paysSource.Add(paysSelectionne);
            paysCible.Remove(paysSelectionne);
            actualiserListes();


            if (index + 1 > listBoxCible.Items.Count)
            {
                index = listBoxCible.Items.Count - 1;
            }

            listBoxCible.SelectedIndex = index;

        }

        //Pour supprimer tous les éléments de la liste cible
        private void buttonSupprimerTout_Click(object sender, EventArgs e)
        {
            paysSource.AddRange(paysCible);
            paysCible.Clear();
            actualiserListes();
        }

        //pour descendre un élement de la liste cible
        private void buttonDescendre_Click(object sender, EventArgs e)
        {
            int indexActuel = listBoxCible.SelectedIndex;
            string elementSelectionne = paysCible[indexActuel];

            if (indexActuel >= 0)
            {
                paysCible.RemoveAt(indexActuel);
                paysCible.Insert(indexActuel + 1, elementSelectionne);
                actualiserListes();
                listBoxCible.SelectedIndex = indexActuel + 1;
            }
        }

        //pour monter un élement de la liste cible
        private void buttonMonter_Click(object sender, EventArgs e)
        {
            int indexActuel = listBoxCible.SelectedIndex;
            string elementSelectionne = paysCible[indexActuel];

            if (indexActuel > 0)
            {
                paysCible.RemoveAt(indexActuel);                        // Supprime l'élément de sa position actuelle
                paysCible.Insert(indexActuel - 1, elementSelectionne);  // Réinsère l'élément une position plus haut (index actuel moins 1)
                actualiserListes();
                listBoxCible.SelectedIndex = indexActuel - 1;
            }
        }

        //pour actualiser l'accesibilité des boutons
        private void actualiserBoutons()
        {
            if (comboBoxSource.SelectedIndex != -1)
            {
                buttonAjouter.Enabled = true;
            }
            else
            {
                buttonAjouter.Enabled = false;
            }

            if (paysSource.Count > 0)
            {
                buttonAjouterTout.Enabled = true;
            }
            else
            {
                buttonAjouterTout.Enabled = false;
            }

            if (listBoxCible.SelectedIndex >= 0)
            {
                buttonSupprimer.Enabled = true;
                buttonAjouter.Enabled = false;
            }
            else
            {
                buttonSupprimer.Enabled = false;
            }

            if (paysCible.Count > 0)
            {
                buttonSupprimerTout.Enabled = true;
            }
            else
            {
                buttonSupprimerTout.Enabled = false;
            }


            if (listBoxCible.SelectedIndex > 0)
            {
                buttonMonter.Enabled = true;
            }
            else
            {
                buttonMonter.Enabled = false;
            }


            if(listBoxCible.SelectedIndex < paysCible.Count-1)
            {
                buttonDescendre.Enabled = true;
            }
            else
            {
                buttonDescendre.Enabled = false;
            }

        }

        //pour rafraichir les listes
        private void actualiserListes()
        {
            comboBoxSource.Items.Clear();
            listBoxCible.Items.Clear();

            foreach (string pays in paysSource)
            {
                comboBoxSource.Items.Add(pays);
            }

            foreach (string pays in paysCible)
            {
                listBoxCible.Items.Add(pays);
            }

            actualiserBoutons();
        }
    }
}
