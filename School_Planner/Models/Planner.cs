using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Planner.NewFolder
{
    public class Planner
    {
        public List<Subject> Subjects { get; set; } = new List<Subject>();

        public Planner(List<Subject> subjects)
        {
            Subjects = subjects;
        }
        public void AddSubject(Subject subject)
        {
            Subjects.Add(subject);
        }
    }
}
