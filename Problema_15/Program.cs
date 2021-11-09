using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,maxim=int.MinValue,poz=0;
            bool ok1 = true, ok2 = true;
            Console.Write("Dati valoare lui n= ");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                if (v[i] > maxim)
                {
                    maxim = v[i];
                    poz = i;
                }
            }
            if(poz>=1)
            {
                for (int i = 0; i < poz - 1; i++)
                    if (v[i] > v[i + 1])
                        ok1 = false;
                for (int i = poz + 1; i < n-1; i++)
                    if (v[i] < v[i + 1])
                        ok2 = false;
            }
            if(ok1==true && ok2==true)
                Console.WriteLine("Secventa de numere este bitonica");
            else
                Console.WriteLine("Secventa de numere nu este bitonica");

        }
    }
}
