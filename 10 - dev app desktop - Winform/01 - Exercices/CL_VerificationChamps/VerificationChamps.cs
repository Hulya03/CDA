using System.Globalization;
using System.Text.RegularExpressions;

namespace CL_VerificationChamps
{
    public static class VerificationChamps

    {
        //Verification du champ nom
        public static bool FormatNomValide(string nom)
        {
            string pattern = @"^[A-Za-zÀ-ÿ-]{1,30}$";           

            return Regex.IsMatch(nom, pattern);
        }

        //Vérification du champs date
        public static bool FormatDateValide(string dateSaisieEntree, out DateTime dateSaisieSortie)
        {
           
            return DateTime.TryParse(dateSaisieEntree,CultureInfo.CurrentCulture, out dateSaisieSortie);
        }



       
    }
}
