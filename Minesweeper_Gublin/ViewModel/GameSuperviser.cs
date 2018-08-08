using Minesweeper_Gublin.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper_Gublin.ViewModel
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
        public int NumBombs { get; set; }

        private bool _stopp;

        public bool Stopp
        {
            get { return _stopp; }
            set
            {
                if (_stopp != value)
                {
                    _stopp = value;
                    RaisePropertyChanged();
                }
            }
        }

        public GameSuperviser()
        {
            Stopp = true;
        }

        public void CreateMinefield()
        {
            NumCols = 20;
            NumRows = 2;
            NumBombs = 5;
            MainMinefield = new Minefield(NumCols, NumRows, NumBombs);
            Stopp = false;

        }
    }
}
