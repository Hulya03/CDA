using VoitureV2;
namespace AppKiloutou
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Voiture> voitures = new List<Voiture>();   

            Voiture v1 = new Voiture(2098, "Peugeot", "307", DateTime.Parse("22/07/1980"));   //comme dans Program.cs, ce qu'il y a dans l'objet sont des chaines de caractère, il faut parser en DateTime
            Voiture v2 = new Voiture(1987, "Renault", "Espace", DateTime.Parse("01/09/1975"));
            Voiture v3 = new Voiture(1203, "Lancia", "Dedra", DateTime.Parse("07/12/1988"));
            Voiture v4 = new Voiture(3049, "Bmw", "324d", DateTime.Parse("30/09/1992"));
            Voiture v5 = new Voiture(1500, "Peugeot", "406", DateTime.Parse("08/11/2000"));
            Voiture v6 = new Voiture(2500, "Ford", "Mondeo", DateTime.Parse("28/02/1999"));

            voitures.Add(v1);
            voitures.Add(v2);   
            voitures.Add(v3);
            voitures.Add(v4);
            voitures.Add(v5);
            voitures.Add(v6);

            //Console.WriteLine(v1.ToString());  // On utilise cw car ToString ne retourne que la chaine de caractère, donc il faut lui dire de l'afficher

            Console.WriteLine("Avant le tri");
            foreach (Voiture v in voitures)      // Pour afficher chaque élément de la liste
            {
                Console.WriteLine(v.ToString());
            }

            voitures.Sort();                //Grace à la modification de la classe Voiture en implémentant l'interface IComparable + utilisation methode CompareTo
                                            //now, the Voitute class can invoke the Sort() method provided in the List<T> class to order the objects according to NumSerie property.

            Console.WriteLine("\n Tri par numéro de série");
            foreach (Voiture v in voitures)    
            {
                Console.WriteLine(v.ToString());
            }

            Console.WriteLine("\nTri par modèle");
            voitures.Sort(new CompareByModele());        // Nous passons une instance de la classe CompareByModele comme argument à la méthode Sort()méthode
            foreach (Voiture v in voitures)              // Du coup, IComparer<> trie la liste                 
            {
                Console.WriteLine(v.ToString());
            }

            Console.ReadKey();                           // permet arrêt à ce niveau dans console : on doit appuyer sur une touche dans la console

            Console.WriteLine("\nTri par marque");
            voitures.Sort(new CompareByMarque());        // surcharge de la méthode Sort()
            foreach (Voiture v in voitures)    
            {
                Console.WriteLine(v.ToString());
            }

            Console.WriteLine("\nTri par date de mise en circulation");
            voitures.Sort(new CompareByDate());
            foreach (Voiture v in voitures)
            {
                Console.WriteLine(v.ToString());
            }


            // Ou sinon pour faire plus simple sans classe Compare, dans le main, on peut directement utiliser :
            // vehicules.Sort((x, y) => x.Marque.CompareTo(y.Marque));
        }
    }
}
