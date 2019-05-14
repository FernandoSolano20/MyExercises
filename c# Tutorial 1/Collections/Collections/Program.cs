using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList(50);

            list.Add("World");
            list.Add("Hello");

            Console.WriteLine("Count {0}", list.Count);
            Console.WriteLine("Capacity {0}", list.Capacity);

            list.Sort();
            PrintCollection(list);

            try
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("list[0] = {0}", list[0]);
                Console.WriteLine("list[1] = {0}", list[1]);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Erroor");
            }

            Console.WriteLine("Contains Hello: {0}", list.Contains("Hello"));
            Console.WriteLine("Contains Hi: {0}", list.Contains("Hi"));
        }

        public static void PrintCollection(IEnumerable collection)
        {
            foreach(object obj in collection)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
