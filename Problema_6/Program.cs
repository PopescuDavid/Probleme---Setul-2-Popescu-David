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
            int n;
            Console.Write("Dati valoare lui n= ");
            n = int.Parse(Console.ReadLine());
            bool ok = true;
            int [] v = new int[n];
            for(int i=0;i<n;i++)
                v[i] = int.Parse(Console.ReadLine());
            for (int i=0;i<n-1;i++)
                if (v[i] > v[i + 1])
                    ok = false;
            if(ok==true)
                Console.WriteLine("Numerele din secventa sunt ordonate crescator");
            else
                Console.WriteLine("Numerele din secventa nu sunt ordonate crescator");
        }
    }
}
