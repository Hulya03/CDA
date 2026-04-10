namespace Jeu_du_pendu
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] motcherche;

            char[] motsolution;

            int nbessais = 0;
            string motatrouver;
            bool trouve;
            char lettre;
            bool testLettre;
            string motjoueur2;

            int nbcouprestant;
            do
            {
                Console.WriteLine("joueur 1 veuillez choisir le mot à deviner de plus de 5 lettres !");
                motatrouver = Console.ReadLine();


            } while (motatrouver.Length < 5);
            motsolution = motatrouver.ToCharArray();
            motcherche = new char[motsolution.Length];
            for (int i = 0; i < motsolution.Length; i++)
            {
                if (i == 0 || i == motsolution.Length - 1)
                {
                    motcherche[i] = motsolution[i];

                }
                else
                {
                    motcherche[i] = '-';
                }


            }
            Console.Clear();
            Console.WriteLine("Joueur 2 voici le mot à rechercher : ");
            ManipulerTableau.Affichertableau(motcherche);
            do
            {

                trouve = false;
                Console.WriteLine($"Joueur 2, veuillez saisir une lettre pour deviner le mot ! vous avez {6 - nbessais} essais restants");
                lettre = char.Parse(Console.ReadLine());
                testLettre = false;
                for (int i = 1; i < motsolution.Length - 1; i++)
                {
                    if (lettre == motsolution[i])
                    {
                        motcherche[i] = lettre;
                        testLettre = true;
                    }
                }
                if (!testLettre)
                {
                    nbessais++;
                    Console.WriteLine($"la lettre n'est pas présente vous avez perdu: coup restant {6 - nbessais} ");

                }
                else
                {


                    Console.WriteLine("Bravo la lettre est presente dans le mot deviner !");
                    ManipulerTableau.Affichertableau(motcherche);
                    motjoueur2 = ManipulerTableau.chainageString(motcherche);
                    if (motatrouver.Equals(motjoueur2))
                    {
                        trouve = true;
                    }

                }
                nbcouprestant = 6 - nbessais;




            } while (nbcouprestant > 0 && trouve == false);

            if (!trouve)
            {
                Console.WriteLine($"Vous avez perdu est le mot à deviner était {motatrouver}");




            }
            else
            {

                Console.WriteLine($" Bravo vous avez trouver le mot à deviner : {motatrouver} en {nbessais} erreurs !");



            }




            Console.ReadKey();
        }



    }
    class ManipulerTableau
    {
        public static void Affichertableau(char[] _untab)
        {
            Console.Write("\n [ ");
            foreach (char element in _untab)
            {
                Console.Write(element + " ");
            }
            Console.Write("]\n");
        }

        public static string chainageString(char[] _untab)
        {
            string chaine = "";
            foreach (char lettre in _untab)
            {
                chaine += lettre;
            }
            return chaine;
        }

    }



}

