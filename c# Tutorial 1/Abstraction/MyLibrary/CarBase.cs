using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public abstract class CarBase : ICar
    {
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", 
            Color.Name, Year, Make, Model);
        }
        public CarBase(string make, string model, int year, Color color, string owner, int price)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
            Owner = owner;
            Price = price;
        }
        public virtual void Star()
        {
            Console.WriteLine("Roar!!");
        }
        public abstract void PressAcelerator(double howFar);
        public abstract void PressBreak();
        public abstract void ChangeMarche();

        public string Make { get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }
        public Color Color { get; set; }
        public string Owner { get; private set; }
        public int Price { get; private set; }

        public event EventHandler CarStopped;
        protected void FireCarStoppedEvent()
        {
            if(null != CarStopped)
            {
                CarStopped(this, EventArgs.Empty);
            }
        }
    }
}
