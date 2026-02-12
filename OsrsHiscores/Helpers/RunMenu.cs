using System;
using System.IO;

namespace OsrsHiscores.Helpers
{
    class InitializeMenu
    {
        public static void PrintMenu()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("[1] Update player data");
            Console.WriteLine("[2] Fetch HighScores");
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
                    Console.WriteLine(userName);
                    ContinueMenu();
                }else if (input == "q")
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
