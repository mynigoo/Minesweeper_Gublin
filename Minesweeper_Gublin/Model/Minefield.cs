using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public Cell[] myCell { get; set; }
        List<Cell> CellList;

        public Minefield()
        {
            NumCols = 9;
            NumRows = 9;
            NumBombs = 10;
            myCell = new Cell[NumCols * NumRows];
            for (int j = 0; j < NumRows; j++)
                for (int i = 0; i < NumCols; i++)
                    myCell[j * NumCols + i] = new Cell(i, j);

            Random r = new Random();
            for (int i = 0; i < NumBombs; i++)
            {
                int x = r.Next(0, NumCols - 1);
                int y = r.Next(0, NumRows - 1);
                if (myCell[NumCols * y + x].isBomb != true)
                    myCell[NumCols * y + x].isBomb = true;
                else i--;
            }


            /*
            CellList = new List<Cell>();
            CellList.Add(new Cell(1, 1));
            CellList.Add(new Cell(2, 3));
            CellList.Add(new Cell(3, 1));*/
            //ObservableCollection<List<Cell>> collection = new ObservableCollection<List<Cell>>();
            //collection.Add(CellList);
            
            //ObservableCollection<Cell[,]> collection = new ObservableCollection<Cell[,]>();
            //ObservableCollection<List<double>> collection = new ObservableCollection<List<double>>();
        }



    }

}
