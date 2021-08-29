using System;

namespace WorkflowEngine
{
        public class CallEncoder : IWorkflow
        {
            public void Execute(Video video)
            {
                Console.WriteLine("Encode video titled: {0}", video.title);
            }
        }
}
