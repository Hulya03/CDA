namespace _3._8Pgcd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int p;
            int q;
            int pgcd;

            do
            {
                Console.WriteLine("Programme de calcul du PGCD de 2 nombres entiers positifs!");

                Console.WriteLine("Saisir le 1er nombre :");
                p = int.Parse(Console.ReadLine());

                Console.WriteLine("Saisir le 2nd nombre :");
                q = int.Parse(Console.ReadLine());
            }
            while (p<0 || q<0);

            pgcd = CalculPgcd(p, q);

            Console.WriteLine($"Le PGCD de {p} et {q} est {pgcd}");

        }
        public static int CalculPgcd (int _a,  int _b)
        {
            int pgcd = 0;

            do
            {
                if(_a>_b)
                {
                    _a = _a - _b;
                }
                else
                {
                    _b = _b - _a;
                }
                
            }
            while (_a != _b);


            return _a;
        }
    }
}
