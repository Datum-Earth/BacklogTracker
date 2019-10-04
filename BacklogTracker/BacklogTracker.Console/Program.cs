using ASUSGamesDB;
using Microsoft.Extensions.Logging;
using System;

namespace BacklogTracker.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
            System.Console.ReadLine();
        }

        static async void Run()
        {
            var logFactory = new LoggerFactory();
            var logger = logFactory.CreateLogger("console");

            var client = new GamesDbClient(logger);
            var results = await client.FindGame("1");

            foreach (var result in results)
            {
            }
        }
    }
}
