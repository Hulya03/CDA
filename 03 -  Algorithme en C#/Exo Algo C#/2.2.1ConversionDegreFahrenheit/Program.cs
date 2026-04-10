namespace _2._2._1ConversionDegreFahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programme de conversion Celsius <-> Fahrenheit.");

            string input;
            double valeurF;
            double valeurC;
            string[] separation;




            do
            {
                Console.WriteLine("Saisir une température avec son unité de mesure (C ou F) : ");
                input = Console.ReadLine();
                separation = input.Split(' ');

                if (input.Contains("C"))
                {

                    valeurF = (double.Parse(separation[0]) * 9 / 5) + 32;

                    Console.WriteLine(double.Parse(separation[0]) + "°C = " + valeurF + " F");

                }

                if (input.Contains("F"))
                {

                    valeurC = (double.Parse(separation[0]) - 32) * 5 / 9;

                    Console.WriteLine(double.Parse(separation[0]) + "°F = " + valeurC + " C");

                }

            }
            while (double.Parse(separation[0]) < -459.67 || double.Parse(separation[0]) > 5000000);
        }
    }
}
