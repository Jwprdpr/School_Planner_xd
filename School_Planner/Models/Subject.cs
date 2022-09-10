using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Planner.NewFolder
{
    public class Subject
    {
        public string Title { get; set; }
        public string ClassRoom { get; set; }
        public string ProfessorName { get; set; }
        public List<Task> Tasks { get; set; }
    }
}
