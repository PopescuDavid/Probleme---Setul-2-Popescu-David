using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,suma=0;
            Console.Write("Dati valoare lui n= ");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                suma += oglindit(v[i]);
            }
            Console.WriteLine($"Suma inverselor numerelor din sir este: {suma}");
        }

        static int oglindit(int n)
        {
            int og = 0;
            while(n!=0)
            {
                og = og * 10 + n % 10;
                n = n / 10;
            }
            return og;
        }
    }
}
