using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public interface ICar
    {
        void Star();
        void PressAcelerator(double howFar);
        void PressBreak();
        void ChangeMarche();

        string Make { get; }
        string Model { get; }
        int Year { get; }
        Color Color { get; set; }
        string Owner { get; }
        int Price { get; }

        event EventHandler CarStopped;
    }
}
