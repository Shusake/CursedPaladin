using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursedPaladin
{
    struct RenderConsoleItem
    {
        public RenderConsoleItem(IRenderConsole _renderConsole, int _index)
        {
            RenderConsole = _renderConsole;
            Index = _index;
        }

        public IRenderConsole RenderConsole;
        public int Index;
    }
}
