using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, suma = 0,produs=1;
            Console.Write("Dati valoare lui n= ");
            n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                suma += i;
                produs *= i;
            }

            Console.WriteLine($"Suma elementelor de la 1 la {n} este: {suma}");
            Console.WriteLine($"Produsul elementelor de la 1 la {n} este: {produs}");
        }
    }
}
