namespace CalculMoyenne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.WriteLine("Veuillez saisir un nombre entier a : ");
            //writeline renvoie en chaine de caractere donc on utilise int.Parse pour avoir un entier 
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Veuillez saisir un nombre entier b : ");
            b = int.Parse(Console.ReadLine());

            Console.Beep();

            float AVG = (float)(a + b) / 2;
            // casting au niveau float

            Console.Write("La moyenne de a et b : " + AVG);

            Console.ReadLine();
            // évite la fermeture de la console donc il n'écrit pas de texte inutile à la fin
             

        }
    }
}
