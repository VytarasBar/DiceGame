﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceMenu
{
    class Button : GUIObject
    {
        public bool IsActive { get; private set; } = false;

        public string Label
        {
            get { return _textLine.Label; }
            set { _textLine.Label = value; }
        }        

        private Frame _notActiveFrame;
        private Frame _activeFrame;
        private TextLine _textLine;

        public Button(int x, int y, int width, int height, string buttonText) : base(x, y, width, height)
        {
            _notActiveFrame = new Frame(x, y, width, height, '+');
            _activeFrame = new Frame(x, y, width, height, '#');

            _textLine = new TextLine(x + 1, y + 1 + ((height - 2) / 2), width -2, buttonText);
        }

        public override void Render()
        {
            if (IsActive)
            {
                _activeFrame.Render();
            }
            else
            {
                _notActiveFrame.Render();
            }

            _textLine.Render();
        }

        public void SetActive()
        {
            IsActive = true;
        }

        public void SetInActive()
        {
            IsActive = false;
        }
    }
}
