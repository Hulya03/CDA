using CL_RegleDeControle;

internal class program
{
    static void Main()
    {

        //1.1) Tester le nom : résultat attendu = true 
        Console.WriteLine("1.1) Nom avec saisie correcte (que lettres et -31 caractères )");
        string inputName1 = "Julia";
        bool nomValide = false;
        nomValide = BoiteAOutilsDeRegles.IsNameValid(inputName1);
        Console.WriteLine("saisie : " + inputName1);
        Console.WriteLine("le format du nom est valide : " + nomValide +"\n");

        //1.2)Tester le nom : 30 caractères donc résultat attendu = true 
        Console.WriteLine("1.2) Nom avec lettre et 30 caractères");
        string inputName2 ="Juliaaaaaaaaaaaaaaaaaaaaaaaaaa";
        bool nomValide2 = false;
        nomValide2 = BoiteAOutilsDeRegles.IsNameValid(inputName2);
        Console.WriteLine("saisie : " + inputName2);
        Console.WriteLine("le format du nom est valide : " + nomValide2 + "\n");

        //1.3)Tester le nom : avec lettres et plus de 30 caractères donc résultat attendu = false 
        Console.WriteLine("1.3) Nom avec lettre et plus de 30 caractères");
        string inputName3 = "Juliaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
        bool nomValide3 = false;
        nomValide3 = BoiteAOutilsDeRegles.IsNameValid(inputName3);
        Console.WriteLine("saisie : " + inputName3);
        Console.WriteLine("le format du nom est valide : " + nomValide3 + "\n");

        //1.3) Tester le nom : contient un chiffre donc résultat attendu = false 
        string inputName4 = "Julia2";
        bool nomValide4 = false;
        nomValide4 = BoiteAOutilsDeRegles.IsNameValid(inputName4);
        Console.WriteLine("saisie : " + inputName4);
        Console.WriteLine("le format du nom est valide : " + nomValide4 + "\n");

    }
}