using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace SortAndSearch
{
    public static class Performance
    {

        // Uses a Sort Function and A List as Input. Returns sorted List and returns time elapsed on function
        public static List<int> ElapsedTimeSorting(Func<List<int>,List<int>> mySortFunction, List<int> x)
        {
            
            var sw = new Stopwatch();
            sw.Start();
            List<int> sortedList = mySortFunction(x);
            sw.Stop();
            Console.WriteLine($"Time elapsed: {sw.Elapsed}");
            return sortedList;
        }

        public static string ElapsedTimeSearching(Func<List<int>, int, string> mySearchFunction, List<int> sortedList, int searchingFor)
        {
            var sw = new Stopwatch();
            sw.Start();
            string result = mySearchFunction(sortedList,searchingFor);
            sw.Stop();
            Console.WriteLine($"Time elapsed: {sw.Elapsed}");
            return result;
        }
        
        
        
    }
}