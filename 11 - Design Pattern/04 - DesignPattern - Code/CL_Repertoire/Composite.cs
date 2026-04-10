using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CL_Repertoire
{
    public class Composite : Composant
    {
        protected List<Composant> listeDenfants = new List<Composant>();              //"espace de stockage" pour ajouter les composants du composite
        public Composite(string nom) : base(nom)                                      // permet d'executer le constructeur du parent pour remplir correctement le champ nom (transmet valeur au parent)
        {
            
        }

        //permet d'identifier tous les composant du répertoire
        public override void Repertorie()                                            //mot clé override obligatoire pour implémenter une méthode abstraite
        {                                                                  
            //Analyse du contenu du dossier
            string[] resultats = Directory.GetFileSystemEntries(this.nom);          // cette méthode permet de rechercher tous les fichier et dossier dans le composant "nom".
                                                                                    // elle donne un tableu de chaine de caracteres

            // Identifier si le path est un fichier ou un dossier grace à File.GetAttributes(entree)
            // pour chaque chemin, création de l'objet "composite (dossier)" ou "fichier"
            // ajouter à la liste

            foreach (string chemin in resultats)
            {

                FileAttributes flagAttr = File.GetAttributes(chemin);
                
                if (flagAttr.HasFlag(FileAttributes.Directory))          //retourne "true" si le chemin correspond à un dossier 
                {
                    Composite sousDossier = new Composite(chemin);       // création du sous dossier 
                    this.listeDenfants.Add(sousDossier);                 // ajout à la liste 

                    sousDossier.Repertorie();                            // puisqu'on obtient un sous dossier, on veut savoir aussi ce qu'il y a dedans,
                                                                         // on utilise donc notre methode "Repertorie" dans notre méthode
                                                                         // c'est la RECURSION = methode qui s'appelle elle-meme  
                }
                else
                {
                    Fichier fichier = new Fichier(chemin);  
                    this.listeDenfants.Add(fichier);                     // on arrive a faire une liste de fichier et coposite car tous les 2 héritent de composant
                }
            }
        }

        // Pour donner un affichage console en arborescence du répertoire analysé 
        // c'est une chaine de caractere qui représente l'arborescence
        // on va juste ajouter "+1" à "ind" quand on passe à l'enfant
        public override string Formate(int ind)
        {
            string tiret = "";
            for (int i = 0; i < ind; i++)
            {
                tiret += "-";
            }
            string resultat = tiret + ".Directory" + this.nom + "\n";

            foreach (Composant enfant in this.listeDenfants)
            {
                resultat += enfant.Formate(ind + 1) + "\n";
            }
            return resultat;
        }
    }
}
