using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper_Gublin.ViewModel
{
    class PlayGround : Minefield
    {

    }

    class CellViewModel : Cell
    {
        public CellViewModel(int x, int y) : base(x, y)
        {
        }
    }
}
