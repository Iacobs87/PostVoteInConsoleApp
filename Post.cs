using System;

namespace PostVoteInConsoleApp
{
    partial class Program
    {
        public class Post
        {
            public string Title { get; set; }
            public string Description { get; set; }
            public DateTime CreationTime { get; set; }

            public int UpVote { get; private set; }

            public int DownVote { get; private set; }


            public void UpVoteMethod()
            {
                UpVote++;
            }
            
            public void DownVoteMethod()
            {
                DownVote++;
            }



        }
    }
}
