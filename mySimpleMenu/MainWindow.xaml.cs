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

using mySimpleMenu.Views;

namespace mySimpleMenu
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WorkSpace.Children.Add(new Page1());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WorkSpace.Children.Add(new Page1());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            WorkSpace.Children.Add(new Page2());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            WorkSpace.Children.Add(new Page3());
        }
    }

}
