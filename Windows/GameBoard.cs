public class GameBoard
{
 public int NumofCells { get; set; }
 public int NumofMines { get; set; }
 public int NumofCol { get; set; }
 public int NumofRow { get; set; }
 public int MineProb { get; set; }
 public Button[,] myBoard;
 public MinedCell Mine;
 public NumCell Square;
 public DispatcherTimer timer { get; set; }
 public Label banderas { get; set; }
 public Window father { get; set; }
 
 public List<MinedCell> placedMines = new List<MinedCell>();
 public List<NumCell> placedCells = new List<NumCell>();
 
 Uri myMine = new Uri(@"C:\Users\claudiaking\Downloads\Resources\mine.png");
 DateTime inicio;
 
 bool FirstClick = true;
 int type;
 public int MarkedMines { get; set; }
 int disabledCells { get; set; }
 
 public GameBoard(int NumofCells, int NumofMines, int NumofRow, int NumofCol, int MineProb)
 {
  this.NumofCells = NumofCells;
  this.NumofMines = NumofMines;
  this.NumofRow = NumofRow;
  this.NumofCol = NumofCol;
  this.MineProb = MineProb;
  }
  
  public void DrawBoard(WrapPanel myPanel)
  {
    MarkedMines = NumofMines;
    myBoard = new Button[NumofRow, NumofCol];
    Button myCell;
    Random randy = new Random();
    
    int index = 0;
    int minita = 0;
    
    for (int x = 0; x < NumofRow; x++)
    {
      for (int y = 0; y < NumofCol; y++)
      {
        type = randy.Next(MineProb);
        myCell = new Button();
        
        if (type == 0 & minita < NumofMines)
        {
          Mine = new MinedCell(20, myCell, x, y);
          Mine.cell.Name = "m";
          Mine.cell.Click += Cell_Click;
          Mine.cell.MouseRightButtonup += Cell_MouseRightButtonUp;
          myBoard[x,y] = Mine.cell;
          placedMines.Add(Mine);
          Mine.PlaceCell(myPanel);
          index++;
          minita++;
        }
        
        else
        {
          Square = new NumCell(20, myCell, x, y);
          Square.cell.Name = ""
        }
      }
    }
    
    foreach
  }
 
}
