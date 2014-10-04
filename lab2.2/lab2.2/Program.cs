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
            string HorizontalLine;


            AlarmClock test1 = new AlarmClock();
            Console.WriteLine("TestOne");
            Console.WriteLine("Test of a Constructor!");
            Console.Write("\n");
            Console.WriteLine(test1.ToString());
            Console.WriteLine();

            AlarmClock test2 = new AlarmClock(9, 42);
            Console.WriteLine("TestTwo");
            Console.WriteLine("Test of a Constructor with two parameters! (9, 42).");
            Console.WriteLine();
            Console.WriteLine(test2.ToString());
            Console.WriteLine();

            AlarmClock test3 = new AlarmClock(13, 24, 7, 35);
            Console.WriteLine("TestThree");
            Console.WriteLine("Test of a Constructor with four parameters! (13, 24, 7, 35)");
            Console.WriteLine();
            Console.WriteLine(test3.ToString());
            Console.Write("\n");

            AlarmClock test4 = new AlarmClock(23, 58 , 7, 35); //skriver ut alla dessa nummer i olika ordning 23:58 och 07:35 vlir tiderna som skickas och skrivs ut!
            Console.WriteLine("TestFour");
            Console.WriteLine("Test of my TickTock method in the class AlarmClock! ");
            Console.Write("\n");

            for (int i = 0; i < 13; i++) // loopar mitt program 13 ggr för att se så att tiden kommer tillbaka i rätt ordning!
            {
                test4.TickTock();
                Console.WriteLine(test4.ToString()); //anropar min ToString och skriver ut resultatet i ordning 13 ggr
            }
            Console.WriteLine();

            AlarmClock test5 = new AlarmClock(6, 12, 6, 16);
            Console.WriteLine("Test5");
            Console.WriteLine("Testing my AlarmClock function in the class! the minutes are 6 between 6:12 and 6:18 and alarm is set to 6:16!");
            Console.Write("\n");

            for (int i = 0; i < 6; i++)
            {
                if (test5.TickTock() == true) //skriver in detta om nu den specifika tiden som är alarmet kommer upp!
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("{0} BEEP! BEEP! BEEP!, Don't you dare SNOOZE!!", test5.ToString());
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine(test5.ToString()); // skriver ut som vanligt om nu inte just den inställda tiden är kommen!
                }
            }

            AlarmClock test6 = new AlarmClock(24, 50, 24, 50);
            Console.WriteLine("Test6");
            Console.WriteLine("I'm now testing what will happend if the numbers are ArgumentExeption and are given faulty numbers");
            Console.WriteLine();


        }

        private static void run(AlarmClock AccessViolationException, int minute)
        {

        }


        private static void ViewErrorMessage(string message)
        {

        }

        private static void ViewTestHeader(string header)
        {

        }








            

        }
    }
}
