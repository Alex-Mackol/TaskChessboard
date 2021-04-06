using System;
using System.Collections.Generic;

using TaskChessboard.Models.ClassModels;

namespace TaskChessboard.Models.InterfaceModels
{
    public interface IChessboard
    {
        Cell[,] SetChessboard();
    }
}
