using System;

namespace StackOverflowPost
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PostDate { get; private set; }
        private int _score;

        public Post(string title)
        {
            this.Title = title;
            _score = 0;
            PostDate = DateTime.Now;
        }

        public Post(string title, string description)
            :this(title)
        {
            this.Description = description;
        }

        public void Vote(string sign)
        {
            if (sign == "+")
                _score += 1;
            else if (sign == "-")
                _score -= 1;

        }

        public void Display()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Description: " + Description);
            Console.WriteLine("Publication Date: " + PostDate);
            Console.WriteLine("Post score is now: " + _score);
        }
    }
}
