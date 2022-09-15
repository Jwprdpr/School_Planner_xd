using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Planner.NewFolder
{
    // The method day will be another type of tasks collection
    // We will create a grid/calendar that will show the tasks we have on every day

    public class Day
    {
        public DayOfWeek DayOfWeek { get; set; }
        public DateTime Date { get; set; }
        public ObservableCollection<Task> Tasks { get; set; }

        //With the dateTime property wi will be able to asociate the Class day
        // with a day in the grid 
        public Day(DateTime date, List<Task> tasks) 
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
