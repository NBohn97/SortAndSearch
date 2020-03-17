using System;
using System.Collections.Generic;
using System.Numerics;

namespace SortAndSearch
{
    public static class Sorting
    {
        // Takes List and checks if sorted
        public static bool IsSorted(List<long> randList)
        {
            for (var i = 0; i < randList.Count - 1; i++)
                if (randList[i] >= randList[i + 1])
                    return false;

            return true;
        }

        // Uses Bubble Sort to sort a List
        public static List<long> BubbleSort(List<long> unsortedList)
        {
            var listCopy = new List<long>(unsortedList);
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
        public static List<long> BubbleSortOptimized(List<long> unsortedList)
        {
            var listCopy = new List<long>(unsortedList);
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
        public static List<long> SelectionSort(List<long> unsortedList)
        {
            var listCopy = new List<long>(unsortedList);
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
        public static List<long> RadixSort(List<long> unsortedList)
        {
            var i = 0;
            var RadixList = new List<string>();
            foreach (var num in unsortedList) RadixList[i] = num.ToString();
            // TBC
            return unsortedList;
        }

        // uses InsertionSort to sort list of integers
        public static List<long> InsertionSort(List<long> unsortedList)
        {
            var listCopy = new List<long>(unsortedList);

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


        public static List<long> QuickSort(List<long> unsortedList)
        {
            return unsortedList;
        }

        public static List<long> MergeSort(List<long> unsortedList)
        {
            return unsortedList;
        }

        public static List<long> HeapSort(List<long> unsortedList)
        {
            return unsortedList;
        }


        public static List<long> BogoSort(List<long> unsortedList)
        {
            var listCopy = new List<long>(unsortedList);
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


        public static List<long> BogoSortWithLog(List<long> unsortedList)
        {
            var listCopy = new List<long>(unsortedList);
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

        public static List<long> BogoSortWithLogLight(List<long> unsortedList)
        {
            var listCopy = new List<long>(unsortedList);
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