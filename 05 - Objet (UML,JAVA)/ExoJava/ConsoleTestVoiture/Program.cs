using ClassLibraryVoiture;

namespace ConsoleTestVoiture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voiture v1;

            v1 = new Voiture("Mercedes", 100, "Continental");

            Console.WriteLine(v1.ToString());
            bool result;

            result = v1.Demarrer();

            Console.WriteLine(v1.ToString());

            result = v1.Arreter();

            Console.WriteLine(v1.ToString());

            result= v1.Avancer();

            Console.WriteLine(v1.ToString());

            result = v1.Demarrer();
            result = v1.Avancer();

            Console.WriteLine("\nApres demarrer et avancer : " + v1.ToString());

            result = v1.Arreter();

            Console.WriteLine(v1.ToString());




        }
    }
}
