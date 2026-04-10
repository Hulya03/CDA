namespace _2._1._2ConversionKmMiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            double valeurKm;
            double valeurMiles;

            Console.WriteLine("Programme de conversion Kilomètres <-> Miles.");

            do
            {
                Console.WriteLine("Saisir une valeur et son unité de mesure (séparés par un espace : 'mi' ou 'km') : ");
                input = Console.ReadLine();

                if (input.Contains("mi"))
                {
                    string[] separation = input.Split(" ");

                    valeurKm = double.Parse(separation[0]) * 1.609;
                    Console.WriteLine(input + " = " + Math.Round(valeurKm, 4) + " km");
                }

                else if (input.Contains("km"))
                {
                    string[] separation = input.Split(" ");

                    valeurMiles = double.Parse(separation[0]) / 1.609;
                    Console.WriteLine(input + " = " + Math.Round(valeurMiles, 4) + " miles");
                }
                else
                {
                    Console.WriteLine("saisie incorrecte");
                }

            }
            while (!(input.Contains("km") || input.Contains("mi")));




        }
    }
}
