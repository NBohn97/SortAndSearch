using System;
using System.Collections.Generic;
using static SortAndSearch.ListGen;
using static SortAndSearch.Sorting;
using static SortAndSearch.Performance;
using static SortAndSearch.Searching;

namespace SortAndSearch
{
    class Program
    {

        static void Main(string[] args)
        {
            
            /* SORT MAIN
            
            // Generate a random List
            Console.WriteLine("GENERATING RANDOM LIST:");
            List<int> generatedRandomList = CreateRandomNumberList();
            PrintList(generatedRandomList);
            Console.WriteLine($"Is unsorted generated List sorted ?: {IsSorted(generatedRandomList)}\n");
            
            // Sort with BubbleSort
            Console.WriteLine("BUBBLE SORT:");
            var sortedBubble = ElapsedTimeSorting(BubbleSort,generatedRandomList);
            PrintList(sortedBubble);
            Console.WriteLine($"Is Bubble Sorted List sorted ?: {IsSorted(sortedBubble)}\n");

            // Sort with BogoSort
            Console.WriteLine("BOGO SORT:");
            var sortedBogo = ElapsedTimeSorting(BogoSort, generatedRandomList);
            PrintList(sortedBogo);
            Console.WriteLine($"Is Bogo Sorted List sorted ?: {IsSorted(sortedBogo)}\n");

            */
            
            
            // SORT STRING LIST

            var sortedList = TxtToStringList("C:\\Solutions\\SortThisShit\\SortAndSearch\\SortString.txt");
            PrintStringList(BubbleSortOptimizedString(sortedList));
            







            // SEARCH MAIN

            /*
            Console.WriteLine("Which integer are you searching for? :");
            long searchingFor = long.Parse(Console.ReadLine());
            
            var SortedForSearch = CreateSortedNumberList();
            Console.WriteLine(ElapsedTimeSearching(SequentialSearch,SortedForSearch,searchingFor));
            */



            /* SEARCH CITY
            Console.WriteLine("Which City are you searching for? :");
            string searchingForString = Console.ReadLine();
            
            var convList = TxtToStringList("C:\\Solutions\\SortThisShit\\SortAndSearch\\CitiesUnsorted.txt");
            Console.WriteLine(ElapsedTimeSearchingString(SequentialSearchString,convList,searchingForString));
            */




















            /* Sample Generate Random and Sorted List and test if sorted
             
            List<int> generatedRandomList = CreateRandomNumberList();
            PrintList(generatedRandomList);

            List<int> generatedList = CreateSortedNumberList();
            PrintList(generatedList);

            Console.WriteLine(IsSorted(generatedList) + "\n");
            Console.WriteLine(IsSorted(generatedRandomList));
            
            */


            /* Sample Generate Files with random and sorted values
             
            CreateRandomNumberFile(CreateFile(AssignPath()));
            CreateNumberFileDistinct(CreateFile(AssignPath()));
            
             */


        }
    }
}