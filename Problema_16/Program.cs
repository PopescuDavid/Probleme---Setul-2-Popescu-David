using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            bool sortat;
            Console.Write("Dati valoare lui n= ");
            n = int.Parse(Console.ReadLine());
            int [] v = new int[n];
            if(verif(n,v))
            {
                for(int i=0;i<n/2;i++)
                {
                    int aux = v[i];
                    v[i] = v[n-i-1]; 
                    v[n - 1-i] = aux;
                }
            }
            else
                Console.WriteLine("Nu este o secventa bitonica rotita");
            if(verif(n,v))
                Console.WriteLine("Secventa bitonica rotita");
            else
                Console.WriteLine("Nu este o secventa bitonica rotita");
        }

        static bool verif(int n,int [] v)
        {
            int maxim = int.MinValue, poz = 0;
            bool ok1 = true, ok2 = true;
            v = new int[n];
            for (int i = 0; i < n/2+1; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                if (v[i] > maxim)
                {
                    maxim = v[i];
                    poz = i;
                }
            }
            if (poz >= 1)
            {
                for (int i = 0; i < poz - 1; i++)
                    if (v[i] > v[i + 1])
                        ok1 = false;
                for (int i = poz + 1; i < n - 1; i++)
                    if (v[i] < v[i + 1])
                        ok2 = false;
            }
            if (ok1 == true && ok2 == true)
                return true;
            return false;
        }
    }
}
