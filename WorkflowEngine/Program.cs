using System;

namespace WorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var myWorkflow = new Workflow();
            var myWorkflowEngine = new WorkflowEngine();

            myWorkflow.Info();
            myWorkflow.AddActivity(new UploadVideo());
            myWorkflow.AddActivity(new CallEncoder());
            myWorkflow.AddActivity(new Notify());

            Console.ForegroundColor = ConsoleColor.Cyan;
            myWorkflowEngine.Run(myWorkflow);
        }
    }
}
