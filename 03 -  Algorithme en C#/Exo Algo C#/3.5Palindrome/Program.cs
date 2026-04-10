namespace _3._5Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string chaineAVerifier;
            string chaineSansEspace;
            bool palindrome;

            do
            {
                Console.WriteLine("Entrez une phrase suivie d'un point pour savoir si c'est un palindrome :");
                chaineAVerifier = Console.ReadLine();

                chaineAVerifier = chaineAVerifier.ToLower();

                chaineSansEspace = chaineAVerifier.Replace(" ", "");   // on remplace les espaces par rien, donc on supprime les espaces  

            }
            while (!(chaineSansEspace.Contains(".")));

            if (chaineSansEspace.Equals("."))
            {
                Console.WriteLine("La phrase est vide");
            }

            chaineSansEspace = chaineSansEspace.Replace(".", "");   // suppression point

            palindrome = true;
            for (int i = 0; i < (chaineSansEspace.Length) / 2; i++)
            {

                if (!(chaineSansEspace[i].Equals(chaineSansEspace[chaineSansEspace.Length - 1 - i])))
                {
                    palindrome = false;
                }
            }

            if (palindrome == false)
            {
                Console.WriteLine("Ce n'est pas un palindrome");

            }
            else
            {
                Console.WriteLine("C'est un palindrome");
            }
        }
    }
}
