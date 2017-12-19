using KD.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Test_ReplaceMultiple
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 1, 3, 1, 4 };
            Console.WriteLine(string.Join(", ", list));

            // Replace value at each index where value equals 1 to new value which is 9
            List<int> list2 = list.ReplaceMultiple(9, value => value == 1).ToList();
            Console.WriteLine(string.Join(", ", list2));

            // Replace value at each index where value equals 2 to new value which is 8
            List<int> list3 = list2.ReplaceMultiple(8, value => value == 2).ToList();
            Console.WriteLine(string.Join(", ", list3));

            Console.ReadKey();
        }
    }
}
