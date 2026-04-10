namespace WFCheckBoxBoutonRadio
{
    public partial class FormCheckBoxBoutonRadio : Form
    {

        public FormCheckBoxBoutonRadio()
        {
            InitializeComponent();
        }

        //Création d'un constructeur surchargé pour pouvoir recevoir le texte de l'autre formulaire (l'autre texte est en paramètre)
        public FormCheckBoxBoutonRadio(string texteRecu) : this()      //comme j'ai mis le "this", il utilise l'autre constructeur  
        {
            textBoxInputUtilisateur.Text = texteRecu;
        }

        private void textBoxInputUtilisateur_TextChanged(object sender, EventArgs e)
        {
            if (textBoxInputUtilisateur.Text != string.Empty)
            {
                groupBoxChoix.Enabled = true;

            }
            else
            {
                groupBoxChoix.Enabled = false;
                checkBoxCouleurFond.Checked = false;
                checkBoxCouleurCaractere.Checked = false;
                checkBoxCasse.Checked = false;
            }


            if (radioButtonMinuscule.Checked == true)
            {
                labelResultatTxtUtilisateur.Text = textBoxInputUtilisateur.Text.ToLower();
            }
            else if(radioButtonMajuscule.Checked == true)
            {
                labelResultatTxtUtilisateur.Text = textBoxInputUtilisateur.Text.ToUpper();
            }
            else
            {
                labelResultatTxtUtilisateur.Text = textBoxInputUtilisateur.Text;
            }

        }

            private void checkBoxCouleurFond_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCouleurFond.Checked)
            {
                groupBoxFond.Visible = true;
            }
            else
            {
                groupBoxFond.Visible = false;
                radioButtonFondRouge.Checked = false;
                radioButtonFondVert.Checked = false;
                radioButtonFondBleu.Checked = false;
            }

        }

        private void checkBoxCouleurCaractere_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCouleurCaractere.Checked)
            {
                groupBoxCaractere.Visible = true;
            }
            else
            {
                groupBoxCaractere.Visible = false;
                radioButtonCaracRouge.Checked = false;
                radioButtonCaracBlanc.Checked = false;
                radioButtonCaracNoir.Checked = false;
            }
        }

        private void checkBoxCasse_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCasse.Checked)
            {
                groupBoxCasse.Visible = true;
            }
            else
            {
                groupBoxCasse.Visible = false;
                radioButtonMinuscule.Checked = false;
                radioButtonMajuscule.Checked = false;
            }
        }

        private void radioButtonFondRouge_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFondRouge.Checked == true)
            {
                labelResultatTxtUtilisateur.BackColor = Color.Red;
            }
            else
            {
                labelResultatTxtUtilisateur.BackColor = SystemColors.Control;
            }
        }

        private void radioButtonFondVert_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFondVert.Checked == true)
            {
                labelResultatTxtUtilisateur.BackColor = Color.Green;
            }
            else
            {
                labelResultatTxtUtilisateur.BackColor = SystemColors.Control;
            }

        }

        private void radioButtonFondBleu_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFondBleu.Checked == true)
            {
                labelResultatTxtUtilisateur.BackColor = Color.Blue;
            }
            else
            {
                labelResultatTxtUtilisateur.BackColor = SystemColors.Control;
            }
        }

        private void radioButtonCaracRouge_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCaracRouge.Checked == true)
            {
                labelResultatTxtUtilisateur.ForeColor = Color.Red;
            }
            else
            {
                labelResultatTxtUtilisateur.ForeColor = Color.Black;
            }
        }

        private void radioButtonCaracBlanc_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCaracBlanc.Checked == true)
            {
                labelResultatTxtUtilisateur.ForeColor = Color.White;
            }
            else
            {
                labelResultatTxtUtilisateur.ForeColor = Color.Black;
            }
        }

        private void radioButtonCaracNoir_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCaracNoir.Checked == true)
            {
                labelResultatTxtUtilisateur.ForeColor = Color.Black;
            }
            else
            {
                labelResultatTxtUtilisateur.ForeColor = Color.Black;
            }
        }

        private void radioButtonMinuscule_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMinuscule.Checked == true)
            {
                labelResultatTxtUtilisateur.Text = labelResultatTxtUtilisateur.Text.ToLower();
                
            }
            else
            {
                labelResultatTxtUtilisateur.Text = textBoxInputUtilisateur.Text;
            }
        }

        private void radioButtonMajuscule_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMajuscule.Checked == true)
            {
                labelResultatTxtUtilisateur.Text = labelResultatTxtUtilisateur.Text.ToUpper();
            }
            else
            {
                labelResultatTxtUtilisateur.Text = textBoxInputUtilisateur.Text;
            }
        }
    }
}
