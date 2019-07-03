using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursedPaladin
{
    class WorldConsole : IRenderConsole
    {
        public void Flush()
        {

        }

        public void Clear()
        {
            Console.CursorLeft = 0;
            Console.CursorTop = 0;
        }


    }
}
