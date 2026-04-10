using System.ComponentModel.Design;

namespace _2._5JeuDu02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nbJoueur;
            Random alea = new Random();
            int nbOrdinateur;
            int pointJoueur;
            int pointOrdinateur;

            pointJoueur = 0;
            pointOrdinateur = 0;

            do
            {
               
                Console.WriteLine("Veuillez saisir un nombre compris entre 0 et 2 compris");
                nbJoueur = int.Parse(Console.ReadLine());
                nbOrdinateur = alea.Next(0, 3);

                try
                {
                    if (nbJoueur - nbOrdinateur == 2) // 1
                    {
                        pointJoueur += 1;
                    }
                    else if (nbJoueur - nbOrdinateur == 1)// 2
                    {
                        pointOrdinateur += 1;
                    }
                    else if (nbOrdinateur - nbJoueur == 2) // 3
                    {
                        pointOrdinateur += 1;
                    }
                    else if (nbOrdinateur - nbJoueur == 1)
                    {
                        pointJoueur += 1;
                    }

                    Console.WriteLine("joueur : " + pointJoueur);
                    Console.WriteLine("ordinateur : " + pointOrdinateur);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                

            }
            while (pointJoueur < 10 && pointOrdinateur < 10 && nbJoueur >= 0 );

            Console.WriteLine("Fin du jeu");

        }
    }
}
