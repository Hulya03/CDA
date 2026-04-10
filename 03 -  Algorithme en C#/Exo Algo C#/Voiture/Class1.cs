namespace Voitures
{
    public class Voiture : IComparable<Voiture>     // Modification de la classe voiture en implémentant l'interface IComparable 
                                                    // The IComparable<T> interface allows us to sort a list of complex types without using LINQ. 
    {

        private int numSerie;
        private string marque;
        private string modele;

        public Voiture(int numSerie, string marque, string modele)
        {
            this.NumSerie = numSerie;
            this.Marque = marque;
            this.Modele = modele;
        }

        public int NumSerie { get => numSerie; set => numSerie = value; }
        public string Marque { get => marque; set => marque = value; }
        public string Modele { get => modele; set => modele = value; }

        public override string ToString()
        {
            string description = $"VOITURE [ numéro de série : {this.NumSerie} , marque : {this.marque} , modèle : {this.modele}] ";

            return description;
        }

        // Méthode pour trier les voitures en fonction du numéro de série dans l'ordre croisssant :

        public int CompareTo(Voiture other)     // To do that, we need to implement the IComparable interface in the Book class and implement the CompareTo() method.
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
}
