using System;
using System.Collections.Generic;
using System.IO;
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

                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Restart? (y)es (n)o:");
                string x = Console.ReadLine();
                restart = x == "y" || x == "yes";
                Console.Clear();

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
                
                selection = GetInput(1,2);

            }
            
            return selection;
        }
        
        
        
        public static void ChooseSecond(int selection1)
        {

            int selection2;

            switch (selection1)
            {
                case 1:
                    List<long> generatedRandomList = CreateRandomNumberList();
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Choose Sorting Algorithm 1");
                    Console.WriteLine("(1) BubbleSort");
                    Console.WriteLine("(2) BubbleSort Optimized");
                    Console.WriteLine("(3) BogoSort");
                    Console.WriteLine("(4) SelectionSort");
                    Console.WriteLine("(5) InsertionSort");
                    selection2 = GetInput(1,5);
                    switch (selection2)
                    {
                        case 1:
                            Console.WriteLine("[BUBBLE SORT]");
                            ElapsedTimeSorting(BubbleSort,generatedRandomList);
                            break;
                        case 2:
                            Console.WriteLine("[BUBBLE SORT OPT.]");
                            ElapsedTimeSorting(BubbleSortOptimized,generatedRandomList);
                            break;
                        case 3:
                            Console.WriteLine("[BOGO SORT]");
                            ElapsedTimeSorting(BogoSort,generatedRandomList);
                            break;
                        case 4:
                            Console.WriteLine("[SELECTION SORT]");
                            ElapsedTimeSorting(SelectionSort,generatedRandomList);
                            break;
                        case 5:
                            Console.WriteLine("[INSERTION SORT]");
                            ElapsedTimeSorting(InsertionSort,generatedRandomList);
                            break;
                        default:
                            Console.WriteLine("ERROR");
                            break;
                    }
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Choose Sorting Algorithm 2");
                    Console.WriteLine("(1) BubbleSort");
                    Console.WriteLine("(2) BubbleSort Optimized");
                    Console.WriteLine("(3) BogoSort");
                    Console.WriteLine("(4) SelectionSort");
                    Console.WriteLine("(5) InsertionSort");
                    Console.WriteLine("(6) BogoSort(LOG)");
                    Console.WriteLine("(7) BogoSort(ENDLOG)");
                    selection2 = GetInput(1,7);
                    switch (selection2)
                    {
                        case 1:
                            Console.WriteLine("[BUBBLE SORT]");
                            ElapsedTimeSorting(BubbleSort,generatedRandomList);
                            break;
                        case 2:
                            Console.WriteLine("[BUBBLE SORT OPT.]");
                            ElapsedTimeSorting(BubbleSortOptimized,generatedRandomList);
                            break;
                        case 3:
                            Console.WriteLine("[BOGO SORT]");
                            ElapsedTimeSorting(BogoSort,generatedRandomList);
                            break;
                        case 4:
                            Console.WriteLine("[SELECTION SORT]");
                            ElapsedTimeSorting(SelectionSort,generatedRandomList);
                            break;
                        case 5:
                            Console.WriteLine("[INSERTION SORT]");
                            ElapsedTimeSorting(InsertionSort,generatedRandomList);
                            break;
                        case 6:
                            Console.WriteLine("[BOGO SORT]");
                            ElapsedTimeSorting(BogoSortWithLog,generatedRandomList);
                            break;
                        case 7:
                            Console.WriteLine("[BOGO SORT]");
                            ElapsedTimeSorting(BogoSortWithLogLight,generatedRandomList);
                            break;
                        default:
                            Console.WriteLine("ERROR");
                            break;
                    }


                    break;
                
                case 2:
                    Console.WriteLine("Search Integers or String?");
                    Console.WriteLine("(1) Integer");
                    Console.WriteLine("(2) String");
                    Console.WriteLine("(3) Integer (CONTAINS ALL INTEGERS IN RANGE)");
                    selection2 = GetInput(1,3);
                    switch (selection2)
                    {
                        case 1:
                            // need to randomize ascending list from CreateSortedNumbersList();
                            List<long> generatedList = CreateSortedNumberListV2();
                            Console.WriteLine("Enter Integer you are searching for");
                            int searchingFor = GetInput(-2147483648, 2147483647);
                            
                            Console.WriteLine("-------------------------------------");
                            Console.WriteLine("Sequential Search: ");
                            Console.WriteLine(ElapsedTimeSearching(SequentialSearch,generatedList,searchingFor));
                            Console.WriteLine("Binary Search: ");
                            Console.WriteLine(ElapsedTimeSearching(BinarySearch,generatedList,searchingFor));
                            break;
                        case 2:
                            Console.WriteLine("Which City are you searching for? (~ 3.2 million Cities) :");
                            string searchingForString = Console.ReadLine().ToLower();
                            //var convList = TxtToStringList("C:\\Solutions\\SortThisShit\\SortAndSearch\\CitiesSorted.txt");

                            
                                //convList = TxtToStringList("..\\..\\..\\CitiesSorted.txt");

                                string directory = AppDomain.CurrentDomain.BaseDirectory;
                                List<string> convList = TxtToStringList(directory + "\\Data\\CitiesSorted.txt");

                            
                            
                            Console.WriteLine("-------------------------------------");
                            Console.WriteLine("Sequential Search:");
                            Console.WriteLine(ElapsedTimeSearching(SequentialSearch,convList,searchingForString));
                            Console.WriteLine("-------------------------------------");
                            Console.WriteLine("Binary Search:");
                            Console.WriteLine(ElapsedTimeSearching(BinarySearch,convList,searchingForString));
                            break;
                        case 3:
                            // need to randomize ascending list from CreateSortedNumbersList();
                            List<long> generatedList2 = CreateSortedNumberList();
                            Console.WriteLine("Enter Integer you are searching for");
                            int searchingFor2 = GetInput(-2147483648, 2147483647);
                            
                            Console.WriteLine("-------------------------------------");
                            Console.WriteLine("Sequential Search: ");
                            Console.WriteLine(ElapsedTimeSearching(SequentialSearch,generatedList2,searchingFor2));
                            Console.WriteLine("Binary Search: ");
                            Console.WriteLine(ElapsedTimeSearching(BinarySearch,generatedList2,searchingFor2));
                            break;
                        default:
                            Console.WriteLine("ERROR");
                            break;
                    }
                    break;
                
            }
            
            
        }

        public static int GetInput(int low, int high)
        {
            int testedInput;
            bool success = false;
            bool range = false;
            do
            {
                var input = Console.ReadLine();
                success = int.TryParse(input, out testedInput);
                if (testedInput >= low && testedInput <= high)
                    range = true;

                if (!success)
                    Console.WriteLine("Input couldn't be converted to valid Integer. Please try again:");
                else if (!range)
                    Console.WriteLine("Value out of range. Try another Number:");
            } while (!success || !range);

            return testedInput;
        }
        
        
        
        
    }
    
    
}