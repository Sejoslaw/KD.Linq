using KD.Linq;
using System;
using System.Collections.Generic;

namespace Test_Find
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> list = new List<int>() { 1, 2, 3, 1, 2, 3, 1, 1 };
            Console.WriteLine(string.Join(", ", list));

            List<int> ones = list.Find(1);
            Console.Write(string.Join(", ", ones));

            Console.ReadKey();
        }
    }
}
