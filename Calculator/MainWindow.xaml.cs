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

    public partial class MainWindow : Window
    {
        public double _firstNumber = 0;
        double _result = 0;
        double _secondNumber = 0;
        string Znak = null;
        string allResult = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        public void OperationParams(params Button[] Numbers)
        {

        }

        private void Result_Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            forText.Text += button.Content.ToString();
            allResult += button.Content.ToString();




            try
            {

                switch (button.Content.ToString())
                {
                    case "C":
                        forText.Clear();
                        forResultLabel.Content = null;
                        break;
                    case "+":
                        if (Znak == "-")
                        {
                            _firstNumber = _firstNumber - double.Parse(forText.Text.Remove(forText.Text.Length - 1));
                            forResultLabel.Content = _firstNumber.ToString() + "+";
                            Znak = "+";
                            forText.Clear();
                            break;
                        }
                        else if (Znak == "/")
                        {
                            _firstNumber = _firstNumber / double.Parse(forText.Text.Remove(forText.Text.Length - 1));
                            forResultLabel.Content = _firstNumber.ToString() + "+";
                            Znak = "+";
                            forText.Clear();
                            break;
                        }
                        else if (Znak == "x")
                        {
                            _firstNumber = _firstNumber * double.Parse(forText.Text.Remove(forText.Text.Length - 1));
                            forResultLabel.Content = _firstNumber.ToString() + "+";
                            Znak = "+";
                            forText.Clear();
                            break;
                        }
                        else if (forResultLabel.Content != null)
                        {
                            _firstNumber = _firstNumber + double.Parse(forText.Text.Remove(forText.Text.Length - 1));
                            forResultLabel.Content = _firstNumber.ToString() + "+";
                            forText.Clear();
                            break;
                        }
                        else if (button.Content.ToString() == "+")
                        {


                            _firstNumber = double.Parse(forText.Text.Remove(forText.Text.Length - 1));
                            forResultLabel.Content = _firstNumber.ToString() + "+";
                            forText.Clear();
                            Znak = "+";
                            break;
                        }
                        else
                        {
                            MessageBox.Show("eror");
                            break;
                        }
                    case "-":
                        if (Znak == "+")
                        {
                            _firstNumber = _firstNumber + double.Parse(forText.Text.Remove(forText.Text.Length - 1));
                            forResultLabel.Content = _firstNumber.ToString() + "-";
                            Znak = "-";
                            forText.Clear();
                            break;
                        }
                        else if (Znak == "/")
                        {
                            _firstNumber = _firstNumber / double.Parse(forText.Text.Remove(forText.Text.Length - 1));
                            forResultLabel.Content = _firstNumber.ToString() + "-";
                            Znak = "-";
                            forText.Clear();
                            break;
                        }
                        else if (Znak == "x")
                        {
                            _firstNumber = _firstNumber * double.Parse(forText.Text.Remove(forText.Text.Length - 1));
                            forResultLabel.Content = _firstNumber.ToString() + "-";
                            Znak = "-";
                            forText.Clear();
                            break;
                        }
                        else if (forResultLabel.Content != null)
                        {
                            _firstNumber = _firstNumber - double.Parse(forText.Text.Remove(forText.Text.Length - 1));
                            forResultLabel.Content = _firstNumber.ToString() + "-";
                            forText.Clear();
                            break;
                        }
                        else if (button.Content.ToString() == "-")
                        {
                            _firstNumber = double.Parse(forText.Text.Remove(forText.Text.Length - 1));
                            forResultLabel.Content = _firstNumber.ToString() + "-";
                            Znak = "-";
                            forText.Clear();
                            break;
                        }
                        else
                        {
                            MessageBox.Show("eror");
                            break;
                        }
                    case "x":
                        if (Znak == "+")
                        {
                            _firstNumber = _firstNumber + double.Parse(forText.Text.Remove(forText.Text.Length - 1));
                            forResultLabel.Content = _firstNumber.ToString() + "x";
                            Znak = "x";
                            forText.Clear();
                            break;
                        }
                        else if (Znak == "/")
                        {
                            _firstNumber = _firstNumber / double.Parse(forText.Text.Remove(forText.Text.Length - 1));
                            forResultLabel.Content = _firstNumber.ToString() + "x";
                            Znak = "x";
                            forText.Clear();
                            break;
                        }
                        else if (Znak == "-")
                        {
                            _firstNumber = _firstNumber - double.Parse(forText.Text.Remove(forText.Text.Length - 1));
                            forResultLabel.Content = _firstNumber.ToString() + "x";
                            Znak = "x";
                            forText.Clear();
                            break;
                        }
                        else if (forResultLabel.Content != null)
                        {
                            _firstNumber = _firstNumber * double.Parse(forText.Text.Remove(forText.Text.Length - 1));
                            forResultLabel.Content = _firstNumber.ToString() + "x";
                            forText.Clear();
                            break;
                        }
                        if (button.Content.ToString() == "x")
                        {
                            _firstNumber = double.Parse(forText.Text.Remove(forText.Text.Length - 1));
                            forResultLabel.Content = _firstNumber.ToString() + "x";
                            Znak = "*";
                            forText.Clear();
                            break;
                        }
                        else
                        {
                            MessageBox.Show("eror");
                            break;
                        }
                    case "/":
                        if (Znak == "+")
                        {
                            _firstNumber = _firstNumber + double.Parse(forText.Text.Remove(forText.Text.Length - 1));
                            forResultLabel.Content = _firstNumber.ToString() + "/";
                            Znak = "/";
                            forText.Clear();
                            break;
                        }
                        else if (Znak == "-")
                        {
                            _firstNumber = _firstNumber - double.Parse(forText.Text.Remove(forText.Text.Length - 1));
                            forResultLabel.Content = _firstNumber.ToString() + "/";
                            Znak = "/";
                            forText.Clear();
                            break;
                        }
                        else if (Znak == "x")
                        {
                            _firstNumber = _firstNumber * double.Parse(forText.Text.Remove(forText.Text.Length - 1));
                            forResultLabel.Content = _firstNumber.ToString() + "/";
                            Znak = "/";
                            forText.Clear();
                            break;
                        }
                        else if (forResultLabel.Content != null)
                        {
                            _firstNumber = _firstNumber / double.Parse(forText.Text.Remove(forText.Text.Length - 1));
                            forResultLabel.Content = _firstNumber.ToString() + "/";
                            forText.Clear();
                            break;
                        }
                        if (button.Content.ToString() == "/")
                        {
                            _firstNumber = double.Parse(forText.Text.Remove(forText.Text.Length - 1));
                            forResultLabel.Content = _firstNumber.ToString() + "/";
                            Znak = "/";
                            forText.Clear();
                            break;
                        }
                        else
                        {
                            MessageBox.Show("eror");
                            break;
                        }
                    case "=":
                        if (Znak == "+")
                        {
                            _secondNumber = double.Parse(forText.Text.Remove(forText.Text.Length - 1));
                            _result = _firstNumber + _secondNumber;
                            forResultLabel.Content = allResult + "=" + _result.ToString();
                            break;
                        }
                        else if (Znak == "-")
                        {
                            _secondNumber = double.Parse(forText.Text.Remove(forText.Text.Length - 1));
                            _result = _firstNumber - _secondNumber;
                            forResultLabel.Content = allResult + "=" + _result.ToString();
                            break;
                        }
                        else if (Znak == "*")
                        {
                            _secondNumber = double.Parse(forText.Text.Remove(forText.Text.Length - 1));
                            _result = _firstNumber * _secondNumber;
                            forResultLabel.Content = allResult + "=" + _result.ToString();
                            break;
                        }
                        else if (Znak == "/")
                        {
                            _secondNumber = double.Parse(forText.Text.Remove(forText.Text.Length - 1));
                            _result = _firstNumber / _secondNumber;
                            forResultLabel.Content = allResult + "=" + _result.ToString();
                            break;
                        }
                        else
                        {
                            break;
                        }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Заебало вылетать");
            }



        }
    }
}
