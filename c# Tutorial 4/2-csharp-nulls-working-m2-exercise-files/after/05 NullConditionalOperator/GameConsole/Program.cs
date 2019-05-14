using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCharacter player = new PlayerCharacter();     
            player.DaysSinceLastLogin = 42;
            //null conditional operator con null coalescing operator para verificar que el obj no sea null
            // y asi no caer en una excepcion

            int days = player?.DaysSinceLastLogin ?? -1;
            
            
            //int days = player.DaysSinceLastLogin.Value;

            Console.WriteLine(days);
            


            Console.ReadLine();
        }
    }
}
