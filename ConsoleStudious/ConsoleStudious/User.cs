using System;
using System.Collections.Generic;

namespace ConsoleStudious
{
    internal class User
    {
        string name;
        int minutes;
        DateTime startTime;
        public User()
        {
            //empty constructor method
        }

        public string Name { get => name; set => name = value; }
        public int Minutes { get => minutes; set => minutes = value; }
        public double Expectations { get => minutes * 1.25; }
        public DateTime StartTime { get => startTime; set => startTime = value; }
    }
}