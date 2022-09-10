using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Planner.NewFolder
{
    public class Week
    {
        public int WeekNumber { get; set; }
        public List<Day> Days { get; set; }

        public Week(int weekNumber)
        {
            WeekNumber = weekNumber;
        }
        public Week(int weekNumber, List<Day> days) : this(weekNumber)
        {
            Days = days;
        }
        public void AddDay(Day day)
        {
            Days.Add(day);
        }
    }
}
