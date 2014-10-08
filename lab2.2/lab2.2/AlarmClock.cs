using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2._2
{
    class AlarmClock
    {
        private int _alarmHour;
        private int _alarmMinute;
        private int _hour;
        private int _minute;



        public int AlarmHour // denna kollar så att både hour, minute, alarmminute och alarmhour får rätt värden inom tidsförhållanden!
    {
           get 
           {
               return _alarmHour; 
           }

           set 
           {
               if (value < 0 || value > 23)
               { throw new ArgumentException("The Value is not in a valid range between 0 and 23!!"); }
                _alarmHour = value;
           }
    }
       public int AlarmMinute
    {
            get 
            {
                return _alarmMinute; 
            }

            set
            {
                if (value < 0 || value > 59)
                { throw new ArgumentException("The Value is not in a valid range between 0 and 59!!"); }
                _alarmMinute = value;
            }
           
    }
       public int Hour
       {
           get
           {
               return _hour;
           }

           set 
           {
               if (value < 0 || value > 23)
               { throw new ArgumentException("The Value is not in a valid range between 0 and 23!"); }
               _hour = value;
           }
       }

       public int Minute
       {
           get 
           {
               return _minute;
           }

           set
           {
               if (value < 0 || value > 59)
               { throw new ArgumentException("The Value is not in a valid range between 0 and 59!"); }
               _minute = value; // skickar med ett argumentexeption med ett felmeddelande!
           }
       }

       public AlarmClock() //testas och fungerar med test1 metoden i program.cs
           : this(0, 0)
       {
 
       }

       public AlarmClock(int hour, int minute) //tar emot 0 0 från föregående och skickar med nya 0 0 till nästkommande!
           : this(hour, minute, 0, 0)
       {
 
       }

       public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)
       {
           Hour = hour;
           Minute = minute;
           AlarmHour = alarmHour;
           AlarmMinute = alarmMinute;
       }

       public bool TickTock()
       {
           
           if (Minute < 59) //ställer om minuterna på 0 om programmet når 59!
           {
               Minute++;
           }
           else
           {
               Minute = 0;

               if (Hour < 23) //ställer om timmarna när de når 24!
               {
                   Hour++;
               }
               else
               {
                   Hour = 0;
               }
           }

           return Hour == AlarmHour && Minute == AlarmMinute;

         //  if (_hour == _alarmHour && _minute == _alarmMinute) //returnerar rätt när allarmet ska gå igång
         //{
         //    return true;
         //}
           
         //  else
         //{
         //    return false;
         //}
       }

       public string ToString()//vad den här metoden gör är att den sktiver ut tiden så som jag vill att det ska vara när den blir anropad denna "mall" funkar till många olika anrop!
       {
           StringBuilder Structure = new StringBuilder();

           Structure.AppendFormat("{0,4}:", _hour); //0,4 gör så att numren ser med strukturerade ut!
           
           if (_minute < 10)
           {
               Structure.AppendFormat("0{0} ", _minute);
           }

           else
           {
               Structure.AppendFormat("{0} ", _minute);
           }

           Structure.AppendFormat("<{0}:", _alarmHour);

           if (_alarmMinute < 10)
           {
               Structure.AppendFormat("0{0}>", _alarmMinute);
           }
           else
           {
               Structure.AppendFormat("{0}>", _alarmMinute);
           }
           return Structure.ToString();
       }








    }

}
