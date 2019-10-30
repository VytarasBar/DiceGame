using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceMenu
{
    class PlayerSelectionMenu
    {
        private Button _player2;
        private Button _player3;
        private Button _player4;
        private Button _player5;
        private Button _player6;
        private Button _player7;
        public List<Button> menuItem = new List<Button>();

        public PlayerSelectionMenu()
        {            
            menuItem.Add(_player2 = new Button(20, 8, 15, 5, "2 Players"));            
            menuItem.Add(_player3 = new Button(50, 8, 15, 5, "3 Players"));
            menuItem.Add(_player4 = new Button(80, 8, 15, 5, "4 Players"));
            menuItem.Add(_player5 = new Button(20, 16, 15, 5, "5 Players"));
            menuItem.Add(_player6 = new Button(50, 16, 15, 5, "6 Players"));
            menuItem.Add(_player7 = new Button(80, 16, 15, 5, "7 Players"));
        }

        public void Render()
        {
            bool needToRender = true;
            int index = 0;


            for (int j = 1; j < menuItem.Count; j++)
            {
                menuItem[j].SetInActive();
                menuItem[j].Render();
            }
            Console.SetCursorPosition(0, 0);

            do
            {
                while (needToRender)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                    int hashCode = pressedKey.Key.GetHashCode();
                    Console.SetCursorPosition(0, 0);

                    for (int j = 0; j < menuItem.Count; j++ )
                    {
                        menuItem[j].SetInActive();
                        menuItem[j].Render();
                    }

                    switch (pressedKey.Key)
                    {

                        case ConsoleKey.RightArrow:
                            index++;
                            if (index > 5)
                            {
                                index = 0;
                            }
                            menuItem[index].SetActive();
                            menuItem[index].Render();
                            break;
                        case ConsoleKey.LeftArrow:
                            index--;
                            if (index < 0)
                            {
                                index = 5;
                            }
                            menuItem[index].SetActive();
                            menuItem[index].Render();
                            break;
                        case ConsoleKey.DownArrow:
                            index += 3;
                            if (index > 5)
                            {
                                index -= 3;
                            }
                            break;
                        case ConsoleKey.UpArrow:
                            index -= 3;
                            if (index < 0)
                            {
                                index += 3;
                            }
                            break;
                        case ConsoleKey.Enter:
                            needToRender = false;
                            Console.Clear();
                            GUIController.RenderDiceSelection(index);
                            break;
                    }
                    if (pressedKey.Key != ConsoleKey.RightArrow || pressedKey.Key != ConsoleKey.LeftArrow ||
                        pressedKey.Key != ConsoleKey.UpArrow || pressedKey.Key != ConsoleKey.DownArrow ||
                        pressedKey.Key != ConsoleKey.Enter)
                    {
                        menuItem[index].SetActive();
                        menuItem[index].Render();
                    }
                }
            } while (needToRender);
        }
    }
}
