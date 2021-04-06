using System;

using TaskChessboard.Models.InterfaceModels;
using TaskChessboard.Models.Enums;

namespace TaskChessboard.Models.ClassModels
{
    public class Chessboard: IChessboard
    {
        public int Width { get; set; }
        public int Heigth { get; set; }
        public Cell[,] cells;

        public Chessboard()
        {
            Width = 8;
            Heigth = 8;
            cells = new Cell[Width, Heigth];
        }
        public Chessboard(int width, int heigth)
        {
            Width = width;
            Heigth = heigth; 
            cells = new Cell[Width, Heigth];
        }

        public Cell[,] SetChessboard()
        {
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Heigth; j++)
                    if ((i + j) % 2 == 0)
                    {
                        cells[i, j] = new Cell((char)ColorEnum.colorWhite);
                    }
                    else
                    {
                        cells[i, j] = new Cell((char)ColorEnum.colorBlack);
                    }
            }
            return cells;
        }
    }
}
