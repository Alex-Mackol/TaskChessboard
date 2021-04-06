using System;

using TaskChessboard.Models.ClassModels;
using ChessboardView.Views.ClassViews;

namespace ChessboardView.Controllers.ClassControllers
{
    public class ChessboardController
    {
        private string width;
        private string height;

        public Chessboard Chessboard { get; set; }
        public ViewChessboard viewChessboard;
        public string Width { get => width; }
        public string Heigth { get => height; }//Todo: 

        UserInputChessboard inputChessboard;
        public ChessboardController()
        {

        }

        public void TakeDataForChessboard()
        {
            Validator validator = new Validator();
            inputChessboard = new UserInputChessboard();
            
            inputChessboard.InputChessboard(out width, out height);
            if(validator.Parsing(width) > 0 && validator.Parsing(height)>0)
            {
                Chessboard = new Chessboard(validator.Parsing(width), validator.Parsing(height));
                Chessboard.cells = Chessboard.SetChessboard();
                viewChessboard = new ViewChessboard(Chessboard);
                viewChessboard.DrawChessboard();
            }
            else
            {
                //bad
            }
        }

        
    }
}
