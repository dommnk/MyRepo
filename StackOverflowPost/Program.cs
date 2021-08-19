using System;

namespace StackOverflowPost
{
    class Program
    {
        static void Main(string[] args)
        {
            string signInput;
            string titleInput;
            string descriptionInput;

            Console.WriteLine("Enter title:");
            titleInput = Console.ReadLine();
            Console.WriteLine("Enter description:");
            descriptionInput = Console.ReadLine();

            var post= new Post(titleInput, descriptionInput);
            // var post = new Post("I am new to programming", "Please help me");
            
            post.Display();

            Console.WriteLine("Type(+/-) to upvote or downvote post. Q to quit.");

            while(true)
            {
                signInput = Console.ReadLine();

                if (signInput != "Q" && signInput != "q")
                    post.Vote(signInput);
                else
                    break;
            }
            
            post.Display();
        }
    }
}
