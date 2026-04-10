namespace WFAppTrouvEmploi
{
    partial class FormFicheDemandeurEmploi
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
            components = new System.ComponentModel.Container();
            labelNom = new Label();
            labelDateInscription = new Label();
            groupBoxNiveauDeFormation = new GroupBox();
            radioButtonSupBac5 = new RadioButton();
            radioButtonBac5 = new RadioButton();
            radioButtonBac2 = new RadioButton();
            radioButtonBac = new RadioButton();
            radioButtonInfBac = new RadioButton();
            textBoxNom = new TextBox();
            textBoxDateInscription = new TextBox();
            buttonModifier = new Button();
            buttonValider = new Button();
            errorProviderNom = new ErrorProvider(components);
            errorProviderDate = new ErrorProvider(components);
            groupBoxNiveauDeFormation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderNom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderDate).BeginInit();
            SuspendLayout();
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.Location = new Point(32, 42);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(34, 15);
            labelNom.TabIndex = 0;
            labelNom.Text = "Nom";
            // 
            // labelDateInscription
            // 
            labelDateInscription.AutoSize = true;
            labelDateInscription.Location = new Point(32, 86);
            labelDateInscription.Name = "labelDateInscription";
            labelDateInscription.Size = new Size(100, 15);
            labelDateInscription.TabIndex = 1;
            labelDateInscription.Text = "Date d'inscription";
            // 
            // groupBoxNiveauDeFormation
            // 
            groupBoxNiveauDeFormation.Controls.Add(radioButtonSupBac5);
            groupBoxNiveauDeFormation.Controls.Add(radioButtonBac5);
            groupBoxNiveauDeFormation.Controls.Add(radioButtonBac2);
            groupBoxNiveauDeFormation.Controls.Add(radioButtonBac);
            groupBoxNiveauDeFormation.Controls.Add(radioButtonInfBac);
            groupBoxNiveauDeFormation.Enabled = false;
            groupBoxNiveauDeFormation.Location = new Point(32, 138);
            groupBoxNiveauDeFormation.Name = "groupBoxNiveauDeFormation";
            groupBoxNiveauDeFormation.Size = new Size(159, 153);
            groupBoxNiveauDeFormation.TabIndex = 2;
            groupBoxNiveauDeFormation.TabStop = false;
            groupBoxNiveauDeFormation.Text = "Niveau de formation";
            // 
            // radioButtonSupBac5
            // 
            radioButtonSupBac5.AutoSize = true;
            radioButtonSupBac5.Location = new Point(23, 122);
            radioButtonSupBac5.Name = "radioButtonSupBac5";
            radioButtonSupBac5.Size = new Size(70, 19);
            radioButtonSupBac5.TabIndex = 4;
            radioButtonSupBac5.TabStop = true;
            radioButtonSupBac5.Text = "SupBac5";
            radioButtonSupBac5.UseVisualStyleBackColor = true;
            radioButtonSupBac5.CheckedChanged += radioButtonSupBac5_CheckedChanged;
            // 
            // radioButtonBac5
            // 
            radioButtonBac5.AutoSize = true;
            radioButtonBac5.Location = new Point(23, 97);
            radioButtonBac5.Name = "radioButtonBac5";
            radioButtonBac5.Size = new Size(58, 19);
            radioButtonBac5.TabIndex = 3;
            radioButtonBac5.TabStop = true;
            radioButtonBac5.Text = "Bac+5";
            radioButtonBac5.UseVisualStyleBackColor = true;
            radioButtonBac5.CheckedChanged += radioButtonBac5_CheckedChanged;
            // 
            // radioButtonBac2
            // 
            radioButtonBac2.AutoSize = true;
            radioButtonBac2.Location = new Point(23, 72);
            radioButtonBac2.Name = "radioButtonBac2";
            radioButtonBac2.Size = new Size(58, 19);
            radioButtonBac2.TabIndex = 2;
            radioButtonBac2.TabStop = true;
            radioButtonBac2.Text = "Bac+2";
            radioButtonBac2.UseVisualStyleBackColor = true;
            radioButtonBac2.CheckedChanged += radioButtonBac2_CheckedChanged;
            // 
            // radioButtonBac
            // 
            radioButtonBac.AutoSize = true;
            radioButtonBac.Location = new Point(23, 47);
            radioButtonBac.Name = "radioButtonBac";
            radioButtonBac.Size = new Size(44, 19);
            radioButtonBac.TabIndex = 1;
            radioButtonBac.TabStop = true;
            radioButtonBac.Text = "Bac";
            radioButtonBac.UseVisualStyleBackColor = true;
            radioButtonBac.CheckedChanged += radioButtonBac_CheckedChanged;
            // 
            // radioButtonInfBac
            // 
            radioButtonInfBac.AutoSize = true;
            radioButtonInfBac.Location = new Point(23, 22);
            radioButtonInfBac.Name = "radioButtonInfBac";
            radioButtonInfBac.Size = new Size(58, 19);
            radioButtonInfBac.TabIndex = 0;
            radioButtonInfBac.TabStop = true;
            radioButtonInfBac.Text = "infBac";
            radioButtonInfBac.UseVisualStyleBackColor = true;
            radioButtonInfBac.CheckedChanged += radioButtonInfBac_CheckedChanged;
            // 
            // textBoxNom
            // 
            textBoxNom.Enabled = false;
            textBoxNom.Location = new Point(199, 39);
            textBoxNom.Name = "textBoxNom";
            textBoxNom.Size = new Size(140, 23);
            textBoxNom.TabIndex = 3;
            textBoxNom.Validating += textBoxNom_Validating;
            // 
            // textBoxDateInscription
            // 
            textBoxDateInscription.Enabled = false;
            textBoxDateInscription.Location = new Point(199, 83);
            textBoxDateInscription.Name = "textBoxDateInscription";
            textBoxDateInscription.Size = new Size(140, 23);
            textBoxDateInscription.TabIndex = 4;
            textBoxDateInscription.Validating += textBoxDateInscription_Validating;
            // 
            // buttonModifier
            // 
            buttonModifier.Location = new Point(231, 304);
            buttonModifier.Name = "buttonModifier";
            buttonModifier.Size = new Size(75, 23);
            buttonModifier.TabIndex = 5;
            buttonModifier.Text = "Modifier";
            buttonModifier.UseVisualStyleBackColor = true;
            buttonModifier.Click += buttonModifier_Click;
            // 
            // buttonValider
            // 
            buttonValider.Location = new Point(362, 304);
            buttonValider.Name = "buttonValider";
            buttonValider.Size = new Size(75, 23);
            buttonValider.TabIndex = 6;
            buttonValider.Text = "Valider";
            buttonValider.UseVisualStyleBackColor = true;
            buttonValider.Click += buttonValider_Click;
            // 
            // errorProviderNom
            // 
            errorProviderNom.ContainerControl = this;
            // 
            // errorProviderDate
            // 
            errorProviderDate.ContainerControl = this;
            // 
            // FormFicheDemandeurEmploi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 339);
            Controls.Add(buttonValider);
            Controls.Add(buttonModifier);
            Controls.Add(textBoxDateInscription);
            Controls.Add(textBoxNom);
            Controls.Add(groupBoxNiveauDeFormation);
            Controls.Add(labelDateInscription);
            Controls.Add(labelNom);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "FormFicheDemandeurEmploi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulaire du demandeur d'emploi";
            Load += FormFicheDemandeurEmploi_Load;
            groupBoxNiveauDeFormation.ResumeLayout(false);
            groupBoxNiveauDeFormation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderNom).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderDate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNom;
        private Label labelDateInscription;
        private GroupBox groupBoxNiveauDeFormation;
        private RadioButton radioButtonSupBac5;
        private RadioButton radioButtonBac5;
        private RadioButton radioButtonBac2;
        private RadioButton radioButtonBac;
        private RadioButton radioButtonInfBac;
        private TextBox textBoxNom;
        private TextBox textBoxDateInscription;
        private Button buttonModifier;
        private Button buttonValider;
        private ErrorProvider errorProviderNom;
        private ErrorProvider errorProviderDate;
    }
}
