namespace _3._5PalindromeCorrection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] endroit;
            char[] envers;
            char lettre;
            string saisie;
            bool verif;
            //string finchaine;

            do
            {
                Console.WriteLine("Veuillez saisir une phrase terminée par un point");
                saisie = Console.ReadLine().ToLower();

                lettre = saisie[saisie.Length - 1];                      // srting = tableau de char

                //finchaine = saisie.Substring(saisie.Length-1);           // récupération de la fin de la chaine

            }
            while (lettre != '.');


            if (saisie.Length == 1 && lettre == '.')
            {
                Console.WriteLine("La phrase est vide.");
            }
            else
            {

                string saisie2 = saisie.Substring(0, saisie.Length - 1);  //Suprression du point 
                saisie2.Replace(" ", string.Empty);                       // Suppression des espace

                endroit = saisie2.ToCharArray();                         // On remplit le tableau "endroit" avec des char
                envers = (char[]) endroit.Clone();                                        // declaration de la taille et on a rempli le tableau
                Array.Reverse(endroit);                                  // Methode void qui ne revoit rien donc on peut pas récupérer directement

                //for (int i = 0; i < endroit.Length; i++)
                //{
                //    envers[i] = endroit[(endroit.Length-1) -i ]; 
                //}

                verif = true; 

                for (int i = 0; i < endroit.Length; i++)
                {
                    if(!endroit[i].Equals(envers[i]))
                    {
                        verif = false;

                        break;
                    }
                }

                if (verif)
                {
                    Console.WriteLine($"La phrase saisie est un palindrome : {saisie}");
                }
                else
                {
                    Console.WriteLine("La phrase saisie n'est pas un palindrome");
                }




            }
        }
    }
}
