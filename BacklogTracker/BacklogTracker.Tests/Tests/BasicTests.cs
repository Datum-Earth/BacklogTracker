using BacklogTracker.Dependencies.HLTB.POCO;
using BacklogTracker.Dependencies.HLTB.Worker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BacklogTracker.Tests.Tests
{
    internal class BasicTests
    {
        public void GetRecord(string path, bool fromFile)
        {
            var filePath = @"C:\Users\ryane\Documents\Research\witcher3test.html";

            var worker = new HLTBWorker();

            if (fromFile == true)
            {
                worker = new HLTBWorker() { IsDebug = true };
            } 

            var gameData = worker.GetGameData(path);

            Console.WriteLine($"Name: {gameData.Name}\n");

            foreach (var category in gameData.Categories)
            {
                Console.WriteLine($"Category Name: {category.Name}\n\tHeaders: {String.Join("\n\t\t", category.Headers)}");

                foreach (var subCategory in category.SubCategories)
                {
                    Console.WriteLine($"\tSubCategory Name: {subCategory.Name}\n\t\tValues: {String.Join("\n\t\t\t", subCategory.Values)}");
                }
            }

            Console.ReadLine();
        }
    }
}
