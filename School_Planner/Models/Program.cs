using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School_Planner.Models;
using School_Planner.NewFolder;

internal class Program
{
    private static void Main(string[] args)
    {
        Interfaz mainInterface = new Interfaz();

        int optionSelected = mainInterface.ShowPlanner();

        mainInterface.ProcesarOpcion(optionSelected);
    }
}