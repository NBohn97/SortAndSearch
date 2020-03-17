using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
                            ElapsedTimeSorting(BubbleSort,generatedRandomList);
                            break;
                        case 2:
                            ElapsedTimeSorting(BubbleSortOptimized,generatedRandomList);
                            break;
                        case 3:
                            ElapsedTimeSorting(BogoSort,generatedRandomList);
                            break;
                    }
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Choose Sorting Algorithm 2");
                    Console.WriteLine("(1) BubbleSort");
                    Console.WriteLine("(2) BubbleSort Optimized");
                    Console.WriteLine("(3) BogoSort");
                    Console.WriteLine("(4) BogoSort(LOG)");
                    selection2 = int.Parse(Console.ReadLine());
                    switch (selection2)
                    {
                        case 1:
                            ElapsedTimeSorting(BubbleSort,generatedRandomList);
                            break;
                        case 2:
                            ElapsedTimeSorting(BubbleSortOptimized,generatedRandomList);
                            break;
                        case 3:
                            ElapsedTimeSorting(BogoSort,generatedRandomList);
                            break;
                        case 4:
                            ElapsedTimeSorting(BogoSortWithLog,generatedRandomList);
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
                            Console.WriteLine("Which City are you searching for? (~ 3.2 million Cities) :");
                            string searchingForString = Console.ReadLine();
                            //var convList = TxtToStringList("C:\\Solutions\\SortThisShit\\SortAndSearch\\CitiesSorted.txt");
                            var convList = TxtToStringList("..\\..\\..\\CitiesSorted.txt");
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