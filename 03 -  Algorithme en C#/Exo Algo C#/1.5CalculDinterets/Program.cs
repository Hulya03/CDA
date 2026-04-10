namespace _1._5CalculDinterets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double somme;
            double interet;
            int nbAnnee;
            double avecInteretSimple;
            double avecInteretCompose;

            
            Console.WriteLine("Entrez la valeur de la somme initiale : ");
            somme = double.Parse(Console.ReadLine());

            Console.WriteLine("Entrez la valeur de l'intéret offert par la banque :");
            interet = double.Parse(Console.ReadLine());

            Console.WriteLine("Entrez le nombre d'années de placement : ");
            nbAnnee = int.Parse(Console.ReadLine());

            avecInteretSimple = somme * ( 1 + nbAnnee * interet );
            avecInteretCompose = somme * Math.Pow ((1 + interet), nbAnnee);

            Console.WriteLine("Avec un intérêt simple, la valeur acquise par " + somme + "euros placées pendant " + nbAnnee + "années est de : " + avecInteretSimple);

            Console.WriteLine("Avec un intérêt composé, la valeur acquise par " + somme + "euros placées pendant " + nbAnnee + "années est de : " + avecInteretCompose);




        }
    }
}
