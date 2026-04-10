using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Repertoire
{
    public class  Fichier : Composant
    {

        public Fichier(string nom) : base(nom) 
        {
        }

        public override void Repertorie()
        {

        }

        public override string Formate(int ind)
        {
            string tiret = "";
            for (int i = 0; i < ind; i++)
            {
                tiret += "-";
            }
            return tiret + ".File" + this.nom;
        }
    }
}
