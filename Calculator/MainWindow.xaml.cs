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

namespace Calculator
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

        private void addition(object sender, RoutedEventArgs e)
        {
            int intput1 = 0;
            int intput2 = 0;
            int.TryParse(input1.Text, out intput1);
            int.TryParse(input2.Text, out intput2);
            var button = sender as Button;
            Answer.Content = intput1 + intput2;
        }

        private void subtraction(object sender, RoutedEventArgs e)
        {
            int intput1 = 0;
            int intput2 = 0;
            int.TryParse(input1.Text, out intput1);
            int.TryParse(input2.Text, out intput2);
            var button = sender as Button;
            Answer.Content = intput1 + intput2;
        }

        private void multiply(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
        }

        private void divide(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
        }

        private void modulo(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
        }
    }
}
