using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Planner.NewFolder
{
    public class User
    {
        public string StudentID { get; set; }
        public string UserName { get; set; }
        public DateTime DateTime { get; set; }
        public Planner Planner { get; set; }
    }
}
