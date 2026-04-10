using CL_DemandeurEmploi;
using CL_VerificationChamps;

namespace WFAppTrouvEmploi
{
    public partial class FormFicheDemandeurEmploi : Form
    {
        private DemandeurEmploi demandeur1;
        public FormFicheDemandeurEmploi()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x10)
            {
                AutoValidate = AutoValidate.Disable;
            }
            base.WndProc(ref m);
        }


        private void FormFicheDemandeurEmploi_Load(object sender, EventArgs e)
        {
            //ActualisationNiveauFormation();

            demandeur1 = new DemandeurEmploi("Cetin", "12/11/2025", 5);

            textBoxNom.Text = demandeur1.Nom;
            textBoxDateInscription.Text = demandeur1.DateInscription;

           

        }

        private void textBoxNom_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                if (!VerificationChamps.FormatNomValide(textBoxNom.Text))
                {
                    e.Cancel = true;
                    errorProviderNom.SetError(textBoxNom, "Le nom doit contenir que des lettres");
                }
                else
                {
                    errorProviderNom.Clear();
                }

            }
            catch
            {
                e.Cancel = true;
                errorProviderNom.SetError(textBoxNom, "saisie nom invalide");

            }
        }

        private void textBoxDateInscription_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                if (!VerificationChamps.FormatDateValide(textBoxDateInscription.Text, out DateTime dateSaisieSortie))
                {
                    e.Cancel = true;
                    errorProviderDate.SetError(textBoxDateInscription, "Format date doit être conforme à votre région");
                }
                else
                {
                    errorProviderDate.Clear();
                }
            }
            catch
            {
                e.Cancel = true;
                errorProviderDate.SetError(textBoxDateInscription, "Saisie date incorrecte");
            }
        }


        private void ActualisationNiveauFormation()
        {
            if (radioButtonInfBac.Checked)
            {
                demandeur1.NiveauFormation = 1;
            }
            else if (radioButtonBac.Checked)
            {
                demandeur1.NiveauFormation = 2;
            }
            else if (radioButtonBac2.Checked)
            {
                demandeur1.NiveauFormation = 3;
            }
            else if (radioButtonBac5.Checked)
            {
                demandeur1.NiveauFormation = 4;
            }
            else if (radioButtonSupBac5.Checked)
            {
                demandeur1.NiveauFormation = 5;
            }
            


            /*
            if (demandeur1.NiveauFormation == 1)
            {
                radioButtonInfBac.Checked = true;
            }
            else if (demandeur1.NiveauFormation == 2)
            {
                radioButtonBac.Checked = true;
            }
            else if (demandeur1.NiveauFormation == 3)
            {
                radioButtonBac2.Checked = true;
            }
            else if (demandeur1.NiveauFormation == 4)
            {
                radioButtonBac5.Checked = true;
            }
            else if (demandeur1.NiveauFormation == 5)
            {
                radioButtonSupBac5.Checked = true;
            }

            */
            

        }

        private void radioButtonInfBac_CheckedChanged(object sender, EventArgs e)
        {
            ActualisationNiveauFormation();
        }

        private void radioButtonBac_CheckedChanged(object sender, EventArgs e)
        {
            ActualisationNiveauFormation();
        }

        private void radioButtonBac2_CheckedChanged(object sender, EventArgs e)
        {
            ActualisationNiveauFormation();
        }

        private void radioButtonBac5_CheckedChanged(object sender, EventArgs e)
        {
            ActualisationNiveauFormation();
        }

        private void radioButtonSupBac5_CheckedChanged(object sender, EventArgs e)
        {
            ActualisationNiveauFormation();
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            textBoxNom.Enabled = true;
            textBoxDateInscription.Enabled = true;
            groupBoxNiveauDeFormation.Enabled = true;
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                DemandeurEmploi demandeur1 = new DemandeurEmploi(textBoxNom.Text, textBoxDateInscription.Text,ValeurRadioButton());

                DialogResult dr = MessageBox.Show(
                                        "Validation",
                                        "Modifié avec succès",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

            }
        }

        public int ValeurRadioButton()
        {

            if (radioButtonInfBac.Checked)
            {
                return 1;
            }
            else if (radioButtonBac.Checked)
            {
                return 2;
            }
            else if (radioButtonBac2.Checked)
            {
                return 3;
            }
            else if (radioButtonBac5.Checked)
            {
                return 4;
            }
            return 5;
        }
    }
}
