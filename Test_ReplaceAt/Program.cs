using KD.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Test_ReplaceAt
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 1, 2, 1, 3, 1, 4 };
            list.ForEach(value => Console.Write(value + ", "));

            Console.WriteLine();

            var list2 = list.ReplaceAt(1, 9).ToList();
            list2.ForEach(value => Console.Write(value + ", "));

            Console.WriteLine();

            var list3 = list2.ReplaceAt(2, 7).ToList();
            list3.ForEach(value => Console.Write(value + ", "));

            Console.ReadKey();
        }
    }
}
