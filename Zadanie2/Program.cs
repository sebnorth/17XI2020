using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = new int[5];
            Console.WriteLine(tablica);

            foreach (int item in tablica)
            {
                Console.Write("{0} ", item);
            }

            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = 100 * i;
            }

            foreach (int item in tablica)
            {
                Console.Write("{0} ", item);
            }

            Console.ReadKey();

            //int x;
            //Console.WriteLine(x);
        }
    }
}
