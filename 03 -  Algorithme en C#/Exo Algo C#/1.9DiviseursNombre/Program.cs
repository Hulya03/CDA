namespace _1._9DiviseursNombre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nb;
            int reste;
            List<int> diviseurs = new List<int>();

            Console.WriteLine("Entrez un nombre entier : ");
            nb = int.Parse(Console.ReadLine());


            for (int i = 2; i < nb; i++)
            {
                reste = nb % i;

                if (reste == 0)
                {
                    diviseurs.Add(i);
                }

            }
            Console.WriteLine("Les diviseurs de " + nb + " sont : ");
            foreach (int valeurs in diviseurs)
            {
                Console.WriteLine(valeurs);
            }

            Console.ReadLine();

                
        }
    }
}
