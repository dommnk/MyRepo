using System;

namespace WorkflowEngine
{
    public class UploadVideo : ITask
    {
        public void Execute(Video video)
        {
            Console.WriteLine("\nUploading a video titled: {0}", video.title);
        }
    }
}
