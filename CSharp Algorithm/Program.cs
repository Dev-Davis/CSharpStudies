using System;

namespace CSharp_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test1BasedArrays();
            // ArraysDemo();
            // ListDemo.Run();
            

            // Node chain
            Node first = new Node() { Value = 5 };
            Node second = new Node { Value = 1 };

            first.Next = second;

            Node third = new Node() { Value = 3 };
            second.Next = third;

            PrintOutLinkedList(first);
            Console.Read();
        }

        private static void PrintOutLinkedList(Node node)
        {
            while(node != null)
            {
                Console.Write(node.Value);
                // reset the value by assigning it to it's own next property
                node = node.Next;
            }
        }

        private static void ArraysDemo()
        {
            // declaring an array of integers
            int[] array1;
            array1 = new int[10];

            int[] array2 = new int[5];

            int[] array3 = new int[5] { 1, 3, 5, 7, 9 };

            int[] array4 = { 1, 2, 3, 4, 5 };

            for(int i = 0; i <= array3.Length -1; i++)
            {
                Console.Write($"{array3[i]}");
            }
            Console.WriteLine();

            foreach(int el in array4)
            {
                Console.Write($"{el}");
            }

            Console.WriteLine();

            
            Array myArray = new int[5];

            Array myArray2 = Array.CreateInstance(typeof(int), 5);
            myArray2.SetValue(1, 0);
            

            Console.Read();
        }

        public static void Test1BasedArrays()
        {
            // Creating an array with 4 elements in which the index starts from 1
            Array myArray = Array.CreateInstance(typeof(int), new int[] { 4 }, new int[] { 1 });
            myArray.SetValue(2019, 1);
            myArray.SetValue(2020, 2);
            myArray.SetValue(2021, 3);
            myArray.SetValue(2022, 4);

            // To get starting index with LowerBound
            Console.WriteLine($"Starting index:{myArray.GetLowerBound(0)}");

            // To get ending index with UpperBound
            Console.WriteLine($"Ending index:{myArray.GetUpperBound(0)}");

            // for (int i = myArray.GetLowerBound(0); i <= myArray.GetUpperBound(0); i++)
            for(int i = 1; i < 5; i++)
            {
                Console.WriteLine($"{myArray.GetValue(i)} at index {i}");
            }
        }
    }
}
