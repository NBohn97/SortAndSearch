using System;
using System.Collections.Generic;

namespace SortAndSearch
{
    public static class Searching
    {

        // SequentialSearch With Integers
        public static string SequentialSearch(List<int> sortedList, int x)
        {


            int searchInt = x;

            for (int i = 0; i < sortedList.Count; i++)
            {
                if (sortedList[i] == searchInt)
                {
                    return $"Integer {searchInt} found at index {i}";
                }
            }
            return $"Integer {searchInt} not found in List.";

        }
        
        // SequentialSearch With Strings
        public static string SequentialSearch(List<string> sortedList, string x)
        {
            
            string searchString = x;

            for (int i = 0; i < sortedList.Count; i++)
            {
                if (sortedList[i] == searchString)
                {
                    return $"String {searchString} found at index {i}";
                }
            }
            return $"String {searchString} not found in List.";

        }
        
        
        
        public static int BinarySearch(List<int> sortedList)
        {
            int x = 0;


            return x;
            
        }
        
    }
}