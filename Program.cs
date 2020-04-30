using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace PostVoteInConsoleApp
{
    partial class Program
    {





        static void Main(string[] args)
        {
            var post = new Post();

            Console.WriteLine("Enter Post Title:");
            var postTitle = Console.ReadLine();

            if (!string.IsNullOrEmpty(postTitle))
                post.Title = postTitle;

            Console.WriteLine("Enter Post Description:");
            var postDescription = Console.ReadLine();

            if (!string.IsNullOrEmpty(postDescription))
                post.Description = postDescription;

            post.CreationTime = DateTime.Now;



            Console.WriteLine("Please cast your vote about this post:\n" +
                "1: Upvote\n" +
                "2: Downvote\n" +
                "3: Exit");
            
            var command = Console.ReadLine();

            while (!string.IsNullOrEmpty(command) && (command.ToLower() != "3"))

                switch(command.ToLower())
                {
                    case "1":
                        post.UpVoteMethod();
                        Console.WriteLine("Cast your vote vote option again or press 3 to exit");
                        command = Console.ReadLine();
                        break;

                    case "2":
                        post.DownVoteMethod();
                        Console.WriteLine("Cast your vote vote option again or press 3 to exit");
                        command = Console.ReadLine();
                        
                        break;

                    case "3":
                        break;

                    default:
                        Console.WriteLine("Please write a valid command: Upvote | Downvote | Exit");
                        command = Console.ReadLine();
                        break;

                }

            Console.WriteLine("Post title:    {0} \n" +
                              "Description:   {1} \n" +
                              "It has {2} likes \n" +
                              "It has {3} dislikes \n" +
                              " and was created at {4}", 
                                post.Title, post.Description, post.UpVote, post.DownVote, post.CreationTime); ;


        }
    }
}
