using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, min = int.MaxValue, max = int.MinValue;
            Console.Write("Dati valoare lui n= ");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                if (v[i] > max)
                    max = v[i];
                if (v[i] < min)
                    min = v[i];
            }
            Console.WriteLine($"Cel mai mare numar din sir este {max}, iar cel mai mic este {min}");
        }
    }
}
