using System;

namespace Post
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = PostCreator();

            Console.WriteLine("Here is your first post.");

            PostDisplay(post);
            
            var input = Console.ReadLine();

            while (input.ToLower() != "quit")
            {
                switch (input.ToLower())
                {
                    case "up":
                        post.UpVote();
                        break;
                    case "down":
                        post.DownVote();
                        break;
                    default:
                        Console.WriteLine("Invalid Input please try again...");
                        break;
                }
                Console.Clear();

                PostDisplay(post);
                
                input = Console.ReadLine();
            }
        }

        public static Post PostCreator()
        {
            Console.WriteLine("Please create a post.");

            Console.Write("Title: ");
            var title = Console.ReadLine();
            Console.Write("Description: ");
            var description = Console.ReadLine();

            return new Post(title, description);
        }

        public static void PostDisplay(Post post)
        {
            Console.WriteLine(post.ReadPost());
            Console.Write("\nType \"Up\" to up vote, \"Down\" to down vote, or \"Quit\" to leave: ");
        }
    }
}
