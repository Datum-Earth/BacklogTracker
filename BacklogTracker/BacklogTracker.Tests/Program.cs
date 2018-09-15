using BacklogTracker.Tests.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BacklogTracker.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            var basicTests = new BasicTests();
            var filePath = @"C:\Users\ryane\Documents\Research\witcher3test.html";
            var uri = @"https://howlongtobeat.com/game.php?id=1957";

            basicTests.GetRecord(uri, false);
        }
    }
}
