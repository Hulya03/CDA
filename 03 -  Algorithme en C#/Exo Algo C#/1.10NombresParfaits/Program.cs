namespace _1._10NombresParfaits
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

            nbATester = 1;

            while (nbParfait < nbDeValeurs)
            {
               
                sommeDiviseurs = 0;
                diviseur = 1;

               

                while (diviseur < nbATester)
                {

                    if (nbATester % diviseur == 0)
                    {
                        sommeDiviseurs += diviseur;
                    }
                    diviseur++;

                }

                if (nbATester == sommeDiviseurs)
                {
                    nbParfait++;
                    Console.WriteLine(nbATester + " est un nombre parfait.");

                }
                nbATester++;

            }


        }
    }
}
