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
            List<int> list = new List<int>() { 1, 2, 1, 3, 1, 4 };
            Console.WriteLine(string.Join(", ", list));

            List<int> list2 = list.ReplaceAt(1, 9).ToList();
            Console.WriteLine(string.Join(", ", list2));

            List<int> list3 = list2.ReplaceAt(2, 7).ToList();
            Console.WriteLine(string.Join(", ", list3));

            Console.ReadKey();
        }
    }
}
