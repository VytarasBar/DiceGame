using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceMenu
{
    class Text : GUIObject
    {
        private string _text { get; set; }

        public Text(int x, int y, int width, int height, string text) : base (x, y, width, height)
        {
            text = _text;
        }

        public override void Render()
        {
            Console.SetCursorPosition(X, Y);
            Console.WriteLine(_text);
        }

    }
}
