using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskChessboard.Models.InterfaceModels
{
    public interface ICell
    {
        char Color { get; set; }

        //char[,] setColor();
    }
}
