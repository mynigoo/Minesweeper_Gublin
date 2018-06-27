﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Minesweeper_Gublin.ViewModel;

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
            ((Minefield)this.MainGrid.DataContext)
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