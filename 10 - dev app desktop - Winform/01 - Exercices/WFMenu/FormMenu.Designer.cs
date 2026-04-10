namespace WFMenu
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            menuStrip1 = new MenuStrip();
            connectionToolStripMenuItem = new ToolStripMenuItem();
            sidentifierToolStripMenuItem = new ToolStripMenuItem();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            phase1ToolStripMenuItem = new ToolStripMenuItem();
            additionneurToolStripMenuItem = new ToolStripMenuItem();
            phase2ToolStripMenuItem = new ToolStripMenuItem();
            contrôlesDeSaisieToolStripMenuItem = new ToolStripMenuItem();
            phase3ToolStripMenuItem = new ToolStripMenuItem();
            checkBoxEtBoutonsRadiosToolStripMenuItem = new ToolStripMenuItem();
            listboxBaseToolStripMenuItem = new ToolStripMenuItem();
            listboxEtComboboxToolStripMenuItem = new ToolStripMenuItem();
            defilementToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            synthèseToolStripMenuItem = new ToolStripMenuItem();
            fenêtresToolStripMenuItem = new ToolStripMenuItem();
            cascadeToolStripMenuItem = new ToolStripMenuItem();
            horizontaleToolStripMenuItem = new ToolStripMenuItem();
            verticalToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripMenuItem1 = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelDate = new ToolStripStatusLabel();
            toolStripStatusLabelEtat = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            toolStripButtonSidentifier = new ToolStripButton();
            toolStripSplitButtonPhase3 = new ToolStripSplitButton();
            checkBoxEtBoutonsRadioToolStripMenuItem = new ToolStripMenuItem();
            listboxBaseToolStripMenuItem1 = new ToolStripMenuItem();
            listboxEtComboboxToolStripMenuItem1 = new ToolStripMenuItem();
            defilementToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            synthèseToolStripMenuItem1 = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { connectionToolStripMenuItem, phase1ToolStripMenuItem, phase2ToolStripMenuItem, phase3ToolStripMenuItem, fenêtresToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.MdiWindowListItem = fenêtresToolStripMenuItem;
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // connectionToolStripMenuItem
            // 
            connectionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sidentifierToolStripMenuItem, quitterToolStripMenuItem });
            connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            connectionToolStripMenuItem.Size = new Size(81, 20);
            connectionToolStripMenuItem.Text = "Connection";
            // 
            // sidentifierToolStripMenuItem
            // 
            sidentifierToolStripMenuItem.Name = "sidentifierToolStripMenuItem";
            sidentifierToolStripMenuItem.Size = new Size(130, 22);
            sidentifierToolStripMenuItem.Text = "S'identifier";
            sidentifierToolStripMenuItem.Click += sidentifierToolStripMenuItem_Click;
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new Size(130, 22);
            quitterToolStripMenuItem.Text = "Quitter";
            quitterToolStripMenuItem.Click += quitterToolStripMenuItem_Click;
            // 
            // phase1ToolStripMenuItem
            // 
            phase1ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { additionneurToolStripMenuItem });
            phase1ToolStripMenuItem.Enabled = false;
            phase1ToolStripMenuItem.Name = "phase1ToolStripMenuItem";
            phase1ToolStripMenuItem.Size = new Size(59, 20);
            phase1ToolStripMenuItem.Text = "Phase 1";
            // 
            // additionneurToolStripMenuItem
            // 
            additionneurToolStripMenuItem.Name = "additionneurToolStripMenuItem";
            additionneurToolStripMenuItem.Size = new Size(144, 22);
            additionneurToolStripMenuItem.Text = "Additionneur";
            additionneurToolStripMenuItem.Click += additionneurToolStripMenuItem_Click;
            // 
            // phase2ToolStripMenuItem
            // 
            phase2ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { contrôlesDeSaisieToolStripMenuItem });
            phase2ToolStripMenuItem.Enabled = false;
            phase2ToolStripMenuItem.Name = "phase2ToolStripMenuItem";
            phase2ToolStripMenuItem.Size = new Size(59, 20);
            phase2ToolStripMenuItem.Text = "Phase 2";
            // 
            // contrôlesDeSaisieToolStripMenuItem
            // 
            contrôlesDeSaisieToolStripMenuItem.Name = "contrôlesDeSaisieToolStripMenuItem";
            contrôlesDeSaisieToolStripMenuItem.Size = new Size(172, 22);
            contrôlesDeSaisieToolStripMenuItem.Text = "Contrôles de saisie";
            contrôlesDeSaisieToolStripMenuItem.Click += contrôlesDeSaisieToolStripMenuItem_Click;
            // 
            // phase3ToolStripMenuItem
            // 
            phase3ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { checkBoxEtBoutonsRadiosToolStripMenuItem, listboxBaseToolStripMenuItem, listboxEtComboboxToolStripMenuItem, defilementToolStripMenuItem, toolStripSeparator1, synthèseToolStripMenuItem });
            phase3ToolStripMenuItem.Enabled = false;
            phase3ToolStripMenuItem.Name = "phase3ToolStripMenuItem";
            phase3ToolStripMenuItem.Size = new Size(59, 20);
            phase3ToolStripMenuItem.Text = "Phase 3";
            // 
            // checkBoxEtBoutonsRadiosToolStripMenuItem
            // 
            checkBoxEtBoutonsRadiosToolStripMenuItem.Name = "checkBoxEtBoutonsRadiosToolStripMenuItem";
            checkBoxEtBoutonsRadiosToolStripMenuItem.Size = new Size(224, 22);
            checkBoxEtBoutonsRadiosToolStripMenuItem.Text = "Check box et boutons radios";
            checkBoxEtBoutonsRadiosToolStripMenuItem.Click += checkBoxEtBoutonsRadiosToolStripMenuItem_Click;
            // 
            // listboxBaseToolStripMenuItem
            // 
            listboxBaseToolStripMenuItem.Name = "listboxBaseToolStripMenuItem";
            listboxBaseToolStripMenuItem.Size = new Size(224, 22);
            listboxBaseToolStripMenuItem.Text = "Listbox base";
            listboxBaseToolStripMenuItem.Click += listboxBaseToolStripMenuItem_Click;
            // 
            // listboxEtComboboxToolStripMenuItem
            // 
            listboxEtComboboxToolStripMenuItem.Name = "listboxEtComboboxToolStripMenuItem";
            listboxEtComboboxToolStripMenuItem.Size = new Size(224, 22);
            listboxEtComboboxToolStripMenuItem.Text = "Listbox et Combobox";
            listboxEtComboboxToolStripMenuItem.Click += listboxEtComboboxToolStripMenuItem_Click;
            // 
            // defilementToolStripMenuItem
            // 
            defilementToolStripMenuItem.Name = "defilementToolStripMenuItem";
            defilementToolStripMenuItem.Size = new Size(224, 22);
            defilementToolStripMenuItem.Text = "Defilement";
            defilementToolStripMenuItem.Click += defilementToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(221, 6);
            // 
            // synthèseToolStripMenuItem
            // 
            synthèseToolStripMenuItem.Name = "synthèseToolStripMenuItem";
            synthèseToolStripMenuItem.Size = new Size(224, 22);
            synthèseToolStripMenuItem.Text = "Synthèse";
            synthèseToolStripMenuItem.Click += synthèseToolStripMenuItem_Click;
            // 
            // fenêtresToolStripMenuItem
            // 
            fenêtresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cascadeToolStripMenuItem, horizontaleToolStripMenuItem, verticalToolStripMenuItem, toolStripSeparator2 });
            fenêtresToolStripMenuItem.Enabled = false;
            fenêtresToolStripMenuItem.Name = "fenêtresToolStripMenuItem";
            fenêtresToolStripMenuItem.Size = new Size(63, 20);
            fenêtresToolStripMenuItem.Text = "Fenêtres";
            // 
            // cascadeToolStripMenuItem
            // 
            cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            cascadeToolStripMenuItem.Size = new Size(180, 22);
            cascadeToolStripMenuItem.Text = "Cascade";
            cascadeToolStripMenuItem.Click += cascadeToolStripMenuItem_Click;
            // 
            // horizontaleToolStripMenuItem
            // 
            horizontaleToolStripMenuItem.Name = "horizontaleToolStripMenuItem";
            horizontaleToolStripMenuItem.Size = new Size(180, 22);
            horizontaleToolStripMenuItem.Text = "Horizontale";
            horizontaleToolStripMenuItem.Click += horizontaleToolStripMenuItem_Click;
            // 
            // verticalToolStripMenuItem
            // 
            verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            verticalToolStripMenuItem.Size = new Size(180, 22);
            verticalToolStripMenuItem.Text = "Vertical";
            verticalToolStripMenuItem.Click += verticalToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(177, 6);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(32, 19);
            toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelDate, toolStripStatusLabelEtat });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelDate
            // 
            toolStripStatusLabelDate.Name = "toolStripStatusLabelDate";
            toolStripStatusLabelDate.Size = new Size(49, 17);
            toolStripStatusLabelDate.Text = "              ";
            // 
            // toolStripStatusLabelEtat
            // 
            toolStripStatusLabelEtat.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            toolStripStatusLabelEtat.Name = "toolStripStatusLabelEtat";
            toolStripStatusLabelEtat.Size = new Size(0, 17);
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonSidentifier, toolStripSplitButtonPhase3 });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 5;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonSidentifier
            // 
            toolStripButtonSidentifier.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonSidentifier.Image = (Image)resources.GetObject("toolStripButtonSidentifier.Image");
            toolStripButtonSidentifier.ImageTransparentColor = Color.Magenta;
            toolStripButtonSidentifier.Name = "toolStripButtonSidentifier";
            toolStripButtonSidentifier.Size = new Size(67, 22);
            toolStripButtonSidentifier.Text = "S'identifier";
            toolStripButtonSidentifier.Click += toolStripButtonSidentifier_Click;
            // 
            // toolStripSplitButtonPhase3
            // 
            toolStripSplitButtonPhase3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripSplitButtonPhase3.DropDownItems.AddRange(new ToolStripItem[] { checkBoxEtBoutonsRadioToolStripMenuItem, listboxBaseToolStripMenuItem1, listboxEtComboboxToolStripMenuItem1, defilementToolStripMenuItem1, toolStripSeparator3, synthèseToolStripMenuItem1 });
            toolStripSplitButtonPhase3.Enabled = false;
            toolStripSplitButtonPhase3.Image = (Image)resources.GetObject("toolStripSplitButtonPhase3.Image");
            toolStripSplitButtonPhase3.ImageTransparentColor = Color.Magenta;
            toolStripSplitButtonPhase3.Name = "toolStripSplitButtonPhase3";
            toolStripSplitButtonPhase3.Size = new Size(63, 22);
            toolStripSplitButtonPhase3.Text = "Phase 3";
            // 
            // checkBoxEtBoutonsRadioToolStripMenuItem
            // 
            checkBoxEtBoutonsRadioToolStripMenuItem.Name = "checkBoxEtBoutonsRadioToolStripMenuItem";
            checkBoxEtBoutonsRadioToolStripMenuItem.Size = new Size(224, 22);
            checkBoxEtBoutonsRadioToolStripMenuItem.Text = "Check Box et boutons radios";
            checkBoxEtBoutonsRadioToolStripMenuItem.Click += checkBoxEtBoutonsRadioToolStripMenuItem_Click;
            // 
            // listboxBaseToolStripMenuItem1
            // 
            listboxBaseToolStripMenuItem1.Name = "listboxBaseToolStripMenuItem1";
            listboxBaseToolStripMenuItem1.Size = new Size(224, 22);
            listboxBaseToolStripMenuItem1.Text = "Listbox base";
            listboxBaseToolStripMenuItem1.Click += listboxBaseToolStripMenuItem1_Click;
            // 
            // listboxEtComboboxToolStripMenuItem1
            // 
            listboxEtComboboxToolStripMenuItem1.Name = "listboxEtComboboxToolStripMenuItem1";
            listboxEtComboboxToolStripMenuItem1.Size = new Size(224, 22);
            listboxEtComboboxToolStripMenuItem1.Text = "Listbox et Combobox";
            listboxEtComboboxToolStripMenuItem1.Click += listboxEtComboboxToolStripMenuItem1_Click;
            // 
            // defilementToolStripMenuItem1
            // 
            defilementToolStripMenuItem1.Name = "defilementToolStripMenuItem1";
            defilementToolStripMenuItem1.Size = new Size(224, 22);
            defilementToolStripMenuItem1.Text = "Defilement";
            defilementToolStripMenuItem1.Click += defilementToolStripMenuItem1_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(221, 6);
            // 
            // synthèseToolStripMenuItem1
            // 
            synthèseToolStripMenuItem1.Name = "synthèseToolStripMenuItem1";
            synthèseToolStripMenuItem1.Size = new Size(224, 22);
            synthèseToolStripMenuItem1.Text = "Synthèse";
            synthèseToolStripMenuItem1.Click += synthèseToolStripMenuItem1_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Créer des formulaires";
            WindowState = FormWindowState.Maximized;
            Load += FormMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem connectionToolStripMenuItem;
        private ToolStripMenuItem sidentifierToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem phase1ToolStripMenuItem;
        private ToolStripMenuItem phase2ToolStripMenuItem;
        private ToolStripMenuItem phase3ToolStripMenuItem;
        private ToolStripMenuItem fenêtresToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem additionneurToolStripMenuItem;
        private ToolStripMenuItem contrôlesDeSaisieToolStripMenuItem;
        private ToolStripMenuItem checkBoxEtBoutonsRadiosToolStripMenuItem;
        private ToolStripMenuItem listboxBaseToolStripMenuItem;
        private ToolStripMenuItem listboxEtComboboxToolStripMenuItem;
        private ToolStripMenuItem defilementToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem synthèseToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripMenuItem cascadeToolStripMenuItem;
        private ToolStripMenuItem horizontaleToolStripMenuItem;
        private ToolStripMenuItem verticalToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButtonSidentifier;
        private ToolStripSplitButton toolStripSplitButtonPhase3;
        private ToolStripMenuItem checkBoxEtBoutonsRadioToolStripMenuItem;
        private ToolStripMenuItem listboxBaseToolStripMenuItem1;
        private ToolStripMenuItem listboxEtComboboxToolStripMenuItem1;
        private ToolStripMenuItem defilementToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem synthèseToolStripMenuItem1;
        private ToolStripStatusLabel toolStripStatusLabelDate;
        private System.Windows.Forms.Timer timer1;
        private ToolStripStatusLabel toolStripStatusLabelEtat;
    }
}
