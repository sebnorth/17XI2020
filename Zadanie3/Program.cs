using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    class Program
    {

        static int PodwojElement(int[] tab, int indeks) {

            return 2 * tab[indeks];
        }

        static int PodwojPierwszyElement(int[] x) {

            return 2 * x[0];
        }

        static void Main(string[] args)
        {
            int[] array = { -1, -10, -100, -1000 };
            // Console.WriteLine(PodwojPierwszyElement(array));

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", PodwojElement(array, i));
            }

            Console.ReadKey();
            
            
        }
    }
}
