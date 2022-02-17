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
        double _resTmp = 0;
        string Znak = null;
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
            forResultLabel.Content += button.Content.ToString();





            try
            {

                switch (button.Content.ToString())
                {
                    case "C":
                        forText.Clear();
                        forResultLabel.Content = null;
                        break;
                    case "+":
                        if (button.Content.ToString() == "+")
                        {
                            
                            string tmp = forText.Text.Remove(forText.Text.Length - 1);
                            _firstNumber = Convert.ToDouble(tmp);
                            Znak = "+";
                            forText.Clear();
                            break;
                        }
                        else
                        {
                            MessageBox.Show("eror");
                            break;
                        }
                    case "-":
                        if (button.Content.ToString() == "-")
                        {
                            string tmp = forText.Text.Remove(forText.Text.Length - 1);
                            _firstNumber = Convert.ToDouble(tmp);
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
                        if (button.Content.ToString() == "x")
                        {
                            string tmp = forText.Text.Remove(forText.Text.Length - 1);
                            _firstNumber = Convert.ToDouble(tmp);
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
                        if (button.Content.ToString() == "/")
                        {
                            string tmp = forText.Text.Remove(forText.Text.Length - 1);
                            _firstNumber = Convert.ToDouble(tmp);
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
                            string tmp = forText.Text.Remove(forText.Text.Length - 1);
                            _result = _firstNumber + Convert.ToDouble(tmp);
                            _resTmp += _result + Convert.ToDouble(tmp);
                            forResultLabel.Content = _resTmp.ToString();
                            break;
                        }
                        else if (Znak == "-")
                        {
                            string tmp = forText.Text.Remove(forText.Text.Length - 1);
                            _result = _firstNumber - Convert.ToDouble(tmp);
                            forResultLabel.Content = _result.ToString();
                            break;
                        }
                        else if (Znak == "*")
                        {
                            string tmp = forText.Text.Remove(forText.Text.Length - 1);
                            _result = _firstNumber * Convert.ToDouble(tmp);
                            forResultLabel.Content = _result.ToString();
                            break;
                        }
                        else if (Znak == "/")
                        {
                            string tmp = forText.Text.Remove(forText.Text.Length - 1);
                            _result = _firstNumber / Convert.ToDouble(tmp);
                            forResultLabel.Content = _result.ToString();
                            break;
                        }
                        else
                        {
                            break;
                        }


                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            switch (button.Content)
            {
                case "%":
                    _result = Convert.ToDouble(forText.Text) / 100;
                    break;


            }

        }
    }
}
