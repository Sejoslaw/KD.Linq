using KD.Linq;
using System;
using System.Collections.Generic;

namespace Test_IndexOf
{
    class Element
    {
        public int Value { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var el1 = new Element() { Value = 1 };
            var el2 = new Element() { Value = 2 };
            var el3 = new Element() { Value = 3 };
            var el4 = new Element() { Value = 4 };

            IEnumerable<Element> list = new List<Element>() { el1, el2, el3, el4 };
            var index = list.IndexOf(el3);

            Console.WriteLine("Index = " + index);

            Console.ReadKey();
        }
    }
}
