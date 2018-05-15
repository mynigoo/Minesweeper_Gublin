using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper_Gublin
{
    public class Minefield
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
        Cell[, ] Cell;
        public Minefield()
        {
            NumCols = 9;
            NumRows = 9;
            NumBombs = 10;
            Cell = new Cell[NumCols, NumRows];
            for (int i = 0; i < NumCols; i++)
                for (int j = 0; j < NumRows; j++)
                    Cell[i, j] = new Cell();

            Random r = new Random();
            for (int i = 0; i < NumBombs; i++)
            {
                int x = r.Next(0, NumCols - 1);
                int y = r.Next(0, NumRows - 1);
                if (Cell[x, y].isBomb != true)
                    Cell[x, y].isBomb = true;
                else i--;
            }
        }
    


    }

}
