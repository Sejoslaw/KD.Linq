using System;
using System.Collections.Generic;
using System.Linq;
using KD.Linq;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 1, 2, 3, 4 };
            list.ForEach(model => Console.Write(model + ", "));

            Console.WriteLine();

            var list2 = list.ReplaceAt(1, 9).ToList();
            list2.ForEach(model => Console.Write(model + ", "));

            Console.WriteLine();

            var list3 = list2.ReplaceAt(2, 567).ToList();
            list3.ForEach(model => Console.Write(model + ", "));

            Console.ReadKey();
        }
    }
}
