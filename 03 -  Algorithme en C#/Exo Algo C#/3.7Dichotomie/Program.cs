using System.Runtime.CompilerServices;

namespace _3._7Dichotomie
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] tab = { "agathe", "berthe", "chloé", "cunégonde", "olga", "raymonde", "sidonie" };
            string input;
            int debutTab;
            int milieuTab;
            int finTab;
            bool motAbsent; 

            motAbsent = true;
            debutTab = 0;   
            finTab = tab.Length - 1;

            Console.WriteLine("Veuillez saisir le prénom dont voulez l'indice :");
            input = Console.ReadLine();

            do
            {
                milieuTab = (debutTab+finTab) / 2;

                int comparaison = String.Compare(input, tab[milieuTab]);

                if (comparaison == -1)
                {
                    finTab = milieuTab -1;
                }
                else if (comparaison == 1)
                {
                    debutTab = milieuTab +1;
                }
                else
                {
                    Console.WriteLine("L'indice du mot est " + (milieuTab +1));
                    motAbsent = false;
                    break;
                } 
            } while (debutTab <= finTab);


            if (motAbsent)
            {
                Console.WriteLine("Votre mot ne se trouve pas dans la liste");
            }





        }


    }
}

