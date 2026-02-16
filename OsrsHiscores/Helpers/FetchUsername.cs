using System;
using System.IO;

namespace OsrsHiscores.Helpers
{
    class GrabUsername
    {
        public static string GetUsername()
        {
            while (true)
            {
                Console.WriteLine("Hello, please provide the username of the player:");
                string? userName = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(userName))
                {
                    Console.WriteLine("Invalid input, Please enter an Username");
                    continue;
                }
                if (!string.IsNullOrWhiteSpace(userName))
                {
                    Console.WriteLine($"Thank you for providing your username: {userName}");
                    return userName;
                }
            }
        }
    }
}
