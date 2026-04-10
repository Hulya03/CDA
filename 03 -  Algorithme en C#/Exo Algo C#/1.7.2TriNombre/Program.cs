namespace _1._7._2TriNombre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //déclaration de variable
            double a;
            double b;
            double c;
            // déclaration et initialisation de variable
            double petit = 0;
            double moyen = 0;
            double grand = 0; 

            Console.WriteLine("Entrez la première valeur :");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Entrez la seconde valeur :");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Entrez la troisieme valeur :");
            c = double.Parse(Console.ReadLine());

            if (a < b && b < c)
            {
                petit = a;
                moyen = b;
                grand = c;
            }
            else if (a < b && c < b)
            {
                petit = a;
                moyen = c;
                grand = b;
            }
            else if (b < a && a < c)
            {
                petit = b;
                moyen = a;
                grand = c;
            }
            else if (b < c && c < a)
            {
                petit = b;
                moyen = c;
                grand = a;
            }
            else if (c < b && b < a)
            {
                petit = c;
                moyen = b;
                grand = a;
            }
            else if (c < b && b < a)
            {
                petit = c;
                moyen = b;
                grand = a;
            }

            Console.WriteLine("Dans l'ordre croissant : " + petit + " < " + moyen + " < " + grand);




        }
    }
}
