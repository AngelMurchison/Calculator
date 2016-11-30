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

        private void additionLogic(object sender, RoutedEventArgs e)
        {
            int intput1 = 0;
            int intput2 = 0;
            // parsing user input from the 2 textboxes into integers.
            int.TryParse(input1.Text, out intput1);
            int.TryParse(input2.Text, out intput2);
            // placing the result of the operation into the label Answer
            Answer.Content = intput1 + intput2;
        }

        private void subtractionLogic(object sender, RoutedEventArgs e)
        {
            int intput1 = 0;
            int intput2 = 0;
            int.TryParse(input1.Text, out intput1);
            int.TryParse(input2.Text, out intput2);
            var button = sender as Button;
            Answer.Content = intput1 - intput2;
        }

        private void multiplyLogic(object sender, RoutedEventArgs e)
        {
            int intput1 = 0;
            int intput2 = 0;
            int.TryParse(input1.Text, out intput1);
            int.TryParse(input2.Text, out intput2);
            var button = sender as Button;
            Answer.Content = intput1 * intput2;
        }

        private void divideLogic(object sender, RoutedEventArgs e)
        {
            int intput1 = 0;
            int intput2 = 0;
            int.TryParse(input1.Text, out intput1);
            int.TryParse(input2.Text, out intput2);
            var button = sender as Button;
            Answer.Content = intput1 / intput2;
        }

        private void moduloLogic(object sender, RoutedEventArgs e)
        {
            int intput1 = 0;
            int intput2 = 0;
            int.TryParse(input1.Text, out intput1);
            int.TryParse(input2.Text, out intput2);
            var button = sender as Button;
            Answer.Content = intput1 % intput2;
        }
    }
}
