using System;

namespace ConsoleStudious
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var name = Prompt("What is your name?");

            Console.WriteLine($"Hello {name}!");

            Console.ReadKey();
        }
        public static string Prompt(string question)
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
    }
}
