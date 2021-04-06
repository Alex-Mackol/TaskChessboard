using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessboardView.Controllers.ClassControllers
{
    class Validator
    {
        public Validator()
        {

        }
        public int Parsing(string st)
        {
            int.TryParse(st, out int num);
            return num;
        }
    }
}
