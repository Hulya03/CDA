using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Commerce
{
    // Produit est la classe de haut niveau (Le métier) : Il se contente d'appeler "NotifierObservateurs')" quand son stock change
    public class Produit : Sujet 
    {
        private int code;
        private string nom;
        private int quantite;
        private readonly int quantiteStockLimite;               // avanatge du readonly : variable initialisée dans le constructeur et valeur non modifié par la suite 
                                                                // contrairement à "const" qui oblige a avoir une quantitéStockLimite identique à tous les produits
                                                                // readonly permettra d'avoir une quantitéLimite propre à chaque produit 

        // Constructeur 
        public Produit(int code, string nom, int quantite, int quantiteStockLimite)
        {   
            this.code = code;
            this.nom = nom;
            this.quantite = quantite;
            this.quantiteStockLimite = quantiteStockLimite;

        }

        public int Code { get => code; }
        public string Nom { get => nom; }
        public int Quantite { get => quantite; }
        public int QuantiteStockLimite => quantiteStockLimite;


        // C'est le sujet qui s'occupe de gérer les listes, donc pas besoin de coder les methodes "EnregistrerObservateurs()"....
  

        // En cas de modification : 

        // Simulation d'un changement de code (sans passer par le setteur mais modifiant la valeur brute de la variable) 

        public int VarierLesNombresProduitsDansStock(int augmentationOuDiminution)
        {
            this.quantite += augmentationOuDiminution;

            if(quantite <= quantiteStockLimite)
            {
                this.NotifierObservateurs();
            }

            return this.quantite;
        }                                       
    }
}
