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
            string topic;

            Console.WriteLine("You are now in Survey mode.");
            if (PromptForTrue("Would you like to learn about SQ3R?"))
            {
                Console.WriteLine("~~~~ CONTENT NOT FOUND ~~~~");
            }
            Console.WriteLine("You can either type in a topic to study, or type in the word 'Studious' to end the study session");
            do
            {
                Console.WriteLine("New Topic:");
                topic = PromptForString("(type 'Studious' to end Survey mode)");
                topics.Add(topic);
            } while (!topic.Equals("Studious"));
            
            return topics;
        }

        private static bool PromptForTrue(string question)
        {
            bool truthy;
            string response;

            Console.WriteLine(question);
            do
            {
                response = PromptForString("(Y/N)");
            } while (!(response.Equals("Y") || response.Equals("N")));
            switch (response)
            {
                case "Y":
                    truthy = true;
                    break;
                case "N":
                    truthy = false;
                    break;
                default:
                    truthy = false;
                    break;
            }
            return truthy;
        }
    }
}
