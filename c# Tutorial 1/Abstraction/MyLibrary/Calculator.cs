using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Calculator
    {
        public double Sum { get; private set; }
        public void Add(double num)
        {
            Sum += num;
        }
    }
}
