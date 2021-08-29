using System;

namespace WorkflowEngine
{
    public class Video
    {
        public string title;
        public string directorName;
        public DateTime dateOfProduction;
        public string status;

        public Video(string title, string directorName, DateTime dateOfProduction)
        {
            this.title = title;
            this.directorName = directorName;
            this.dateOfProduction = dateOfProduction;
            status = "";
        }
    }
}
