using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public delegate void KeypressDelelgate(char key);
    public delegate void QuitDelegate();
    class KeystrokeHandler
    {
        public event KeypressDelelgate OnKey;
        public event QuitDelegate OnQuitting;
        public void Run()
        {
            Console.WriteLine("Keystroke handler is running. Press q to quit");
            while(true)
            {
                char key = Console.ReadKey(true).KeyChar;
                if('q' == key)
                {
                    if(null != OnQuitting)
                    {
                        OnQuitting();
                    }
                    break;
                }
                if(null != OnKey)
                {
                    OnKey(key);
                }
            }
        }
    }
}
