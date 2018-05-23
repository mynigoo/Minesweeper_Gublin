using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

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

        public Minefield()
        {
            NumCols = 9;
            NumRows = 9;
            NumBombs = 10;
            myCell = new Cell[NumCols * NumRows];
            for (int j = 0; j < NumRows; j++)
                for (int i = 0; i < NumCols; i++)
                    myCell[NumCols * j + i] = new Cell(i, j);

            Random r = new Random();
            for (int i = 0; i < NumBombs; i++)
            {
                int x = r.Next(0, NumCols - 1);
                int y = r.Next(0, NumRows - 1);
                if (myCell[NumCols * y + x].isBomb != true)
                {
                    myCell[NumCols * y + x].isBomb = true;
                    //myCell[NumCols * y + x].BackgroundColor = new SolidColorBrush(Colors.Red);
                    myCell[NumCols * y + x].Title = "!!!";
                }
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

        public void ChangeBackgroundColor(int x, int y, Color c)
        {
            foreach (var i in VicinityIndexes(x, y))
                myCell[i].BackgroundColor = new SolidColorBrush(Colors.Red);
        }

        public void ChangeColorOfMinedCell()
        {
            foreach(var c in myCell )
                if (c.isBomb) c.BackgroundColor = new SolidColorBrush(Colors.Red);

        }
         



    }

}
