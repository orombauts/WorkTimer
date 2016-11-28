using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkTimer.logic
{
    public class WorkTimerProperties
    {
        public static readonly double DefaultLunchPauseMinutes = 30; 
        public static readonly string DefaultLunchTime = "13:00";

        public string LunchTime { get; set; }
    }
}
