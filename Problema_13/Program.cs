using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Dati valoare lui n= ");
            n = int.Parse(Console.ReadLine());
            bool ok = true, sortat;
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            for (int i = 0; i < n - 1; i++)
                if (v[i] > v[i + 1])
                    ok = false;
            if (ok == true)
                Console.WriteLine("Secventa crescatoare rotita");
            else
            {
                do
                {
                    sortat = true;
                    for (int i = 0; i < n - 1; i++)
                    {
                        if (v[i] > v[i + 1])
                        {
                            int aux = v[i];
                            v[i] = v[i + 1];
                            v[i + 1] = aux;
                            sortat = false;
                        }
                    }
                } while (!sortat);
                Console.Write("Secventa crescatoare rotita transformata este: ");
                for (int i = 0; i < n; i++)
                    Console.Write(v[i] + " ");
                Console.ReadKey();
            }
        }
    }
}
