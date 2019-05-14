using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListPogram
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList table = new SortedList();
            table["Fer"] = 18;
            table["Jose"] = 21;
            table["Yo"] = 22;

            Console.WriteLine("Fer is at {0}", table.IndexOfKey("Fer"));
            Console.WriteLine("Jose is at {0}", table.IndexOfKey("Jose"));
            Console.WriteLine("Yo is at {0}", table.IndexOfKey("Yo"));

            table.RemoveAt(2);
            table.GetByIndex(1);

            Console.WriteLine("I am {0} years old", table["Fer"]);
            Console.WriteLine("He is {0} years old", table["Jose"]);
            Console.WriteLine("He is {0} years old", table["Yo"]);

            Console.WriteLine("Contain foo {0}", table.Contains("Foo"));
            Console.WriteLine("Contain Fer {0}", table.Contains("Fer"));

            PrintCollection(table.Keys);
            PrintCollection(table.Values);
        }
        public static void PrintCollection(IEnumerable collection)
        {
            foreach (object obj in collection)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
