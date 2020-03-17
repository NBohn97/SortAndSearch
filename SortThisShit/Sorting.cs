using System.Collections.Generic;

namespace SortThisShit
{
    public class Sorting
    {
        
        // Takes List and checks if sorted
        public static bool IsSorted(List<int> randList)
        {
            for (var i = 0; i < randList.Count - 1; i++)
                if (randList[i] >= randList[i + 1])
                    return false;

            return true;
        }
        
        // Uses Bubble Sort to sort a List
        public List<int> BubbleSort(List<int> unsortedList)
        {
            var x = unsortedList.Count;
            for (var i = 0; i < x - 1; i++)
            for (var j = 0; j < x - i - 1; j++)
                if (unsortedList[j] > unsortedList[j + 1])
                {
                    var temp = unsortedList[j];
                    unsortedList[j] = unsortedList[j + 1];
                    unsortedList[j + 1] = temp;
                }

            return unsortedList;
        }
        
        // Optimized Bubble Sort to sort a list
        public List<int> BubbleSortOptimized(List<int> unsortedList)
        {
            var x = unsortedList.Count;
            bool swap;
            for (var i = 0; i < x - 1; i++)
            {
                swap = false;
                for (var j = 0; j < x - i - 1; j++)
                    if (unsortedList[j] > unsortedList[j + 1])
                    {
                        var temp = unsortedList[j];
                        unsortedList[j] = unsortedList[j + 1];
                        unsortedList[j + 1] = temp;
                        swap = true;
                    }

                if (swap == false) break;
            }

            return unsortedList;
        }
        
        
        
        
        
        
        
        
        
    }
}