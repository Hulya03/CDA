namespace ExDateCorrige
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateNaissance;
            string chaineReponse;

            Console.WriteLine("Veuillez entrer votre date de naissance au format dd/mm/yyyy ");

            string[] tabDate;


            chaineReponse = Console.ReadLine();

            tabDate = chaineReponse.Split('/');


            //new DateTime : appel du constructeur "DateTime" avec "new" 
            dateNaissance = new DateTime (int.Parse(tabDate[2]), int.Parse(tabDate[1]), int.Parse(tabDate[0]));



            ControleSaisie monControle;
            monControle = new ControleSaisie();


            bool estMajeur = Program.ControleSaisie.Majorite(dateNaissance);

            if (estMajeur)
            {
                Console.WriteLine("Vous êtes majeur, vous pouvez entrer dans l'application");
            }
            else
            {
                Console.WriteLine("Vous êtes mineur, revenez nous voir plus tard !!");
            }

        }

        // même si on met pas "public", on pourra y acceder car on est dans le meme  namespace
        // si on met rien on en private par défaut
        // meme si on nomme pas de constructeur, il y en a un par défaut
    class ControleSaisie()
        {
            // static : pas besoin d'instancier d'objet pour accéder à la méthode
            // si public : accessible depuis l'instance
            // private : sera accessible que en interne, pas dans "Program"
            public static bool Majorite(DateTime _maDate)
            {
                bool estMajeur = false;
                DateTime dateDuJour = DateTime.Today;   //permet de prendre date du jour sans les heures
                TimeSpan ecart = dateDuJour - _maDate;
                double nbAnnee = (ecart.Days) / 365.2425;

                if (nbAnnee >= 18)
                {
                    estMajeur = true;
                }
                else
                {
                    estMajeur = false; 
                }

                return estMajeur;
            }


        }
    }
}
