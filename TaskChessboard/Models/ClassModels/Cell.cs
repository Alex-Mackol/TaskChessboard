using System;

using TaskChessboard.Models.InterfaceModels;
using TaskChessboard.Models.Enums;

namespace TaskChessboard.Models.ClassModels
{
    public class Cell : ICell
    {
        public char Color { get; set; }

        public Cell(char color)
        {
            Color = color;
        }

        public char GetColorCell(ColorEnum colorEnum) 
        {
            char res = ' ';
            switch (colorEnum)
            {
                case ColorEnum.colorWhite:
                    {
                        res = '8';
                    }
                    break;
                case ColorEnum.colorBlack:
                    {
                        res = '\u2b1b';
                    }
                    break;
            }
            return res;

        }
    }
}

