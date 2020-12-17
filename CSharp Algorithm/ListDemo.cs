using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Algorithm
{
    class ListDemo
    {
        public class Customer
        {
            public string Name { get; set; }
            public DateTime BirthDate { get; set; }
        }

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

            // TrimExcess only works if 90% or more of the capacity is being used
            list.TrimExcess();
            LogCountAndCapacity(list);

            list.Add(1);
            LogCountAndCapacity(list);

            Console.Read();
        }

        public static void ApiMembers()
        {
            // Other API members
            var list = new List<int>() { 1, 0, 5, 3, 4 };
            // Sort method without passing anything in works well for integers
            list.Sort();

            // research these moethods
  
            int indexBinSearch = list.BinarySearch(3);

            list.Reverse();

            IReadOnlyCollection<int> readOnlyList = list.AsReadOnly();

            // To pull the array out of the list
            int[] array = list.ToArray();



            var customerList = new List<Customer>
            {
                new Customer { BirthDate = new DateTime(1981, 08, 24), Name = "Marquita" },
                new Customer { BirthDate = new DateTime(1987, 06, 27), Name = "Teara" },
                new Customer { BirthDate = new DateTime(1988, 07, 27), Name = "Sean" }
            };

            // lamda expression
            customerList.Sort((left, right) =>
            {
                if(left.BirthDate > right.BirthDate)
                    return 1;
                if (right.BirthDate > left.BirthDate)
                    return -1;
                    return 0;
            });
        }
        
       

        private static void LogCountAndCapacity(List<int> list)
        {
            Console.WriteLine($"Count = {list.Count}. Capacity = {list.Capacity}. ");
        }
    }
}
