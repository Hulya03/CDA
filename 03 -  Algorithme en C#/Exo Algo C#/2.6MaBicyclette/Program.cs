using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace _2._6MaBicyclette
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            string input;
            bool beauTemps;
            bool baladeBicyclette;
            bool baladePied;
            bool veloBonEtat;
            bool reparationImmediate;
            bool livreDispoMaison;
            bool livreDispoBibliotheque;
           

            Console.WriteLine("Est ce qu'il fait beau ?");
            input = Console.ReadLine();
            beauTemps = ConversionStringToBool(input);

            if (beauTemps)
            {
                Console.WriteLine("Est-ce que le vélo est en bon état ?");
                input = Console.ReadLine();
                veloBonEtat = ConversionStringToBool(input);

                if (veloBonEtat == false)
                {
                    Console.WriteLine("Puis-je rélaiser des réparations immédiates chez le garagiste ?");
                    input = Console.ReadLine();
                    reparationImmediate = ConversionStringToBool(input);
                    if (reparationImmediate == false)
                    {
                        Console.WriteLine("Il fait beau et le vélo est en mauvais état, je passe chez le garagiste qui réalisera les réparations plus tard donc je fais une balade à pied");
                    }
                    else
                    {
                        Console.WriteLine("Il fait beau et le vélo est en mauvais état, je passe chez le garagiste qui réalise les réparations immédiatement donc je fais une balade à vélo");
                                            }
                }
                else
                {
                    Console.WriteLine("Il fait beau et le vélo est en bon état donc je fais une balade en vélo");
                                    }

            }else
            {
                Console.WriteLine("Est ce que je possède le livre de Game of Thrones ?");
                input = Console.ReadLine();
                livreDispoMaison = ConversionStringToBool(input);

                if (!livreDispoMaison)
                {
                    Console.WriteLine("Est ce que le livre est disponible à la bibliothèque ?");
                    input = Console.ReadLine();
                    livreDispoBibliotheque = ConversionStringToBool(input);

                    if (livreDispoBibliotheque == false)
                    {
                        Console.WriteLine("Du coup, je lis un roman policier confortablement à la maison");

                    }else
                    {
                        Console.WriteLine("Il fait pas beau, je lis Game of Throne à la maison");
                    }

                }else
                {
                    Console.WriteLine("Il fait pas beau, je lis Game of Throne à la maison");

                }

            }




        }
        public static Boolean ConversionStringToBool(string _input)
        {
            
            do
            {
                if (_input.Equals("o"))
                {  
                    return true;
                }
                else if (_input.Equals("n"))
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("saisir une valeur correcte : 'o' ou 'n'");
                    _input = Console.ReadLine();
                }
            }
            while (!_input.Equals("o") && !_input.Equals("n"));
           return false;
        }
    }
}
