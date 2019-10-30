using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceMenu
{
    class GameOverWindow
    {
        private TextLine replay;
        private TextLine menu;
        private TextLine quit;
        private List<TextLine> optionItem = new List<TextLine>();

        public GameOverWindow()
        {
            optionItem.Add(replay = new TextLine(30, 14, 18, "R - Relay game"));
            optionItem.Add(menu = new TextLine(50, 14, 18, "M - Go to menu"));
            optionItem.Add(quit = new TextLine(66, 14, 18, "Q - Quit"));
        }

        public void Render()
        {
            bool needToRender = true;

            do
            {
                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedChar = Console.ReadKey(true);
                    switch (pressedChar.Key)
                    {
                        case ConsoleKey.R:
                            Console.Clear();
                            needToRender = false;
                            GUIController.RenderPlayerselectionMenu();
                            break;
                        case ConsoleKey.M:
                            Console.Clear();
                            needToRender = false;
                            GUIController.RenderMainMenu();
                            break;
                        case ConsoleKey.Q:
                            Console.Clear();
                            needToRender = false;
                            break;
                    }
                }
            } while (needToRender);
        }
    }
}
