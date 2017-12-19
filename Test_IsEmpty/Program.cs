using KD.Linq;
using System;
using System.Collections.Generic;

namespace Test_IsEmpty
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> list1 = new List<int> { 1, 2, 3 };
            Console.WriteLine($"List1 is empty: { list1.IsEmpty() }");

            IEnumerable<int> list2 = new List<int> { };
            Console.WriteLine($"List2 is empty: { list2.IsEmpty() }");

            Console.ReadKey();
        }
    }
}