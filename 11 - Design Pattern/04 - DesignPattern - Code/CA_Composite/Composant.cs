using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_DesignPatternComposite
{
    public abstract class Composant
    {
        protected string nom;                                // on met en protected car il y a un "#" dans l'UML et ça les rend accessibles aux classes filles
        protected int indentation;


        public Composant(string nom) 
        { 
            this.nom = nom;
        }

        // Méthodes abstraites à implémenter chez les classes filles 
        public abstract void Repertorie();

        public abstract string Formate(int ind);
    }
}
