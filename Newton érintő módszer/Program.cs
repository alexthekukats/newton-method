using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem adja meg a gyökön vonni kívánt számot!");
            int a = Convert.ToInt32(Console.ReadLine());
            double kitevo = a;
            int alap = a;
            //ertek = ertek - (((Math.Pow(1, 2) - gyok)) / 2 * 1);

            for (int i = 0;i < 30 ; i++)
            {
                kitevo = kitevo - ((kitevo * kitevo - alap) / (2*kitevo));
                Console.WriteLine(kitevo);
                Console.ReadKey();
            }

            Console.ReadKey();
        }
    }
}
