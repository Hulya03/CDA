namespace WFListeEtPropriete
{
    partial class FormListeEtPropriete
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
            labelNouvelElement = new Label();
            textBoxNouvelElement = new TextBox();
            labelIndexElement = new Label();
            textBoxIndexElement = new TextBox();
            buttonAjouterListe = new Button();
            buttonSelectionner = new Button();
            buttonViderListe = new Button();
            labelLstListe = new Label();
            lbxElement = new ListBox();
            labelProprietes = new Label();
            labelItemsCount = new Label();
            labelSelectedIndex = new Label();
            labelTextSelectionne = new Label();
            textBoxItemsCount = new TextBox();
            textBoxSelectedIndex = new TextBox();
            textBoxTextSelectionne = new TextBox();
            ePDoublon = new ErrorProvider(components);
            ePIndexNonAutorise = new ErrorProvider(components);
            ePPasDespace = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)ePDoublon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ePIndexNonAutorise).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ePPasDespace).BeginInit();
            SuspendLayout();
            // 
            // labelNouvelElement
            // 
            labelNouvelElement.AutoSize = true;
            labelNouvelElement.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelNouvelElement.Location = new Point(12, 9);
            labelNouvelElement.Name = "labelNouvelElement";
            labelNouvelElement.Size = new Size(96, 15);
            labelNouvelElement.TabIndex = 0;
            labelNouvelElement.Text = "Nouvel Elément";
            // 
            // textBoxNouvelElement
            // 
            textBoxNouvelElement.Location = new Point(12, 36);
            textBoxNouvelElement.Name = "textBoxNouvelElement";
            textBoxNouvelElement.Size = new Size(121, 23);
            textBoxNouvelElement.TabIndex = 1;
            textBoxNouvelElement.TextChanged += textBoxNouvelElement_TextChanged;
            // 
            // labelIndexElement
            // 
            labelIndexElement.AutoSize = true;
            labelIndexElement.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelIndexElement.Location = new Point(190, 9);
            labelIndexElement.Name = "labelIndexElement";
            labelIndexElement.Size = new Size(88, 15);
            labelIndexElement.TabIndex = 2;
            labelIndexElement.Text = "Index Elément";
            // 
            // textBoxIndexElement
            // 
            textBoxIndexElement.Enabled = false;
            textBoxIndexElement.Location = new Point(190, 36);
            textBoxIndexElement.Name = "textBoxIndexElement";
            textBoxIndexElement.Size = new Size(46, 23);
            textBoxIndexElement.TabIndex = 3;
            textBoxIndexElement.TextChanged += textBoxIndexElement_TextChanged;
            // 
            // buttonAjouterListe
            // 
            buttonAjouterListe.Enabled = false;
            buttonAjouterListe.Location = new Point(12, 71);
            buttonAjouterListe.Name = "buttonAjouterListe";
            buttonAjouterListe.Size = new Size(121, 23);
            buttonAjouterListe.TabIndex = 4;
            buttonAjouterListe.Text = "Ajout Liste";
            buttonAjouterListe.UseVisualStyleBackColor = true;
            buttonAjouterListe.Click += buttonAjouterListe_Click;
            // 
            // buttonSelectionner
            // 
            buttonSelectionner.Enabled = false;
            buttonSelectionner.Location = new Point(251, 36);
            buttonSelectionner.Name = "buttonSelectionner";
            buttonSelectionner.Size = new Size(125, 23);
            buttonSelectionner.TabIndex = 5;
            buttonSelectionner.Text = "Sélectionner";
            buttonSelectionner.UseVisualStyleBackColor = true;
            buttonSelectionner.Click += buttonSelectionner_Click;
            // 
            // buttonViderListe
            // 
            buttonViderListe.Enabled = false;
            buttonViderListe.Location = new Point(251, 71);
            buttonViderListe.Name = "buttonViderListe";
            buttonViderListe.Size = new Size(125, 23);
            buttonViderListe.TabIndex = 6;
            buttonViderListe.Text = "Vider la Liste";
            buttonViderListe.UseVisualStyleBackColor = true;
            buttonViderListe.Click += buttonViderListe_Click;
            // 
            // labelLstListe
            // 
            labelLstListe.AutoSize = true;
            labelLstListe.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelLstListe.Location = new Point(12, 117);
            labelLstListe.Name = "labelLstListe";
            labelLstListe.Size = new Size(49, 15);
            labelLstListe.TabIndex = 7;
            labelLstListe.Text = "LstListe";
            // 
            // lbxElement
            // 
            lbxElement.FormattingEnabled = true;
            lbxElement.ItemHeight = 15;
            lbxElement.Location = new Point(12, 144);
            lbxElement.Name = "lbxElement";
            lbxElement.Size = new Size(120, 109);
            lbxElement.TabIndex = 8;
            lbxElement.SelectedIndexChanged += lbxElement_SelectedIndexChanged;
            // 
            // labelProprietes
            // 
            labelProprietes.AutoSize = true;
            labelProprietes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelProprietes.Location = new Point(190, 117);
            labelProprietes.Name = "labelProprietes";
            labelProprietes.Size = new Size(65, 15);
            labelProprietes.TabIndex = 9;
            labelProprietes.Text = "Propriétés";
            // 
            // labelItemsCount
            // 
            labelItemsCount.AutoSize = true;
            labelItemsCount.Location = new Point(190, 155);
            labelItemsCount.Name = "labelItemsCount";
            labelItemsCount.Size = new Size(72, 15);
            labelItemsCount.TabIndex = 10;
            labelItemsCount.Text = "Items.Count";
            // 
            // labelSelectedIndex
            // 
            labelSelectedIndex.AutoSize = true;
            labelSelectedIndex.Location = new Point(190, 190);
            labelSelectedIndex.Name = "labelSelectedIndex";
            labelSelectedIndex.Size = new Size(79, 15);
            labelSelectedIndex.TabIndex = 11;
            labelSelectedIndex.Text = "SelectedIndex";
            // 
            // labelTextSelectionne
            // 
            labelTextSelectionne.AutoSize = true;
            labelTextSelectionne.Location = new Point(190, 228);
            labelTextSelectionne.Name = "labelTextSelectionne";
            labelTextSelectionne.Size = new Size(28, 15);
            labelTextSelectionne.TabIndex = 12;
            labelTextSelectionne.Text = "Text";
            // 
            // textBoxItemsCount
            // 
            textBoxItemsCount.Location = new Point(284, 147);
            textBoxItemsCount.Name = "textBoxItemsCount";
            textBoxItemsCount.ReadOnly = true;
            textBoxItemsCount.Size = new Size(47, 23);
            textBoxItemsCount.TabIndex = 13;
            textBoxItemsCount.Text = "0";
            // 
            // textBoxSelectedIndex
            // 
            textBoxSelectedIndex.Location = new Point(284, 187);
            textBoxSelectedIndex.Name = "textBoxSelectedIndex";
            textBoxSelectedIndex.ReadOnly = true;
            textBoxSelectedIndex.Size = new Size(47, 23);
            textBoxSelectedIndex.TabIndex = 14;
            // 
            // textBoxTextSelectionne
            // 
            textBoxTextSelectionne.Location = new Point(284, 225);
            textBoxTextSelectionne.Name = "textBoxTextSelectionne";
            textBoxTextSelectionne.ReadOnly = true;
            textBoxTextSelectionne.Size = new Size(92, 23);
            textBoxTextSelectionne.TabIndex = 15;
            // 
            // ePDoublon
            // 
            ePDoublon.ContainerControl = this;
            // 
            // ePIndexNonAutorise
            // 
            ePIndexNonAutorise.ContainerControl = this;
            // 
            // ePPasDespace
            // 
            ePPasDespace.ContainerControl = this;
            // 
            // FormListeEtPropriete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 261);
            Controls.Add(textBoxTextSelectionne);
            Controls.Add(textBoxSelectedIndex);
            Controls.Add(textBoxItemsCount);
            Controls.Add(labelTextSelectionne);
            Controls.Add(labelSelectedIndex);
            Controls.Add(labelItemsCount);
            Controls.Add(labelProprietes);
            Controls.Add(lbxElement);
            Controls.Add(labelLstListe);
            Controls.Add(buttonViderListe);
            Controls.Add(buttonSelectionner);
            Controls.Add(buttonAjouterListe);
            Controls.Add(textBoxIndexElement);
            Controls.Add(labelIndexElement);
            Controls.Add(textBoxNouvelElement);
            Controls.Add(labelNouvelElement);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "FormListeEtPropriete";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Les listes et leurs propriétés";
            ((System.ComponentModel.ISupportInitialize)ePDoublon).EndInit();
            ((System.ComponentModel.ISupportInitialize)ePIndexNonAutorise).EndInit();
            ((System.ComponentModel.ISupportInitialize)ePPasDespace).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNouvelElement;
        private TextBox textBoxNouvelElement;
        private Label labelIndexElement;
        private TextBox textBoxIndexElement;
        private Button buttonAjouterListe;
        private Button buttonSelectionner;
        private Button buttonViderListe;
        private Label labelLstListe;
        private ListBox lbxElement;
        private Label labelProprietes;
        private Label labelItemsCount;
        private Label labelSelectedIndex;
        private Label labelTextSelectionne;
        private TextBox textBoxItemsCount;
        private TextBox textBoxSelectedIndex;
        private TextBox textBoxTextSelectionne;
        private ErrorProvider ePDoublon;
        private ErrorProvider ePIndexNonAutorise;
        private ErrorProvider ePPasDespace;
    }
}
