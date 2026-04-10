namespace WFCheckBoxBoutonRadio
{
    partial class FormCheckBoxBoutonRadio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelChampsDEntree = new Label();
            textBoxInputUtilisateur = new TextBox();
            groupBoxChoix = new GroupBox();
            checkBoxCasse = new CheckBox();
            checkBoxCouleurCaractere = new CheckBox();
            checkBoxCouleurFond = new CheckBox();
            groupBoxFond = new GroupBox();
            radioButtonFondBleu = new RadioButton();
            radioButtonFondVert = new RadioButton();
            radioButtonFondRouge = new RadioButton();
            groupBoxCaractere = new GroupBox();
            radioButtonCaracNoir = new RadioButton();
            radioButtonCaracBlanc = new RadioButton();
            radioButtonCaracRouge = new RadioButton();
            groupBoxCasse = new GroupBox();
            radioButtonMajuscule = new RadioButton();
            radioButtonMinuscule = new RadioButton();
            labelResultatTxtUtilisateur = new Label();
            groupBoxChoix.SuspendLayout();
            groupBoxFond.SuspendLayout();
            groupBoxCaractere.SuspendLayout();
            groupBoxCasse.SuspendLayout();
            SuspendLayout();
            // 
            // labelChampsDEntree
            // 
            labelChampsDEntree.AutoSize = true;
            labelChampsDEntree.Location = new Point(28, 13);
            labelChampsDEntree.Name = "labelChampsDEntree";
            labelChampsDEntree.Size = new Size(95, 15);
            labelChampsDEntree.TabIndex = 0;
            labelChampsDEntree.Text = "Tapez votre texte";
            // 
            // textBoxInputUtilisateur
            // 
            textBoxInputUtilisateur.Location = new Point(28, 42);
            textBoxInputUtilisateur.Name = "textBoxInputUtilisateur";
            textBoxInputUtilisateur.Size = new Size(234, 23);
            textBoxInputUtilisateur.TabIndex = 1;
            textBoxInputUtilisateur.TextChanged += textBoxInputUtilisateur_TextChanged;
            // 
            // groupBoxChoix
            // 
            groupBoxChoix.Controls.Add(checkBoxCasse);
            groupBoxChoix.Controls.Add(checkBoxCouleurCaractere);
            groupBoxChoix.Controls.Add(checkBoxCouleurFond);
            groupBoxChoix.Enabled = false;
            groupBoxChoix.ForeColor = Color.Blue;
            groupBoxChoix.Location = new Point(283, 13);
            groupBoxChoix.Name = "groupBoxChoix";
            groupBoxChoix.Size = new Size(200, 97);
            groupBoxChoix.TabIndex = 2;
            groupBoxChoix.TabStop = false;
            groupBoxChoix.Text = "Choix";
            // 
            // checkBoxCasse
            // 
            checkBoxCasse.AutoSize = true;
            checkBoxCasse.ForeColor = SystemColors.InfoText;
            checkBoxCasse.Location = new Point(13, 72);
            checkBoxCasse.Name = "checkBoxCasse";
            checkBoxCasse.Size = new Size(56, 19);
            checkBoxCasse.TabIndex = 2;
            checkBoxCasse.Text = "Casse";
            checkBoxCasse.UseVisualStyleBackColor = true;
            checkBoxCasse.CheckedChanged += checkBoxCasse_CheckedChanged;
            // 
            // checkBoxCouleurCaractere
            // 
            checkBoxCouleurCaractere.AutoSize = true;
            checkBoxCouleurCaractere.ForeColor = SystemColors.InfoText;
            checkBoxCouleurCaractere.Location = new Point(13, 47);
            checkBoxCouleurCaractere.Name = "checkBoxCouleurCaractere";
            checkBoxCouleurCaractere.Size = new Size(145, 19);
            checkBoxCouleurCaractere.TabIndex = 1;
            checkBoxCouleurCaractere.Text = "Couleur des caractères";
            checkBoxCouleurCaractere.UseVisualStyleBackColor = true;
            checkBoxCouleurCaractere.CheckedChanged += checkBoxCouleurCaractere_CheckedChanged;
            // 
            // checkBoxCouleurFond
            // 
            checkBoxCouleurFond.AutoSize = true;
            checkBoxCouleurFond.ForeColor = SystemColors.InfoText;
            checkBoxCouleurFond.Location = new Point(13, 22);
            checkBoxCouleurFond.Name = "checkBoxCouleurFond";
            checkBoxCouleurFond.Size = new Size(113, 19);
            checkBoxCouleurFond.TabIndex = 0;
            checkBoxCouleurFond.Text = "Couleur du fond";
            checkBoxCouleurFond.UseVisualStyleBackColor = true;
            checkBoxCouleurFond.CheckedChanged += checkBoxCouleurFond_CheckedChanged;
            // 
            // groupBoxFond
            // 
            groupBoxFond.Controls.Add(radioButtonFondBleu);
            groupBoxFond.Controls.Add(radioButtonFondVert);
            groupBoxFond.Controls.Add(radioButtonFondRouge);
            groupBoxFond.ForeColor = Color.Blue;
            groupBoxFond.Location = new Point(28, 145);
            groupBoxFond.Name = "groupBoxFond";
            groupBoxFond.Size = new Size(95, 102);
            groupBoxFond.TabIndex = 3;
            groupBoxFond.TabStop = false;
            groupBoxFond.Text = "Fond";
            groupBoxFond.Visible = false;
            // 
            // radioButtonFondBleu
            // 
            radioButtonFondBleu.AutoSize = true;
            radioButtonFondBleu.ForeColor = Color.Black;
            radioButtonFondBleu.Location = new Point(6, 76);
            radioButtonFondBleu.Name = "radioButtonFondBleu";
            radioButtonFondBleu.Size = new Size(48, 19);
            radioButtonFondBleu.TabIndex = 2;
            radioButtonFondBleu.TabStop = true;
            radioButtonFondBleu.Text = "Bleu";
            radioButtonFondBleu.UseVisualStyleBackColor = true;
            radioButtonFondBleu.CheckedChanged += radioButtonFondBleu_CheckedChanged;
            // 
            // radioButtonFondVert
            // 
            radioButtonFondVert.AutoSize = true;
            radioButtonFondVert.ForeColor = Color.Black;
            radioButtonFondVert.Location = new Point(6, 51);
            radioButtonFondVert.Name = "radioButtonFondVert";
            radioButtonFondVert.Size = new Size(45, 19);
            radioButtonFondVert.TabIndex = 1;
            radioButtonFondVert.TabStop = true;
            radioButtonFondVert.Text = "Vert";
            radioButtonFondVert.UseVisualStyleBackColor = true;
            radioButtonFondVert.CheckedChanged += radioButtonFondVert_CheckedChanged;
            // 
            // radioButtonFondRouge
            // 
            radioButtonFondRouge.AutoSize = true;
            radioButtonFondRouge.ForeColor = Color.Black;
            radioButtonFondRouge.Location = new Point(6, 26);
            radioButtonFondRouge.Name = "radioButtonFondRouge";
            radioButtonFondRouge.Size = new Size(59, 19);
            radioButtonFondRouge.TabIndex = 0;
            radioButtonFondRouge.TabStop = true;
            radioButtonFondRouge.Text = "Rouge";
            radioButtonFondRouge.UseVisualStyleBackColor = true;
            radioButtonFondRouge.CheckedChanged += radioButtonFondRouge_CheckedChanged;
            // 
            // groupBoxCaractere
            // 
            groupBoxCaractere.Controls.Add(radioButtonCaracNoir);
            groupBoxCaractere.Controls.Add(radioButtonCaracBlanc);
            groupBoxCaractere.Controls.Add(radioButtonCaracRouge);
            groupBoxCaractere.ForeColor = Color.Blue;
            groupBoxCaractere.Location = new Point(129, 145);
            groupBoxCaractere.Name = "groupBoxCaractere";
            groupBoxCaractere.Size = new Size(86, 102);
            groupBoxCaractere.TabIndex = 4;
            groupBoxCaractere.TabStop = false;
            groupBoxCaractere.Text = "Caractères";
            groupBoxCaractere.Visible = false;
            // 
            // radioButtonCaracNoir
            // 
            radioButtonCaracNoir.AutoSize = true;
            radioButtonCaracNoir.ForeColor = Color.Black;
            radioButtonCaracNoir.Location = new Point(6, 76);
            radioButtonCaracNoir.Name = "radioButtonCaracNoir";
            radioButtonCaracNoir.Size = new Size(48, 19);
            radioButtonCaracNoir.TabIndex = 2;
            radioButtonCaracNoir.TabStop = true;
            radioButtonCaracNoir.Text = "Noir";
            radioButtonCaracNoir.UseVisualStyleBackColor = true;
            radioButtonCaracNoir.CheckedChanged += radioButtonCaracNoir_CheckedChanged;
            // 
            // radioButtonCaracBlanc
            // 
            radioButtonCaracBlanc.AutoSize = true;
            radioButtonCaracBlanc.ForeColor = Color.Black;
            radioButtonCaracBlanc.Location = new Point(6, 51);
            radioButtonCaracBlanc.Name = "radioButtonCaracBlanc";
            radioButtonCaracBlanc.Size = new Size(54, 19);
            radioButtonCaracBlanc.TabIndex = 1;
            radioButtonCaracBlanc.TabStop = true;
            radioButtonCaracBlanc.Text = "Blanc";
            radioButtonCaracBlanc.UseVisualStyleBackColor = true;
            radioButtonCaracBlanc.CheckedChanged += radioButtonCaracBlanc_CheckedChanged;
            // 
            // radioButtonCaracRouge
            // 
            radioButtonCaracRouge.AutoSize = true;
            radioButtonCaracRouge.ForeColor = Color.Black;
            radioButtonCaracRouge.Location = new Point(6, 26);
            radioButtonCaracRouge.Name = "radioButtonCaracRouge";
            radioButtonCaracRouge.Size = new Size(59, 19);
            radioButtonCaracRouge.TabIndex = 0;
            radioButtonCaracRouge.TabStop = true;
            radioButtonCaracRouge.Text = "Rouge";
            radioButtonCaracRouge.UseVisualStyleBackColor = true;
            radioButtonCaracRouge.CheckedChanged += radioButtonCaracRouge_CheckedChanged;
            // 
            // groupBoxCasse
            // 
            groupBoxCasse.Controls.Add(radioButtonMajuscule);
            groupBoxCasse.Controls.Add(radioButtonMinuscule);
            groupBoxCasse.ForeColor = Color.Blue;
            groupBoxCasse.Location = new Point(224, 173);
            groupBoxCasse.Name = "groupBoxCasse";
            groupBoxCasse.Size = new Size(116, 74);
            groupBoxCasse.TabIndex = 5;
            groupBoxCasse.TabStop = false;
            groupBoxCasse.Text = "Casse";
            groupBoxCasse.Visible = false;
            // 
            // radioButtonMajuscule
            // 
            radioButtonMajuscule.AutoSize = true;
            radioButtonMajuscule.ForeColor = Color.Black;
            radioButtonMajuscule.Location = new Point(6, 47);
            radioButtonMajuscule.Name = "radioButtonMajuscule";
            radioButtonMajuscule.Size = new Size(84, 19);
            radioButtonMajuscule.TabIndex = 1;
            radioButtonMajuscule.TabStop = true;
            radioButtonMajuscule.Text = "Majuscules";
            radioButtonMajuscule.UseVisualStyleBackColor = true;
            radioButtonMajuscule.CheckedChanged += radioButtonMajuscule_CheckedChanged;
            // 
            // radioButtonMinuscule
            // 
            radioButtonMinuscule.AutoSize = true;
            radioButtonMinuscule.ForeColor = Color.Black;
            radioButtonMinuscule.Location = new Point(6, 22);
            radioButtonMinuscule.Name = "radioButtonMinuscule";
            radioButtonMinuscule.Size = new Size(85, 19);
            radioButtonMinuscule.TabIndex = 0;
            radioButtonMinuscule.TabStop = true;
            radioButtonMinuscule.Text = "Minuscules";
            radioButtonMinuscule.UseVisualStyleBackColor = true;
            radioButtonMinuscule.CheckedChanged += radioButtonMinuscule_CheckedChanged;
            // 
            // labelResultatTxtUtilisateur
            // 
            labelResultatTxtUtilisateur.AutoSize = true;
            labelResultatTxtUtilisateur.BackColor = SystemColors.Control;
            labelResultatTxtUtilisateur.Location = new Point(28, 95);
            labelResultatTxtUtilisateur.Name = "labelResultatTxtUtilisateur";
            labelResultatTxtUtilisateur.Size = new Size(10, 15);
            labelResultatTxtUtilisateur.TabIndex = 6;
            labelResultatTxtUtilisateur.Text = " ";
            // 
            // FormCheckBoxBoutonRadio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 257);
            Controls.Add(labelResultatTxtUtilisateur);
            Controls.Add(groupBoxCasse);
            Controls.Add(groupBoxCaractere);
            Controls.Add(groupBoxFond);
            Controls.Add(groupBoxChoix);
            Controls.Add(textBoxInputUtilisateur);
            Controls.Add(labelChampsDEntree);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "FormCheckBoxBoutonRadio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CheckBox et RadioButton";
            groupBoxChoix.ResumeLayout(false);
            groupBoxChoix.PerformLayout();
            groupBoxFond.ResumeLayout(false);
            groupBoxFond.PerformLayout();
            groupBoxCaractere.ResumeLayout(false);
            groupBoxCaractere.PerformLayout();
            groupBoxCasse.ResumeLayout(false);
            groupBoxCasse.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelChampsDEntree;
        private TextBox textBoxInputUtilisateur;
        private GroupBox groupBoxChoix;
        private CheckBox checkBoxCasse;
        private CheckBox checkBoxCouleurCaractere;
        private CheckBox checkBoxCouleurFond;
        private GroupBox groupBoxFond;
        private GroupBox groupBoxCaractere;
        private GroupBox groupBoxCasse;
        private Label labelResultatTxtUtilisateur;
        private RadioButton radioButtonFondBleu;
        private RadioButton radioButtonFondVert;
        private RadioButton radioButtonFondRouge;
        private RadioButton radioButtonCaracNoir;
        private RadioButton radioButtonCaracBlanc;
        private RadioButton radioButtonCaracRouge;
        private RadioButton radioButtonMajuscule;
        private RadioButton radioButtonMinuscule;
    }
}
