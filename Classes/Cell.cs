using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Minesweeper
{
  public abstract class Cell
  {
    public int size { get; set; }
    public int x { get; set; }//row
    public int y { get; set; }//column
    public Button cell = new Button();
    
    public Cell(int size, Button cell, int x, int y)
    {
      this.size = size;
      this.cell = cell;
      this.x = x;
      this.y = y;
      cell.Height = size;
      cell.Width = size;
    }
    
    public abstract void PlaceCell(WrapPanel myPanel);
  }
}
