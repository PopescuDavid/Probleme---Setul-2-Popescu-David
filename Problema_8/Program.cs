using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Dati valoare lui n= ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Al {n}-lea numar din sirul lui fibonacii este: {fibonacci(n)}");
        }

        static int fibonacci(int n)
        {
            if (n <= 1)
                return 1;
            else
                return fibonacci(n - 1) + fibonacci(n - 2);
        }
    }
}
