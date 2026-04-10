namespace triBulle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nbCAse;
            int[] tabNombres;
            TriTableau monObjetTriAffichage;


            nbCAse = 0;

            Console.WriteLine("Veuillez saisir le nombre de valeurs à intégrer dans le tableau");
            nbCAse = int.Parse(Console.ReadLine());

            tabNombres = new int[nbCAse];

            for (int i = 0; i < tabNombres.Length; i++)
            {
                Console.WriteLine("Veuillez saisir le nombre de numéro {0} / {1} du tableau ", i + 1, nbCAse);
                tabNombres[i] = int.Parse(Console.ReadLine());
            }

            monObjetTriAffichage = new TriTableau();
            Console.WriteLine("Tableau de nombre avant le tri : ");

            monObjetTriAffichage.AfficherTableau(tabNombres);

            
            // ref passe le tableau en référence, donc les valeurs du tableau est définitivement modifié :
            monObjetTriAffichage.TrierTableauAsc(ref tabNombres);

            Console.WriteLine("Tableau de nombre après le tri : ");

            monObjetTriAffichage.AfficherTableau(tabNombres);


        }
    }

    class TriTableau
    {
        // si tableau ne retourne rien : utilisation de void
        // il faut mettre "ref" sinon tableau non modifiable en dehors 
        public void TrierTableauAsc(ref int[] _monTab)
        {
            //bool permut = false;
            int temp;

            for (int i = 0; i < _monTab.Length -1; i++)
            {
                for (int j = i +1; j < _monTab.Length; j++)
                {
                    if (_monTab[i] > _monTab[j])
                    {
                        //permut = true;
                        temp = _monTab[i];
                        _monTab[j] = _monTab[i];
                        _monTab[i] = temp;
                    }

                }

            }

            

        }
        public void AfficherTableau(int[] _unTab)
        {
            Console.Write("\n [ ");

            foreach (int element in _unTab)
            {
                Console.Write( element + " ");
            }

            Console.Write(" ]");
        }




    }
}
