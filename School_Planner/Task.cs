﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Planner
{
    public enum Priority
    {
        High,
        Medium,
        Low,
    }
    public enum Status
    {
        NotStarted,
        Started,
        Paused,
        Complete,
        Cancelled,
    }
    class Task
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Priority Priority { get; set; }
        public Status Status { get; set; }
        public DateTime DueDateTime { get; set; }

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
    }
}