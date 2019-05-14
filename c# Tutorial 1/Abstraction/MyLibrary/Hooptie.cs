using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Hooptie: CarBase
    {
        public Hooptie() : base("Cadillac", "Coupe", 1999, Color.Black, "Yo", 7850000)
        {

        }
        public override void ChangeMarche()
        {
            Console.WriteLine("GO SLOW");
        }

        public override void PressAcelerator(double howFar)
        {
            Console.WriteLine("Keep calm");
        }

        public override void PressBreak()
        {
            Console.WriteLine("OH nooo!!!");
            base.FireCarStoppedEvent();
        }

        public sealed override void Star()
        {
            Console.WriteLine("Starting");
        }
    }
}
