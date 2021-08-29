namespace WorkflowEngine
{
    public class WorkflowEngine
    {
        public void Run(Workflow workflow)
        {
            var video = new Video("Shrek 2", "Andrew Adamson", new System.DateTime(2004, 05, 08));
            
            foreach (var activity in workflow.workflowActivities)
                activity.Execute(video);
        }
    }
}
