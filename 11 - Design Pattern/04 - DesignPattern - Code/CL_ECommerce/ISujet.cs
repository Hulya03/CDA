using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Commerce
{
    public interface ISujet
    {
        //en c#, les membres d'une intreface sont "public" par défaut

        void EnregistrerObservateur(IObservateur observateur);
        void SupprimerObservateur(IObservateur observateur);

        //cette méthode notifie tous les observateurs quand l'état du sujet a changé
        void NotifierObservateurs();
    }
}
