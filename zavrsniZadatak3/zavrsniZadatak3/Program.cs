using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavrsniZadatak3
{
    class Program
    {
        static void Main(string[] args)
        {
            int cetiri, sest, cetiriIsest, broj;

            Console.Write("Molimo Vas unesite broj: ");
            broj = Convert.ToInt32(Console.ReadLine());

            if(broj % 6 == 0 && broj % 4 != 0)
            {
                Console.Write("Uneseni broj djeljiv je sa 6.");
            }

            if (broj % 4 == 0 && broj % 6 != 0)
            {
                Console.Write("Uneseni broj djeljiv je sa 4.");
            }


            if (broj % 6 == 0 && broj % 4 == 0)
            {
                Console.Write("Uneseni broj djeljiv je sa 6 i 4.");
            }
            
            if (broj % 6 != 0 && broj % 4 != 0)
            {
                Console.Write("Uneseni broj nije djeljiv sa 6 i 4.");
            }

            Console.ReadKey();
        }
    }
}
