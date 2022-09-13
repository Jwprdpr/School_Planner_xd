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
        public List<User> Users { get; set; }

        public Planner(List<Subject> subjects, List<User> users)
        {
            Subjects = subjects;
            Users = users;
        }

        public void AddSubject(Subject subject)
        {
            Subjects.Add(subject);
        }

        public void AddUser(User user)
        {
            Users.Add(user);
        }
    }
}