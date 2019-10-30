using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceMenu
{
    class GUIController
    {     
        //Nelabai gerai supratau ar taip turi but controleris parasytas
        public static void RenderMainMenu()
        {
            MainMenu mainMenu = new MainMenu();
            MainMenu.Render();
        }

        public static void RenderPlayerselectionMenu()
        {
            PlayerSelectionMenu playerSelectionMenu = new PlayerSelectionMenu();
            playerSelectionMenu.Render();
        }

        public static void RenderDiceSelection(int index)
        {
            DiceSelection diceSelection = new DiceSelection(index += 2);
            diceSelection.Render();
        }

        public static void RenderResults(int playerCount, int diceCount)
        {
            Results results = new Results(playerCount, diceCount);
            results.Render();
            GameOverWindow gameOverWindow = new GameOverWindow();
            gameOverWindow.Render();
        }
    }
}
