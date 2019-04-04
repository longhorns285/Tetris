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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// This program is designed to run tetris.
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MainCanvas_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down)
            {
                TetrisRectangle test = new TetrisRectangle(50, 50, Constants.WIDTH, Constants.HEIGHT);
            }

            if (e.Key == Key.Left)
            {

            }

            if (e.Key == Key.Right)
            {

            }
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
