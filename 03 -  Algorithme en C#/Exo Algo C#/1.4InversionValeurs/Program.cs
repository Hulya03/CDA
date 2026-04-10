namespace _1._4InversionValeurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double box;

            Console.WriteLine("Entrez la valeur de a :");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Entrez la valeur de b :");
            b = double.Parse(Console.ReadLine());

            box = a;
            a = b; 
            b = box;

            Console.WriteLine(" Désormais, la valeur de a est : " + a + " et la valeur de b est " + b);
        }
    }
}
