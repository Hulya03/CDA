namespace WFMenu
{
    partial class FormSaisie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTapezTxt = new Label();
            textBoxSaisieTexte = new TextBox();
            buttonValider = new Button();
            SuspendLayout();
            // 
            // labelTapezTxt
            // 
            labelTapezTxt.AutoSize = true;
            labelTapezTxt.Location = new Point(22, 9);
            labelTapezTxt.Name = "labelTapezTxt";
            labelTapezTxt.Size = new Size(95, 15);
            labelTapezTxt.TabIndex = 0;
            labelTapezTxt.Text = "Tapez votre texte";
            // 
            // textBoxSaisieTexte
            // 
            textBoxSaisieTexte.Location = new Point(22, 27);
            textBoxSaisieTexte.Name = "textBoxSaisieTexte";
            textBoxSaisieTexte.Size = new Size(200, 23);
            textBoxSaisieTexte.TabIndex = 1;
            textBoxSaisieTexte.TextChanged += textBoxSaisieTexte_TextChanged;
            // 
            // buttonValider
            // 
            buttonValider.Enabled = false;
            buttonValider.Location = new Point(253, 26);
            buttonValider.Name = "buttonValider";
            buttonValider.Size = new Size(133, 23);
            buttonValider.TabIndex = 2;
            buttonValider.Text = "Valider";
            buttonValider.UseVisualStyleBackColor = true;
            buttonValider.Click += buttonValider_Click;
            // 
            // FormSaisie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 78);
            Controls.Add(buttonValider);
            Controls.Add(textBoxSaisieTexte);
            Controls.Add(labelTapezTxt);
            Name = "FormSaisie";
            Text = "Saisie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTapezTxt;
        private TextBox textBoxSaisieTexte;
        private Button buttonValider;
    }
}