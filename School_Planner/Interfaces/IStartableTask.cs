﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Planner.Interfaces
{
    interface IStartableTask
    {
        DateTime StartedDatetime { get; }

        void StartTask();
    }
}
