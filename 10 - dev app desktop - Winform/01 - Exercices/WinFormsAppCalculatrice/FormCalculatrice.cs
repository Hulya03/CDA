namespace WinFormsAppCalculatrice
{
    public partial class FormCalculatrice : Form
    {
        public FormCalculatrice()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)   // expéditeur et infos propre à l'évènement
        {
            FormAdditionneur f = new FormAdditionneur();
            f.ShowDialog(); // ouverture de fenetre en modal - bloquant 
            // f.Show(); // non modal - non bloquant mais plus difficile à coder

           
        }
    }
}
