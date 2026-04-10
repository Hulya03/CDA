using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Expression
{
    public class Nombre : Expression
    {
        private double valeur;

        public Nombre(double valeur) 
        { 
            this.valeur = valeur;
        }

        public override double Evalue()
        {
            return valeur;
        }

        public override string ToString()
        {
            return valeur.ToString();
        }

        public override string FormateCalcule()
        {
            return valeur.ToString();
        }

    }
}
