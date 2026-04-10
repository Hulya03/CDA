using System.ComponentModel.Design;

namespace _2._7._2NbPersonneParCategorie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            string[] tab;
            List<int> list;
            int compteur;
            int compteur2;
            int compteur3;

            Console.WriteLine("Saisissez l'age des utilisateurs séparé par un espace ");
            input = Console.ReadLine();

            tab = input.Split(" ");
            list = new List<int>();
            compteur = 0;
            compteur2 = 0;
            compteur3 = 0;

            for (int i = 0; i < tab.Length; i++)
            {
                if (int.Parse(tab[i]) < 20)
                {
                    list.Add(int.Parse(tab[i]));
                    compteur++;
                } else if (int.Parse(tab[i]) > 20)
                {
                    compteur2++;
                } else {
                    compteur3++;
                }
            }

            if (compteur == 20)
            {
                Console.WriteLine("TOUTES LES PERSONNES ONT MOINS DE 20 ANS");
            }
            else if (compteur == 0) 
            {
                    Console.WriteLine("TOUTES LES PERSONNES ONT PLUS DE 20 ANS");
            }else
            {
                Console.WriteLine( " - 20 ans : " + compteur + " personnes" );
                Console.WriteLine(" + 20 ans : " + compteur2 + " personnes");
                Console.WriteLine(" 20 ans : " + compteur2 + " personnes");

            }

           
        }
    }
}
