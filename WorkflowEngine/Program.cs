using System;

namespace WorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var myWorkflow = new Workflow();
            var myWorkflowEngine = new WorkflowEngine();
            var myNotification = new Notify();

            myWorkflow.Info();
            myWorkflow.AddActivity(new UploadVideo());
            myWorkflow.AddActivity(new CallEncoder());
            myWorkflow.AddActivity(myNotification);
            myWorkflow.RemoveActivity(myNotification);

            Console.ForegroundColor = ConsoleColor.Cyan;
            myWorkflowEngine.Run(myWorkflow);
        }
    }
}
