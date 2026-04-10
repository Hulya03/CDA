using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Forme
{
    public interface IVisiteurDeForme                      //cette interface permet de faire le lien entre les différent visiteur et la classe métier
    {
        void Visit(Rectangle rectangle);
        void Visit(Cercle cercle);
        void Visit(Formes formes);

    }
}
