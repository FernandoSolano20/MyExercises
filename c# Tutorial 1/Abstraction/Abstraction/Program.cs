using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar[] cars =
            {
                new M3{Color = Color.Silver },
                new Hooptie{Color = Color.Black },
            };

            foreach(ICar car in cars)
            {
                PrintInfoCar(car);
                car.CarStopped += OnCarStopped;
                car.Star();
                car.PressAcelerator(2);
                car.PressAcelerator(10);
                car.PressBreak();
                car.PressAcelerator(20);
                car.ChangeMarche();
            };

            QuitTracker bob = new QuitTracker { Name = "Bob"};
            QuitTracker sandy = new QuitTracker { Name = "Sandy" };
            KeystrokeHandler keystrokehandler = new KeystrokeHandler();
            keystrokehandler.OnKey += GotKey;
            keystrokehandler.OnQuitting += bob.QuitHandler;
            keystrokehandler.OnQuitting += sandy.QuitHandler;
            keystrokehandler.OnQuitting += OnQuit;
            keystrokehandler.Run();

            object carM3 = new M3();
            Type type = carM3.GetType();
            Console.WriteLine(type.Assembly.GetName().Version);
            Console.WriteLine(carM3);

            object[] objects =
            {
                new M3(),
                new Hooptie(),
            };

            foreach(object obj in objects)
            {
                Console.WriteLine(obj);
                Is(obj);
                As(obj);
                Cast(obj);
                Console.WriteLine("-------------    ");
            }
        }

        private static void Cast(object obj)
        {
            try
            {
                CarBase m3 = (M3)obj;
                Console.WriteLine("M3 retuned {0}", m3);
            }
            catch(InvalidCastException)
            {
                Console.WriteLine("InvalidCastException");
            }
        }

        private static void As(object obj)
        {
            ICar m3 = obj as Hooptie;
            Console.WriteLine("as M3 retuned {0}", m3);
        }

        private static void OnCarStopped(object sender, EventArgs e)
        {
            Console.WriteLine("Car stop");
        }

        private static void Is(object obj)
        {
            bool isM3 = obj is M3;
            Console.WriteLine("is M3 retuned {0}", isM3);
        }

        static void PrintInfoCar(ICar car)
        {
            Console.WriteLine("Here is the car {0} {1} {2} {3} {4}", car.Make, car.Model, car.Owner, car.Year, car.Price);
        }

        static void GotKey(char key)
        {
            Console.WriteLine("Got a key {0}",key); 
        }

        static void OnQuit()
        {
            Console.WriteLine("Quitting!!!");
        }
    }
}
