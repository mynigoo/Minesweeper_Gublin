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

        public int NumCols { get; set; }
        public int NumRows { get; set; }
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
            MainMinefield = new Minefield(9, 9, 10);
            Stopp = false;

        }
    }
}
