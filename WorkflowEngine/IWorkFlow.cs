using System.Collections.Generic;

namespace WorkflowEngine
{
    public interface IWorkFlow
    {
        IList<ITask> workflowActivities { get; set; }
        void AddActivity(ITask task);
        void RemoveActivity(ITask task);
    }
}