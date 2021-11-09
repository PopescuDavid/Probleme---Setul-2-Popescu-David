using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int contor=0;
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            int [] v = new int[n];
            Console.WriteLine("Dati elementele vectorului: ");
            for (int i=0;i<n;i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                if (v[i] % 2 == 0)
                    contor++;
            }
            Console.WriteLine($"Numarul de elemente pare este: {contor}");

        }
    }
}
