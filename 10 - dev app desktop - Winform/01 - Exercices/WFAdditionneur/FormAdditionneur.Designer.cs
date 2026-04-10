namespace WFAdditionneur
{
    partial class FormAdditionneur
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
            textBoxZoneCalculs = new TextBox();
            btnCaseZero = new Button();
            btnCase1 = new Button();
            bntCase2 = new Button();
            btnCase3 = new Button();
            btnCase4 = new Button();
            btnCase5 = new Button();
            btnCase6 = new Button();
            btnCase7 = new Button();
            btnCase8 = new Button();
            btnCase9 = new Button();
            btnVider = new Button();
            btnValider = new Button();
            SuspendLayout();
            // 
            // textBoxZoneCalculs
            // 
            textBoxZoneCalculs.Location = new Point(30, 25);
            textBoxZoneCalculs.Multiline = true;
            textBoxZoneCalculs.Name = "textBoxZoneCalculs";
            textBoxZoneCalculs.ReadOnly = true;
            textBoxZoneCalculs.ScrollBars = ScrollBars.Vertical;
            textBoxZoneCalculs.Size = new Size(259, 111);
            textBoxZoneCalculs.TabIndex = 0;
            // 
            // btnCaseZero
            // 
            btnCaseZero.Location = new Point(30, 156);
            btnCaseZero.Name = "btnCaseZero";
            btnCaseZero.Size = new Size(47, 39);
            btnCaseZero.TabIndex = 1;
            btnCaseZero.Text = "0";
            btnCaseZero.UseVisualStyleBackColor = true;
            btnCaseZero.Click += btnCaseGeneral_Click;
            // 
            // btnCase1
            // 
            btnCase1.Location = new Point(83, 156);
            btnCase1.Name = "btnCase1";
            btnCase1.Size = new Size(47, 39);
            btnCase1.TabIndex = 2;
            btnCase1.Text = "1";
            btnCase1.UseVisualStyleBackColor = true;
            btnCase1.Click += btnCaseGeneral_Click;
            // 
            // bntCase2
            // 
            bntCase2.Location = new Point(136, 156);
            bntCase2.Name = "bntCase2";
            bntCase2.Size = new Size(47, 39);
            bntCase2.TabIndex = 3;
            bntCase2.Text = "2";
            bntCase2.UseVisualStyleBackColor = true;
            bntCase2.Click += btnCaseGeneral_Click;
            // 
            // btnCase3
            // 
            btnCase3.Location = new Point(189, 156);
            btnCase3.Name = "btnCase3";
            btnCase3.Size = new Size(47, 39);
            btnCase3.TabIndex = 4;
            btnCase3.Text = "3";
            btnCase3.UseVisualStyleBackColor = true;
            btnCase3.Click += btnCaseGeneral_Click;
            // 
            // btnCase4
            // 
            btnCase4.Location = new Point(242, 156);
            btnCase4.Name = "btnCase4";
            btnCase4.Size = new Size(47, 39);
            btnCase4.TabIndex = 5;
            btnCase4.Text = "4";
            btnCase4.UseVisualStyleBackColor = true;
            btnCase4.Click += btnCaseGeneral_Click;
            // 
            // btnCase5
            // 
            btnCase5.Location = new Point(30, 201);
            btnCase5.Name = "btnCase5";
            btnCase5.Size = new Size(47, 39);
            btnCase5.TabIndex = 6;
            btnCase5.Text = "5";
            btnCase5.UseVisualStyleBackColor = true;
            btnCase5.Click += btnCaseGeneral_Click;
            // 
            // btnCase6
            // 
            btnCase6.Location = new Point(83, 201);
            btnCase6.Name = "btnCase6";
            btnCase6.Size = new Size(47, 39);
            btnCase6.TabIndex = 7;
            btnCase6.Text = "6";
            btnCase6.UseVisualStyleBackColor = true;
            btnCase6.Click += btnCaseGeneral_Click;
            // 
            // btnCase7
            // 
            btnCase7.Location = new Point(136, 201);
            btnCase7.Name = "btnCase7";
            btnCase7.Size = new Size(47, 39);
            btnCase7.TabIndex = 8;
            btnCase7.Text = "7";
            btnCase7.UseVisualStyleBackColor = true;
            btnCase7.Click += btnCaseGeneral_Click;
            // 
            // btnCase8
            // 
            btnCase8.Location = new Point(189, 201);
            btnCase8.Name = "btnCase8";
            btnCase8.Size = new Size(47, 39);
            btnCase8.TabIndex = 9;
            btnCase8.Text = "8";
            btnCase8.UseVisualStyleBackColor = true;
            btnCase8.Click += btnCaseGeneral_Click;
            // 
            // btnCase9
            // 
            btnCase9.Location = new Point(242, 201);
            btnCase9.Name = "btnCase9";
            btnCase9.Size = new Size(47, 39);
            btnCase9.TabIndex = 10;
            btnCase9.Text = "9";
            btnCase9.UseVisualStyleBackColor = true;
            btnCase9.Click += btnCaseGeneral_Click;
            // 
            // btnVider
            // 
            btnVider.Location = new Point(30, 266);
            btnVider.Name = "btnVider";
            btnVider.Size = new Size(100, 23);
            btnVider.TabIndex = 11;
            btnVider.Text = "Vider";
            btnVider.UseVisualStyleBackColor = true;
            btnVider.Click += btnVider_Click;
            // 
            // btnValider
            // 
            btnValider.Location = new Point(189, 266);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(100, 23);
            btnValider.TabIndex = 12;
            btnValider.Text = "Calculer";
            btnValider.UseVisualStyleBackColor = true;
            btnValider.Click += btnValider_Click;
            // 
            // FormAdditionneur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 368);
            Controls.Add(btnValider);
            Controls.Add(btnVider);
            Controls.Add(btnCase9);
            Controls.Add(btnCase8);
            Controls.Add(btnCase7);
            Controls.Add(btnCase6);
            Controls.Add(btnCase5);
            Controls.Add(btnCase4);
            Controls.Add(btnCase3);
            Controls.Add(bntCase2);
            Controls.Add(btnCase1);
            Controls.Add(btnCaseZero);
            Controls.Add(textBoxZoneCalculs);
            Name = "FormAdditionneur";
            Text = "FormAdditionneur";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxZoneCalculs;
        private Button btnCaseZero;
        private Button btnCase1;
        private Button bntCase2;
        private Button btnCase3;
        private Button btnCase4;
        private Button btnCase5;
        private Button btnCase6;
        private Button btnCase7;
        private Button btnCase8;
        private Button btnCase9;
        private Button btnVider;
        private Button btnValider;
    }
}