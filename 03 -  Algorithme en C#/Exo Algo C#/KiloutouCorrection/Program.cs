using System.Diagnostics;

namespace KiloutouCorrection 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Voiture> parcVehicules = new List<Voiture>();

            Voiture v1 = new Voiture(2098, "Peugeot", "307", "BARBIER", "2016/12/05");   //comme dans Program.cs, ce qu'il y a dans l'objet sont des chaines de caractère, il faut parser en DateTime
            Voiture v2 = new Voiture(1987, "Renault", "Espace", "ARES", "2020/02/15");
            Voiture v3 = new Voiture(1203, "Lancia", "Dedra", "BANOR", "2014/04/20");
            Voiture v4 = new Voiture(3049, "Bmw", "324d", "PECHEUR", "2025/01/25");
            Voiture v5 = new Voiture(1500, "Peugeot", "406", "HUMERY", "2012/08/21");
            Voiture v6 = new Voiture(2500, "Ford", "Mondeo", "MORABITI", "2019/05/08");

            parcVehicules.Add(v1);
            parcVehicules.Add(v2);
            parcVehicules.Add(v3);
            parcVehicules.Add(v4);
            parcVehicules.Add(v5);
            parcVehicules.Add(v6);

            parcVehicules.Sort();                       // Methode par défaut : va aller trier parMarque parce qu'on a mis par marque dans CompareTo
            AfficherListe(parcVehicules);

            Console.WriteLine("La voiture ayant pour propriétaire M. BARBIER");
            Voiture D = parcVehicules.Find(vehicule => vehicule.GetProprio().Equals("BARBIER"));
            Console.WriteLine(D.ToString());

            Console.WriteLine("\nLes voitures mise en circulation après 2000");
            List<Voiture> vRecents = parcVehicules.FindAll(vehicule => vehicule.DateMiseCirculation > new DateTime(2019, 12, 31));
            AfficherListe(vRecents);

            Console.WriteLine("\nLes voitures mise en circulation après 2016 et de marque Peugeot");
            List<Voiture> vPeugeot = parcVehicules.FindAll(vehicule => vehicule.Marque.Equals("Peugeot") && vehicule.DateMiseCirculation.Year >= 2016);
            AfficherListe(vPeugeot);

            Console.ReadKey();

            Console.WriteLine("Voitures triées par modèle :");
            parcVehicules.Sort(new ParModele());
            AfficherListe(parcVehicules);


        }

        public static void AfficherListe(List<Voiture> _maListe)
        {
            Console.WriteLine("[");
            foreach (Voiture monObj in _maListe)
            {
                Console.WriteLine(monObj.ToString() + " ");
            }
            Console.WriteLine("]\n");
        }
    }
}
