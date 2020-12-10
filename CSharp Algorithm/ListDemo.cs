using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Algorithm
{
    class ListDemo
    {
        public static void Run()
        {
            // list of integers
            List<int> list = new List<int>();
            // list of strings
            // List<string> listOfStrings = new List<string>();
            LogCountAndCapacity(list);
            // adding elements to a list
            for(int i = 0; i < 16; i++)
            {
                list.Add(i);
                LogCountAndCapacity(list);
            }
            // removing elements from a list
            for(int i = 10; i > 0; i--)
            {
                list.RemoveAt(i - 1);
                LogCountAndCapacity(list);
            }

            Console.Read();
        }
       

        private static void LogCountAndCapacity(List<int> list)
        {
            Console.WriteLine($"Count = {list.Count}. Capacity = {list.Capacity}. ");
        }
    }
}
