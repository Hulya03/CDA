using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Commerce
{
    public interface IObservateur
    {
        void Actualiser(Sujet sujetObserve);

    }
}
