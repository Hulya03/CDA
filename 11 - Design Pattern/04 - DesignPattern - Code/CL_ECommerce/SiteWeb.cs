using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Commerce
{
    public class SiteWeb : IObservateur
    {
        //pas besoin d'écrire "override" car dans une interface on a pas de code dans la méthode (contrairement à une classe abstraite où il pourrait y en avoir) 

        public void Actualiser(Sujet sujetObserve)
        {
            if (sujetObserve is Produit produit)
            {
                if (produit.Quantite == 0)
                {
                    Console.WriteLine($"Le porduit suivant = {produit.Nom} n'est plus disponible sur notre site ");

                }else
                {
                    Console.WriteLine($"Attention il reste une quantité limitée du produit : {produit.Nom}");
                }
            }

        }
    }
}
