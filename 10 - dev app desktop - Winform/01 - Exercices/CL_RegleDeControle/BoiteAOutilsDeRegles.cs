using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CL_RegleDeControle
{
    public static class BoiteAOutilsDeRegles    //on le passe en public 
                                                //static : on peut appeler la méthode sans l'instancier 
                                                //(cest que des méthodes dans cette classe)
    {

        public static bool IsNameValid(string nom) 
        {
            string pattern = @"^[A-Za-zÀ-ÿ-]{1,30}$";           // ^ : début
                                                                // [A-Za-zÀ-ÿ-] : lettres majuscules et minuscule incluant accents et trait d'union
                                                                // {1,30}: entre 1 et 30 caractères maximum
                                                                // $ : fin

            return Regex.IsMatch(nom, pattern) ;
        }
        
        //tryparse exact avec format 
        public static bool IsFormatDateValid(string dateInput, out DateTime dateOutput)
        {
            dateOutput = DateTime.MinValue;                 // valeur par défaut qui restera ainsi si la fonction ne valide pas la date 

            string pattern = @"^(0[1-9]|[12][0-9]|3[0-1])/(0[1-9]|1[0-2])/([0-9]{4})$";  //vérification du format JJ/MM/AAAA      [12][0-9] = imaginer ca comme un développement mathématiques

            if (!Regex.IsMatch(dateInput, pattern))
            {
                
                return false;                               //indique que le format n'est pas valide
            }

            if (DateTime.TryParse(dateInput, out dateOutput))  //DateTime.TryParse : convertit le texte en une vraie date ET range la date dans la variable dateOutput 
                                                               //ça renverra false et le progamme s'arrête là si la date n'existe pas réellement 
            {
                if (dateOutput > DateTime.Now)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsMontantValid(string montantInput, out decimal montantOutput)
        {
            montantOutput = decimal.MinValue;
            if (!Regex.IsMatch(montantInput, @"[-]"))
            {
                return Decimal.TryParse(montantInput, CultureInfo.CurrentCulture, out montantOutput);  // grace au "out", la fonction renvoie 2 infos : 
                                                                                                       // 1 bool grace au return
                                                                                                       // un nombre converti grace à la variable montantOutput
            }
            return false;
        }
        // retour de 2 paramètres 
        public static (bool, decimal) IsMontantValid(string montantInput)
        {
            bool ok = BoiteAOutilsDeRegles.IsMontantValid(montantInput, out decimal montantOuput);
            return (ok, montantOuput);
        }

        public static bool IsCPValid(string codePostal)
        {
            string pattern = @"^[0-9]{5}$";

            return Regex.IsMatch(codePostal, pattern);
 
        }
    }
}
