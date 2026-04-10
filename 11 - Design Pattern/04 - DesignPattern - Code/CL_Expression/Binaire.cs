using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Expression
{
    public abstract class Binaire : Expression
    {
        protected Expression expressionGauche;
        protected Expression expressionDroite;

        public Binaire(Expression expressionGauche, Expression expressionDroite)
        {
            this.expressionGauche = expressionGauche;
            this.expressionDroite = expressionDroite;
        }

        public override string ToString()
        {
            return $"Expression gauche = {expressionGauche} ; Expression droite = {expressionDroite}";
        }

        public override string FormateCalcule()
        {
            return ""; 
        }


    }
}
