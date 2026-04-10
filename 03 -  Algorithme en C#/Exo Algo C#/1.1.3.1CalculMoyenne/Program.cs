namespace _1._1._3._1CalculMoyenne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number;
            string answer;
            int somme = 0;
            int N;
            bool test = true;
            string[] tab;
            double avg;
            do
            {

                do
                {
                    avg = 0;
                    Console.WriteLine("Combien de nombres voulez vous saisir ? ");
                    if (int.TryParse(Console.ReadLine(), out N))
                    {

                        number = new int[N];

                        Console.WriteLine("Programme de calcul de la moyenne de plusieurs nombres");
                        Console.WriteLine("Veuillez saisir des nombres séparés par un espace : ");
                        string nb = Console.ReadLine();
                        //Création d'une chaine de caractere qu'on va tansformer en tableau et utiliser "split" pour diviser la chaine de caractère
                        tab = nb.Split(' ');

                        for (int i = 0; i < number.Length; i++)
                        {
                            number[i]=int.Parse(tab[i]);
                        }
                        somme = number.Sum();
                         avg = Math.Round((double)somme / N,2);
                         //Writeline renvoie en chaine de caractere donc on utilise int.Parse pour avoir un entier 
                         Console.WriteLine("La moyenne des nombres est " + avg);

                    }
                    else
                    {
                        Console.WriteLine("Saisie erronée");
                        test = false;
                    }
                }
                while (test == false);

        
             
                Console.WriteLine("Souhaitez-vous faire un autre calcul ? (O/N)");
                answer = Console.ReadLine().ToLower();

            }

            while (answer.Equals("o"));
        }
    }
}


