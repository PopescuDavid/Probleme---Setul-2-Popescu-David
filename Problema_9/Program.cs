using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Dati valoare lui n= ");
            n = int.Parse(Console.ReadLine());
            bool crescator= true,descrescator=true;
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            for (int i = 0; i < n - 1; i++)
            {
                if (v[i] > v[i + 1])
                    crescator = false;
                if (v[i] < v[i + 1])
                    descrescator = false;
            }
            if (crescator == true)
                Console.WriteLine("Numerele din secventa sunt ordonate crescator");
            if(descrescator==true)
                Console.WriteLine("Numerele din secventa sunt ordonate descrescator");
            if(crescator==false && descrescator==false)
                Console.WriteLine("Secventa nu este monotona");
        }
    }
}
