using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class QuitTracker
    {
        public string Name {get; set;}
        public void QuitHandler()
        {
            Console.WriteLine("My name is {0} and I just got a notification", Name);
        }
    }
}
