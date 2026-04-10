namespace WFListBoxCombobox
{
    partial class FormListboxCombobox
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
            comboBoxSource = new ComboBox();
            labelSource = new Label();
            listBoxCible = new ListBox();
            LabelCible = new Label();
            buttonAjouter = new Button();
            buttonAjouterTout = new Button();
            buttonSupprimer = new Button();
            buttonSupprimerTout = new Button();
            buttonMonter = new Button();
            buttonDescendre = new Button();
            ePDoublon = new ErrorProvider(components);
            ePPresenceEspaceDebutFin = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)ePDoublon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ePPresenceEspaceDebutFin).BeginInit();
            SuspendLayout();
            // 
            // comboBoxSource
            // 
            comboBoxSource.FormattingEnabled = true;
            comboBoxSource.Location = new Point(12, 39);
            comboBoxSource.Name = "comboBoxSource";
            comboBoxSource.Size = new Size(121, 23);
            comboBoxSource.TabIndex = 0;
            comboBoxSource.DropDown += comboBoxSource_DropDown;
            comboBoxSource.SelectedIndexChanged += comboBoxSource_SelectedIndexChanged;
            comboBoxSource.TextChanged += comboBoxSource_TextChanged;
            // 
            // labelSource
            // 
            labelSource.AutoSize = true;
            labelSource.Location = new Point(39, 15);
            labelSource.Name = "labelSource";
            labelSource.Size = new Size(43, 15);
            labelSource.TabIndex = 2;
            labelSource.Text = "Source";
            // 
            // listBoxCible
            // 
            listBoxCible.FormattingEnabled = true;
            listBoxCible.ItemHeight = 15;
            listBoxCible.Location = new Point(201, 39);
            listBoxCible.Name = "listBoxCible";
            listBoxCible.Size = new Size(139, 154);
            listBoxCible.TabIndex = 3;
            listBoxCible.SelectedIndexChanged += listBoxCible_SelectedIndexChanged;
            // 
            // LabelCible
            // 
            LabelCible.AutoSize = true;
            LabelCible.Location = new Point(253, 15);
            LabelCible.Name = "LabelCible";
            LabelCible.Size = new Size(34, 15);
            LabelCible.TabIndex = 4;
            LabelCible.Text = "Cible";
            // 
            // buttonAjouter
            // 
            buttonAjouter.Enabled = false;
            buttonAjouter.Location = new Point(139, 39);
            buttonAjouter.Name = "buttonAjouter";
            buttonAjouter.Size = new Size(49, 23);
            buttonAjouter.TabIndex = 5;
            buttonAjouter.Text = ">";
            buttonAjouter.UseVisualStyleBackColor = true;
            buttonAjouter.Click += buttonAjouter_Click;
            // 
            // buttonAjouterTout
            // 
            buttonAjouterTout.Enabled = false;
            buttonAjouterTout.Location = new Point(139, 68);
            buttonAjouterTout.Name = "buttonAjouterTout";
            buttonAjouterTout.Size = new Size(49, 23);
            buttonAjouterTout.TabIndex = 6;
            buttonAjouterTout.Text = ">>";
            buttonAjouterTout.UseVisualStyleBackColor = true;
            buttonAjouterTout.Click += buttonAjouterTout_Click;
            // 
            // buttonSupprimer
            // 
            buttonSupprimer.Enabled = false;
            buttonSupprimer.Location = new Point(139, 141);
            buttonSupprimer.Name = "buttonSupprimer";
            buttonSupprimer.Size = new Size(49, 23);
            buttonSupprimer.TabIndex = 7;
            buttonSupprimer.Text = "<";
            buttonSupprimer.UseVisualStyleBackColor = true;
            buttonSupprimer.Click += buttonSupprimer_Click;
            // 
            // buttonSupprimerTout
            // 
            buttonSupprimerTout.Enabled = false;
            buttonSupprimerTout.Location = new Point(139, 170);
            buttonSupprimerTout.Name = "buttonSupprimerTout";
            buttonSupprimerTout.Size = new Size(49, 23);
            buttonSupprimerTout.TabIndex = 8;
            buttonSupprimerTout.Text = "<<";
            buttonSupprimerTout.UseVisualStyleBackColor = true;
            buttonSupprimerTout.Click += buttonSupprimerTout_Click;
            // 
            // buttonMonter
            // 
            buttonMonter.Enabled = false;
            buttonMonter.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            buttonMonter.Location = new Point(230, 199);
            buttonMonter.Name = "buttonMonter";
            buttonMonter.Size = new Size(35, 45);
            buttonMonter.TabIndex = 9;
            buttonMonter.Text = "🡱";
            buttonMonter.UseVisualStyleBackColor = true;
            buttonMonter.Click += buttonMonter_Click;
            // 
            // buttonDescendre
            // 
            buttonDescendre.Enabled = false;
            buttonDescendre.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            buttonDescendre.Location = new Point(271, 199);
            buttonDescendre.Name = "buttonDescendre";
            buttonDescendre.Size = new Size(35, 45);
            buttonDescendre.TabIndex = 10;
            buttonDescendre.Text = "🡳";
            buttonDescendre.UseVisualStyleBackColor = true;
            buttonDescendre.Click += buttonDescendre_Click;
            // 
            // ePDoublon
            // 
            ePDoublon.ContainerControl = this;
            // 
            // ePPresenceEspaceDebutFin
            // 
            ePPresenceEspaceDebutFin.ContainerControl = this;
            // 
            // FormListboxCombobox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 257);
            Controls.Add(buttonDescendre);
            Controls.Add(buttonMonter);
            Controls.Add(buttonSupprimerTout);
            Controls.Add(buttonSupprimer);
            Controls.Add(buttonAjouterTout);
            Controls.Add(buttonAjouter);
            Controls.Add(LabelCible);
            Controls.Add(listBoxCible);
            Controls.Add(labelSource);
            Controls.Add(comboBoxSource);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MinimizeBox = false;
            Name = "FormListboxCombobox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listbox et Combobox";
            Load += FormListboxCombobox_Load;
            ((System.ComponentModel.ISupportInitialize)ePDoublon).EndInit();
            ((System.ComponentModel.ISupportInitialize)ePPresenceEspaceDebutFin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxSource;
        private Label labelSource;
        private ListBox listBoxCible;
        private Label LabelCible;
        private Button buttonAjouter;
        private Button buttonAjouterTout;
        private Button buttonSupprimer;
        private Button buttonSupprimerTout;
        private Button buttonMonter;
        private Button buttonDescendre;
        private ErrorProvider ePDoublon;
        private ErrorProvider ePPresenceEspaceDebutFin;
    }
}
