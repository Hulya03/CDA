namespace _1._2CalculAireSphere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rayon;
            double aire;
            double volume;
            double roundedAire;
            double roundedVolume;

            Console.WriteLine("Entrez le rayon de la sphère : ");
            rayon = double.Parse(Console.ReadLine());

            aire = 4 * Math.PI * Math.Pow(rayon, 2);
            roundedAire = Math.Round(aire, 2);

            volume = (4 / 3) * Math.PI * Math.Pow(rayon, 3);
            roundedVolume = Math.Round(volume, 2);

            Console.WriteLine("L'aire est de " + roundedAire);
            Console.WriteLine("Le volume est de " + roundedVolume);


        }
    }
}
