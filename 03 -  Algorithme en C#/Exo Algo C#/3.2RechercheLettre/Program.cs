namespace _3._2RechercheLettre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence;
            char letter;
            int count;

            count = 0;

            Console.WriteLine("Veuillez saisir une phrase, terminée par un point");
            sentence = Console.ReadLine();



            if (sentence.Equals("."))
            {
                Console.WriteLine("La chaine est vide");
            }
            else
            {
                Console.WriteLine("Choisissez une lettre dont vous voulez vérifier la présence : ");
                letter = char.Parse(Console.ReadLine());

                if (!sentence.Contains(letter))
                {

                    Console.WriteLine("La lettre n'est pas présente.");
                }
                else
                {
                    foreach (char c in sentence)
                    {
                        Console.WriteLine("test1");
                        if (c.Equals(letter))
                        { 
                            count++;
                            Console.WriteLine("test2");
                        } 
                                           
                    }
                    Console.WriteLine(letter + " : " + count);
                }
            }

            
        }
    }
}
