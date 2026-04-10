namespace _1._3CalculSurface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rayon;
            double angle;
            double aire;
            double aireRounded; 

            Console.WriteLine("Entrez le rayon du cercle : ");

            rayon = double.Parse(Console.ReadLine());

            Console.WriteLine("Entrez l'angle en degré : ");

            angle = double.Parse(Console.ReadLine());

            aire = Math.PI * Math.Pow(rayon, 2) * angle / 360;
            aireRounded = Math.Round(aire, 2);

            Console.WriteLine("L'aire du secteur circulaire est " + aireRounded);

        }
    }
}
