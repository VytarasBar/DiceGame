using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceMenu
{
    class DiceSelection : GUIController
    {
        private int _playerCount { get; }
        public int diceCount = 2;
        public int maxDice = 10;
        public int minDice = 2;

        public DiceSelection (int playerCount)
        {
            _playerCount = playerCount;
        }

        public void Render()
        {
            bool needToRender = true;

            Console.Clear();
            PrintInfo(_playerCount, diceCount);

            do{
                
                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedChar = Console.ReadKey(true);
                    int hashCode = pressedChar.Key.GetHashCode();

                    switch (pressedChar.Key)
                    {
                        case ConsoleKey.Add:
                            diceCount++;
                            if (diceCount > maxDice)
                            {
                                diceCount = maxDice;
                            }
                            break;
                        case ConsoleKey.Subtract:
                            diceCount--;
                            if (diceCount < minDice)
                            {
                                diceCount = minDice;
                            }
                            break;
                        case ConsoleKey.Enter:
                            GUIController.RenderResults(_playerCount, diceCount);
                            needToRender = false; ;
                            break;
                    }

                    Console.Clear();
                    PrintInfo(_playerCount, diceCount);
                }
            } while (needToRender);
        }
        public static void PrintInfo(int _playerCount, int diceCount)
        {
            Console.WriteLine($"{_playerCount} players will roll {diceCount} dice");
            Console.WriteLine("Press + or - to change amount of dice\nPress Enter to continue");
        }
    }
}
