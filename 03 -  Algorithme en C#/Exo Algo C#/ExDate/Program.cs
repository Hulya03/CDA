namespace ExDate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            string[] separation;

            Console.WriteLine("Veuillez saisir la date en format américain séparé par des '/' ");
            input = Console.ReadLine();

            separation = input.Split("/");


            DateTime d2 = new DateTime(int.Parse(separation[0]), int.Parse(separation[1]), int.Parse(separation[2]));
            DateTime d1 = DateTime.Now;
            TimeSpan ts = d1 - d2;

            Console.WriteLine(ts / 365);

        }
    }
}
