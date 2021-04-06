using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskChessboard.Views.ClassViews
{
    class UserInputChessboard
    {
        public string Width { get; set; }
        public string Heigth { get; set; }
        public UserInputChessboard()
        {
            InputChessboard();
        }

        public void InputChessboard()
        {
            //Display.EnterData(EnterDataEnum.DataEnum.Width);
            Width = Console.ReadLine();
            //Display.EnterData(EnterDataEnum.DataEnum.Heigth);
            Heigth = Console.ReadLine();
        }
    }
}
