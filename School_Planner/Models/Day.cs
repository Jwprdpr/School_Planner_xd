using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Planner.NewFolder
{
    public class Day
    {
        public DayOfWeek DayOfWeek { get; set; }
        public DateTime Date { get; set; }
        public ObservableCollection<Task> Tasks { get; set; }

        public Day(DateTime date, List<Task> tasks) : this(date)
        {
            Tasks = new ObservableCollection<Task>(tasks);
            Date = date;
            SetDayOfWeek();
        }

        public void SetDayOfWeek()
        {
            DayOfWeek = Date.DayOfWeek;
        }

        public void AddTask(Task task)
        {
            Tasks.Add(task);
        }
    }
}
