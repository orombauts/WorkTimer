using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WorkTimer.logic;

namespace WorkTimer
{
    public class WorkDayInterval
    {
        public DateTime startTime;
        public double pauseMinutes;

        public WorkDayInterval()
        {
            startTime = DateTime.Now.ToLocalTime().AddMinutes(-5);
            pauseMinutes = WorkTimerProperties.DefaultLunchPauseMinutes;
        }

        public DateTime getEndTime()
        {           
            double workingHours = startTime.DayOfWeek == DayOfWeek.Friday ? 7: 8;
            DateTime endTime16PM = new DateTime(startTime.Year, startTime.Month, startTime.Day, 16, 00, 00);

            DateTime endTime = startTime.AddHours(workingHours).AddMinutes(pauseMinutes);

            if (startTime.DayOfWeek == DayOfWeek.Friday && endTime < endTime16PM)
            {
                endTime = endTime16PM;
            }
            return endTime;
        }
    }
}
