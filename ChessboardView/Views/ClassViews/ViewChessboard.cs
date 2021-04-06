using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TaskChessboard.Models.ClassModels;
using ChessboardView.Views.InterfaceViews;
using ChessboardView.Controllers.ClassControllers;

namespace ChessboardView.Views.ClassViews
{
    public class ViewChessboard : IDrawer
    {
        public Chessboard Chessboard { get; set; }

        public ChessboardController chessboardController { get; } 

        public ViewChessboard()
        {
            chessboardController = new ChessboardController();
        }

        public ViewChessboard(Chessboard chessboard)
        {
            Chessboard = chessboard;
        }

        public void DrawChessboard()
        {
            for (int i = 0; i < Chessboard.Width; i++)
            {
                for (int j = 0; j < Chessboard.Heigth; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write(Chessboard.cells[i, j].Color.ToString());
                    }
                    else
                    {
                        Console.Write(Chessboard.cells[i, j].Color.ToString());
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
