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
                if (num == intSearchedFor) return $"Integer {intSearchedFor} first found at index {index}";
                ++index;
            }

            return $"Integer {intSearchedFor} not found in List.";
        }

        // SequentialSearch With Strings
        public static string SequentialSearch(List<string> sortedList, string stringSearchedFor)
        {
            long index = 0;

            foreach (var word in sortedList)
            {
                if (word == stringSearchedFor) return $"{stringSearchedFor.ToUpper()} first found at index {index}";
                ++index;
            }

            return $"Integer {stringSearchedFor} not found in List.";
        }


        // BinarySearch with Integers
        public static string BinarySearch(List<long> sortedList, long intSearchedFor)
        {
            var upperBound = sortedList.Count - 1;
            var lowerBound = 0;
            int location;

            while (upperBound >= lowerBound)
            {
                location = (lowerBound + upperBound) / 2;

                if (sortedList[location] == intSearchedFor)
                    return $"{intSearchedFor} first found at index {location}";

                if (intSearchedFor > sortedList[location])
                    lowerBound = location + 1;
                else
                    upperBound = location - 1;
            }

            return $"Integer {intSearchedFor} not found in List";
        }


        // BinarySearch with Strings
        public static string BinarySearch(List<string> sortedList, string stringSearchedFor)
        {
            var upperBound = sortedList.Count - 1;
            var lowerBound = 0;
            int location;

            while (upperBound >= lowerBound)
            {
                location = (lowerBound + upperBound) / 2;

                if (sortedList[location].Equals(stringSearchedFor))
                    return $"{stringSearchedFor.ToUpper()} first found at index {location}";

                if (string.Compare(stringSearchedFor, sortedList[location], StringComparison.Ordinal) > 0)
                    lowerBound = location + 1;
                else if (string.Compare(stringSearchedFor, sortedList[location], StringComparison.Ordinal) < 0)
                    upperBound = location - 1;
            }

            return $"{stringSearchedFor} not found in List";
        }
    }
}