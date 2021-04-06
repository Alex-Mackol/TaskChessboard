using System;

using TaskChessboard.Models.ClassModels;
using TaskChessboard.Views.ClassViews;

namespace TaskChessboard.Controllers.ClassControllers
{
    class ChessboardController
    {
        public Chessboard Chessboard { get; }
        public string Width { get; set; }
        public string Heigth { get; set; }//Todo: 

        UserInputChessboard inputChessboard;
        public ChessboardController()
        {

        }

        public void InputChessboard()
        {
            inputChessboard = new UserInputChessboard();
            inputChessboard.InputChessboard();
        }

        
    }
}
