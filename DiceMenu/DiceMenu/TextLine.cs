using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceMenu
{
    class TextLine : GUIObject
    {
        private string _label;

        public TextLine (int x, int y, int width, string label) : base (x,y, width, 0)
        {
            Label = label;
        }

        public string Label
        {
            get { return _label; }
            set
            {
                _label = value;
                Render();
            }
        }

        public override void Render()
        {
            Console.SetCursorPosition(X, Y);
            if (Width > _label.Length)
            {
                int offset = (Width - _label.Length) / 2;
                for (int i = 0; i <offset; i++)
                {
                    Console.Write(' ');
                }
            }

            Console.Write(_label);
        }

    }
}
