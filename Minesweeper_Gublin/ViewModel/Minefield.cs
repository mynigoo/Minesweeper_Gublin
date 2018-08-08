using Minesweeper_Gublin.Helpers;
using System;
using System.Collections.Generic;

namespace Minesweeper_Gublin.ViewModel
{
    public class Minefield: ObservableObject
    {

        public int NumCols { get; set; }
        public int NumRows { get; set; }
        public int NumBombs { get; set; }

        private bool _stopGame;

        public bool StopGame
        {
            get { return _stopGame; }
            set
            {
                if (_stopGame != value)
                {
                    _stopGame = value;
                    RaisePropertyChanged();
                }
            }
        }

        public int CountOpenCells { get; set; }

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
            StopGame = false;
            CellFilling();
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
                    foreach (var cellIndex in GetIndexesAround(x, y))
                        Cells[cellIndex].BombQuantityAround++;
                }
                else i--;
            }
        }

        private void CellFilling()
        {
            Cells = new Cell[NumCols * NumRows];
            for (int j = 0; j < NumRows; j++)
                for (int i = 0; i < NumCols; i++)
                    Cells[NumCols * j + i] = new Cell(i, j);
            Mining();
        }

        private List<int> GetIndexesAround(int x, int y)
        {
            List<int> r = new List<int>();

            //1
            if (y - 1 >= 0 & y - 1 < NumRows &  x - 1 >= 0 & x - 1 < NumCols)
                       r.Add((y - 1) * NumCols + x - 1);
            //2
            if (y - 0 >= 0 & y - 0 < NumRows &  x - 1 >= 0 & x - 1 < NumCols)
                       r.Add((y - 0) * NumCols + x - 1);
            //3
            if (y + 1 >= 0 & y + 1 < NumRows &  x - 1 >= 0 & x - 1 < NumCols)
                       r.Add((y + 1) * NumCols + x - 1);
            //4
            if (y - 1 >= 0 & y - 1 < NumRows &  x - 0 >= 0 & x - 0 < NumCols)
                       r.Add((y - 1) * NumCols + x - 0);
            //5
            if (y + 1 >= 0 & y + 1 < NumRows &  x - 0 >= 0 & x - 0 < NumCols)
                       r.Add((y + 1) * NumCols + x - 0);
            //6
            if (y - 1 >= 0 & y - 1 < NumRows &  x + 1 >= 0 & x + 1 < NumCols)
                       r.Add((y - 1) * NumCols + x + 1);
            //7
            if (y - 0 >= 0 & y - 0 < NumRows &  x + 1 >= 0 & x + 1 < NumCols)
                       r.Add((y - 0) * NumCols + x + 1);
            //8
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
                YouLose();
            CountOpenCells++;
            if (CountOpenCells == NumCols * NumRows - NumBombs)
                YouWin();
        }

        private void YouWin()
        {
            StopGame = true;
            CellFilling();
        }

        private void YouLose()
        {
            StopGame = true;
            CellFilling();
        }
    }

}
