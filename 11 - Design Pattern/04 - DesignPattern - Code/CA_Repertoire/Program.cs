using CL_Repertoire;


string monChemin = @"C:\Users\hcetin\Desktop\test";

Composite racine = new Composite(monChemin);

// On appelle la méthode sur l'objet 'racine'
racine.Repertorie();

// pour voir le résultat
// on met formate(0) car la racine n'a aucun tiret d'indentation, donc ind = 0 
Console.WriteLine(racine.Formate(0));
