using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TaskChessboard.Models;
using ChessboardView.Views.ClassViews;

namespace ChessboardView
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            ViewChessboard viewChessboard = new ViewChessboard();
            //int width, height;
            viewChessboard.chessboardController.TakeDataForChessboard();
            Console.ReadKey();
        }
    }
}
