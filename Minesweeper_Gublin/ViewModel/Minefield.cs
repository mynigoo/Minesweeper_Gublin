using System;
using System.Collections.Generic;

namespace Minesweeper_Gublin.ViewModel
{
    public class Minefield
    {

        public int NumCols { get; set; }
        public int NumRows { get; set; }
        public int NumBombs { get; set; }

        public Cell[] Cells { get; set; }

        public Minefield()
        {
            NumCols = 9;
            NumRows = 9;
            NumBombs = 10;
            Cells = new Cell[NumCols * NumRows];
            for (int j = 0; j < NumRows; j++)
                for (int i = 0; i < NumCols; i++)
                    Cells[NumCols * j + i] = new Cell(i, j);

            Mining();
        }

        private void Mining()
        {
            Random r = new Random();
            for (int i = 0; i < NumBombs; i++)
            {
                int x = r.Next(0, NumCols - 1);
                int y = r.Next(0, NumRows - 1);
                if (Cells[NumCols * y + x].IsBomb != true)
                {
                    Cells[NumCols * y + x].IsBomb = true;
                    foreach (var cellIndex in VicinityIndexes(x, y))
                        Cells[cellIndex].BombQuantityAround++;
                }
                else i--;
            }
        }

        private List<int> VicinityIndexes(int x, int y)
        {
            List<int> r = new List<int>();

            //1
            if (y - 1 >= 0 & y - 1 < NumRows  &  x - 1 >= 0 & x - 1 < NumRows)
                       r.Add((y - 1) * NumCols + x - 1 );
            //2
            if (y - 0 >= 0 & y - 0 < NumRows  &  x - 1 >= 0 & x - 1 < NumRows)
                       r.Add((y - 0) * NumCols + x - 1);
            //3
            if (y + 1 >= 0 & y + 1 < NumRows  &  x - 1 >= 0 & x - 1 < NumRows)
                       r.Add((y + 1) * NumCols + x - 1);
            //4
            if (y - 1 >= 0 & y - 1 < NumRows  &  x - 0 >= 0 & x - 0 < NumRows)
                       r.Add((y - 1) * NumCols + x - 0);
            //5
            if (y + 1 >= 0 & y + 1 < NumRows  &  x - 0 >= 0 & x - 0 < NumRows)
                       r.Add((y + 1) * NumCols + x - 0);
            //6
            if (y - 1 >= 0 & y - 1 < NumRows  &  x + 1 >= 0 & x + 1 < NumRows)
                       r.Add((y - 1) * NumCols + x + 1);
            //7
            if (y - 0 >= 0 & y - 0 < NumRows  &  x + 1 >= 0 & x + 1 < NumRows)
                       r.Add((y - 0) * NumCols + x + 1);
            //8
            if (y + 1 >= 0 & y + 1 < NumRows  &  x + 1 >= 0 & x + 1 < NumRows)
                       r.Add((y + 1) * NumCols + x + 1);

            return r;
        }

        public void CellCheck (Cell c)
        {
            c.Open();
            if (c.BombQuantityAround == 0)
                foreach (var i in VicinityIndexes(c.X, c.Y))
                    if (Cells[i].State == CellStates.CLOSE)
                    {
                        Cells[i].Open();
                        CellCheck(Cells[i]);
                    }
        }

 
         



    }

}
