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



        public int AlarmHour
    {
           get 
           {
               return _alarmHour; 
           }

           set 
           {
               if (value < 0 || value > 23)
               { throw new ArgumentException("The Value is not in a valid range between 0 and 23!"); }
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
                { throw new ArgumentException("The Value is not in a valid range between 0 and 59!"); }
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
               _minute = value;
           }
       }

       public AlarmClock() //testas och fungerar med test1 metoden i program.cs
           : this(0, 0)
       {
 
       }

       public AlarmClock(int hour, int minute)
           : this(hour, minute, 0, 0)
       {
 
       }

       public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)
       {
           _hour = hour;
           _minute = minute;
           _alarmHour = alarmHour;
           _alarmMinute = alarmMinute;
       }

       public bool TickTock()
       {
           _minute++;

           if (_minute > 59) //ställer om minuterna på 0 om programmet når 59!
         {
            _minute = 0;
            _hour++; 
         }

           if (_hour > 23) //ställer om timmarna när de når 24!
         {
             _hour = 0;
             //_minute++;
         }

           if (_hour == _alarmHour && _minute == _alarmMinute) //returnerar rätt när allarmet ska gå igång
         {
             return true;
         }
           
           else
         {
             return false;
         }
       }

       public string ToString()
       {
           StringBuilder Structure = new StringBuilder();

           Structure.AppendFormat("{0,4}:", _hour);
           
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
