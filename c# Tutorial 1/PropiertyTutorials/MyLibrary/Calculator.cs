using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MyLibrary
{
    public class Multi
    {
        internal double numberMul { get; set; }

        public void Result(double a)
        {
            numberMul = numberMul * a;
        }
    }

    public class Calculator : Multi
    {
        public double Sum { get; private set; }

        public static int UsageCount { get; private set; }

        public void Add(double a)
        {
            this.Sum += a;
            Calculator.UsageCount++;
            Console.WriteLine(numberMul);
        }
    }
}
