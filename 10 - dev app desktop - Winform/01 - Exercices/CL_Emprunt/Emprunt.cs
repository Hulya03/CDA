using System.Globalization;

namespace CL_Emprunt
{
    public class Emprunt
    {
        private string nom;
        private int capitalEmprunte;
        private double taux; 
        private int dureeMoisRemb;
        private int periodicite; 


        public Emprunt()
        {
            this.nom = "";
            this.capitalEmprunte = 0;                               //j'ai bloqué le nombre de caractère à 9 pour le capital emprunté pour eviter de sortir des limite des calculs
            this.taux = 0.07d;
            this.dureeMoisRemb = 1;
            this.periodicite = 1;

            // periodicite à traduire du coté interface 
            // 1 = mensuel 
            // 2 = bimestriel
            // 3 = trimestriel
            // 6 = semestriel
            // 12 = annuel
        }

        public Emprunt(string nom, int capitalEmprunte, double taux, int dureeMoisRemb, int periodicite)
        {
            this.nom = nom;
            this.capitalEmprunte = capitalEmprunte;
            this.taux = taux;
            this.dureeMoisRemb = dureeMoisRemb;
            this.periodicite = periodicite;
        }

        public string Nom { get => nom; set => nom = value; }
        public int CapitalEmprunte { get => capitalEmprunte; set => capitalEmprunte = value; }
        public double Taux { get => taux; set => taux = value; }
        public int DureeMoisRemb { get => dureeMoisRemb; set => dureeMoisRemb = value; }
        public int Periodicite { get => periodicite; set => periodicite = value; }


        public int CalculNbRemboursement()
        {
            int nbRemboursement = this.dureeMoisRemb / this.periodicite;

            return nbRemboursement;
        }
        public double CalculerMensualite()
        {
            // attention : le calcul dans l'exercice est seulement pour obtenir une mensualité, alors qu'on peut faire des calculs pour
            // faire des paiements bimestriel, trimestriel.. D'où le taux annuel / 12 pour avoir le taux mensuel puis * periodicité
            double montantRemb = this.capitalEmprunte * ((this.taux / 12 * this.periodicite)  / (1 - Math.Pow (1 + (this.taux / 12 * this.periodicite), - CalculNbRemboursement())));
            //double montantRembArrondi = Math.Round(montantRemb, 2);

            return montantRemb;
        }


    }
}
