using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiloutouCorrection
{
    class ParNumeroSerie : IComparer<Voiture>
    {
        public int Compare(Voiture x, Voiture y)
        {
            int classement = x.NumSerie.CompareTo(y.NumSerie);

            return classement;
        }
    }
}
