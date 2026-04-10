namespace _2._7._1CalculNombreJeunes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            string [] tab;
            List<int> list;
            int compteur;

            Console.WriteLine("Saisissez l'age des utilisateurs séparé par un espace ");
            input = Console.ReadLine();

            tab = input.Split(" ");
            list = new List<int>();
            compteur = 0;

            for (int i = 0; i < tab.Length; i++)
            {
                if (int.Parse(tab[i]) < 20)
                {
                    list.Add(int.Parse(tab[i]));
                    compteur++;
                }
            }

            Console.WriteLine("Il y a " + compteur + " personnes dont l'âge est strictement inférieur à 20 ans. La liste ");
        }
    }
}
