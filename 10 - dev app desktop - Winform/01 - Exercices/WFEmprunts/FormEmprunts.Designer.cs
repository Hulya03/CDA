namespace WFEmprunts
{
    partial class FormEmprunts
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
            labelCapEmprunte = new Label();
            labelDureeMoisRemb = new Label();
            textBoxNom = new TextBox();
            textBoxCapEmprunte = new TextBox();
            textBoxDureeMoisRemb = new TextBox();
            hScrollBarDureeMoisRemb = new HScrollBar();
            labelPeriodicite = new Label();
            listBoxPeriodicite = new ListBox();
            groupBoxTauxInteret = new GroupBox();
            radioButton9 = new RadioButton();
            radioButton8 = new RadioButton();
            radioButton7 = new RadioButton();
            labelRemboursements = new Label();
            errorProviderCapital = new ErrorProvider(components);
            labelNbRemb = new Label();
            labelMontantRemb = new Label();
            groupBoxTauxInteret.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderCapital).BeginInit();
            SuspendLayout();
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.Location = new Point(27, 33);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(34, 15);
            labelNom.TabIndex = 0;
            labelNom.Text = "Nom";
            // 
            // labelCapEmprunte
            // 
            labelCapEmprunte.AutoSize = true;
            labelCapEmprunte.Location = new Point(27, 87);
            labelCapEmprunte.Name = "labelCapEmprunte";
            labelCapEmprunte.Size = new Size(99, 15);
            labelCapEmprunte.TabIndex = 1;
            labelCapEmprunte.Text = "Capital Emprunté";
            // 
            // labelDureeMoisRemb
            // 
            labelDureeMoisRemb.Location = new Point(27, 143);
            labelDureeMoisRemb.Name = "labelDureeMoisRemb";
            labelDureeMoisRemb.Size = new Size(114, 31);
            labelDureeMoisRemb.TabIndex = 2;
            labelDureeMoisRemb.Text = "Durée en mois de remboursement";
            // 
            // textBoxNom
            // 
            textBoxNom.Location = new Point(181, 30);
            textBoxNom.Name = "textBoxNom";
            textBoxNom.Size = new Size(138, 23);
            textBoxNom.TabIndex = 3;
            // 
            // textBoxCapEmprunte
            // 
            textBoxCapEmprunte.Location = new Point(181, 84);
            textBoxCapEmprunte.MaxLength = 9;
            textBoxCapEmprunte.Name = "textBoxCapEmprunte";
            textBoxCapEmprunte.Size = new Size(138, 23);
            textBoxCapEmprunte.TabIndex = 4;
            textBoxCapEmprunte.TextChanged += textBoxCapEmprunte_TextChanged;
            // 
            // textBoxDureeMoisRemb
            // 
            textBoxDureeMoisRemb.Location = new Point(181, 140);
            textBoxDureeMoisRemb.Name = "textBoxDureeMoisRemb";
            textBoxDureeMoisRemb.ReadOnly = true;
            textBoxDureeMoisRemb.Size = new Size(39, 23);
            textBoxDureeMoisRemb.TabIndex = 5;
            // 
            // hScrollBarDureeMoisRemb
            // 
            hScrollBarDureeMoisRemb.Location = new Point(253, 140);
            hScrollBarDureeMoisRemb.Maximum = 250;
            hScrollBarDureeMoisRemb.Minimum = 1;
            hScrollBarDureeMoisRemb.Name = "hScrollBarDureeMoisRemb";
            hScrollBarDureeMoisRemb.Size = new Size(134, 23);
            hScrollBarDureeMoisRemb.TabIndex = 6;
            hScrollBarDureeMoisRemb.Value = 1;
            hScrollBarDureeMoisRemb.Scroll += hScrollBarDureeMoisRemb_Scroll;
            // 
            // labelPeriodicite
            // 
            labelPeriodicite.AutoSize = true;
            labelPeriodicite.Location = new Point(27, 210);
            labelPeriodicite.Name = "labelPeriodicite";
            labelPeriodicite.Size = new Size(167, 15);
            labelPeriodicite.TabIndex = 7;
            labelPeriodicite.Text = "Périodicité de remboursement";
            // 
            // listBoxPeriodicite
            // 
            listBoxPeriodicite.FormattingEnabled = true;
            listBoxPeriodicite.ItemHeight = 15;
            listBoxPeriodicite.Location = new Point(27, 228);
            listBoxPeriodicite.Name = "listBoxPeriodicite";
            listBoxPeriodicite.Size = new Size(265, 79);
            listBoxPeriodicite.TabIndex = 8;
            listBoxPeriodicite.SelectedIndexChanged += listBoxPeriodicite_SelectedIndexChanged;
            // 
            // groupBoxTauxInteret
            // 
            groupBoxTauxInteret.Controls.Add(radioButton9);
            groupBoxTauxInteret.Controls.Add(radioButton8);
            groupBoxTauxInteret.Controls.Add(radioButton7);
            groupBoxTauxInteret.Location = new Point(423, 30);
            groupBoxTauxInteret.Name = "groupBoxTauxInteret";
            groupBoxTauxInteret.Size = new Size(99, 144);
            groupBoxTauxInteret.TabIndex = 9;
            groupBoxTauxInteret.TabStop = false;
            groupBoxTauxInteret.Text = "Taux d'intérêt";
            // 
            // radioButton9
            // 
            radioButton9.AutoSize = true;
            radioButton9.Location = new Point(26, 98);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(44, 19);
            radioButton9.TabIndex = 2;
            radioButton9.TabStop = true;
            radioButton9.Text = "9 %";
            radioButton9.UseVisualStyleBackColor = true;
            radioButton9.CheckedChanged += radioButton9_CheckedChanged;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Location = new Point(26, 58);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(44, 19);
            radioButton8.TabIndex = 1;
            radioButton8.TabStop = true;
            radioButton8.Text = "8 %";
            radioButton8.UseVisualStyleBackColor = true;
            radioButton8.CheckedChanged += radioButton8_CheckedChanged;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(26, 22);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(44, 19);
            radioButton7.TabIndex = 0;
            radioButton7.TabStop = true;
            radioButton7.Text = "7 %";
            radioButton7.UseVisualStyleBackColor = true;
            radioButton7.CheckedChanged += radioButton7_CheckedChanged;
            // 
            // labelRemboursements
            // 
            labelRemboursements.AutoSize = true;
            labelRemboursements.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRemboursements.Location = new Point(389, 231);
            labelRemboursements.Name = "labelRemboursements";
            labelRemboursements.Size = new Size(133, 20);
            labelRemboursements.TabIndex = 11;
            labelRemboursements.Text = "Remboursements";
            // 
            // errorProviderCapital
            // 
            errorProviderCapital.ContainerControl = this;
            // 
            // labelNbRemb
            // 
            labelNbRemb.AutoSize = true;
            labelNbRemb.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelNbRemb.ForeColor = Color.Red;
            labelNbRemb.Location = new Point(340, 235);
            labelNbRemb.Name = "labelNbRemb";
            labelNbRemb.Size = new Size(14, 15);
            labelNbRemb.TabIndex = 13;
            labelNbRemb.Text = "1";
            // 
            // labelMontantRemb
            // 
            labelMontantRemb.AutoSize = true;
            labelMontantRemb.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelMontantRemb.ForeColor = Color.Red;
            labelMontantRemb.Location = new Point(399, 272);
            labelMontantRemb.Name = "labelMontantRemb";
            labelMontantRemb.Size = new Size(14, 15);
            labelMontantRemb.TabIndex = 14;
            labelMontantRemb.Text = "0";
            // 
            // FormEmprunts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 336);
            Controls.Add(labelMontantRemb);
            Controls.Add(labelNbRemb);
            Controls.Add(labelRemboursements);
            Controls.Add(groupBoxTauxInteret);
            Controls.Add(listBoxPeriodicite);
            Controls.Add(labelPeriodicite);
            Controls.Add(hScrollBarDureeMoisRemb);
            Controls.Add(textBoxDureeMoisRemb);
            Controls.Add(textBoxCapEmprunte);
            Controls.Add(textBoxNom);
            Controls.Add(labelDureeMoisRemb);
            Controls.Add(labelCapEmprunte);
            Controls.Add(labelNom);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "FormEmprunts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Emprunts";
            Load += FormEmprunts_Load;
            groupBoxTauxInteret.ResumeLayout(false);
            groupBoxTauxInteret.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderCapital).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNom;
        private Label labelCapEmprunte;
        private Label labelDureeMoisRemb;
        private TextBox textBoxNom;
        private TextBox textBoxCapEmprunte;
        private TextBox textBoxDureeMoisRemb;
        private HScrollBar hScrollBarDureeMoisRemb;
        private Label labelPeriodicite;
        private ListBox listBoxPeriodicite;
        private GroupBox groupBoxTauxInteret;
        private RadioButton radioButton9;
        private RadioButton radioButton8;
        private RadioButton radioButton7;
        private Label labelRemboursements;
        private ErrorProvider errorProviderCapital;
        private Label labelNbRemb;
        private Label labelMontantRemb;
    }
}
