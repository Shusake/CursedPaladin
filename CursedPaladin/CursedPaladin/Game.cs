using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursedPaladin
{
    class Game
    {
        public Game()
        {
            m_ConsoleWindow = new ConsoleWindow();
        }

        private bool m_IsGameRun;
        private ConsoleWindow m_ConsoleWindow;

        public void Run()
        {
            Initialize();
            GameLoop();
            ShutDown();
        }

        private void Initialize()
        {
            m_ConsoleWindow.AddConsole(new WorldConsole());

            // m_ConsoleWindow.DEBUGConsoles();

            m_IsGameRun = true;
            Console.Beep(432, 500);
        }

        private void GameLoop()
        {
            while(m_IsGameRun)
            {
                Update();
                Draw();
            }
        }

        private void ShutDown()
        {

        }

        private void Draw()
        {
            m_ConsoleWindow.Flush();
        }

        private void Update()
        {
            
        }
    }
}
