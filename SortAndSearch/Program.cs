using System;
using System.Collections.Generic;
using System.Linq;
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

            bool restart = true;
            
            while(restart == true){
                int firstChoice = ChooseFirst();
                ChooseSecond(firstChoice);

                Console.WriteLine("Restart? (y)es (n)o:");
                string x = Console.ReadLine();
                restart = x == "y";

            }



























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



            // SEARCH MAIN

            /*
            Console.WriteLine("Which integer are you searching for? :");
            long searchingFor = long.Parse(Console.ReadLine());
            
            var SortedForSearch = CreateSortedNumberList();
            Console.WriteLine(ElapsedTimeSearching(SequentialSearch,SortedForSearch,searchingFor));
            */














            /*

            // SEARCH CITY SORTED SEQUENTIAL STRING
            Console.WriteLine("Which City are you searching for? :");
            string searchingForString = Console.ReadLine();
            
            var convList = TxtToStringList("C:\\Solutions\\SortThisShit\\SortAndSearch\\CitiesSorted.txt");
            Console.WriteLine(ElapsedTimeSearchingString(SequentialSearch,convList,searchingForString));
            
            // Search long list SEQUENTIAL
            List<long> generatedList = CreateSortedNumberList();
            PrintList(generatedList);
            
            Console.WriteLine(ElapsedTimeSearching(SequentialSearch,generatedList,50));

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

        public static int ChooseFirst()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Choose:");
            int selection = 0;
            
            while (selection != 1 && selection != 2)
            {
                Console.WriteLine("(1) Sort");
                Console.WriteLine("(2) Search");

                selection = int.Parse(Console.ReadLine());

            }
            
            return selection;
        }
        
        
        
        public static void ChooseSecond(int selection1)
        {

            int selection2;
            int selection3;
            string selectionSort1;
            string selectionSort2;
            
            switch (selection1)
            {
                case 1:
                    Console.WriteLine("Enter Amount of Numbers in random List:");
                    List<long> generatedRandomList = CreateRandomNumberList();
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Choose Sorting Algorithm 1");
                    Console.WriteLine("(1) BubbleSort");
                    Console.WriteLine("(2) BubbleSort Optimized");
                    Console.WriteLine("(3) BogoSort");
                    selection2 = int.Parse(Console.ReadLine());
                    switch (selection2)
                    {
                        case 1:
                            var sortedBubble = ElapsedTimeSorting(BubbleSort,generatedRandomList);
                            break;
                        case 2:
                            var sortedBubbleOptimized = ElapsedTimeSorting(BubbleSortOptimized,generatedRandomList);
                            break;
                        case 3:
                            var sortedBogoSort = ElapsedTimeSorting(BogoSort,generatedRandomList);
                            break;
                    }
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Choose Sorting Algorithm 2");
                    Console.WriteLine("(1) BubbleSort");
                    Console.WriteLine("(2) BubbleSort Optimized");
                    Console.WriteLine("(3) BogoSort");
                    selection2 = int.Parse(Console.ReadLine());
                    switch (selection2)
                    {
                        case 1:
                            var sortedBubble = ElapsedTimeSorting(BubbleSort,generatedRandomList);
                            break;
                        case 2:
                            var sortedBubbleOptimized = ElapsedTimeSorting(BubbleSortOptimized,generatedRandomList);
                            break;
                        case 3:
                            var sortedBogoSort = ElapsedTimeSorting(BogoSort,generatedRandomList);
                            break;
                    }


                    break;
                
                case 2:
                    Console.WriteLine("Search Integers or String?");
                    Console.WriteLine("(1) Integer ");
                    Console.WriteLine("(2) String ");
                    selection2 = int.Parse(Console.ReadLine());
                    switch (selection2)
                    {
                        case 1:
                            // need to randomize ascending list from CreateSortedNumbersList();
                            List<long> generatedList = CreateSortedNumberList();
                            Console.WriteLine("Enter Integer you are searching for");
                            int searchingFor = int.Parse(Console.ReadLine());
                            
                            Console.WriteLine("------------------------------");
                            Console.WriteLine("Sequential Search: ");
                            Console.WriteLine(ElapsedTimeSearching(SequentialSearch,generatedList,searchingFor));
                            Console.WriteLine("Binary Search: ");
                            Console.WriteLine(ElapsedTimeSearching(BinarySearch,generatedList,searchingFor));
                            break;
                        case 2:
                            Console.WriteLine("Which City are you searching for? :");
                            string searchingForString = Console.ReadLine();
                            // make path relative
                            var convList = TxtToStringList("C:\\Solutions\\SortThisShit\\SortAndSearch\\CitiesSorted.txt");
                            Console.WriteLine("Sequential Search:");
                            Console.WriteLine(ElapsedTimeSearchingString(SequentialSearch,convList,searchingForString));
                            Console.WriteLine(ElapsedTimeSearchingString(BinarySearch,convList,searchingForString));
                            break;
                    }
                    
                    break;
                
            }
            
    
    
    
        }
        
    }
    

    
    
    
}