namespace WFValidationSaisieEP
{
    partial class FormValidationSaisieEP
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
            components = new System.ComponentModel.Container();
            labelNom = new Label();
            labelDate = new Label();
            labelMontant = new Label();
            labelCP = new Label();
            txtNom = new TextBox();
            txtDate = new TextBox();
            txtMontant = new TextBox();
            txtCP = new TextBox();
            btnValider = new Button();
            btnEffacer = new Button();
            imageList1 = new ImageList(components);
            labelDateFormat = new Label();
            errorProviderNom = new ErrorProvider(components);
            errorProviderDate = new ErrorProvider(components);
            errorProviderMontant = new ErrorProvider(components);
            errorProviderCP = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProviderNom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderDate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderMontant).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderCP).BeginInit();
            SuspendLayout();
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.Location = new Point(24, 36);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(34, 15);
            labelNom.TabIndex = 0;
            labelNom.Text = "Nom";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(24, 72);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(31, 15);
            labelDate.TabIndex = 1;
            labelDate.Text = "Date";
            // 
            // labelMontant
            // 
            labelMontant.AutoSize = true;
            labelMontant.Location = new Point(24, 110);
            labelMontant.Name = "labelMontant";
            labelMontant.Size = new Size(53, 15);
            labelMontant.TabIndex = 2;
            labelMontant.Text = "Montant";
            // 
            // labelCP
            // 
            labelCP.AutoSize = true;
            labelCP.Location = new Point(24, 150);
            labelCP.Name = "labelCP";
            labelCP.Size = new Size(70, 15);
            labelCP.TabIndex = 3;
            labelCP.Text = "Code Postal";
            // 
            // txtNom
            // 
            txtNom.Location = new Point(131, 36);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(170, 23);
            txtNom.TabIndex = 4;
            txtNom.Tag = "Nom";
            txtNom.Validating += txtNom_Validating;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(131, 72);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(125, 23);
            txtDate.TabIndex = 5;
            txtDate.Tag = "Date";
            txtDate.Validating += txtDate_Validating;
            // 
            // txtMontant
            // 
            txtMontant.Location = new Point(131, 110);
            txtMontant.Name = "txtMontant";
            txtMontant.Size = new Size(125, 23);
            txtMontant.TabIndex = 6;
            txtMontant.Tag = "Montant";
            txtMontant.Validating += txtMontant_Validating;
            // 
            // txtCP
            // 
            txtCP.Location = new Point(131, 150);
            txtCP.Name = "txtCP";
            txtCP.Size = new Size(93, 23);
            txtCP.TabIndex = 7;
            txtCP.Tag = "Code Postal";
            txtCP.Validating += txtCP_Validating;
            // 
            // btnValider
            // 
            btnValider.Location = new Point(297, 150);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(75, 23);
            btnValider.TabIndex = 8;
            btnValider.Text = "Valider";
            btnValider.UseVisualStyleBackColor = true;
            btnValider.Click += btnValider_Click;
            // 
            // btnEffacer
            // 
            btnEffacer.CausesValidation = false;
            btnEffacer.Location = new Point(297, 179);
            btnEffacer.Name = "btnEffacer";
            btnEffacer.Size = new Size(75, 23);
            btnEffacer.TabIndex = 9;
            btnEffacer.Text = "Effacer";
            btnEffacer.UseVisualStyleBackColor = true;
            btnEffacer.Click += btnEffacer_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // labelDateFormat
            // 
            labelDateFormat.AutoSize = true;
            labelDateFormat.Location = new Point(268, 72);
            labelDateFormat.Name = "labelDateFormat";
            labelDateFormat.Size = new Size(87, 15);
            labelDateFormat.TabIndex = 10;
            labelDateFormat.Text = "(JJ/MM/AAAA)";
            // 
            // errorProviderNom
            // 
            errorProviderNom.ContainerControl = this;
            // 
            // errorProviderDate
            // 
            errorProviderDate.ContainerControl = this;
            // 
            // errorProviderMontant
            // 
            errorProviderMontant.ContainerControl = this;
            // 
            // errorProviderCP
            // 
            errorProviderCP.ContainerControl = this;
            // 
            // FormValidationSaisieEP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 220);
            Controls.Add(labelDateFormat);
            Controls.Add(btnEffacer);
            Controls.Add(btnValider);
            Controls.Add(txtCP);
            Controls.Add(txtMontant);
            Controls.Add(txtDate);
            Controls.Add(txtNom);
            Controls.Add(labelCP);
            Controls.Add(labelMontant);
            Controls.Add(labelDate);
            Controls.Add(labelNom);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "FormValidationSaisieEP";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "";
            Text = "FormValidationSaisie";
            FormClosing += FormValidationSaisie_FormClosing;
            ((System.ComponentModel.ISupportInitialize)errorProviderNom).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderDate).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderMontant).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderCP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNom;
        private Label labelDate;
        private Label labelMontant;
        private Label labelCP;
        private TextBox txtNom;
        private TextBox txtDate;
        private TextBox txtMontant;
        private TextBox txtCP;
        private Button btnValider;
        private Button btnEffacer;
        private ImageList imageList1;
        private Label labelDateFormat;
        private ErrorProvider errorProviderNom;
        private ErrorProvider errorProviderDate;
        private ErrorProvider errorProviderMontant;
        private ErrorProvider errorProviderCP;
    }
}