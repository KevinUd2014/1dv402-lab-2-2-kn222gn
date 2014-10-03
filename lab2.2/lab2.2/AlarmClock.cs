﻿using System;
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
                    throw new ArgumentException();
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
                    throw new ArgumentException();
                _alarmMinute = value;
            }
           
    }
       public int Hour
       {
           
       }


       
    }

}