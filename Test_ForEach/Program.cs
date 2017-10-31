using System;
using System.Collections.Generic;

namespace Test_ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 1, 3, 1, 4 };
            // Standard ForEach which is include in List class
            Console.WriteLine(string.Join(", ", list));

            IEnumerable<int> enumerable = new int[] { 1, 2, 1, 3, 1, 4 };
            // Generic ForEach made for any Enumerable
            Console.WriteLine(string.Join(", ", enumerable));

            Console.ReadKey();
        }
    }
}
