namespace ExDenombrementLettre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tabFrequence = new int[26];
            char[] tabAlphabet = new char[26];
            string phraseSaisie;
            char lettre;
            int min = 120;

            char test;

            for (int i = 0; i < tabFrequence.Length; i++)
            {
                tabFrequence[i] = 0;
            }

            lettre = 'a';

            for (int i = 0; i < tabAlphabet.Length; i++)
            {
                tabAlphabet[i] = lettre;                  // [] permet de sélectionner/scanner des char dans un string  
                lettre++;                                 // sur c#, l'incrémentation est capable d'aller chercher la lettre suivante
            }

            do
            {
                Console.WriteLine("Veuillez saisir un texte d'au moins 120 caractères, espace vide non inclus");
                phraseSaisie = (Console.ReadLine()).Trim().ToLower();              // Trim = enlève les espaces avant et après chaine de carctere, pas les espace à l'intérieur

            }
            while (phraseSaisie.Length < 120);

            phraseSaisie = Program.FiltreAccent(phraseSaisie);

            for (int i = 0; i < tabAlphabet.Length; i++)
            {
                test = tabAlphabet[i];

                for (int j = 0; j < phraseSaisie.Length; j++)
                {
                    if (test == phraseSaisie[j])
                    {
                        tabFrequence[i]++;
                    }
                }

            }

            Console.WriteLine("Voici la fréquence d'apparition des lettres présentes dans la phrase");

            for (int i = 0; i < tabFrequence.Length; i++)
            {
                if (tabFrequence[i] > 0)
                {
                    Console.WriteLine($"La lettre : {tabAlphabet[i]} est présente : {tabFrequence[i]} fois.");
                }
            }
        }

        public static string FiltreAccent(string _Phrase)
        {
            _Phrase = _Phrase.Replace(" ", string.Empty);
            _Phrase = _Phrase.Replace("è", "e");
            _Phrase = _Phrase.Replace("é", "e");
            _Phrase = _Phrase.Replace("ê", "e");
            _Phrase = _Phrase.Replace("ë", "e");
            _Phrase = _Phrase.Replace("à", "a");
            _Phrase = _Phrase.Replace("ù", "u");
            _Phrase = _Phrase.Replace("î", "i");
            _Phrase = _Phrase.Replace("ô", "o");
            _Phrase = _Phrase.Replace("œ", "oe");
            _Phrase = _Phrase.Replace("â", "a");
            _Phrase = _Phrase.Replace("ï", "i");
            _Phrase = _Phrase.Replace("'", "");
            _Phrase = _Phrase.Replace(",", "");
            _Phrase = _Phrase.Replace(";", "");
            _Phrase = _Phrase.Replace("-", "");
            _Phrase = _Phrase.Replace(".", "");

            return _Phrase;
        }
    }
}
