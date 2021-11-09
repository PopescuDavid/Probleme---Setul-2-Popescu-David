using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, poz=0,a;
            bool ok = false;
            Console.Write("Dati valoare lui n= ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Dati valoare lui a= ");
            a = int.Parse(Console.ReadLine());
            int [] v = new int[n];
            for(int i=0;i<n;i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                if(v[i]==a)
                {
                    poz = i;
                    ok = true;
                }
            }
            if(ok==true)
                Console.WriteLine($"Numarul {a} se afla pe pozitia {poz}");
            else
                Console.WriteLine("-1");
        }
    }
}
