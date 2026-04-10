namespace WFDefilement
{
    partial class FormDefilement
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
            labelRouge = new Label();
            labelVert = new Label();
            labelBleu = new Label();
            hScrollBarRouge = new HScrollBar();
            numericUpDownRouge = new NumericUpDown();
            hScrollBarVert = new HScrollBar();
            numericUpDownVert = new NumericUpDown();
            hScrollBarBleu = new HScrollBar();
            numericUpDownBleu = new NumericUpDown();
            labelCadreRouge = new Label();
            labelCadreVert = new Label();
            labelCadreBleu = new Label();
            labelCadreResultat = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRouge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownVert).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBleu).BeginInit();
            SuspendLayout();
            // 
            // labelRouge
            // 
            labelRouge.AutoSize = true;
            labelRouge.Location = new Point(14, 44);
            labelRouge.Name = "labelRouge";
            labelRouge.Size = new Size(41, 15);
            labelRouge.TabIndex = 0;
            labelRouge.Text = "Rouge";
            // 
            // labelVert
            // 
            labelVert.AutoSize = true;
            labelVert.Location = new Point(14, 89);
            labelVert.Name = "labelVert";
            labelVert.Size = new Size(27, 15);
            labelVert.TabIndex = 1;
            labelVert.Text = "Vert";
            // 
            // labelBleu
            // 
            labelBleu.AutoSize = true;
            labelBleu.Location = new Point(14, 134);
            labelBleu.Name = "labelBleu";
            labelBleu.Size = new Size(30, 15);
            labelBleu.TabIndex = 2;
            labelBleu.Text = "Bleu";
            // 
            // hScrollBarRouge
            // 
            hScrollBarRouge.Location = new Point(69, 44);
            hScrollBarRouge.Maximum = 264;
            hScrollBarRouge.Name = "hScrollBarRouge";
            hScrollBarRouge.Size = new Size(173, 24);
            hScrollBarRouge.TabIndex = 3;
            hScrollBarRouge.Scroll += hScrollBarRouge_Scroll;
            // 
            // numericUpDownRouge
            // 
            numericUpDownRouge.Location = new Point(245, 45);
            numericUpDownRouge.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDownRouge.Name = "numericUpDownRouge";
            numericUpDownRouge.Size = new Size(62, 23);
            numericUpDownRouge.TabIndex = 4;
            numericUpDownRouge.ValueChanged += numericUpDownRouge_ValueChanged;
            // 
            // hScrollBarVert
            // 
            hScrollBarVert.Location = new Point(69, 87);
            hScrollBarVert.Maximum = 264;
            hScrollBarVert.Name = "hScrollBarVert";
            hScrollBarVert.Size = new Size(173, 23);
            hScrollBarVert.TabIndex = 5;
            hScrollBarVert.Scroll += hScrollBarVert_Scroll;
            // 
            // numericUpDownVert
            // 
            numericUpDownVert.Location = new Point(245, 87);
            numericUpDownVert.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDownVert.Name = "numericUpDownVert";
            numericUpDownVert.Size = new Size(62, 23);
            numericUpDownVert.TabIndex = 6;
            numericUpDownVert.ValueChanged += numericUpDownVert_ValueChanged;
            // 
            // hScrollBarBleu
            // 
            hScrollBarBleu.Location = new Point(69, 134);
            hScrollBarBleu.Maximum = 264;
            hScrollBarBleu.Name = "hScrollBarBleu";
            hScrollBarBleu.Size = new Size(173, 24);
            hScrollBarBleu.TabIndex = 7;
            hScrollBarBleu.Scroll += hScrollBarBleu_Scroll;
            // 
            // numericUpDownBleu
            // 
            numericUpDownBleu.Location = new Point(245, 135);
            numericUpDownBleu.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDownBleu.Name = "numericUpDownBleu";
            numericUpDownBleu.Size = new Size(62, 23);
            numericUpDownBleu.TabIndex = 8;
            numericUpDownBleu.ValueChanged += numericUpDownBleu_ValueChanged;
            // 
            // labelCadreRouge
            // 
            labelCadreRouge.BackColor = SystemColors.ActiveCaptionText;
            labelCadreRouge.ForeColor = SystemColors.ControlText;
            labelCadreRouge.Location = new Point(331, 45);
            labelCadreRouge.Name = "labelCadreRouge";
            labelCadreRouge.Size = new Size(59, 20);
            labelCadreRouge.TabIndex = 9;
            // 
            // labelCadreVert
            // 
            labelCadreVert.BackColor = SystemColors.ActiveCaptionText;
            labelCadreVert.Location = new Point(331, 89);
            labelCadreVert.Name = "labelCadreVert";
            labelCadreVert.Size = new Size(59, 20);
            labelCadreVert.TabIndex = 10;
            // 
            // labelCadreBleu
            // 
            labelCadreBleu.BackColor = SystemColors.ActiveCaptionText;
            labelCadreBleu.Location = new Point(331, 135);
            labelCadreBleu.Name = "labelCadreBleu";
            labelCadreBleu.Size = new Size(59, 20);
            labelCadreBleu.TabIndex = 11;
            // 
            // labelCadreResultat
            // 
            labelCadreResultat.BackColor = SystemColors.ActiveCaptionText;
            labelCadreResultat.Location = new Point(32, 189);
            labelCadreResultat.Name = "labelCadreResultat";
            labelCadreResultat.Size = new Size(358, 63);
            labelCadreResultat.TabIndex = 12;
            // 
            // FormDefilement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 261);
            Controls.Add(labelCadreResultat);
            Controls.Add(labelCadreBleu);
            Controls.Add(labelCadreVert);
            Controls.Add(labelCadreRouge);
            Controls.Add(numericUpDownBleu);
            Controls.Add(hScrollBarBleu);
            Controls.Add(numericUpDownVert);
            Controls.Add(hScrollBarVert);
            Controls.Add(numericUpDownRouge);
            Controls.Add(hScrollBarRouge);
            Controls.Add(labelBleu);
            Controls.Add(labelVert);
            Controls.Add(labelRouge);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "FormDefilement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Defilement";
            ((System.ComponentModel.ISupportInitialize)numericUpDownRouge).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownVert).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBleu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelRouge;
        private Label labelVert;
        private Label labelBleu;
        private HScrollBar hScrollBarRouge;
        private NumericUpDown numericUpDownRouge;
        private HScrollBar hScrollBarVert;
        private NumericUpDown numericUpDownVert;
        private HScrollBar hScrollBarBleu;
        private NumericUpDown numericUpDownBleu;
        private Label labelCadreRouge;
        private Label labelCadreVert;
        private Label labelCadreBleu;
        private Label labelCadreResultat;
    }
}
