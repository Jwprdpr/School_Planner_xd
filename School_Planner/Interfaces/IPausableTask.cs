using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Planner.Interfaces
{
    interface IPausableTask
    {
        DateTime PausedDatetime { get; }

        void PauseTask();
    }
}
