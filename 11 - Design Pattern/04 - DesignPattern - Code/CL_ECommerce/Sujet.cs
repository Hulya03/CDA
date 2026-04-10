using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Commerce
{
    public abstract class Sujet : ISujet
    {
        protected List<IObservateur> sesObservateurs = new List<IObservateur>();            //On place en protected pour que ses "enfants" y ait acces
                                                                                            // On initialise la liste ici = création de la liste vide d'observateurs
                                                                                            // si on la met pas, sesObservateur sera null
                                                                                            // on ne met pas dans les parametre pcq elle est vide, on a encore rien à mettre dedans
        public void EnregistrerObservateur(IObservateur observateur)
        {
            if (!sesObservateurs.Contains(observateur))
            {
                sesObservateurs.Add(observateur);
            }
        }
        public void SupprimerObservateur(IObservateur observateur)
        {
            if (sesObservateurs.Contains(observateur))
            {
                sesObservateurs.Remove(observateur);
            }
        }

        public void NotifierObservateurs()                                                  // Pas besoin de mettre un observateur en particulier car on veut notifier tous les observateur
        {
            {
                foreach (IObservateur observateur in sesObservateurs)
                {
                    observateur.Actualiser(this);
                }

            }
        }
    }
}
