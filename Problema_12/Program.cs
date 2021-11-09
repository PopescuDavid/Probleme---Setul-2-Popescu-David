using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, contor = 1;
            Console.Write("Dati valoare lui n= ");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            for (int i = 0; i < n-1; i++)
            {
                if (v[i] != 0 && v[i + 1] == 0)
                    contor++;
            }
            Console.WriteLine($"Numarul de grupuri din secventa este: {contor}");
        }
    }
}
