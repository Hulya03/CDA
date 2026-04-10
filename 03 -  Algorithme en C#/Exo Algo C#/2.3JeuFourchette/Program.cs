namespace _2._3JeuFourchette
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min;
            int max;
            //pour créer un nb aléatoire :
            Random createurNbAleatoire = new Random();
            //stockage du nb aléatoire compris entre 0 et 100 (limite supérieure non comprise) :
            int nbOrdinateur = createurNbAleatoire.Next(0, 101);
            int nbJoueur;
            int compteur;


            min = 0;
            max = 100;
            compteur = 1;
            Console.WriteLine("Veuillez entrer une valeur comprise entre " + min + " et " + max + " :");


            do
            {
                Console.WriteLine("Essai numéro " + compteur);
                nbJoueur = int.Parse(Console.ReadLine());


                if (nbOrdinateur > nbJoueur)
                {
                    min = nbJoueur;
                    Console.WriteLine("Veuillez entrer une valeur comprise entre " + min + " et " + max + " :");


                }

                if (nbOrdinateur < nbJoueur)
                {
                    max = nbJoueur;
                    Console.WriteLine("Veuillez entrer une valeur comprise entre " + min + " et " + max + " :");

                }
                compteur++;

            }
            while (nbJoueur != nbOrdinateur);

            if (nbJoueur == nbOrdinateur)
            {
                Console.WriteLine("Bravo, vous avez trouvé le bon nombre ! ");
            }

        }
    }
}
