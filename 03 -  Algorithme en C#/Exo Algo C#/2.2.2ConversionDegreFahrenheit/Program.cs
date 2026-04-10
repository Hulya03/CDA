namespace _2._2._2ConversionDegreFahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string unite;
            double min;
            double max;
            double valeurF;
            double valeurC;
          


            Console.WriteLine("Programme de conversion Celsius <-> Fahrenheit.");

            Console.WriteLine("Saisir une unité de mesure (C ou F) : ");
            unite = Console.ReadLine();

            Console.WriteLine("Saisir la valeur minimum : ");
            min = double.Parse(Console.ReadLine());

            Console.WriteLine("Saisir la valeur maximum : ");
            max = double.Parse(Console.ReadLine());

            for (double i = min; i <= max; i++)
            {

                if (unite.Contains("C"))
                {

                    valeurF = (min * 9 / 5) + 32;

                    Console.WriteLine(min + "°C = " + valeurF + " °F");


                }

                if (unite.Contains("F"))
                {

                    valeurC = (min - 32) * 5 / 9;

                    Console.WriteLine(min + "°F = " + valeurC + " °C");

                }

                min++;

            }

        }
    }
}
