using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiloutouCorrection
{
    internal class ParModele : IComparer<Voiture>
    {
        public int Compare(Voiture x, Voiture y)
        {
            int rang = x.Modele.CompareTo(y.Modele);
            return rang;
        }
    }
}
