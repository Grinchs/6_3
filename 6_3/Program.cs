using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_3
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Ievadiet skaitli R: ");
            int R = int.Parse(Console.ReadLine());
            Console.Write("Ievadiet pirmo skaitli: ");
            int pirmais_sk = int.Parse(Console.ReadLine());
            int i = 0;

            while (i <= R)
            {
                if (i == R)
                {
                    Console.WriteLine($"Reiz[{i}] = {pirmais_sk}");
                    break;
                }

                Console.Write($"Reiz[{i}] = {pirmais_sk}*");
                int otrais_sk = int.Parse(Console.ReadLine());
                pirmais_sk = pirmais_sk * otrais_sk;
                i++;
            }
        }
    }
}