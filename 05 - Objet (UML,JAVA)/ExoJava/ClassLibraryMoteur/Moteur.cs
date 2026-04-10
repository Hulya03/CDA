namespace ClassLibraryMoteur
{
    public class Moteur
    {
        private int puissanceEnChevaux;
        private bool moteurTourne;

        public Moteur (int puissanceEnChevaux, bool moteurTourne)
        {
            this.puissanceEnChevaux = puissanceEnChevaux;
            this.moteurTourne = moteurTourne;
        }

        public Moteur() :this(0, false)
        {

        }

        public Moteur(Moteur moteurACopier) : this(moteurACopier.puissanceEnChevaux, moteurACopier.moteurTourne)
        {

        }

        public bool TournerMoteur()
        {
            if(moteurTourne == false) 
                {
                    moteurTourne = true;
                    return true;
                }
            return false;
        }

        public bool ArreterMoteur()
        {
            if (moteurTourne == true)
            {
                moteurTourne= false;
                return true;
            }
            return false;
        }

        public bool FaireTournerLesRoues(Roue roueAvantGauche, Roue roueAvantDroit)
        {

        }
    }
}
