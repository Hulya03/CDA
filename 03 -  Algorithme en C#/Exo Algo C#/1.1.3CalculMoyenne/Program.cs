namespace _1._1._3CalculMoyenne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer;
            int somme = 0;
            do
            {
                Console.WriteLine("Programme de calcul de la moyenne de plusieurs nombres");
                Console.WriteLine("Veuillez saisir des nombres séparés par un espace : ");
                string nb = Console.ReadLine();
                //Création d'une chaine de caractere qu'on va tansformer en tableau et utiliser "split" pour diviser la chaine de caractère
                string[] nbs = nb.Split(' ');

                foreach(string nombre in nbs)
                // pour chaque valeur "nombre" dans la liste du tableau nbs, on va faire l'addition suivante : 
                {
                    somme += int.Parse(nombre);
                }

                double avg = (double)somme / nbs.Length;
                //Writeline renvoie en chaine de caractere donc on utilise int.Parse pour avoir un entier 
                Console.WriteLine("La moyenne des nombres est " + avg);
                Console.WriteLine("Souhaitez-vous faire un autre calcul ? (O/N)");
                answer = Console.ReadLine();

            }

            while (answer == "O");
        }
    }
}
