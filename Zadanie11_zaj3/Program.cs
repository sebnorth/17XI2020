using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie11_zaj3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj n");
            int n = int.Parse(Console.ReadLine());


            // pierwszy wiersz n-1 spacji i 1 X
            for (int j = 0; j < n - 1; j++)
            {
                Console.Write(" ");
            }
            Console.Write("X");
            Console.WriteLine();

            for (int i = 1; i < n-1; i++) // i - numer wiersza
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    Console.Write(" ");
                }

                Console.Write("X");
                for (int k = 0; k < i-1; k++)
                {
                    Console.Write(" ");
                }
                Console.Write("X");

                Console.WriteLine();
            }
            for (int k = 0; k < n; k++)
            {
                Console.Write("X");
            }


            // druga wersja
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= n; j++)
            //    {
            //        if (n - i - j < 0)
            //        {
            //            Console.Write("X");

            //        }
            //        else {
            //            Console.Write(" ");
            //        }
            //    }

            //    Console.WriteLine();

            //}

            Console.ReadKey();

        }
    }
}
