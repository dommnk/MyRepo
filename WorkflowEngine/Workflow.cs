using System.Collections.Generic;
using System;

namespace WorkflowEngine
{
    public class Workflow : IWorkFlow
    {
        public IList<ITask> workflowActivities { get; set; }

        public Workflow()
        {
            workflowActivities = new List<ITask>();
        }

        public void Info()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"This program Simulates workflow engine.
The purpose of this program is to show practical usage of interfaces." + "\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void AddActivity(ITask activity)
        {
            workflowActivities.Add(activity);
            Console.WriteLine("Added {0} to the list of activities.", activity.GetType());
        }

        public void RemoveActivity(ITask activity)
        {
            workflowActivities.Remove(activity);
            Console.WriteLine("Removed {0} from the list of activities.", activity.GetType());
        }
    }
}
