using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace PR3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void start_Click(object sender, RoutedEventArgs e)
        {
            List<Player> players = new List<Player>();
            Game game = new Game(byte.Parse(count.Text), players);
            Questions questions = new Questions();
            Label lb1 = (Label)questions.FindName("pl1");
            Label lb2 = (Label)questions.FindName("pl2");
            Label lb3 = (Label)questions.FindName("pl3");
            Label lb4 = (Label)questions.FindName("pl4");
            if (int.Parse(count.Text) >= 2 && int.Parse(count.Text) <= 4)
            {
                Hide();
                questions.Show();
                switch (int.Parse(count.Text))
                {
                    case 2:
                        lb1.Content = $"{game.Players[0].Name}\t{game.Players[0].Score}";
                        lb1.Foreground = Brushes.DarkSeaGreen;
                        lb1.FontWeight = FontWeights.Bold;
                        lb2.Content = $"{game.Players[1].Name}\t{game.Players[1].Score}";
                        break;
                    case 3:
                        lb1.Content = $"{game.Players[0].Name}\t{game.Players[0].Score}";
                        lb1.Foreground = Brushes.DarkSeaGreen;
                        lb1.FontWeight = FontWeights.Bold;
                        lb2.Content = $"{game.Players[1].Name}\t{game.Players[1].Score}";
                        lb3.Content = $"{game.Players[2].Name}\t{game.Players[2].Score}";
                        break;
                    case 4:
                        lb1.Content = $"{game.Players[0].Name}\t{game.Players[0].Score}";
                        lb1.Foreground = Brushes.DarkSeaGreen;
                        lb1.FontWeight = FontWeights.Bold;
                        lb2.Content = $"{game.Players[1].Name}\t{game.Players[1].Score}";
                        lb3.Content = $"{game.Players[2].Name}\t{game.Players[2].Score}";
                        lb4.Content = $"{game.Players[3].Name}\t{game.Players[3].Score}";
                        break;
                }
            }
            else
            {
                MessageBox.Show("Количество игроков от 2 до 4");
            }
            game.Start();
        }

    }
}
