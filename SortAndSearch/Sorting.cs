using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using static SortAndSearch.ListGen;


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

            //Console.WriteLine(IsSorted(listCopy));
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

            //Console.WriteLine(IsSorted(listCopy));
            return listCopy;
        }


        // uses SelectionSort to sort List of integers
        public static List<int> SelectionSort(List<int> unsortedList)
        {
            var listCopy = new List<int>(unsortedList);
            var n = listCopy.Count;

            for (var j = n - 1; j > 0; j--)
            {
                var pos = 0;

                for (var i = 0; i <= j; i++)
                    if (listCopy[i] > listCopy[pos])
                        pos = i;
                var temp = listCopy[pos];
                listCopy[pos] = listCopy[j];
                listCopy[j] = temp;
            }

            //Console.WriteLine(IsSorted(listCopy));
            return listCopy;
        }

        // unfinished RadixSort
        public static List<int> RadixSort(List<int> unsortedList)
        {
            var i = 0;
            var RadixList = new List<string>();
            foreach (var num in unsortedList) RadixList[i] = num.ToString();
            // TBC
            return unsortedList;
        }

        // uses InsertionSort to sort list of integers
        public static List<int> InsertionSort(List<int> unsortedList)
        {
            var listCopy = new List<int>(unsortedList);

            for (var i = 0; i < listCopy.Count; i++)
            {
                var temp = listCopy[i];
                var j = i;

                while (j > 0 && temp < listCopy[j - 1])
                {
                    listCopy[j] = listCopy[j - 1];
                    j = j - 1;
                }

                listCopy[j] = temp;
            }

            //Console.WriteLine(IsSorted(listCopy));
            return listCopy;
        }
        
        public static List<T> Quicksort<T>(List<T> unsortedList,Random rand) where T: IComparable {
            if (unsortedList.Count() < 2) 
                return unsortedList;
            
            var pivot = rand.Next(unsortedList.Count());
            var val = unsortedList[pivot];
            var smaller = new List<T>();
            var bigger = new List<T>();
            
            for (int i = 0; i < unsortedList.Count(); i++) {
                if (i != pivot) {
                    if (unsortedList[i].CompareTo(val) < 0) {
                        smaller.Add(unsortedList[i]);
                    }
                    else {
                        bigger.Add(unsortedList[i]);
                    }
                }
            }

            var sorted = Quicksort(smaller,rand);
            sorted.Add(val);
            sorted.AddRange(Quicksort(bigger,rand));
            return sorted;
        }
        
        public static List<int> MergeSort(List<int> unsortedList)
        {
            return unsortedList;
        }

        public static List<int> HeapSort(List<int> unsortedList)
        {
            return unsortedList;
        }


        public static List<int> BogoSort(List<int> unsortedList)
        {
            var listCopy = new List<int>(unsortedList);
            var rand = new Random();

            while (!IsSorted(listCopy))
                for (var i = listCopy.Count - 1; i > 1; i--)
                {
                    var random = rand.Next(i + 1);
                    var value = listCopy[random];
                    listCopy[random] = listCopy[i];
                    listCopy[i] = value;
                }

            //Console.WriteLine(IsSorted(listCopy));
            return listCopy;
        }


        public static List<int> BogoSortWithLog(List<int> unsortedList)
        {
            var listCopy = new List<int>(unsortedList);
            var rand = new Random();
            var n = listCopy.Count;

            BigInteger shuffled = 0;

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
                if (shuffled % 100000 == 0) Console.WriteLine($"Shuffled {shuffled} times.");
            }

            Console.WriteLine($"Shuffled {shuffled} times.");
            //Console.WriteLine(IsSorted(listCopy));
            return listCopy;
        }

        public static List<int> BogoSortWithLogLight(List<int> unsortedList)
        {
            var listCopy = new List<int>(unsortedList);
            var rand = new Random();
            var n = listCopy.Count;

            BigInteger shuffled = 0;

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
            }

            Console.WriteLine($"Shuffled {shuffled} times.");
            //Console.WriteLine(IsSorted(listCopy));
            return listCopy;
        }


        /* NOT WORKING
        public static List<string> BubbleSortOptimizedString(List<string> unsortedList)
        {
            var listCopy = new List<string>(unsortedList);
            var x = listCopy.Count;
            bool swap;
            for (var i = 0; i < x - 1; i++)
            {
                swap = false;
                for (var j = 0; j < x - i - 1; j++)
                    if (listCopy[j][0] > listCopy[j + 1][0])
                    {
                        var temp = listCopy[j];
                        listCopy[j] = listCopy[j + 1];
                        listCopy[j + 1] = temp;
                        swap = true;
                    }
                    else if (listCopy[j][0] == listCopy[j + 1][0])
                    {
                        if (listCopy[j][1] > listCopy[j + 1][1]) ;
                        var temp = listCopy[j];
                        listCopy[j] = listCopy[j + 1];
                        listCopy[j + 1] = temp;
                        swap = true;
                    }
                

                if (swap == false) break;
            }

            return listCopy;
        }
        */
    }
}