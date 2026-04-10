namespace WinFormsControlUserControls
{
    partial class UC_DisBonjour
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            labelNom = new Label();
            textBoxReponseNom = new TextBox();
            SuspendLayout();
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.Location = new Point(45, 65);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(62, 15);
            labelNom.TabIndex = 0;
            labelNom.Text = "Qui es tu ?";
            // 
            // textBoxReponseNom
            // 
            textBoxReponseNom.Location = new Point(149, 59);
            textBoxReponseNom.Name = "textBoxReponseNom";
            textBoxReponseNom.Size = new Size(100, 23);
            textBoxReponseNom.TabIndex = 1;
            textBoxReponseNom.TextChanged += textBoxReponseNom_TextChanged;
            // 
            // UC_DisBonjour
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBoxReponseNom);
            Controls.Add(labelNom);
            Name = "UC_DisBonjour";
            Size = new Size(419, 150);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNom;
        private TextBox textBoxReponseNom;
    }
}
