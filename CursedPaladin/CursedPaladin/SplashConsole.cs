using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursedPaladin
{
    class SplashConsole : IRenderConsole
    {
        public void Flush()
        {
            Console.WriteLine("Splash!");
        }

        public void Clear()
        {
            for(int i = 0; i < Console.BufferWidth; i++)
                for( int j = 0; j < Console.BufferHeight; j++)
                {
                    Console.CursorLeft = i;
                    Console.CursorTop = j;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write(" ");
                }
            Console.CursorLeft = 0;
            Console.CursorTop = 0;
        }
    }
}
