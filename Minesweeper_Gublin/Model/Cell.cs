using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Minesweeper_Gublin.Helpers;

namespace Minesweeper_Gublin
{
    public class Cell : ObservableObject
    {
        private int _x;
        public int X { get; set; }

        private int _y;
        public int Y { get; set; }
        public int BombCount { get; set; }
        public bool isBomb { get; set; }

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

        private SolidColorBrush _backgroundColor;
        public SolidColorBrush BackgroundColor
        {
            get { return _backgroundColor; }
            set
            {
                if (_backgroundColor != value)
                {
                    _backgroundColor = value;
                    RaisePropertyChanged();
                }
            }
        }
        public Cell(int x, int y)
        {
            //Title = x.ToString() + " " + y.ToString();
            this.X = x;
            this.Y = y;
            BackgroundColor = new SolidColorBrush(Colors.Green);
        }
    }
}
