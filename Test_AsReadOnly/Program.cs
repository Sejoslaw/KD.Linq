using KD.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Test_AsReadOnly
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> list1 = new List<int> { 1, 2, 3 };
            ReadOnlyCollection<int> readOnly = list1.AsReadOnly();
            Console.WriteLine($"Is read-only: { readOnly.ToString() }");

            Console.ReadKey();
        }
    }
}