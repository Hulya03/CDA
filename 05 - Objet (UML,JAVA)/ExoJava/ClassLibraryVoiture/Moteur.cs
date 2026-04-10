using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVoiture
{
    internal class Moteur
    {
        private int puissanceEnChevaux;
        private bool moteurTourne;

        public int PuissanceEnChevaux { get => puissanceEnChevaux; /*set => puissanceEnChevaux = value;*/ }
        public bool MoteurTourne { get => moteurTourne; /*set => moteurTourne = value;*/ }

        public Moteur(int puissanceEnChevaux, bool moteurTourne)
        {
            this.puissanceEnChevaux = puissanceEnChevaux;
            this.moteurTourne = moteurTourne;
        }

        public Moteur() : this(0, false)
        {

        }

        public Moteur(Moteur moteurACopier) : this(moteurACopier.puissanceEnChevaux, moteurACopier.MoteurTourne)
        {

        }

        public bool TournerMoteur()
        {
            if (moteurTourne == false)
            {
                moteurTourne = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ArreterMoteur()
        {
            if (moteurTourne == true)
            {
                moteurTourne = false;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool FaireTournerLesRoues(Roue roueAvantGauche, Roue roueAvantDroit)
        {
            if(moteurTourne == true)
            {
                if( roueAvantDroit.TournerRoue() && roueAvantGauche.TournerRoue())
                {
                    return true;
                }
                else
                {
                    return false;
                }    
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            string result;

            result = $"Moteur = [ PuissanceEnChevaux : {puissanceEnChevaux}, moteurTourne : {moteurTourne} ]";
            return result;
        }
    }
}
