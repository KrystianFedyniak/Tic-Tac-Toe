using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Reflection;
using System.Media;

namespace Tic_Tac_Toe
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        
        

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            LabelName.Content = Assembly.GetExecutingAssembly().GetName().Name.ToString();
            LabelVersion.Content = "Version" + " " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
            LabelCreator.Content = "Created by Fedyniak Krystian";


        }

        public void Sound()
        {
            SoundPlayer sp = new SoundPlayer();
            sp.Stream = Properties.Resources._1;
            sp.Play();
        }

        private void AboutImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Sound();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
