namespace _3._1RechercheNb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab;
            int N;
            int indice;


            tab = new int[3];
            indice = 0;

            Console.WriteLine("Veuillez saisir un nombre entier : ");

            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = int.Parse(Console.ReadLine());
            }


            for (int i = 0;i < tab.Length; i++)                     // parcourt le tableau à partir de la cellule 0
            {
                int minIndex = i;

                for (int j = i + 1; j < tab.Length; j++)               // parcourt le tableau à partir de la cellule 1
                {
                    if(tab[j] <  tab[minIndex])                             // compare les 2 valeurs 
                    {
                        minIndex = j;                               // stockage de l'indice du nombre inférieur
                    }

                }
                int temp;                                           // permet de stocker une variable temporairement

                temp = tab[i];
                tab[i] = tab[minIndex];
                tab[minIndex] = temp;                                      // changement de la place des deux valeurs pour mettre la plus petite en premier
            }

            Console.WriteLine("Les valeurs dans l'ordre croissant :");
            foreach (int values in tab)
            {
                Console.Write(values + " ");
            }

            Console.WriteLine("Saisissez une valeur pour savoir si elle se trouve dans le tableau :");
            N = int.Parse(Console.ReadLine()) ;

            for (int i = 0; i < tab.Length ; i++)
            {
                if (tab[i] == N)
                {
                    indice = i + 1;

                }
            }

            if (indice != 0)
            {
                Console.WriteLine("Votre nombre est au rang " + indice);
            }
            else
            {
                Console.WriteLine("non trouvé");
            }

        }
    }
}
