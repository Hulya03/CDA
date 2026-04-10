using System;
using System.Collections.Generic;                       // 1. On a fait clic droit sur "ajouter élément" sur "KiloutouCorrection" pour "ajouter nouvel élément" puis "classe" 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiloutouCorrection
{                                                       // Clic droit pour renommer class comme ca nom du fichier class change aussi
    internal class Voiture :IComparable<Voiture>        // = interface = classe abstraite(= on ne pas instancier d'objet) qui contient un prototye de méthode qui permet de comparer 2 objets      
    {                                                   // cette interface implémente la méthode ComporeTo que pour les voitures
                                                        // <> permet de specifier que c'est pour des listes 
        // Attributs :
        private int numSerie;
        private string marque;
        private string modele;                      
        private string proprio;
        private DateTime dateMiseCirculation;

        // Propriétés
        public int NumSerie { get => numSerie; }
        public string Marque { get => marque; }
        public string Modele { get => modele; }
        public DateTime DateMiseCirculation { get => dateMiseCirculation; set => dateMiseCirculation = value; }

        public string GetProprio()                        // Quand on fait le "get"er nous meme, le nom de l'attribut change
        {
            return this.proprio;
        }

        public void SetProprio(string _nouveauProprio)           // pour modifer le nom du propriétaire car le propriétaire du véhicule peut changer (à l'ancienne) 
        { 
            this.proprio = _nouveauProprio; 
        }   
        

        // Constructeur 

        public Voiture (int _numSerie, string _marqueTest, string _modeleTest, string _nouvProprio, string _datemc)
        {
            this.numSerie = _numSerie;
            this.marque = _marqueTest;
            this.modele = _modeleTest;
            SetProprio(_nouvProprio);
            this.dateMiseCirculation = DateTime.Parse(_datemc);

        }

        // Méthode 

        public override string ToString()
        {
            return base.ToString() + " : ayant pour Numéro de série " + this.NumSerie + ", marque : " + this.Marque + ", modèle : " + this.Modele + " et pour propriétaire : " + GetProprio() + " 1ère mise en circulation : " + this.dateMiseCirculation.ToString("dd/MM/yyyy"); 
        }

        public int CompareTo(Voiture objVoiture)
        {
            return marque.CompareTo(objVoiture.Marque);
        }
    }
}
