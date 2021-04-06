using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessboardView.Views.ClassViews
{
    class UserInputChessboard
    {
        public string Width { get; set; }
        public string Heigth { get; set; }
        public UserInputChessboard()
        {
            //InputChessboard();
        }

        public void InputChessboard(out string width, out string heigth)
        {
            //Display.EnterData(EnterDataEnum.DataEnum.Width);
            width = Console.ReadLine();
            //Display.EnterData(EnterDataEnum.DataEnum.Heigth);
            heigth = Console.ReadLine();
        }
    }
}
