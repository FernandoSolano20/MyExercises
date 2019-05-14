using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploringNETFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loading settings");
            MySettings settings = MySettings.Load();

            Console.WriteLine("MyNumber equals {0}",settings.MyNumber);
            Console.WriteLine("MyString equals {0}", settings.MyString);

            Console.WriteLine();
            Console.WriteLine("Updating settings and saving file");

            settings.MyNumber++;
            settings.MyString = DateTime.Now.ToString();

            settings.Save();

            Console.WriteLine("Done");
        }
    }
}
