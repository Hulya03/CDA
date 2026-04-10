using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary02Bouteille
{
    public class Bouteille
    {
        // Attributs

        private bool estOuvert;
        private decimal contenanceEnLitre;
        private decimal contenuEnLitre;


        //Constructeur par défaut 
        public Bouteille():this(false,0,0)              // utilisation de l'INTERDEPENDANCE pour éviter de faire du code redondant (on se base plutot sur le contructeur classique)
        {
        }

        //Constructeur Classique
        public Bouteille(bool estOuvert, decimal contenanceEnLitre, decimal contenuEnLitre)
        {

        // Exemple pour lever des exceptions :  attention on lève l'exception pour des choses qui sont impossible à faire dans la vraie vie (ex : mettre une quantité d'eau négative)

            if (contenanceEnLitre < 0)
            {
                throw new ArgumentException("\nImpossible d'avoir une valeur négative pour la contenance\n", nameof(contenanceEnLitre));
            }
            else if (contenuEnLitre < 0)
            {
                throw new ArgumentException("\nImpossible d'avoir une valeure négative pour le contenu\n", nameof (contenuEnLitre));
            }

            this.estOuvert = estOuvert;
            this.contenanceEnLitre = contenanceEnLitre;
            this.contenuEnLitre = contenuEnLitre;
        }

        //Constructeur Par Clonage
        public Bouteille(Bouteille bouteilleACloner): this(bouteilleACloner.estOuvert, bouteilleACloner.contenanceEnLitre, bouteilleACloner.contenuEnLitre)
        {
        }                                  

        //Méthodes :

            // Getter

        public bool EstOuvert { get => estOuvert; }
        public decimal ContenanceEnLitre { get => contenanceEnLitre; }
        public decimal ContenuEnLitre { get => contenuEnLitre; }
        public decimal GetContenanceEnMl()
        {
            decimal result = contenanceEnLitre * 1000;

            return result;
        }

            // Autres méthodes


        public bool Ouvrir()
        {
            if (estOuvert == false)
            {
                estOuvert = true;                       
                return true;                            // le "return" permet de quitter la méthode en renvoyant la valeur du return (donc n'execute pas le reste s'il retourne la valeur de cette ligne)
            }
            return false;                               // On ne peut pas ouvrir la bouteille car elle est déja ouverte d'où on retourne false 

        }

        public bool Fermer()
        {
            if (estOuvert == true)
            {
                estOuvert = false;
                return true;
            }
            else
            {
                return false;                           // Bouteille déjà fermée
            }
        }

        public bool Remplir() 
        {
            return Remplir(this.contenanceEnLitre - this.contenuEnLitre);   // Eviter le code redondant donc si on a deux fois le même code, utiliser l'autre méthode similaire 
        }

        public bool Remplir(decimal quantiteEnLitre)
        {

            if(quantiteEnLitre < 0)
            {
                throw new ArgumentException("\nImpossible d'ajouter une quantité négative\n", nameof(quantiteEnLitre));
            }

            if (estOuvert == true && quantiteEnLitre <= this.contenanceEnLitre - this.contenuEnLitre)
            {
                contenuEnLitre = contenuEnLitre + quantiteEnLitre;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Vider()
        {
            return Vider(contenuEnLitre);
        }

        public bool Vider(decimal quantiteEnLitre)
        {
            if(quantiteEnLitre <0)
            {
                throw new ArgumentException("\nImpossible d'ajouter une quantité négative", nameof(quantiteEnLitre));
            }

            if (this.estOuvert == true && quantiteEnLitre <= this.contenuEnLitre && contenuEnLitre !=0)
            {
                contenuEnLitre = contenuEnLitre - quantiteEnLitre;
                return true ;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"[ est ouverte : {this.estOuvert} , contenanceEnLitre : {this.contenanceEnLitre} ,  son contenuEnLitre : {this.contenuEnLitre}";
        }

        // pas besoin d'utiliser les "this" car on est dans la bouteille classe déjàs

    }
}
