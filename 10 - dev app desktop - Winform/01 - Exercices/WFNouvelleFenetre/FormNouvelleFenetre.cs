using CL_Achat;

namespace WFNouvelleFenetre
{
    public partial class FormNouvelleFenetre : Form
    {

        //Constructeur par défaut utile pour faire le "Designer" 
        public FormNouvelleFenetre()
        {
            InitializeComponent();


        }
        /*
            1.faire un contructeur de la form avec l'objet 
            2.y ajouter l'objet en parametre 
            3. y modifier les label pour y ajouter les données de lobjet
         */

        //Constructeur avec surcharge, il accepte donc de nouveaux arguments
        public FormNouvelleFenetre(Achat monAchat)
        {
            InitializeComponent();

            labelNom.Text += monAchat.Nom;
            labelDate.Text += monAchat.Date;
            labelMontant.Text += monAchat.Montant;
            labelCode.Text += monAchat.CodePostal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
