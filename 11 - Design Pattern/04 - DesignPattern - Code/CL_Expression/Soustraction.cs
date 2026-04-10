using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Expression
{
    public class Soustraction : Binaire
    {
        public Soustraction(Expression expressionGauche, Expression expressionDroite) : base ( expressionGauche, expressionDroite)
        {
        }

        public override double Evalue()
        {
            return expressionGauche.Evalue() - expressionDroite.Evalue();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override string FormateCalcule()
        {
            return $"{expressionGauche.FormateCalcule()} - {expressionDroite.FormateCalcule()}";
        }
    }
}
