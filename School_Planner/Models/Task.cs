using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Planner.NewFolder
{
    public enum TypeOfTask
    {
        Exam,
        Essay,
        Explanation,
        HomeWork
    };
    public enum Priority
    {
        High,
        Medium,
        Low
    };
    public enum Status
    {
        NotStarted,
        Started,
        Paused,
        Complete,
        Cancelled
    };

    public class Tasky
    {
        public string Title { get; set; }
        public TypeOfTask Type { get; set; }
        public int PercentageWorth { get; set; }
        public string Description { get; set; }
        public Priority Priority { get; set; }
        public Status Status { get; set; }
        public DateTime DueDateTime { get; set; }

        public Tasky()
        {
        }

        public void UpdatePriority(Priority priority)
        {
            Priority = priority;
        }
        public Status CompleteTask()
        {
            Status = Status.Complete;

            return Status;
        }
        public Status CancelTask()
        {
            Status = Status.Cancelled;

            return Status;
        }

        public void ShowAllTaskTypes()
        {
            int taskNum = 0;
            foreach ( TypeOfTask task in Enum.GetValues(typeof(TypeOfTask)) )
            {
                Console.WriteLine($"{taskNum}. {task}\n");
                taskNum += 1;
            }
        }

        public void ShowAllPriorities()
        {
            int priorityNum = 0;
            foreach ( Priority priority in Enum.GetValues(typeof(Priority)) )
            {
                Console.WriteLine($"{priorityNum}. {priority}\n");
                priorityNum += 1;
            }
        }

        public void ShowAllStatus()
        {
            int statusNum = 0;
            foreach ( Status status in Enum.GetValues(typeof(Status)) )
            {
                Console.WriteLine($"{statusNum}. {status}\n");
                statusNum += 1;
            }
        }
    }
}
