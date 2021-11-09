using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,nr=0,nr_total=0;
            Console.Write("Dati valoare lui n= ");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                if (v[i] == 1)
                    nr++;
            }
            nr_total = nr / 2;
            if(nr%2==0)
                Console.WriteLine($"Secventa contine paranteze plasate corect iar nivelul maxim de incuibare este: {nr_total}");
            else
                Console.WriteLine($"Secventa nu contine paranteze plasate corect.");

        }
    }
}
