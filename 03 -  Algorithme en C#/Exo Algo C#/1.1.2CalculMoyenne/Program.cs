namespace _1._1._2CalculMoyenne
{
    internal class Program
    {
        // 
        static void Main(string[] args)
        {
            string answer;
            do
            {
            Console.WriteLine("Programme de calcul de la moyenne de 2 nombres");
            Console.WriteLine("Veuillez saisir 2 nombres séparés par un espace : ");
            string nb = Console.ReadLine();
            //Création d'une chaine de caractere qu'on va tansformer en tableau et utiliser "split" pour diviser la chaine de caractère
            string[] nbs = nb.Split(' ');
            double avg = (int.Parse(nbs[0]) + int.Parse(nbs[1])) / 2.0 ;
            //Writeline renvoie en chaine de caractere donc on utilise int.Parse pour avoir un entier 
            Console.WriteLine("La moyenne de " + nbs[0] + " et " + nbs[1] + " est " +  avg);
            Console.WriteLine("Souhaitez-vous faire un autre calcul ? (O/N)");
            answer = Console.ReadLine();

            }

            while (answer == "O");


            

        }
    }
}
