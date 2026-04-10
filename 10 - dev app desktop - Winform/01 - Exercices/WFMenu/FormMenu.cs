using WFAdditionneur;
using WFCheckBoxBoutonRadio;
using WFDefilement;
using WFEmprunts;
using WFListBoxCombobox;
using WFListeEtPropriete;
using WFNouvelleFenetre;
using WFValidationSaisieEP;


namespace WFMenu
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();

        }

        private int numero = 1;

        private void additionneurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdditionneur formAdditionneur = new FormAdditionneur();             // on créé l'instance pour la fenetre de l'additionneur
            formAdditionneur.MdiParent = this;                                      // on lui dit que "this" cad le formMenu est son parent
            formAdditionneur.Show();                                                // on affiche la fenetre de l'additionneur

            formAdditionneur.Text = "L'additionneur N° " + numero;
            numero++;
            toolStripStatusLabelEtat.Text = "Additionneur";
        }

        private void contrôlesDeSaisieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormValidationSaisieEP formValidation = new FormValidationSaisieEP();
            formValidation.MdiParent = this;
            formValidation.Show();

            toolStripStatusLabelEtat.Text = "Contrôles des saisie";
        }

        private void checkBoxEtBoutonsRadiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSaisie formSaisie = new FormSaisie();
            formSaisie.MdiParent = this;
            formSaisie.Show();

            toolStripStatusLabelEtat.Text = "Check box et boutons radios";
        }

        private void listboxBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListeEtPropriete formListProp = new FormListeEtPropriete();
            formListProp.MdiParent = this;
            formListProp.Show();

            toolStripStatusLabelEtat.Text = "Listbox base";
        }

        private void listboxEtComboboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListboxCombobox formListCombo = new FormListboxCombobox();
            formListCombo.MdiParent = this;
            formListCombo.Show();

            toolStripStatusLabelEtat.Text = "Listbox et Combobox";
        }

        private void defilementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDefilement formDefil = new FormDefilement();
            formDefil.MdiParent = this;
            formDefil.Show();

            toolStripStatusLabelEtat.Text = "Défilement";

        }

        private void synthèseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmprunts emprunt = new FormEmprunts();
            emprunt.MdiParent = this;
            emprunt.Show();

            toolStripStatusLabelEtat.Text = synthèseToolStripMenuItem.Text;
        }

        private void sidentifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
             * 
             DialogResult dr = MessageBox.Show(
                                    "Bienvenue dans l'application",
                                    "Messasge",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                    );

            phase1ToolStripMenuItem.Enabled = true;
            phase2ToolStripMenuItem.Enabled = true;
            phase3ToolStripMenuItem.Enabled = true;
            fenêtresToolStripMenuItem.Enabled = true;
            toolStripSplitButtonPhase3.Enabled = true;

            */

            //Changement de code : on veut appeler une nouvelle feuille pour s'identifier avec login et password (ils doivent être identique pour pouvoir se connecter)

            FormSidentifier sidentifier = new FormSidentifier();
            //sidentifier.MdiParent = this;                          //pas besoin car "sidentifier" est une fenetre passagere, d'option
            DialogResult dr = sidentifier.ShowDialog();              //on place le résultat du dialogResult de la feuille sidentifier dans la variable "dr" 

            if(dr == DialogResult.OK)                                //on a placé le "Dialogresult.Ok" de l'autre quand le login et mdp sont identiques
            {
                DialogResult drOk = MessageBox.Show(
                                        "Bienvenue dans l'application",
                                        "Messasge",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information
                                        );

                phase1ToolStripMenuItem.Enabled = true;
                phase2ToolStripMenuItem.Enabled = true;
                phase3ToolStripMenuItem.Enabled = true;
                fenêtresToolStripMenuItem.Enabled = true;
                toolStripSplitButtonPhase3.Enabled = true;
            }

            toolStripStatusLabelEtat.Text = sidentifierToolStripMenuItem.Text;

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                                    "Voulez-vous quittez l'application ?",
                                    "Fermeture de l'application",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question
                                        );

            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }

            toolStripStatusLabelEtat.Text = "Fermeture en cours";

        }

        private void toolStripButtonSidentifier_Click(object sender, EventArgs e)
        {
            FormSidentifier sidentifier = new FormSidentifier();
            DialogResult dr = sidentifier.ShowDialog();             
            if (dr == DialogResult.OK)                                
            {
                DialogResult drOk = MessageBox.Show(
                                        "Bienvenue dans l'application",
                                        "Messasge",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information
                                        );

                phase1ToolStripMenuItem.Enabled = true;
                phase2ToolStripMenuItem.Enabled = true;
                phase3ToolStripMenuItem.Enabled = true;
                fenêtresToolStripMenuItem.Enabled = true;
                toolStripSplitButtonPhase3.Enabled = true;
            }

            toolStripStatusLabelEtat.Text = sidentifierToolStripMenuItem.Text;

        }

        private void checkBoxEtBoutonsRadioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormSaisie formSaisie = new FormSaisie();
            formSaisie.MdiParent = this;
            formSaisie.Show();

            toolStripStatusLabelEtat.Text = "Check box et boutons radios";
        }

        private void listboxBaseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormListeEtPropriete formListProp = new FormListeEtPropriete();
            formListProp.MdiParent = this;
            formListProp.Show();

            toolStripStatusLabelEtat.Text = "Listbox base";
        }

        private void listboxEtComboboxToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormListboxCombobox formListCombo = new FormListboxCombobox();
            formListCombo.MdiParent = this;
            formListCombo.Show();

            toolStripStatusLabelEtat.Text = "Listbox et Combobox";
        }

        private void defilementToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormDefilement formDefil = new FormDefilement();
            formDefil.MdiParent = this;
            formDefil.Show();

            toolStripStatusLabelEtat.Text = "Défilement";

        }

        private void synthèseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormEmprunts emprunt = new FormEmprunts();
            emprunt.MdiParent = this;
            emprunt.Show();

            toolStripStatusLabelEtat.Text = "Synthèse";
        }

        //pour faire avancer le temps (propriété Enabled=true et interval=1000ms)
        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelDate.Text = DateTime.Now.ToString();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            toolStripStatusLabelDate.Text = DateTime.Now.ToString();
        }
        
        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
