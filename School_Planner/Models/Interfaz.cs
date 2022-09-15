﻿using School_Planner.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Planner.Models
{
    public class Interfaz
    {
        private const int OPTION_SEE_SUBJECT = 1;
        private const int OPTION_ADD_SUBJECT = 2;
        private const int OPTION_SEE_TASK = 3;
        private const int OPTION_ADD_TASK = 4;
        private const int OPTION_COMPLETE_TASK = 5;
        private const int OPTION_CANCELE_TASK = 6;
        public const int OPTION_EXIT = 7;

        private const string TITLE = "School Planner";
        private const string SEE_SUBJECT = "See subject details";
        private const string ADD_SUBJECT = "Add a new subject to your planner";
        private const string SEE_TASK = "See task Details";
        private const string ADD_TASK = "Add a new task in this subject";
        private const string COMPLETED_TASK = "Change the status of this task to completed";
        private const string CANCELED_TASK = "Change the status of this task to canceled";

        private readonly Planner _planner;
        private readonly Subject _subject;
        private readonly Tasky _task;
        private readonly Subject _subjects;

        public Interfaz()
        {
            List<Subject> initialSubjects = new List<Subject>();
            _planner = new Planner(initialSubjects);
            List<Tasky> initialTasks = new List<Tasky>();
            _subject = new Subject("Subject title", "Classroom name", "professor name", initialTasks);
            _task = new Tasky();
        }

        public int ShowPlanner()
        {
            Console.WriteLine($"=== Main Page of {TITLE} ===");
            Console.WriteLine("\nYour Planner");
            Console.WriteLine(_planner.Subjects);
            Console.WriteLine($"{OPTION_SEE_SUBJECT}. {SEE_SUBJECT}");
            Console.WriteLine($"{OPTION_ADD_SUBJECT}. {ADD_SUBJECT}");
            Console.WriteLine($"{OPTION_EXIT}. EXIT PLANNER");
            int option = Console.Read();
            return option;
        }
        public void ShowSubject(Subject subject)
        {
            Console.WriteLine(subject.Tasks);
            
            Console.WriteLine($"{OPTION_SEE_TASK}. {SEE_TASK}");
            Console.WriteLine($"{OPTION_ADD_TASK}. {ADD_TASK}");
        }
        public void ShowTask(Tasky task)
        {
            Console.WriteLine(task.Type);
            Console.WriteLine(task.Priority);
            Console.WriteLine(task.Title);
            Console.WriteLine(task.DueDateTime);
            Console.WriteLine(task.Description);
            Console.WriteLine(task.PercentageWorth);
            Console.WriteLine(task.Status);

            Console.WriteLine($"{OPTION_COMPLETE_TASK} . {COMPLETED_TASK}");
            Console.WriteLine($"{OPTION_CANCELE_TASK} . {COMPLETED_TASK}");
        }

        

        public void ProcesarOpcion(int opcion)
        {
            Console.WriteLine();
            switch (opcion)
            {
                case OPTION_SEE_SUBJECT:
                    ShowSubject(_subject);
                    break;
                case OPTION_ADD_TASK:
                    Console.WriteLine($"== {ADD_TASK} ==");
                    AddTask(_subject);
                    break;
                case OPTION_SEE_TASK:
                    Console.WriteLine($"== {SEE_TASK} ==");
                    Console.WriteLine(_planner);
                    ShowTasks(_subject);
                    break;
                case OPTION_COMPLETE_TASK:
                    Console.WriteLine($"== {COMPLETED_TASK} ==");
                    _task.CompleteTask();
                    break;
                case OPTION_CANCELE_TASK:
                    Console.WriteLine($"== {CANCELED_TASK} ==");
                    _task.CancelTask();
                    break;
                case OPTION_EXIT:
                    ProcessExit();
                    break;
            }
            Console.WriteLine();
        }
        public void ShowSubjects(List<Subject> subjects)
        {
            Console.WriteLine($"Your Subjects");
            Console.WriteLine($"______________________________");
            foreach (Subject subject in subjects)
            {
                Console.WriteLine(subject);
            }
        }

        public void AddTask(Subject subject)
        {
            Tasky task = new Tasky();
            Console.Write("Insert the info about the new task :\n\n");
            Console.WriteLine("Insert Title : ");
            task.Title = Console.ReadLine();

            Console.WriteLine("\n\nSelect Type of task : \n\n");
            task.ShowAllTaskTypes();
            Console.WriteLine("\n\nType : ");
            task.Type = (TypeOfTask) Enum.ToObject(typeof(TypeOfTask), Console.Read());

            Console.WriteLine("How much percentage does this new task represent? (0 - 100) : ");
            task.PercentageWorth = Console.Read();

            Console.WriteLine("Insert a description for your task : ");
            task.Description = Console.ReadLine();

            Console.WriteLine("\n\nInsert the level of priority : \n\n");
            task.ShowAllPriorities();
            Console.WriteLine("\n\nPriority : ");
            task.Priority = (Priority) Enum.ToObject(typeof(Priority), Console.Read());

            Console.WriteLine("what day should you deliver this? (mm/dd/yyyy) : ");
            task.DueDateTime = (DateTime)Convert.ToDateTime(Console.ReadLine());
            task.Status = Status.NotStarted;
            
            try
            {
                _subject.AddTask(task);
                Console.WriteLine(">> INFO: The new task was created succesfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($">> ERROR: {ex.Message}");
            }
        }

        

        public void ProcessExit()
        {
            Console.WriteLine(">> INFO: Fin del programa.");
        }

        
        public void ShowTasks(Subject subject)
        {
            Console.WriteLine($"{subject.Title}");
            Console.WriteLine($"______________________________");
            foreach (Tasky task in subject.Tasks)
            {
                Console.WriteLine(task.Title);
            }
        }
    }
}

