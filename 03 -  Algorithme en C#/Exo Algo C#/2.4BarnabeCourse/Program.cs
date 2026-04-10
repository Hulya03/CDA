namespace _2._4BarnabeCourse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sommeDepart;
            double reste;
            int compteurMagasin;

            Console.WriteLine("Entrez la somme de départ :");
            sommeDepart = double.Parse(Console.ReadLine());

            reste = sommeDepart;
            compteurMagasin = 0;

            while (reste > 2)
            {
                reste = (sommeDepart / 2 ) - 1;
                compteurMagasin++;
                Console.WriteLine("reste : " + reste);
                sommeDepart = reste;

            }
            
            Console.WriteLine("Barnabé a dépensé ses sous dans " + (compteurMagasin + 1) + " magasins.");
        }
    }
}
