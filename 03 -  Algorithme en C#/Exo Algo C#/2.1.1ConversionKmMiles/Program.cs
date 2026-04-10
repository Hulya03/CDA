namespace _2._1ConversionKmMiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            double valeurKm;
            double valeurMiles;

            do
            {

                Console.WriteLine("Programme de conversion Kilomètres -> Miles.");
                Console.WriteLine("Saisir une valeur en Kilomètres : ");

                input = Console.ReadLine();

                if (input.Contains("q"))
                {
                    Environment.Exit(0);
                }

                valeurKm = double.Parse(input);


                if (valeurKm >= 0.01 && valeurKm <= 1000000)
                {
                    valeurMiles = valeurKm / 1.609;
                    Console.WriteLine(valeurKm + " Kilomètres = " + Math.Round(valeurMiles, 4) + " miles");
                }
                else
                {
                    Console.WriteLine("saisie incorrecte");
                }
            }
            while (valeurKm < 0.01 || valeurKm > 1000000);



        }
    }
}
