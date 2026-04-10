using System.Diagnostics;
using System.Linq.Expressions;

namespace jeu_01_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int scoreBot = 0;
            int scoreJoueur = 0;
            int nbBot;
            int nbJoueur;
            bool continuer;
            int diff;

            do
            {
                do
                {
                    Console.WriteLine("Veuillez saisir un chiffre entre 0 et 2 :");
                    continuer = int.TryParse(Console.ReadLine(), out nbJoueur);
                }
                while (continuer == false || nbJoueur >= 3);

                Random alea = new Random();
                nbBot = alea.Next(0, 3);

                diff = Math.Abs(nbJoueur - nbBot);

                // switch case tjrs basée sur une variable
                switch (diff)
                {

                    case 2:
                        if (nbJoueur > nbBot)
                        {
                            scoreJoueur++;
                            Console.WriteLine($"Le joueur gagne un point {scoreJoueur}");
                        }
                        else
                        {
                            scoreBot++;
                            Console.WriteLine($"La machine gagne un point {scoreBot}");
                        }
                        break;
                    case 1:
                        if (nbJoueur > nbBot)
                        {
                            scoreBot++;
                            Console.WriteLine($"La machine gagne un point {scoreBot}");

                        }
                        else
                        {
                            scoreJoueur++;
                            Console.WriteLine($"Le joueur gagne un point {scoreJoueur}");
                        }
                        break;
                    case 0:
                        Console.WriteLine($"égalité ! aucun joueur ne marque un point : joueur {scoreJoueur} et bot machine {scoreBot}");
                        break;

                    default:
                        break;

                }
            }
            while (scoreBot < 10 && scoreJoueur < 10 && nbJoueur >= 0);

            if(nbJoueur <0)
            {
                Console.WriteLine($"Vous avez décidé d'arrêter la partie les socres sont : joueur {scoreJoueur} et bot machine {scoreBot}");
            }else if(scoreBot == 10)
            {
                Console.WriteLine("La machine a gagné");
            }else
            {
                Console.WriteLine("Bravo vous avez gagné");
            }
        }
    }
}
