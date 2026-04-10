using System.IO.IsolatedStorage;

namespace _2._1._3ConverionKmMiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            double valeurKm;
            double valeurMiles;
            List<string> values = new List<string>();

            Console.WriteLine("Programme de conversion km <=> miles");
            Console.WriteLine("Entrez la commande 'go' pour tout convertir ou 'quit' pour quitter le programme");


            do
            {
                Console.WriteLine("Saisir une valeur et son unité de mesure (séparés par un espace : 'mi' ou 'km') : ");
                do
                {


                    input = Console.ReadLine();

                    values.Add(input);
                }
                while (!(input.Contains("go") || input.Contains("quit")));


                for (int i = 0; i < values.Count; i++)
                {

                    if (values[i].Contains("mi"))
                    {
                        string[] separation = values[i].Split(" ");

                        valeurKm = double.Parse(separation[0]) * 1.609;
                        Console.WriteLine(values[i] + " = " + Math.Round(valeurKm, 4) + " km");
                    }

                    else if (values[i].Contains("km"))
                    {
                        string[] separation = values[i].Split(" ");

                        valeurMiles = double.Parse(separation[0]) / 1.609;
                        Console.WriteLine(values[i] + " = " + Math.Round(valeurMiles, 4) + " miles");
                    }

                }

            }
            while (!(input.Contains("quit")));
        }
    }
}
