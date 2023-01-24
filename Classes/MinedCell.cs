using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Minesweeper
{
  public class MinedCell : Cell
  {
    public MinedCell(int size, Button cell, int x, int y) : base(size, cell, x, y)
    {
      this.size = size;
      this.cell = cell;
      this.x = x;
      this.y ) y;
      cell.Height = size;
      cell.Width = size;
    }
    
    public override void PlaceCell(WrapPanel myPanel)
    {
      myPanel.Children.Add(cell);
    }
  }
}
