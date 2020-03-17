﻿using System;
using System.Collections.Generic;
using System.IO;

namespace SortAndSearch
{
    public static class ListGen
    {
        
        // Creates a List filled with n distinct random (unsorted) values
        // uses User input for amount of numbers
        public static List<int> CreateRandomNumberList()
        {
            var numberlist = new List<int>();

            Console.WriteLine("Enter amount of numbers");
            var amount = int.Parse(Console.ReadLine());

            // Fill List
            for (var i = 0; i < amount; i++) numberlist.Add(i);

            // Randomize List using Fisher-Yates Shuffle
            var rand = new Random();
            var n = numberlist.Count;

            for (var i = numberlist.Count - 1; i > 1; i--)
            {
                var random = rand.Next(i + 1);
                var value = numberlist[random];
                numberlist[random] = numberlist[i];
                numberlist[i] = value;
            }

            return numberlist;
        }

        public static List<int> CreateSortedNumberList()
        {
            var numberlist = new List<int>();

            Console.WriteLine("Enter amount of numbers");
            var amount = int.Parse(Console.ReadLine());

            // Fill List
            for (var i = 0; i < amount; i++) numberlist.Add(i);

            return numberlist;
        }
        
        
        
        
        
        
        /* Examples:
         * Create A File with random distinct numbers: CreateRandomNumberFile(CreateFile(AssignPath()))
         * Create A File with sorted distinct numbers: CreateNumberFileDistinct(CreateFile(AssignPath()))
         * Create A List with random distinct numbers: CreateRandomNumberList()
         * Create A List with sorted distinct numbers:
         */
        
        
        
        
        // Creates a path pointing to specified file name
        public static string AssignPath()
        {
            const string basepath = "E:\\Documents\\SolutionFiles\\AlgoSort\\";
            Console.WriteLine("Enter a file name:");
            var filename = Console.ReadLine() + ".txt";
            var path = basepath + filename;
            return path;
        }

        
        // Takes path and creates empty file at path
        public static StreamWriter CreateFile(string path)
        {
            //var stream = File.Create(path);
            var stream = new StreamWriter(path, true) {AutoFlush = true};
            return stream;
        }
        
        
        // takes Stream and writes ascending distinct numbers there
        public static void CreateNumberFileDistinct(StreamWriter stream)
        {
            /*
            Console.WriteLine("Enter amount of numbers");
            var amount = int.Parse(Console.ReadLine());

            for (var i = 0; i <= amount; i++) stream.WriteLine(i);
            */
            
            var sortedNumberlist = CreateSortedNumberList();
            foreach (var number in sortedNumberlist) stream.WriteLine(number);
            
            
            stream.Close();
        }
        
        
        // Takes Stream and writes random distinct numbers there
        public static void CreateRandomNumberFile(StreamWriter stream)
        {
            var randomNumberList = CreateRandomNumberList();

            foreach (var number in randomNumberList) stream.WriteLine(number);

            stream.Close();
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        // Takes a path to a txt file and converts back to list
        public static List<int> TxtToList(string path)
        {
            string line;
            var numList = new List<int>();
            var file = new StreamReader(path);

            while ((line = file.ReadLine()) != null) numList.Add(int.Parse(line));

            return numList;
        }
        
        
        // Prints list values to console
        public static void PrintList(List<int> list)
        {
            foreach (var num in list)
            {
                Console.Write(num);
                Console.Write("|");
            }
            Console.Write("\n");
        }
        
    }
}