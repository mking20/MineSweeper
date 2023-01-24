public partial class MainWindow : Window
{
  public MainWindow()
  {
    InitializeComponent();
    
    Uri uri = new Uri(@"C:\Users\claudiaking\Downloads\Resources\smile.gif");
    BitmapImage bitmap = new BitmapImage(uri);
    Image imagen = new Image();
    imagen.Source = bitmap;
    elCanvas.Children.Add(image);
    Canvas.SetTop(image, 70);
    Canvas.SetLeft(image, 228);
  }
  private void btnBeginner_Click(object sender, RoutedEventArgs e)
  {
    BeginnerLevel window = new BeginnerLevel();
    window.Owner = this;
    window.Show();
    Hide();
  }
  private void btnIntermediate_Click(object sender, RoutedEventArgs e)
  {
    IntermediateLevel window = new IntermediateLevel();
    window.Owner = this;
    window.Show();
    Hide();
  }
  private void btnExpert_Click(object sender, RoutedEventArgs e)
  {
    ExpertLevel window = new ExpertLevel();
    window.Owner = this;
    window.Show();
    Hide();
  }
  private void btnHScores_Click(object sender, RoutedEventArgs e)
  {
    HighScores window = new HighScores();
    window.Owner = this;
    window.Show();
    Hide();
  }
  private void btnStart_Click(object sender, RoutedEventArgs e)
  {
    btnStart.Visibility = Visibility.Hidden;
    lblChooseLevel.Visibility = Visibility;
    btnBeginner.Visibility = Visibility;
    btnIntermediate.Visibility = Visibility.Visible;
    btnExpert.Visibility = Visibility;
    btnHScores.Visibility = Visibility.Hidden;
  }
}
