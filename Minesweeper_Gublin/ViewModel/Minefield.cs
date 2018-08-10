using Minesweeper.Helpers;
using System;
using System.Collections.Generic;

namespace Minesweeper.ViewModel
{
    public class Minefield: ObservableObject
    {

        public int NumCols { get; set; }
        public int NumRows { get; set; }
        private int NumBombs { get; set; }
        private int CountOpenCells { get; set; }

        private bool _theEnd;
        public bool TheEnd
        {
            get { return _theEnd; }
            set
            {
                if (_theEnd != value)
                {
                    _theEnd = value;
                    RaisePropertyChanged();
                }
            }
        }

        private Cell[] _cells;
        public Cell[] Cells
        {
            get { return _cells; }
            set
            {
                if (_cells != value)
                {
                    _cells = value;
                    RaisePropertyChanged();
                }
            }
        }

        public Minefield(int NumColsI, int NumRowsI, int NumBombsI)
        {
            NumCols = NumColsI;
            NumRows = NumRowsI;
            NumBombs = NumBombsI;
            CountOpenCells = 0;
            TheEnd = false;
            CellFilling();
            Mining();
        }

        private void CellFilling()
        {
            Cells = new Cell[NumCols * NumRows];
            for (int j = 0; j < NumRows; j++)
                for (int i = 0; i < NumCols; i++)
                    Cells[NumCols * j + i] = new Cell(i, j);

        }

        private void Mining()
        {
            Random r = new Random();
            for (int i = 0; i < NumBombs; i++)
            {
                int v = r.Next(0, NumCols * NumRows - 1);
                if (Cells[v].IsBomb != true)
                {
                    Cells[v].IsBomb = true;
                    foreach (var cellIndex in GetIndexesAround(Cells[v].X, Cells[v].Y))
                        Cells[cellIndex].BombQuantityAround++;
                }
                else i--;
            }
        }

        private List<int> GetIndexesAround(int x, int y)
        {
            List<int> r = new List<int>();

            //00
            if (y - 1 >= 0 & y - 1 < NumRows &  x - 1 >= 0 & x - 1 < NumCols)
                       r.Add((y - 1) * NumCols + x - 1);
            //01
            if (y - 0 >= 0 & y - 0 < NumRows &  x - 1 >= 0 & x - 1 < NumCols)
                       r.Add((y - 0) * NumCols + x - 1);
            //02
            if (y + 1 >= 0 & y + 1 < NumRows &  x - 1 >= 0 & x - 1 < NumCols)
                       r.Add((y + 1) * NumCols + x - 1);
            //10
            if (y - 1 >= 0 & y - 1 < NumRows &  x - 0 >= 0 & x - 0 < NumCols)
                       r.Add((y - 1) * NumCols + x - 0);
            //12
            if (y + 1 >= 0 & y + 1 < NumRows &  x - 0 >= 0 & x - 0 < NumCols)
                       r.Add((y + 1) * NumCols + x - 0);
            //20
            if (y - 1 >= 0 & y - 1 < NumRows &  x + 1 >= 0 & x + 1 < NumCols)
                       r.Add((y - 1) * NumCols + x + 1);
            //21
            if (y - 0 >= 0 & y - 0 < NumRows &  x + 1 >= 0 & x + 1 < NumCols)
                       r.Add((y - 0) * NumCols + x + 1);
            //22
            if (y + 1 >= 0 & y + 1 < NumRows &  x + 1 >= 0 & x + 1 < NumCols)
                       r.Add((y + 1) * NumCols + x + 1);

            return r;
        }

        public void CellCheck (Cell c)
        {
            c.Open();
            if (c.BombQuantityAround == 0)
                foreach (var i in GetIndexesAround(c.X, c.Y))
                    if (Cells[i].State == CellStates.CLOSE)
                        CellCheck(Cells[i]);
            if (c.State == CellStates.OPEN_BOMB)
                TheEnd = true;
            CountOpenCells++;
            if (CountOpenCells == NumCols * NumRows - NumBombs)
                TheEnd = true;
        }

    }

}
