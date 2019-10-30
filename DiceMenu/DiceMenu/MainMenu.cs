using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceMenu
{
    class MainMenu
    {
        private TextLine play;
        private TextLine quit;
        private List<TextLine> optionItem = new List<TextLine>();

        public MainMenu()
        {
            optionItem.Add(play = new TextLine(40, 14, 18, "P - To Play"));
            optionItem.Add(quit = new TextLine(60, 14, 18, "Q - To Quit"));
        }

        public static void Render()
        {
            GUIController guiController = new GUIController();

            bool needToRender = true;
            
            do
            {
                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedChar = Console.ReadKey(true);
                    int hashCode = pressedChar.Key.GetHashCode();

                    switch (pressedChar.Key)
                    {
                        case ConsoleKey.P:
                            Console.Clear();
                            GUIController.RenderPlayerselectionMenu();
                            needToRender = false;
                            break;
                        case ConsoleKey.Q:
                            needToRender = false;
                            break;
                    }
                }
            } while (needToRender);
        }
    }
}
