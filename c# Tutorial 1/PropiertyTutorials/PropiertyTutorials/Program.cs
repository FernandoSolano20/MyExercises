using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace PropiertyTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Calculator calc2 = new Calculator();
            Calculator calc3 = new Calculator();
            Calculator calc4 = new Calculator();
            Calculator calc5 = new Calculator();

            calc.Add(5);
            Console.WriteLine(calc.Sum);

            Subtrac rest = new Subtrac();
            rest.Result(8);
            Console.WriteLine(rest.numberRes);

            Console.WriteLine(Calculator.UsageCount);

        }
    }
}
