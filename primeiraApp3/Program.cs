using System;

namespace primeiraApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 18;
            int b = 6;
            int c = a + b;
            Console.WriteLine(c);
            int d = (a + b) - 6 * c + (12 * 4) / 3 + 12;

            Console.WriteLine(d);
             a = 7;
             b = 4;
             c = 3;
             d = (a  + b) / c; //Div
            int e = (a + b) % c;// Mod
            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");
            int max = int.MaxValue; //Valor maximo para interio
            int min = int.MinValue; // Valor minimo para interio
            Console.WriteLine($"The range of integers is {min} to {max}");
            int what = max + 3;
            Console.WriteLine($"Um exemplo de transbordo: {what}");
            double maxd = double.MaxValue;
            double mind = double.MinValue;
            Console.WriteLine($"The range of double is {mind} to {maxd}");

            double aa = 1.0;
            double bb = 3.0;
            Console.WriteLine(aa / bb);

            decimal cc= 1.0M;
            decimal dd = 3.0M;
            Console.WriteLine(cc / dd);
            Mate math = new Mate();
            Console.WriteLine($"O valor da área é : {math.AreaDoCirculo(2.50)}");
        }
    }
}
