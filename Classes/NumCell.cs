using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Minesweeper
{
  public calss NumCell: Cell
  {
    public Button above { get; set; }
    public Button below { get; set; }
    public Button right { get; set; }
    public Button left { get; set; }
    public Button UpLeft { get; set; }
    public Button UpRight { get; set; }
    public Button LowLeft { get; set; }
    public Button LowRight { get; set; }
    
    public int danger { get; set; }
    
    public NumCell(int size, Button cell, int x, int y) : base(size, cell, x, y)
    {
      this.size = size;
      this.cell = cell;
      this.x = x;
      this.y = y;
      cell.Height = size;
      cell.Width = size;
    }
    
    public override void PlaceCell(WrapPanel MiPanel) 
    {
      MiPanel.Children.Add(cell);
    }
    
    public void CountMines (NumCell NoMine) {}
    
  }
}
