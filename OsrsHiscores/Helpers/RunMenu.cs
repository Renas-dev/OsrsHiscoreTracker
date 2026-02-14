using System;
using System.IO;

namespace OsrsHiscores.Helpers
{
    class InitializeMenu
    {
        public static void PrintMenu()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("[1] To print the api URL");
            Console.WriteLine("[Q] To exit the app");
            Console.WriteLine();
        }

        public static void ContinueMenu()
        {
            Console.WriteLine("Press Enter to continue....");
            Console.ReadLine();
        }

        public static void StartMenu()
        {
            string userName = GrabUsername.GetUsername();

            while (true)
            {
                Console.WriteLine();
                PrintMenu();
                string? input = Console.ReadLine();
                input = input?.Trim().ToLower();
                if (input == "1")
                {
                    string url = HiscoreUrlBuilder.BuildIronmanUrl(userName);
                    Console.WriteLine(url);
                    ContinueMenu();
                }
                else if (input == "q")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option. Please enter 1, or Q");
                }
            }
        }
    }
}
