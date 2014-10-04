using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2._2
{
    class Program
    {
        static void Main(string[] args)

        {


            AlarmClock test1 = new AlarmClock();
            Console.WriteLine("Test1");
            Console.WriteLine("Test av Standardkonstruktorn.");
            Console.Write("\n");
            Console.WriteLine(test1.ToString());
            Console.WriteLine();

            AlarmClock test2 = new AlarmClock(9, 42);
            Console.WriteLine("Test2");
            Console.WriteLine("Test av Konstruktorn med två parametrar, (9, 42).");
            Console.WriteLine();
            Console.WriteLine(test2.ToString());
            Console.WriteLine();

            AlarmClock test3 = new AlarmClock(13, 24, 7, 35);
            Console.WriteLine("Test3");
            Console.WriteLine("Test av konstruktorn med fyra parametrar (13, 24, 7, 35)");
            Console.WriteLine();
            Console.WriteLine(test3.ToString());
            Console.Write("\n");





            

        }
    }
}
