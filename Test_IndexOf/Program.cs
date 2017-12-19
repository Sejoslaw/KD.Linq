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
            Element el1 = new Element() { Value = 1 };
            Element el2 = new Element() { Value = 2 };
            Element el3 = new Element() { Value = 3 };
            Element el4 = new Element() { Value = 4 };

            IEnumerable<Element> list = new List<Element>() { el1, el2, el3, el4 };
            int index = list.IndexOf(el3);

            Console.WriteLine("Index = " + index);

            Console.ReadKey();
        }
    }
}
