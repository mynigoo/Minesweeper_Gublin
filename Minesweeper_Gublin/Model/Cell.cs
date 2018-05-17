using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper_Gublin
{
    public class Cell
    {
        public int x { get; set; }
        public int y { get; set; }
        public bool isBomb { get; set; }
        public string Coord { get; set; }
        public Cell(int x, int y)
        {
            Coord = x.ToString() + " " + y.ToString();
        }
    }
}
