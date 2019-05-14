using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class M3 : CarBase
    {
        public M3() : base("BMW", "M3", 2008, Color.Silver, "Yo", 10000)
        {

        }

        public sealed override void ChangeMarche()
        {
            Console.WriteLine("GOOOO Fasterrrr");
        }

        public override void PressAcelerator(double howFar)
        {
            Console.WriteLine("GO MORE FASTEEER");
        }

        public override void PressBreak()
        {
            Console.WriteLine("Stop");
            FireCarStoppedEvent();//con esto le estoy diciendo que ejecute el de la clase base y no lo de pressBreak    
        }

        public new void Star()
        {
            Console.WriteLine("Wait a seconds");
        }

    }
}
