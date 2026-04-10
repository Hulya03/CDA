namespace WFDefilement
{
    public partial class FormDefilement : Form
    {
        private Color renk;

        public Color Renk { get => renk; /*set => renk = value;*/ }

        public FormDefilement():this(Color.Black)    //constructeur créé par interdépendance, cad à partir du constructeur classique
        {
        }

        public FormDefilement(Color renk)
        {
            InitializeComponent();
            this.renk = renk;
            UpdateView();
        }

        private void UpdateView()
        {
            hScrollBarRouge.Value = this.renk.R;
            hScrollBarBleu.Value = this.renk.B;
            hScrollBarVert.Value = this.renk.G;

            numericUpDownRouge.Value = this.renk.R;
            numericUpDownBleu.Value = this.renk.B;
            numericUpDownVert.Value = this.renk.G;

            labelCadreRouge.BackColor = Color.FromArgb(hScrollBarRouge.Value, 0, 0);
            labelCadreVert.BackColor = Color.FromArgb(0, hScrollBarVert.Value, 0);
            labelCadreBleu.BackColor = Color.FromArgb(0, 0, hScrollBarBleu.Value);

            labelCadreResultat.BackColor = renk;
            //
        }

        private void hScrollBarRouge_Scroll(object sender, ScrollEventArgs e)
        {
            renk = Color.FromArgb(hScrollBarRouge.Value, renk.G, renk.B);

            
            UpdateView();
        }

        private void numericUpDownRouge_ValueChanged(object sender, EventArgs e)
        {
            renk = Color.FromArgb((int)numericUpDownRouge.Value, renk.G, renk.B);

            UpdateView();
        }

        private void hScrollBarVert_Scroll(object sender, ScrollEventArgs e)
        {
            renk = Color.FromArgb(renk.R, hScrollBarVert.Value, renk.B);
            UpdateView();
        }

        private void numericUpDownVert_ValueChanged(object sender, EventArgs e)
        {
            renk = Color.FromArgb(renk.R, (int)numericUpDownVert.Value, renk.B);

            UpdateView();
        }

        private void hScrollBarBleu_Scroll(object sender, ScrollEventArgs e)
        {
            renk = Color.FromArgb(renk.R, renk.G, hScrollBarBleu.Value);
            UpdateView();
        }

        private void numericUpDownBleu_ValueChanged(object sender, EventArgs e)
        {
            renk = Color.FromArgb(renk.R, renk.G, (int)numericUpDownBleu.Value);

            UpdateView();
        }
    }



    /*
     * facon "simple" de coder 
     * 
     private void hScrollBarRouge_Scroll(object sender, ScrollEventArgs e)
        {
            labelCadreRouge.BackColor = Color.FromArgb(hScrollBarRouge.Value, 0, 0);
            numericUpDownRouge.Value = hScrollBarRouge.Value;

            labelCadreResultat.BackColor = Color.FromArgb(hScrollBarRouge.Value, hScrollBarVert.Value, hScrollBarBleu.Value);
        }

        private void numericUpDownRouge_ValueChanged(object sender, EventArgs e)
        {
            hScrollBarRouge.Value = (int)numericUpDownRouge.Value;
        }

        private void hScrollBarVert_Scroll(object sender, ScrollEventArgs e)
        {
            labelCadreVert.BackColor = Color.FromArgb(0, hScrollBarVert.Value, 0);
            numericUpDownVert.Value = hScrollBarVert.Value;

            labelCadreResultat.BackColor = Color.FromArgb(hScrollBarRouge.Value, hScrollBarVert.Value, hScrollBarBleu.Value);

        }

        private void numericUpDownVert_ValueChanged(object sender, EventArgs e)
        {
            hScrollBarVert.Value = (int)numericUpDownVert.Value;
        }

        private void hScrollBarBleu_Scroll(object sender, ScrollEventArgs e)
        {
            labelCadreBleu.BackColor = Color.FromArgb(0, 0, hScrollBarBleu.Value);
            numericUpDownBleu.Value = hScrollBarBleu.Value;

            labelCadreResultat.BackColor = Color.FromArgb(hScrollBarRouge.Value, hScrollBarVert.Value, hScrollBarBleu.Value);

        }

        private void numericUpDownBleu_ValueChanged(object sender, EventArgs e)
        {
            hScrollBarBleu.Value = (int)(numericUpDownBleu.Value);
        }
    }
     
     */
}
