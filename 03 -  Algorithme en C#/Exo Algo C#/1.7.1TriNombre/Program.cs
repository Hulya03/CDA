namespace _1._7TriNombre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;

            Console.WriteLine("Entrez un nombre a : ");

            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Entrez un nombre b : ");

            b = double.Parse(Console.ReadLine());

            if (a < b)
            {
                Console.WriteLine(a + " < " + b);
            }
            else
            {
                Console.WriteLine(b + " < " + a);

            }
        }
    }
}
