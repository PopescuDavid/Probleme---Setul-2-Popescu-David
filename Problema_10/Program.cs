using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,consecutive=1,maxim=int.MinValue;
            Console.Write("Dati valoare lui n= ");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            for (int i = 0; i < n-1; i++)
            {
                if (v[i] == v[i + 1])
                    consecutive++;
                if (v[i] != v[i + 1])
                    consecutive = 1;
                if (consecutive > maxim)
                    maxim = consecutive;
            }
            Console.WriteLine($"Numarul maxim de numere consecutive din secventa este {maxim}");
        }
    }
}
