using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Expression
{
    public abstract class Expression
    {
        public Expression() 
        { 
        }

        public abstract double Evalue();

        public abstract string FormateCalcule();                        // on va utiliser cette méthode abstraite à implémenter dans addition, soustraction.. pour formater de facon récursive que la partie calcul, avant le égal

        public string Formate()                                         // puisque le zéro et le résultat on le veut que une foi et non en récursif,
                                                                        // je créer un méthode pour afficher le = et résultat 
                                                                        // et on place cette méthode dans la classe "Expression", et on peut utiliser "this" pour dire qu'on agit sur l'expression pour le calculer (ou le formater pour la partie "calcul" avant le égal) 
        {
           return this.FormateCalcule() + "=" + this.Evalue().ToString();
        }

    }
}
