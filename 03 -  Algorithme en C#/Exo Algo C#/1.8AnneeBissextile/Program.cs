namespace _1._8AnneeBissextile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string reponse;
            uint annee;
            string choix;


            // do while : 


            do
            {
            Console.WriteLine("Entrez une année : ");
            reponse = Console.ReadLine();


            // TryParse : met dans la variable "annee" la valeur de "reponse", si la saisie est correct

            if (uint.TryParse(reponse, out annee))
            {
                if (annee % 4 == 0 && annee % 100 != 0 || annee % 400 == 0)
                {
                    Console.WriteLine("L'année " + annee + " est bissextile ");
                }
                else
                {
                    Console.WriteLine("L'année " + annee + " n'est pas une année bissextile ");
                }

            }
            else
            {
                Console.WriteLine("Saisie erronée, veuillez recommencer !");
            }
                Console.WriteLine("Voulez-vous recommencer avec une autre année ? (o/n)");
                choix = Console.ReadLine().ToLower();
                //ToLower() : force les minuscules
            }
            while (choix.Equals("o"));

            Console.WriteLine("Programme terminé !");



        }
    }
}
