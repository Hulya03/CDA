namespace WFMenu
{
    partial class FormSidentifier
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
            labelLogin = new Label();
            labelPassword = new Label();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            buttonAnnuler = new Button();
            buttonOk = new Button();
            errorProviderIdentification = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProviderIdentification).BeginInit();
            SuspendLayout();
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Location = new Point(30, 21);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(37, 15);
            labelLogin.TabIndex = 0;
            labelLogin.Text = "Login";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(30, 61);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(57, 15);
            labelPassword.TabIndex = 1;
            labelPassword.Text = "Password";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(113, 21);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(129, 23);
            textBoxLogin.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(113, 61);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(129, 23);
            textBoxPassword.TabIndex = 3;
            // 
            // buttonAnnuler
            // 
            buttonAnnuler.Location = new Point(274, 61);
            buttonAnnuler.Name = "buttonAnnuler";
            buttonAnnuler.Size = new Size(89, 23);
            buttonAnnuler.TabIndex = 4;
            buttonAnnuler.Text = "Annuler";
            buttonAnnuler.UseVisualStyleBackColor = true;
            buttonAnnuler.Click += buttonAnnuler_Click;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(274, 90);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(89, 23);
            buttonOk.TabIndex = 5;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // errorProviderIdentification
            // 
            errorProviderIdentification.ContainerControl = this;
            // 
            // FormSidentifier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 118);
            Controls.Add(buttonOk);
            Controls.Add(buttonAnnuler);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(labelPassword);
            Controls.Add(labelLogin);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "FormSidentifier";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormSidentifier";
            ((System.ComponentModel.ISupportInitialize)errorProviderIdentification).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLogin;
        private Label labelPassword;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Button buttonAnnuler;
        private Button buttonOk;
        private ErrorProvider errorProviderIdentification;
    }
}