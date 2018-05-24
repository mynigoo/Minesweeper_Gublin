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

namespace Minesweeper_Gublin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            var myMinefield = new Minefield();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ((Minesweeper_Gublin.Minefield)this.MainGrid.DataContext)
                .CellCheck(
                (Cell)((Button)sender).DataContext
                );
        }

        private void Button_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            ((Cell)((Button)sender).DataContext).MarkCell();
        }

    }
}
