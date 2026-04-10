namespace _3._4TriDunTableauCorrection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nbCAse;
            int[] tabNombres;


            nbCAse = 0;

            Console.WriteLine("Veuillez saisir le nombre de valeurs à intégrer dans le tableau");
            nbCAse = int.Parse(Console.ReadLine());

            tabNombres = new int[nbCAse];

            for (int i = 0; i < tabNombres.Length; i++)
            {
                Console.WriteLine("Veuillez saisir le nombre de numéro {0} / {1} du tableau ", i+1, nbCAse);
                tabNombres[i] = int.Parse(Console.ReadLine());

            }
            AfficherTableau(tabNombres);
            TrierTableau(ref tabNombres);
            Console.WriteLine("Tableau trié par ordre croissant");
            AfficherTableau(tabNombres);



        }

        // static = accessible sans instancier d'bojet, pour acceder à une methode dans la meme classe 
        public static void AfficherTableau(int [] _monTab)
        {
            Console.Write("\n[");
            foreach (int element in _monTab)
            {
                Console.Write( element + " ");   
            }
            Console.Write("]");

        }

        // on utilise "_" pour nommer un paramètre
        // "ref" prend le paramètre et le modifie de façon définitive
        public static void TrierTableau (ref int[] _monTab)
        {
            int min;
            int temp;

            for (int i = 0; i < _monTab.Length; i++)
            {
                min = i; 
                for (int j = i+1 ; j < _monTab.Length; j++)
                {
                    if (_monTab[j] < _monTab[min])
                    {
                        min = j;
                    }
                }
                temp = _monTab[i];
                _monTab[i] = _monTab[min];
                _monTab[min] = temp;

            }

        }
    }
}
