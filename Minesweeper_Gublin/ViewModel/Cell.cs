using Minesweeper_Gublin.Helpers;

namespace Minesweeper_Gublin.ViewModel
{
    public class Cell : ObservableObject
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int BombQuantityAround { get; set; }
        public bool IsBomb { get; set; }

        private string _title;
        public string Title
        {
            get { return _title; }
            set
            {
                if (_title != value)
                {
                    _title = value;
                    RaisePropertyChanged();
                }
            }
        }

        private CellStates _state;
        public CellStates State
        {
            get { return _state; }
            set
            {
                if (_state != value)
                {
                    _state = value;
                    RaisePropertyChanged();
                }
            }
        }


        public Cell(int x, int y)
        {
            X = x;
            Y = y;
            State = CellStates.CLOSE;
        }

        public void MarkCell()
        {
            if (State == CellStates.CLOSE) State = CellStates.MARKED;
            else if (State == CellStates.MARKED) State = CellStates.CLOSE;
        }

        public void Open()
        {
            if (State == CellStates.CLOSE || State == CellStates.MARKED)
            {
                if (IsBomb)
                    State = CellStates.OPEN_BOMB;
                else
                {
                    Title = BombQuantityAround == 0 ? "" : BombQuantityAround.ToString();
                    State = CellStates.OPEN_CLEAR;
                }
            }
        }

    }
}
