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
        public int X { get; set; }
        public int Y { get; set; }
        public int BombQuantityAround { get; set; }
        public bool IsBomb { get; set; }
        public bool IsChecked { get; set; }

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
            X = x;
            Y = y;
            BackgroundColor = new SolidColorBrush(Colors.Green);
            IsChecked = false;
        }

        public void MarkCell()
        {
            if (!IsChecked)
                if (Title != "#") Title = "#";
                else Title = "";
        }

        public void Open()
        {
            IsChecked = true;
            if (IsBomb)
            {
                BackgroundColor = new SolidColorBrush(Colors.Red);
                Title = "Ж";
            }
            else
            {
                BackgroundColor = new SolidColorBrush(Colors.DarkKhaki);
                Title = BombQuantityAround == 0 ? "" : BombQuantityAround.ToString();
            }
        }



    }
}
