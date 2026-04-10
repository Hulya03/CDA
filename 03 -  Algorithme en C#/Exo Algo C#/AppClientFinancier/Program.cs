using Financier;                                     // ça veut dire qu'on utilise une bibliothèque de classe 
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace AppClientFinancier
{
    internal class Program                       
    {
        static void Main(string[] args)
        {
            double tauxAnnuel;
            double montant;
            int dureeEmprunt;
            
            List<Credit> banqueRevolut = new List<Credit>();                          // = Liste typée
                                                                                      // "List" différent de "Arraylist" (arraylist peut prendre différents types)
         

            Console.WriteLine("Veuillez saisir le montant à emprunter :");
            montant = double.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez saisir le taux annuel");
            tauxAnnuel = double.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez saisir la durée de remboursement");
            dureeEmprunt = int.Parse(Console.ReadLine());

            Credit creditUtilisateur = new Credit(montant,tauxAnnuel, dureeEmprunt);

            banqueRevolut.Add(creditUtilisateur);

            // Add : permet d'ajouter élément par élément
            // AddRange : permet d'ajouter une collection entière 
            // Count : renvoie combien d'élément il y a dans la liste. spécifique au list
            // FindAll : renvoie une sous liste typée
            // Find : renvoi un objet 
            // FindIndex : recherche seulement sur une partie de la liste (on marque début et la fin)
            // Sort : permet de trier des éléments dans liste typée selon le critère qu'on veut 

            Credit credit2 = new Credit(15000, 5.4, 5);
            Credit credit3 = new Credit(8000, 5.2, 4);
            Credit credit4 = new Credit(12000, 4.8, 4);

            banqueRevolut.Add(credit2);                                               // pour ajouter élément dans liste : utilisation "Add"
            banqueRevolut.Add(credit3);
            banqueRevolut.Add(credit4);

            // pour selectionner certains éléments de la liste : créer une sous-liste
            List<Credit> creditSup = banqueRevolut.FindAll(elementCredit => elementCredit.MontantEmprunt >= 10000 && elementCredit.TauxMensuel>0.004);
                                                        // prédicat : condition (qui permet de remplacer requête SQL)
                                                        // en mettant la majuscule sur "MontantEmprunt", grace à la fonction get, on accède à l'attribut privé

            double mensualite = creditUtilisateur.CalculMensualite();

            Console.WriteLine($"Votre mensualité sera de : {mensualite} EUROS");

            int compteur = 1;
            foreach (Credit item in creditSup)
            {
                Console.WriteLine(item.ToString());
                compteur++;
            }

            //creditUtilisateur.AfficherTableauAmrt();  // comme j'ai une procédure, pas besoin de variable ni de cw
            // (si il y a un return dans la fonction "AfficherTableauAmrt()", cw est suffisant, pas besoin de variable)


            
            Console.WriteLine(creditUtilisateur.CoutTotalDuCredit());

        }
    }
}
