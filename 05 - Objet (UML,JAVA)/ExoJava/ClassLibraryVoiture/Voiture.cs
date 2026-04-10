using System.Data;
using System.Security.AccessControl;

namespace ClassLibraryVoiture
{
    public class Voiture
    {

        private string marque;
        private Moteur sonMoteur;
        private Roue[] sesRoues;

        internal string Marque { get => marque;/* set => marque = value;*/ }
        //internal Moteur SonMoteur { get => sonMoteur; /*set => sonMoteur = value;*/ }   // attention avec les get sur objet et tableau car on peut modifier le tabler ou agir sur les obkets avec des focntion !!
        //internal Roue[] SesRoues { get => sesRoues;/* set => sesRoues = value;*/ }

        private Voiture(string marque,Moteur sonMonteur, Roue[] sesRoues)
        {
            this.marque = marque;
            this.sonMoteur = sonMonteur;
            this.sesRoues = sesRoues ;
        }

        public Voiture(string marque, int puissanceEnChevaux, string marqueRoue)
        {
            this.marque = marque;
            this.sonMoteur = new Moteur(puissanceEnChevaux, false);
            this.sesRoues = new Roue[4];
            for (int i = 0; i < this.sesRoues.Length; i++)
            {
                this.sesRoues[i] = new Roue(marqueRoue, false);
            }
        }
                
        public Voiture():this("", 0, "")
        {
        }

        public Voiture(Voiture voitureACopier) : this(voitureACopier.marque,new Moteur(voitureACopier.sonMoteur), new Roue[4] { new Roue(voitureACopier.sesRoues[0]), new Roue(voitureACopier.sesRoues[1]), new Roue (voitureACopier.sesRoues[2]), new Roue (voitureACopier.sesRoues[3])})  //quand on clone, on refait chaque objet avet le "new" (pour savoir si le constructeur fonctionne correctement, verifier que les 2 ont des identifiants/hashscode différent)
        {
        }

        public bool Demarrer()
        {
            if (sonMoteur.TournerMoteur() == true )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Arreter ()
        {
            if (sonMoteur.ArreterMoteur() == true )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Avancer()
        {
            if(sonMoteur.FaireTournerLesRoues(sesRoues[0], sesRoues[1]))
            {
                return true;
            }
            else
            {
                return false;   
            }

        }

        public override string ToString()
        {
            string result;

            result = $"marque : {this.marque}, \nsonMoteur : \n{this.sonMoteur.ToString()}, \nsesRoues : ";
            for (int i = 0; i < sesRoues.Length; i++)
            {
                result += "\n\t " + "Roue[" + i +"] " + sesRoues[i].ToString();
            }
            return result;
        }


    }
}
