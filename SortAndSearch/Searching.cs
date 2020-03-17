using System;
using System.Collections.Generic;

namespace SortAndSearch
{
    public static class Searching
    {

        // SequentialSearch With Integers
        public static string SequentialSearch(List<long> sortedList, long intSearchedFor)
        {
            
            long index = 0;
            
            foreach (var num in sortedList)
            {
                if (num == intSearchedFor)
                {
                    return $"Integer {intSearchedFor} found at index {index}";
                }
                ++index;
            }
            return $"Integer {intSearchedFor} not found in List.";
            
            
        }
        
        // SequentialSearch With Strings
        public static string SequentialSearchString(List<string> sortedList, string stringSearchedFor)
        {

            long index = 0;
            
            foreach (var word in sortedList)
            {
                if (word == stringSearchedFor)
                {
                    return $"Integer {stringSearchedFor} found at index {index}";
                }
                ++index;
            }
            return $"Integer {stringSearchedFor} not found in List.";
        }
        
        
        
        public static long BinarySearch(List<long> sortedList)
        {
            long x = 0;


            return x;
            
        }
        
    }
}