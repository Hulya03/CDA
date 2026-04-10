using System.Runtime.CompilerServices;

namespace ExEmprunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tauxInteretAnnuel;
            int nbAnneeRbmt;
            double capitalEmprunte;
            double tauxInteretMensuel;
            double mensualite;
            
            double interetsMensuel;
            string amortissementMois;

            mensualite = 0;


            Console.WriteLine("Veuillez saisir le montant à emprunter :");
            capitalEmprunte = double.Parse(Console.ReadLine());

            Console.WriteLine("Veuillez saisir le taux annuel");
            tauxInteretAnnuel = double.Parse(Console.ReadLine());

            Console.WriteLine("Veuillez saisir la durée de remboursement");
            nbAnneeRbmt = int.Parse(Console.ReadLine());


            mensualite = CalculMensualiteConstante(tauxInteretAnnuel, capitalEmprunte, nbAnneeRbmt);


            Console.WriteLine($"Votre mensualité sera de : {mensualite} EUROS");

           amortissementMois = TableauAmortissement(tauxInteretAnnuel,capitalEmprunte,nbAnneeRbmt);
        }


        public static double CalculMensualiteConstante(double _tauxInteretAnnuel, double _capitalEMprunte, double _nbAnneeRbmt)
        {
            double mensualiteConstante;
            mensualiteConstante = 0;
            double n = _nbAnneeRbmt * 12;

            mensualiteConstante = _capitalEMprunte * (_tauxInteretAnnuel / 1200) / (1 - Math.Pow((1+_tauxInteretAnnuel / 1200),-n));

            return Math.Round(mensualiteConstante, 2);
        }


        public static string TableauAmortissement(double _tauxInteretAnnuel, double _capitalEmprunte, int _nbAnneeRbmt)
        {
            double [] partInteret = new double [_nbAnneeRbmt*12];
            double [] partCapital = new double[_nbAnneeRbmt * 12];
            double [] capitalRestantDu = new double[_nbAnneeRbmt * 12];
            double mensualite;
            double tauxMensuel = _tauxInteretAnnuel / 1200;
            string result;

            result = "";

            capitalRestantDu[0] = _capitalEmprunte;
            partInteret[0] = 0;
            partCapital[0] = 0;

            mensualite = _capitalEmprunte * tauxMensuel / (1 - Math.Pow((1 + _tauxInteretAnnuel / 1200), -(_nbAnneeRbmt*12)));

            for (int i = 1; i < _nbAnneeRbmt * 12; i++)
            {
                partInteret[i] = capitalRestantDu[i-1]* tauxMensuel;
                partCapital[i] = mensualite - partInteret[i];
                capitalRestantDu[i] = capitalRestantDu[i-1] - partCapital[i];
                            

            }
            for (int j = 0; j < _nbAnneeRbmt * 12; j++)
            {
                result = j.ToString() + "  ";
                result += Math.Round(partInteret[j], 2).ToString() + "  ";
                result += Math.Round(partCapital[j], 2).ToString() + "  ";
                result += Math.Round(capitalRestantDu[j], 2).ToString() + "  ";
                result += Math.Round(mensualite, 2).ToString() + "  ";
                Console.WriteLine(result);

            }
            return result;
        }
    }
}
