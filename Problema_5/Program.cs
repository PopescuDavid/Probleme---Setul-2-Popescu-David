using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,contor=0;
            Console.Write("Dati valoare lui n= ");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for(int i=0;i<n;i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                if (v[i] == i)
                    contor++;
            }
            Console.WriteLine($"In sir se afla {contor} numere egale cu pozitia lor");
        }
    }
}
