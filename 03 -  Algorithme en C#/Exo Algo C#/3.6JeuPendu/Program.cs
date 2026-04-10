namespace _3._6JeuPendu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string motMystere;
            char[] motMystereChar;
            char essai;
            int compteurEssai;
            List<char> lesEssais;
            bool lettreCorrecte;


            do
            {
                Console.WriteLine("Joueur 1 : Entrer le mot à faire deviner (minimum 5 caractères)");
                motMystere = Console.ReadLine();
            } while (motMystere.Length < 5);

            motMystere = motMystere.ToLower();



            motMystereChar = motMystere.ToCharArray(0, motMystere.Length);

            for (int i = 1; i < motMystere.Length - 1; i++)
            {
                motMystereChar[i] = '_';
            }

            foreach (char c in motMystereChar)
            {
                Console.Write(c);
            }


            compteurEssai = 1;

            do
            {
                lettreCorrecte = false;


                if (motMystereChar.Contains('_'))
                {
                    Console.WriteLine("\nTentative n° " + compteurEssai + "/6. Veuillez entrez une lettre : ");
                    essai = char.Parse(Console.ReadLine());
                    for (int i = 0; i < motMystereChar.Length; i++)
                    {
                        if (motMystere[i] == essai)
                        {
                            motMystereChar[i] = essai;
                            lettreCorrecte = true;
                        }
                    }

                }

                foreach (char c in motMystereChar)
                {
                    Console.Write(c);
                }

                if (lettreCorrecte == false)
                {
                    compteurEssai++;
                }

            } while (compteurEssai < 7 && motMystereChar.Contains('_'));


            if (motMystereChar.Contains('_'))
            {
                Console.WriteLine("Vous avez perdu");
            }
            else
            {
                System.Console.WriteLine("\nVous avez gagné");
            }
        }
    }
}
