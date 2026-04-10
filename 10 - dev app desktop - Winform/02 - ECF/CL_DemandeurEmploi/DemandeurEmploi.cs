namespace CL_DemandeurEmploi
{
    public class DemandeurEmploi
    {
        private string nom;
        private string dateInscription;
        private int niveauFormation;
                        // 1 = InfBac
                        // 2 = Bac
                        // 3 = Bac+2
                        // 4 = Bac+5
                        // 5 = SupBac+5
       

        public DemandeurEmploi()
        {
            
        }

        public DemandeurEmploi(string nom, string dateInscription, int niveauFormation)
        {
            this.nom = nom;
            this.dateInscription = dateInscription;
            this.niveauFormation = niveauFormation;
        }

        public string Nom { get => nom; set => nom = value; }
        public string DateInscription { get => dateInscription; set => dateInscription = value; }
        public int NiveauFormation { get => niveauFormation; set => niveauFormation = value; }

        
    }
}
