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

        //public Minefield myMinefield { get; set; }
        public MainWindow()
        {

            InitializeComponent();
            var myMinefield = new Minefield();

            //myMinefield.NumCols = 9;
            //myMinefield.NumRows = 9;
/*
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
            */
        }

        private void Button_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var element = (Button)e.Source;

            int c = Grid.GetColumn(element);
            int r = Grid.GetRow(element);
            element.Content = c.ToString() + "_" + r.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //var b_element = (Button)e.Source;
            Cell openedCell = (Cell)((Button)sender).DataContext;
            int y = openedCell.Y;
            int x = openedCell.X;
            var curGrid = MainGrid.DataContext;
            if (openedCell.isBomb) openedCell.Title = "!!!"; else openedCell.Title = openedCell.BombCount.ToString() ;
            //((Minesweeper_Gublin.Minefield)this.MainGrid.DataContext).ChangeBackgroundColor(x, y, Colors.Aqua);
            //((Minesweeper_Gublin.Minefield)this.MainGrid.DataContext).ChangeColorOfMinedCell();



        }
    }
}
