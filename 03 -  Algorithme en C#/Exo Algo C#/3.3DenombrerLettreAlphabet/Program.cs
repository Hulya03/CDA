namespace _3._3DenombrerLettreAlphabet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texte;
            int countLetter;
            int countSpace;
            int countAlphabet;

            char[] alphabet;
            int[] tabCount;

            countSpace = 0;
            countLetter = 0;
            alphabet = new[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'x', 'y', 'z' };
            tabCount = new int[alphabet.Length];

            for (int i = 0; i < tabCount.Length; i++)                   // tableau de compteur de chaque lettre de l'alphabet, initialisé à 0 pour chaque case
            {
                tabCount[i] = 0;
            }


            do
            {
                Console.WriteLine("Veuillez saisir un texte de 120 caractères minimum : ");
                texte = Console.ReadLine();
                texte = texte.ToLower();


                foreach (char c in texte)
                {
                    if (c.Equals(' '))
                    {
                        countSpace++;
                    }
                    countLetter++;
                }
                Console.WriteLine("Nombre d'espaces : " + countSpace);
                Console.WriteLine("Nombre de lettres : " + countLetter);

                if ((countLetter - countSpace) < 120)
                {
                    Console.WriteLine("Votre texte possède " + (countLetter - countSpace) + " caractères. il est trop court. Veuillez saisir un texte plus long");
                    texte = Console.ReadLine();
                    texte = texte.ToLower();
                }
                else
                {
                    for (int i = 0; i < alphabet.Length; i++)

                    {
                        countAlphabet = 0;
                        for (int j = 0; j < texte.Length; j++)
                        {

                            if (alphabet[i].Equals(texte[j]))                   // texte[i] : donne le char à la position i du texte
                            {
                                countAlphabet++;
                            }
                            
                        }
                        tabCount[i] = countAlphabet;

                    }


                    for (int i = 0; i < tabCount.Length; i++)
                    {
                        Console.WriteLine(alphabet[i] + " : " + tabCount[i]);
                    }

                }

            }
            while ((countLetter - countSpace) < 120);



        }
    }
}
