using KD.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Test_ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 1, 3, 1, 4 };
            // Standard ForEach which is include in List class
            list.ForEach(value => Console.Write(value + ", "));

            Console.WriteLine();

            // Generic ForEach made for any Enumerable - Action Version
            IEnumerable<int> enumerable = new int[] { 1, 2, 1, 3, 1, 4 };
            enumerable.ForEach(value => Console.Write(value + ", ")).ToList();

            Console.WriteLine();

            // Generic ForEach made for any Enumerable - Function Version
            IEnumerable<int> enumerable2 = enumerable.ForEach(value => { return value + 1; }).ToList();
            enumerable2.ForEach(value => Console.Write(value + ", ")).ToList();

            Console.ReadKey();
        }
    }
}
