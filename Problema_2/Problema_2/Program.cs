using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int contorNegative=0,contorZero=0,contorPozitive = 0;
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("Dati elementele vectorului: ");
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                if (v[i] <  0)
                    contorNegative++;
                if (v[i] > 0)
                    contorPozitive++;
                if (v[i] == 0)
                    contorZero++;
            }
            Console.WriteLine($"Numarul de elemente negtive este: {contorNegative}");
            Console.WriteLine($"Numarul de elemente pozitive este: {contorPozitive}");
            Console.WriteLine($"Numarul de elemente nule este: {contorZero}");
        }
    }
}
