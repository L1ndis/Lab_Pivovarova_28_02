using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) //ВыйтиX
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) //Готово
        {

        }




        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            AlgoritmFrame.Navigate(new Page1());
            AlgoritmLineyni.Navigate(new Page2());
        }
    }
}
