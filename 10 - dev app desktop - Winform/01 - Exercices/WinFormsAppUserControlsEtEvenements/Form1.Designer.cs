namespace WinFormsAppUserControlsEtEvenements
{
    partial class Form1
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
            uC_DisBonjour1 = new WinFormsControlUserControls.UC_DisBonjour();
            uC_DisBonjour2 = new WinFormsControlUserControls.UC_DisBonjour();
            SuspendLayout();
            // 
            // uC_DisBonjour1
            // 
            uC_DisBonjour1.Location = new Point(111, 61);
            uC_DisBonjour1.Name = "uC_DisBonjour1";
            uC_DisBonjour1.NomDestinataire = "Ludo";
            uC_DisBonjour1.Size = new Size(419, 150);
            uC_DisBonjour1.TabIndex = 0;
            // 
            // uC_DisBonjour2
            // 
            uC_DisBonjour2.Location = new Point(224, 262);
            uC_DisBonjour2.Name = "uC_DisBonjour2";
            uC_DisBonjour2.NomDestinataire = null;
            uC_DisBonjour2.Size = new Size(419, 150);
            uC_DisBonjour2.TabIndex = 1;
            uC_DisBonjour2.NomIdentified += uC_DisBonjour2_NomIdentified;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 543);
            Controls.Add(uC_DisBonjour2);
            Controls.Add(uC_DisBonjour1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private WinFormsControlUserControls.UC_DisBonjour uC_DisBonjour1;
        private WinFormsControlUserControls.UC_DisBonjour uC_DisBonjour2;
    }
}
