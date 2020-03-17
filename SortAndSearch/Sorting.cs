using System;
using System.Collections.Generic;

namespace SortAndSearch
{
    public static class Sorting
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
        public static List<int> BubbleSort(List<int> unsortedList)
        {
            var listCopy = new List<int>(unsortedList);
            var x = listCopy.Count;
            for (var i = 0; i < x - 1; i++)
            for (var j = 0; j < x - i - 1; j++)
                if (listCopy[j] > listCopy[j + 1])
                {
                    var temp = listCopy[j];
                    listCopy[j] = listCopy[j + 1];
                    listCopy[j + 1] = temp;
                }

            return listCopy;
        }
        
        // Optimized Bubble Sort to sort a list
        public static List<int> BubbleSortOptimized(List<int> unsortedList)
        {
            var listCopy = new List<int>(unsortedList);
            var x = listCopy.Count;
            bool swap;
            for (var i = 0; i < x - 1; i++)
            {
                swap = false;
                for (var j = 0; j < x - i - 1; j++)
                    if (listCopy[j] > listCopy[j + 1])
                    {
                        var temp = listCopy[j];
                        listCopy[j] = listCopy[j + 1];
                        listCopy[j + 1] = temp;
                        swap = true;
                    }

                if (swap == false) break;
            }

            return listCopy;
        }
        
        public static List<int> BogoSort(List<int> unsortedList)
        {
            var listCopy = new List<int>(unsortedList);
            var rand = new Random();
            var n = listCopy.Count;
            
            while (!IsSorted(listCopy))
            {
                for (var i = listCopy.Count - 1; i > 1; i--)
                {
                    var random = rand.Next(i + 1);
                    var value = listCopy[random];
                    listCopy[random] = listCopy[i];
                    listCopy[i] = value;
                }
                
            }
            
            return listCopy;
        }
        
        

        public static List<int> BogoSortWithLog(List<int> unsortedList)
        {
            var listCopy = new List<int>(unsortedList);
            var rand = new Random();
            var n = listCopy.Count;

            var shuffled = 0;

            while (!IsSorted(listCopy))
            {
                for (var i = listCopy.Count - 1; i > 1; i--)
                {
                    var random = rand.Next(i + 1);
                    var value = listCopy[random];
                    listCopy[random] = listCopy[i];
                    listCopy[i] = value;
                }

                ++shuffled;
                if (shuffled % 1000 == 0)
                {
                    Console.WriteLine($"Shuffled {shuffled} times.");
                }
                
            }
            
            Console.WriteLine($"Shuffled {shuffled} times.");
            return listCopy;
        }
        
        
        
        
        
        
        
    }
}