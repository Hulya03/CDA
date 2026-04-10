using System.Runtime.CompilerServices;

namespace NbParfaitFonction
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int nbDeValeurs;
            int nbATester;
            int nbParfait;
            int diviseur;
            int sommeDiviseurs;


            nbParfait = 0;

            Console.WriteLine("Programme de recherche des nombres parfaits.");
            Console.WriteLine("Combien de nombres parfaits souhaitez-vous afficher ?");
            nbDeValeurs = int.Parse(Console.ReadLine());

            nbATester = 2;
        


                    while (nbParfait <nbDeValeurs)
            {
                sommeDiviseurs = CalculSommeDiviseur(nbATester);
                if (nbATester == sommeDiviseurs)
                {
                    nbParfait++;
                    Console.WriteLine(nbATester + " est un nombre parfait.");

                }
               nbATester++;
            }



        }
        public static int CalculSommeDiviseur(int _nb) {
            int diviseur = 1;
            int sommeDiviseur = 0;
            
            while (diviseur <_nb)
            {

                if (_nb % diviseur == 0)
                {
                    sommeDiviseur +=diviseur;
                    
                }
                diviseur++;

            }
            return sommeDiviseur;



        }
    }
}
