using System;

namespace WorkflowEngine
{
        public class Notify : ITask
        {
            public void Execute(Video video)
            {
                video.status = "Processing";
                Console.WriteLine("Status of your record: {0}", video.status);
            }
        }
}