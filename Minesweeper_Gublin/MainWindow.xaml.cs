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

            //myMinefield.NumCols = 9;
            //myMinefield.NumRows = 9;

            MainUniformGrid.Rows = myMinefield.NumRows;
            MainUniformGrid.Columns = myMinefield.NumCols;

            for (int i = 0; i < myMinefield.NumCols; i++)
                for (int j = 0; j < myMinefield.NumRows; j++)
                {
                    Button btn = new Button();
                    btn.Content = i.ToString() + " " + j.ToString();

                    MainUniformGrid.Children.Add(btn);

                    Grid.SetColumn(btn, i);
                    Grid.SetRow(btn, j);

                    //MainUniformGrid.Children.Add(new Button()); Background = new SolidColorBrush(Colors.Red);
                    //this.AddChild(new Button());
                }
        }
    }
}
