using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Commerce
{
    public class Fournisseur : IObservateur
    {
        public void Actualiser(Sujet sujetObserve)
        {
            if (sujetObserve is Produit produit)                              // On "convertit" le sujet pour pouvoir accéder à ses propriétés, on doit caster 
            {
                Console.WriteLine($"passer une commande pour : \n" +
                $"=> Nom du produit : {produit.Nom} \n " +
                $"code du produit : {produit.Code} \n " +
                $"quantité actuelle : {produit.Quantite}");
            }
        }
    }
}
