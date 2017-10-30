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
            IEnumerable<int> list = new List<int>() { 1, 2, 3, 4 };
            list.ToList().ForEach(model => Console.Write(model + ", "));

            Console.WriteLine();

            list = list.ReplaceAt(1, 9).ReplaceAt(2, 567);
            list.ToList().ForEach(model => Console.Write(model + ", "));

            Console.ReadKey();
        }
    }
}
