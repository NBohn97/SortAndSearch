using System;
using static SortAndSearch.ListGen;
using static SortAndSearch.Sorting;
using static SortAndSearch.Performance;
using static SortAndSearch.Searching;

namespace SortAndSearch
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var restart = true;

            while (restart)
            {
                var firstChoice = ChooseFirst();
                ChooseSecond(firstChoice);

                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Restart? (y)es (n)o:");
                var x = Console.ReadLine();
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
            var selection = 0;

            while (selection != 1 && selection != 2)
            {
                Console.WriteLine("(1) Sort");
                Console.WriteLine("(2) Search");

                selection = GetInput(1, 2);
            }

            return selection;
        }


        public static void ChooseSecond(int selection1)
        {
            int selection2;
            int selection3;

            switch (selection1)
            {
                case 1:
                    var generatedRandomList = CreateRandomNumberList();

                    // Select the two algorithms
                    SortMenu(1);
                    selection2 = GetInput(1, 5);
                    SortMenu(2);
                    selection3 = GetInput(1, 7);
                    
                    // First algorithm
                    switch (selection2)
                    {
                        case 1:
                            Console.WriteLine("[BUBBLE SORT]");
                            ElapsedTimeSorting(BubbleSort, generatedRandomList);
                            break;
                        case 2:
                            Console.WriteLine("[BUBBLE SORT OPT.]");
                            ElapsedTimeSorting(BubbleSortOptimized, generatedRandomList);
                            break;
                        case 3:
                            Console.WriteLine("[BOGO SORT]");
                            ElapsedTimeSorting(BogoSort, generatedRandomList);
                            break;
                        case 4:
                            Console.WriteLine("[SELECTION SORT]");
                            ElapsedTimeSorting(SelectionSort, generatedRandomList);
                            break;
                        case 5:
                            Console.WriteLine("[INSERTION SORT]");
                            ElapsedTimeSorting(InsertionSort, generatedRandomList);
                            break;
                        default:
                            Console.WriteLine("ERROR");
                            break;
                    }
                    
                    // Second algorithm
                    switch (selection3)
                    {
                        case 1:
                            Console.WriteLine("[BUBBLE SORT]");
                            ElapsedTimeSorting(BubbleSort, generatedRandomList);
                            break;
                        case 2:
                            Console.WriteLine("[BUBBLE SORT OPT.]");
                            ElapsedTimeSorting(BubbleSortOptimized, generatedRandomList);
                            break;
                        case 3:
                            Console.WriteLine("[BOGO SORT]");
                            ElapsedTimeSorting(BogoSort, generatedRandomList);
                            break;
                        case 4:
                            Console.WriteLine("[SELECTION SORT]");
                            ElapsedTimeSorting(SelectionSort, generatedRandomList);
                            break;
                        case 5:
                            Console.WriteLine("[INSERTION SORT]");
                            ElapsedTimeSorting(InsertionSort, generatedRandomList);
                            break;
                        case 6:
                            Console.WriteLine("[BOGO SORT]");
                            ElapsedTimeSorting(BogoSortWithLog, generatedRandomList);
                            break;
                        case 7:
                            Console.WriteLine("[BOGO SORT]");
                            ElapsedTimeSorting(BogoSortWithLogLight, generatedRandomList);
                            break;
                        default:
                            Console.WriteLine("ERROR");
                            break;
                    }
                    break;

                case 2:
                    SearchMenu();
                    selection2 = GetInput(1, 3);
                    switch (selection2)
                    {
                        case 1:
                            // need to randomize ascending list from CreateSortedNumbersList();
                            var generatedList = CreateSortedNumberListV2();
                            Console.WriteLine("Enter Integer you are searching for");
                            var searchingFor = GetInput(-2147483648, 2147483647);

                            Console.WriteLine("-------------------------------------");
                            Console.WriteLine("Sequential Search: ");
                            Console.WriteLine(ElapsedTimeSearching(SequentialSearch, generatedList, searchingFor));
                            Console.WriteLine("Binary Search: ");
                            Console.WriteLine(ElapsedTimeSearching(BinarySearch, generatedList, searchingFor));
                            break;
                        case 2:
                            
                            // need to randomize ascending list from CreateSortedNumbersList();
                            var generatedList2 = CreateSortedNumberList();
                            Console.WriteLine("Enter Integer you are searching for");
                            var searchingFor2 = GetInput(-2147483648, 2147483647);

                            Console.WriteLine("-------------------------------------");
                            Console.WriteLine("Sequential Search: ");
                            Console.WriteLine(ElapsedTimeSearching(SequentialSearch, generatedList2, searchingFor2));
                            Console.WriteLine("Binary Search: ");
                            Console.WriteLine(ElapsedTimeSearching(BinarySearch, generatedList2, searchingFor2));
                            break;
                        default:
                            Console.WriteLine("ERROR");
                            break;
                            
                            
                            
                        case 3:
                            Console.WriteLine("Which City are you searching for? (~ 3.2 million Cities) :");
                            var searchingForString = Console.ReadLine().ToLower();
                            //var convList = TxtToStringList("C:\\Solutions\\SortThisShit\\SortAndSearch\\CitiesSorted.txt");

                            // uncomment line below incase of file not found error && comment out the two lines below
                            //convList = TxtToStringList("..\\..\\..\\CitiesSorted.txt");

                            // Make sure Data directory containing .txt data is in same directory as executable.
                            var directory = AppDomain.CurrentDomain.BaseDirectory;
                            var convList = TxtToStringList(directory + "\\Data\\CitiesSorted.txt");


                            Console.WriteLine("-------------------------------------");
                            Console.WriteLine("Sequential Search:");
                            Console.WriteLine(ElapsedTimeSearching(SequentialSearch, convList, searchingForString));
                            Console.WriteLine("-------------------------------------");
                            Console.WriteLine("Binary Search:");
                            Console.WriteLine(ElapsedTimeSearching(BinarySearch, convList, searchingForString));
                            break;
                    }

                    break;
            }
        }

        public static int GetInput(int low, int high)
        {
            int testedInput;
            var success = false;
            var range = false;
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

        public static void SortMenu(int x)
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"Choose Sorting Algorithm {x}");
            Console.WriteLine("(1) BubbleSort");
            Console.WriteLine("(2) BubbleSort Optimized");
            Console.WriteLine("(3) BogoSort");
            Console.WriteLine("(4) SelectionSort");
            Console.WriteLine("(5) InsertionSort");
            Console.WriteLine("(6) BogoSort(LOG)");
            Console.WriteLine("(7) BogoSort(ENDLOG)");
            Console.WriteLine("(8) QuickSort");
        }

        public static void SearchMenu()
        {
            Console.WriteLine("Search Integers or String?");
            Console.WriteLine("(1) Random Integers");
            Console.WriteLine("(2) Consecutive Integers");
            Console.WriteLine("(3) String (City name)");
        }
        
        
    }
}