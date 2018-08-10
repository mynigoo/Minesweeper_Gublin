using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Minesweeper.ViewModel;

namespace Minesweeper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }


        private void UserControl_MouseRightClick(object sender, MouseButtonEventArgs e)
        {
            ((Cell)((UserControl)sender).DataContext).MarkCell();
        }

        private void UserControl_MouseLeftClick(object sender, MouseButtonEventArgs e)
        {
            ((GameSuperviser)(gameSuperviser.DataContext)).MainMinefield.CellCheck(
                (Cell)((UserControl)sender).DataContext
                );

        }
    }
}
