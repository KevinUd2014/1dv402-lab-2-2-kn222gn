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
            string HorizontalLine = "________________________________________________________________";


            AlarmClock test1 = new AlarmClock();
            ViewTestHeader(HorizontalLine);//Console.WriteLine("TestOne");
            ViewTestHeader("\nTest1");       //Console.WriteLine("Test of a Constructor!");
            ViewTestHeader("Test of a Constructor! \n");//Console.Write("\n");
            ViewTestHeader(test1.ToString());//Console.WriteLine(test1.ToString());
            //Console.WriteLine();

            AlarmClock test2 = new AlarmClock(9, 42);
            ViewTestHeader(HorizontalLine);//här skickar jag med strängen Horizontalline
            ViewTestHeader("\nTestTwo"); // här anropar jag metoden viewtestheader och skriver ut all min text!
            ViewTestHeader("Test of a Constructor with two parameters! (9, 42). \n");
            ViewTestHeader(test2.ToString()); //här anropar jag via min viewtestheader min class Alarmclock metoden to string!

            AlarmClock test3 = new AlarmClock(13, 24, 7, 35);
            ViewTestHeader(HorizontalLine);
            ViewTestHeader("\nTestThree");
            ViewTestHeader("Test of a Constructor with four parameters! (13, 24, 7, 35) \n");
            ViewTestHeader(test3.ToString());

            AlarmClock test4 = new AlarmClock(23, 58 , 0, 0); //skriver ut alla dessa nummer i olika ordning 23:58 och 07:35 vlir tiderna som skickas och skrivs ut!
            ViewTestHeader(HorizontalLine);
            ViewTestHeader("\nTestFour");
            ViewTestHeader("Test of my TickTock method in the class AlarmClock! \n");
            run(test4, 13);

            AlarmClock test5 = new AlarmClock(6, 12, 6, 16);
            ViewTestHeader(HorizontalLine);
            ViewTestHeader("\nTestFive");
            ViewTestHeader("Testing my AlarmClock function in the class! the minutes are 6 between 6:12 and 6:18 and alarm is set to 6:16! \n");
            run(test5, 6);

            AlarmClock test6 = new AlarmClock();
            ViewTestHeader("\nTestSix");
            ViewTestHeader("I'm now testing what will happend if the numbers are ArgumentExeption and are given faulty numbers \n");

            try
            {
                test6.AlarmHour = 25;
            }
            catch (ArgumentException Error)
            {
                ViewErrorMessage(Error.Message);
            }

            try
            {
                test6.AlarmMinute = 60;
            }
            catch (ArgumentException Error2)
            {
                ViewErrorMessage(Error2.Message);
            }

            try
            {
                test6.Hour = 40;
            }
            catch (ArgumentException Error3)
            {
                ViewErrorMessage(Error3.Message);
            }

            try
            {
                test6.Minute = 100;
            }
            catch (ArgumentException Error4)
            {
                ViewErrorMessage(Error4.Message);
            }

            AlarmClock test7 = new AlarmClock();
            ViewTestHeader(HorizontalLine);
            ViewTestHeader("\nTestSeven");
            ViewTestHeader("Testing what will happend if wrong numbers are written as alarm hour and hour \n");

            try
            {
                test7.AlarmHour = 25;
            }
            catch (ArgumentException Error)
            {
                ViewErrorMessage(Error.Message);
            }

            try
            {
                test7.Hour = 40;
            }
            catch (ArgumentException Error3)
            {
                ViewErrorMessage(Error3.Message);
            }

        }

        private static void run(AlarmClock ac, int minute)
        {
            for (int i = 0; i < minute; i++)
            {
                if (ac.TickTock()) //skriver in detta om nu den specifika tiden som är alarmet kommer upp!
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("{0} BEEP! BEEP! BEEP!, Don't you dare SNOOZE!!", ac.ToString());
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine(ac.ToString()); // skriver ut som vanligt om nu inte just den inställda tiden är kommen!
                }
            }
        }


        private static void ViewErrorMessage(string message)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        private static void ViewTestHeader(string header)
        {
            Console.WriteLine(header);
        }








            

        }
    }

