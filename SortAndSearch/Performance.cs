using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace SortAndSearch
{
    public static class Performance
    {
        // Uses a Sort Function and A List as Input. Returns sorted List and returns time elapsed on function
        public static void ElapsedTimeSorting(Func<List<int>, List<int>> mySortFunction, List<int> x)
        {
            var sw = new Stopwatch();
            sw.Start();
            mySortFunction(x);
            sw.Stop();

            if (sw.Elapsed.TotalMilliseconds <= 30000)
                Console.WriteLine($"Time elapsed: {sw.Elapsed.TotalMilliseconds} ms");
            else if (sw.Elapsed.TotalMilliseconds > 30000 && sw.Elapsed.TotalMilliseconds < 180000)
                Console.WriteLine($"Time elapsed: {Math.Round(sw.Elapsed.TotalSeconds, 2)} s");
            else if (sw.Elapsed.TotalMilliseconds > 180000 && sw.Elapsed.TotalMilliseconds < 1.08e+7)
                Console.WriteLine($"Time elapsed: {Math.Round(sw.Elapsed.TotalMinutes, 2)} m");
            else if (sw.Elapsed.TotalMilliseconds > 1.08e+7)
                Console.WriteLine($"Time elapsed: {Math.Round(sw.Elapsed.TotalHours, 2)} h");

            
        }

        public static string ElapsedTimeSearching(Func<List<int>, int, string> mySearchFunction,
            List<int> sortedList, int searchingFor)
        {
            var sw = new Stopwatch();
            sw.Start();
            var result = mySearchFunction(sortedList, searchingFor);
            sw.Stop();
            Console.WriteLine($"Time elapsed: {sw.Elapsed.TotalMilliseconds} ms");
            return result;
        }

        public static string ElapsedTimeSearching(Func<List<string>, string, string> mySearchFunction,
            List<string> sortedList, string searchingFor)
        {
            var sw = new Stopwatch();
            sw.Start();
            var result = mySearchFunction(sortedList, searchingFor);
            sw.Stop();
            Console.WriteLine($"Time elapsed: {sw.Elapsed.TotalMilliseconds} ms");
            return result;
        }
    }
}