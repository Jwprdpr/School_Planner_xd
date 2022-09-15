using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        public List<Tasky> Tasks { get; set; }

        public Subject(string title, string classRoom, string professorName, List<Tasky> tasks)
        {
            Title = title;
            ClassRoom = classRoom;
            ProfessorName = professorName;
            Tasks = tasks;
        }

        public void AddTask(Tasky task)
        {
            Tasks.Add(task);
        }
    }
}