using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Minesweeper_Gublin
{
    public class Cell
    {
        public int x { get; set; }
        public int y { get; set; }
        public bool isBomb { get; set; }
        public string Coord { get; set; }

        public SolidColorBrush BackgroundColor { get; set; }
        public Cell(int x, int y)
        {
            Coord = x.ToString() + " " + y.ToString();
            this.x = x;
            this.y = y;
            BackgroundColor = new SolidColorBrush(Colors.Green);
        }
    }
}
