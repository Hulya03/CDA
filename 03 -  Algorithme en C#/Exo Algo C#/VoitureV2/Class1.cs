namespace VoitureV2
{
    public class Voiture : IComparable<Voiture>     // Modification de la classe voiture en implémentant l'interface IComparable 
                                                    // The IComparable<T> interface allows us to sort a list of complex types without using LINQ. 
    {
        private int numSerie;
        private string marque;
        private string modele;
        private DateTime dateMiseEnCirculation;

        public Voiture(int numSerie, string marque, string modele, DateTime dateMiseEnCirculation)
        {
            this.NumSerie = numSerie;
            this.Marque = marque;
            this.Modele = modele;
            this.DateMiseEnCirculation = dateMiseEnCirculation;
        }

        public int NumSerie { get => numSerie; set => numSerie = value; }
        public string Marque { get => marque; set => marque = value; }
        public string Modele { get => modele; set => modele = value; }
        public DateTime DateMiseEnCirculation { get => dateMiseEnCirculation; set => dateMiseEnCirculation = value; }

        public override string ToString()
        {
            string description = $"VOITURE [ numéro de série : {this.NumSerie} , marque : {this.marque} , modèle : {this.modele} , date de mise en circulation {this.dateMiseEnCirculation}] ";
            return description;
        }

        // Méthode pour trier les voitures en fonction du numéro de série dans l'ordre croisssant :
        public int CompareTo(Voiture other)     // To do that, we need to implement the IComparable interface in the Voiture class and implement the CompareTo() method.
        {
            if (other == null)
                return 1;                       // Greater than zero – meaning the compared instance comes before the current instance in the sort order
            if (this.NumSerie > other.NumSerie)
                return 1;
            else if (this.NumSerie < other.NumSerie)
                return -1;                      // Less than zero – meaning the compared instance comes after the current instance in the sort order
            else
                return 0;                       // Zero – meaning both the compared and the current instances have the same position in the sort order
            // !!!!! Avec le duo Icomparable et CompareTo : on arrive à trier selon seulement un attribut
        }
    }

    //Nous pouvons également utiliser  IComparer<> l'interface pour avoir nos implémentations de comparaison et
    //ainsi trier la liste en fonction de nos implémentations personnalisées.

    //Les interfaces IComparer<T> et IComparable<T> fonctionnent différemment.

    //Nous l'utilisons IComparable<T>pour la comparaison intrinsèque, c'est-à-dire pour comparer une autre instance à l'instance actuelle.
    //IComparer<T>, d'autre part, nous fournit un mécanisme pour comparer deux objets différents.

    class CompareByNumSerie : IComparer<Voiture>
    {
        public int Compare(Voiture x, Voiture y)                 // Comparaison de int
        {                                                        // j'ai pas utilisé cette classe qui permet de faire la meme chose que la méthode ci dessus combiné à Sort                                                       
            if (x.NumSerie > y.NumSerie)
                return 1;
            if (x.NumSerie < y.NumSerie)
                return -1;
            else
                return 0;
        }
    }

    public class CompareByModele : IComparer<Voiture>        // Implémentation de IComparer pour trier List<Voiture> par Modèle
                                                             // Maintenant, dans le MAIN, nous devons passer une instance de la classe CompareByModele comme argument à la méthode Sort()méthode
    {                                                        // Pb : avec Sort() vide, cad sans paramètre, le tri ne se fera que par marque avec cette classe
        public int Compare(Voiture x, Voiture y)
        {
            return x.Modele.CompareTo(y.Modele);              // Comparaison de chaine de caractères
        }
    }
    public class CompareByMarque : IComparer<Voiture>
    {
        public int Compare(Voiture x, Voiture y)
        {
            return x.Marque.CompareTo(y.Marque);
        }
    }

    public class CompareByDate : IComparer<Voiture>
    {
        public int Compare(Voiture x, Voiture y)
        {
            return x.DateMiseEnCirculation.CompareTo(y.DateMiseEnCirculation);
        }
    }
}
