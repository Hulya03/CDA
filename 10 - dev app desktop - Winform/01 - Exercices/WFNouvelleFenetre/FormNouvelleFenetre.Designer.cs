namespace WFNouvelleFenetre
{
    partial class FormNouvelleFenetre
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
            labelNom = new Label();
            labelDate = new Label();
            labelMontant = new Label();
            labelCode = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.Location = new Point(23, 21);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(43, 15);
            labelNom.TabIndex = 0;
            labelNom.Text = "Nom : ";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(23, 36);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(40, 15);
            labelDate.TabIndex = 1;
            labelDate.Text = "Date : ";
            // 
            // labelMontant
            // 
            labelMontant.AutoSize = true;
            labelMontant.Location = new Point(23, 51);
            labelMontant.Name = "labelMontant";
            labelMontant.Size = new Size(62, 15);
            labelMontant.TabIndex = 2;
            labelMontant.Text = "Montant : ";
            // 
            // labelCode
            // 
            labelCode.AutoSize = true;
            labelCode.Location = new Point(23, 66);
            labelCode.Name = "labelCode";
            labelCode.Size = new Size(44, 15);
            labelCode.TabIndex = 3;
            labelCode.Text = "Code : ";
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(83, 92);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormNouvelleFenetre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(231, 127);
            Controls.Add(button1);
            Controls.Add(labelCode);
            Controls.Add(labelMontant);
            Controls.Add(labelDate);
            Controls.Add(labelNom);
            Name = "FormNouvelleFenetre";
            Text = "Validation effectuée";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNom;
        private Label labelDate;
        private Label labelMontant;
        private Label labelCode;
        private Button button1;
    }
}
