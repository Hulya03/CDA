using System.Formats.Asn1;

namespace _1._7._3TriNombre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nbValeurs;
            int[] tableau;
            int nbTrie;

            Console.WriteLine("Entrez le nombre de valeurs que vous voulez trier");
            nbValeurs = int.Parse(Console.ReadLine());

            tableau = new int[nbValeurs];

            for (int i = 0; i < nbValeurs; i++)
            {
                Console.WriteLine("Veuillez saisir la valeur n° " + (i+1));
                tableau[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(tableau);

            Console.WriteLine("Les nombres dans l'ordre croissant :");

            foreach (int i in tableau)
            {
                
                Console.WriteLine(i);
            }
          
            Console.ReadLine();
        }
    }
}
