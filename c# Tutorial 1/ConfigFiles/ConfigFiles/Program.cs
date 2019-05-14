using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string settings = ConfigurationManager.AppSettings["MySettings"];
            if(settings == null)
            {
                throw new ApplicationException("Please configurate an AppSettings for MySettings");
            }
            Console.WriteLine(settings);
        }
    }
}
