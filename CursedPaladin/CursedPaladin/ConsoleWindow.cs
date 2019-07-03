using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursedPaladin
{
    class ConsoleWindow
    {
        public ConsoleWindow(int _width = 80, int _height= 45, string _title = "Miratera")
        {
            m_Consoles = new List<RenderConsoleItem>();
            AddConsole(new SplashConsole());

            Console.WindowWidth = _width;
            Console.WindowHeight = _height;
            Console.BufferWidth = _width;
            Console.BufferHeight = _height;
            Console.Title = _title;
            Console.CursorVisible = false;
            Console.CursorLeft = 0;
            Console.CursorTop = 0;
        }

        public void Flush()
        {
            m_Consoles[m_CurrentConsoleID].RenderConsole.Flush();
            m_Consoles[m_CurrentConsoleID].RenderConsole.Clear();
        }

        public void AddConsole(IRenderConsole _newConsole)
        {
            m_Consoles.Add(new RenderConsoleItem(_newConsole, m_Consoles.Count));
        }

        public void ChangeConsole(int _id)
        {
            foreach (RenderConsoleItem item in m_Consoles)
            {
                if (_id == item.Index)
                {
                    m_CurrentConsoleID = _id;
                    break;
                }
            }
            
        }

        /*
        public void DEBUGConsoles()
        {
            foreach(RenderConsoleItem item in m_Consoles)
            {
                Console.WriteLine(item.RenderConsole.GetType());
                Console.WriteLine(item.Index);
            }
        }
        */

        private List<RenderConsoleItem> m_Consoles;
        private int m_CurrentConsoleID = 0;
    }
}
