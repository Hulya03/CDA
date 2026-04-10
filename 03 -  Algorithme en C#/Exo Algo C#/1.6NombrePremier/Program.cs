namespace _1._6NombrePremier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nb;
            int counter;
            int reste;

            Console.WriteLine("Entrez un nombre entier : ");
            nb = int.Parse(Console.ReadLine());
            counter = 0;

            for (int i = 2; i <= nb; i++)
            {

                reste = nb % i;
                if (reste == 0)
                {
                    counter++;
                }

            }
            if (counter == 1)
            {
                Console.WriteLine(nb + " est un nombre premier");
            }
            else
            {
                Console.WriteLine(nb + " n'est pas un nombre premier");
            }

        }
    }
}

