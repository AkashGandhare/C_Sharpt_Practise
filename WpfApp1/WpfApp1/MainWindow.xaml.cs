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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {

            
                var num1 = 0;
                var num2 = 0;
                var result = 0;
                var operation = "";

                num1 = Convert.ToInt32(num1_box.Text);
                num2 = Convert.ToInt32(num2_box.Text);
                operation = operation_box.Text;

                switch(operation)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;

                    case "/":
                        result = num1 / num2;
                        break;

                    case "%":
                        result = num1 % num2;
                        break;                

                    default:
                        result = 0;
                        break;

                }

                result_box.Text = Convert.ToString(result);
                result_box.Background = Brushes.Green;
            } catch
            {
                result_box.Text = "Valid for Integers only";
                result_box.Background = Brushes.Red;

            }            

        }

    }
}
