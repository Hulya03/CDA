using ClassLibrary02Bouteille;
using System.Collections.Specialized;

namespace ConsoleTestBouteille
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bouteille b;
            Bouteille b2;
            Bouteille b3;

            Bouteille defaut;

            //b = new Bouteille();

            defaut = new Bouteille(true, 5,4);

            b = new Bouteille(true, 1, 0.5m);      // quand on utilise "decimal" en type, il faut mettre un "m" ou "M" après la valeur pour spécifier que c'est une décimale
                                                   // "f" ou "F" pour float
                                                   // "d" ou "D" pour double


            b2 = new Bouteille(false, 1, 0.3m);      // Bouteille fermée donc impossible de remplir ou vider ou de fermer

            b3 = new Bouteille(true, 1, 0.3m);

            string s = b.ToString();

            Console.WriteLine(s);

            bool result;

            result = b.Ouvrir();
            result = b.Fermer();
            result = b.Fermer();
            result = b.Ouvrir();

            result = b.Remplir();                        // Bouteille b est remplie donc son contenu est passé à 1 L.
            result = b.Remplir();                        // false car Bouteille b remplie au préalable

            result = b2.Remplir(0.4m);                   // false car fermée  
            result = b3.Remplir(0.4m);                   // true et contenuEnL de b3 passe à 0.7 L
            result = b3.Remplir(0.4m);                   // false car plus assez d'espace

            result = b3.Vider(0.5m);                     // true contenu passe à 0.2
            result = b3.Vider(0.5m);                     // false, car il ne reste pas 0.5 L
            result = b3.Vider();                         // true, contenu passe à 0
            result = b3.Vider();                         // false car il n'y a plus rien à vider 

        }
    }
}
