using System;
using System.Collections.Generic;

namespace ConsoleStudious
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = Welcome();
            var topics = Survey(user);
            
            ShutDown();
        }

        private static void ShutDown()
        {
            Console.WriteLine("~~~      END OF STUDIOUS     ~~~");
            Console.ReadKey();
        }

        public static string PromptForString(string question)
        {
            Console.WriteLine(question);
            Console.WriteLine("(press enter to continue...)");
            string response;
            do
            {
                response = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(response))
                {
                    Console.WriteLine("Response cannot be blank.");
                }
            } while (string.IsNullOrWhiteSpace(response));
            
            return response;
        }

        public static int PromptForInt(string question)
        {
            int i;
            string response;

            Console.WriteLine(question);
            Console.WriteLine("(press enter to continue...)");

            do
            {
                response = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(response))
                {
                    Console.WriteLine("Response cannot be blank.");
                }

                if (!Int32.TryParse(response, out i))
                {
                    i = -1;
                    Console.WriteLine("Response must be a whole number.");
                }
            } while (string.IsNullOrWhiteSpace(response) 
                    || i < 0);
            
            return i;
        }

        public static User Welcome()
        {
            Console.WriteLine("Hello World, I am Studious for C# Console!");

            User user = new User();

            user.Name = PromptForString("What is your name?");
            Console.WriteLine($"Hello {user.Name}!");

            PromptForString("Are you ready to begin?");

            user.Minutes = PromptForInt("How much time (in minutes) do you have to study right now?");
            Console.WriteLine($"You say you only have {user.Minutes}, but I will expect you to study for {user.Expectations}.");

            Console.WriteLine($"You must work hard, {user.Name}!");
            Console.WriteLine($"Your study session begins now.");
            user.StartTime = DateTime.Now;

            return user;
        }

        public static List<string> Survey(User user)
        {
            List<string> topics = new List<string>();
            return topics;
        }
    }
}
