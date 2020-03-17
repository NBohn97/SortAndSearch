using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace SortAndSearch
{
    public static class Performance
    {

        // Uses a Sort Function and A List as Input. Returns sorted List and returns time elapsed on function
        public static List<long> ElapsedTimeSorting(Func<List<long>,List<long>> mySortFunction, List<long> x)
        {
            
            var sw = new Stopwatch();
            sw.Start();
            List<long> sortedList = mySortFunction(x);
            sw.Stop();
            Console.WriteLine($"Time elapsed: {sw.Elapsed}");
            return sortedList;
        }

        public static string ElapsedTimeSearching(Func<List<long>, long, string> mySearchFunction, List<long> sortedList, long searchingFor)
        {
            var sw = new Stopwatch();
            sw.Start();
            string result = mySearchFunction(sortedList,searchingFor);
            sw.Stop();
            Console.WriteLine($"Time elapsed: {sw.Elapsed}");
            return result;
        }
        
        public static string ElapsedTimeSearchingString(Func<List<string>, string, string> mySearchFunction, List<string> sortedList, string searchingFor)
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