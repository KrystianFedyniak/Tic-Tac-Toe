using System.Media;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Tic_Tac_Toe
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string player;
        private Button[] B;
        bool Win = false;

        public MainWindow()
        {
            player = "X";
            InitializeComponent();
            B = new Button[9];
            B[0] = Button1;
            B[1] = Button2;
            B[2] = Button3;
            B[3] = Button4;
            B[4] = Button5;
            B[5] = Button6;
            B[6] = Button7;
            B[7] = Button8;
            B[8] = Button9;
        }
        public void Sound()
        {
            SoundPlayer BC = new SoundPlayer();
            BC.Stream = Properties.Resources.button1;
            BC.Play();
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Sound();

            Button B1 = (Button)sender;
            if (B1.Content != "X" && B1.Content != "O")
            {
                B1.Content = player;
                if (player == "X") player = "O";
                else player = "X";

                if (player == "X")
                {
                    B1.Foreground = new SolidColorBrush(Color.FromRgb(12, 0, 255));
                }
                else
                {
                    B1.Foreground = new SolidColorBrush(Color.FromRgb(255, 0, 0)); ;
                }

                label1.Content = ($"Player {player}");
                WinCheck();
            }
        }

        public void WinCheck()
        {


            // Horisontal Winner Check
            if ((B[0].Content == B[1].Content) && (B[1].Content == B[2].Content) && (B[0].Content != "") && (B[1].Content != "") && (B[2].Content != ""))
            {
                Win = true;
                B[0].Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                B[1].Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                B[2].Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            }

            else if ((B[3].Content == B[4].Content) && (B[4].Content == B[5].Content) && (B[3].Content != "") && (B[4].Content != "") && (B[5].Content != ""))
            {
                Win = true;
                B[3].Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                B[4].Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                B[5].Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));

            }
            else if ((B[6].Content == B[7].Content) && (B[7].Content == B[8].Content) && (B[6].Content != "") && (B[7].Content != "") && (B[8].Content != ""))
            {
                Win = true;
                B[6].Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                B[7].Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                B[8].Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            }

            // Vertical Winner Check
            if ((B[0].Content == B[3].Content) && (B[3].Content == B[6].Content) && (B[0].Content != "") && (B[3].Content != "") && (B[6].Content != ""))
            {
                Win = true;
                B[0].Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                B[3].Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                B[6].Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            }
            else if ((B[1].Content == B[4].Content) && (B[4].Content == B[7].Content) && (B[1].Content != "") && (B[4].Content != "") && (B[7].Content != ""))
            {
                Win = true;
                B[1].Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                B[4].Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                B[7].Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            }
            else if ((B[2].Content == B[5].Content) && (B[5].Content == B[8].Content) && (B[2].Content != "") && (B[5].Content != "") && (B[8].Content != ""))
            {
                Win = true;
                B[2].Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                B[5].Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                B[8].Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            }

            // Diagonal Winner Check
            if ((B[0].Content == B[4].Content) && (B[4].Content == B[8].Content) && (B[0].Content != "") && (B[4].Content != "") && (B[8].Content != ""))
            {
                Win = true;
                B[0].Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                B[4].Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                B[8].Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            }
            else if ((B[2].Content == B[4].Content) && (B[4].Content == B[6].Content) && (B[2].Content != "") && (B[4].Content != "") && (B[6].Content != ""))
            {
                Win = true;
                B[2].Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                B[4].Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                B[6].Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            }


            if (Win == true)
            {
                if (player == "X")
                {
                    player = "O";
                }
                else
                {
                    player = "X";
                }
                var result = MessageBox.Show($"Player {player} Win", "Congratulations", MessageBoxButton.OK, MessageBoxImage.Information);
                if (result == MessageBoxResult.OK)
                {
                    Win = false;
                    this.ResetButton_Click(null, null);

                }
            }


        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            player = "X";
            label1.Content = "Player X";


            Button1.Content = "";
            Button2.Content = "";
            Button3.Content = "";
            Button4.Content = "";
            Button5.Content = "";
            Button6.Content = "";
            Button7.Content = "";
            Button8.Content = "";
            Button9.Content = "";

            B[0].Background = new SolidColorBrush(Color.FromRgb(221, 221, 221));
            B[1].Background = new SolidColorBrush(Color.FromRgb(221, 221, 221));
            B[2].Background = new SolidColorBrush(Color.FromRgb(221, 221, 221));

            B[3].Background = new SolidColorBrush(Color.FromRgb(221, 221, 221));
            B[4].Background = new SolidColorBrush(Color.FromRgb(221, 221, 221));
            B[5].Background = new SolidColorBrush(Color.FromRgb(221, 221, 221));

            B[6].Background = new SolidColorBrush(Color.FromRgb(221, 221, 221));
            B[7].Background = new SolidColorBrush(Color.FromRgb(221, 221, 221));
            B[8].Background = new SolidColorBrush(Color.FromRgb(221, 221, 221));
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            var ExitResult = MessageBox.Show("Close application", "Exit", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (ExitResult == MessageBoxResult.Yes)
            {
                this.Close();

            }

        }

        private void AboutButton_Click(object sender, RoutedEventArgs e)
        {
            Window1 b = new Window1();
            b.ShowDialog();
        }
    }
}
