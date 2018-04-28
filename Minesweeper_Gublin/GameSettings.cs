using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper_Gublin
{
    public class GameSettings
    {
        private int cols = 9;
        private int rows = 9;
        public int NumCols
        {
            get;
            set;
        }
        public int NumRows
        {
            get;
            set;
        }
        public int NumBombs
        {
            get;
            set;
        }
    }
}
