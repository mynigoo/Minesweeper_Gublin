using Minesweeper.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper.ViewModel
{
    public class GameSuperviser : ObservableObject
    {
        private Minefield _mainMinefield;
        public Minefield MainMinefield
        {
            get { return _mainMinefield; }
            set
            {
                if (_mainMinefield != value)
                {
                    _mainMinefield = value;
                    RaisePropertyChanged();
                }
            }
        }


        private int _numCols;
        public int NumCols
        {
            get { return _numCols; }
            set
            {
                if (_numCols != value)
                {
                    _numCols = value;
                    RaisePropertyChanged();
                }
            }
        }


        private int _numRows;
        public int NumRows
        {
            get
            { return _numRows; }
            set
            {
                if (_numRows != value)
                {
                    _numRows = value;
                    RaisePropertyChanged();
                }
            }
        }

        private int _numBombs;
        public int NumBombs
        {
            get
            { return _numBombs; }
            set
            {
                if (_numBombs != value)
                {
                    _numBombs = value;
                    RaisePropertyChanged();
                }
            }
        }

        public void CreateMinefield()
        {/*
            NumCols = 10;
            NumRows = 3;
            NumBombs = 0;*/
            MainMinefield = new Minefield(NumCols, NumRows, NumBombs);
        }
    }
}
