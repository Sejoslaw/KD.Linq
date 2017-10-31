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
            var list = new List<int>() { 1, 2, 1, 3, 1, 4 };
            list.ForEach(value => Console.Write(value + ", "));

            Console.WriteLine();

            // Replace value at each index where value equals 1 to new value which is 9
            var list2 = list.ReplaceMultiple(9, value => value == 1).ToList();
            list2.ForEach(value => Console.Write(value + ", "));

            Console.WriteLine();

            // Replace value at each index where value equals 2 to new value which is 8
            var list3 = list2.ReplaceMultiple(8, value => value == 2).ToList();
            list3.ForEach(value => Console.Write(value + ", "));

            Console.ReadKey();
        }
    }
}
