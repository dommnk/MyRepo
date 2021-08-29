using System.Collections.Generic;
using System;

namespace WorkflowEngine
{
    public class Workflow
    {
        public IList<IWorkflow> workflowActivities;

        public Workflow()
        {
            workflowActivities = new List<IWorkflow>();
        }

        public void Info()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"This program Simulates workflow engine.
The purpose of this program is to show practical usage of interfaces." + "\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void AddActivity(IWorkflow activity)
        {
            workflowActivities.Add(activity);
            Console.WriteLine("Added {0} to the list of activities.", activity.GetType());
        }

    }
}
