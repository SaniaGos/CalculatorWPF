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
    public enum PrevAction
    {
        none, Add, Minus, Multipl, Division, Equal
    }
    public partial class MainWindow : Window
    {
        private PrevAction action;
        private bool clear;
        private double equal;
        private double tmp;
        public MainWindow()
        {
            InitializeComponent();
            equal = 0;
            tmp = 0;
            action = PrevAction.Add;
            clear = false;
        }
        private void ButtonCE_Click(object sender, RoutedEventArgs e)
        {
            textBoxEqual.Text = "0";
        }
        private void ButtonC_Click(object sender, RoutedEventArgs e)
        {
            Esc();
        }
        private void Button_Digits(object sender, RoutedEventArgs e)
        {
            Digit(Convert.ToChar((sender as Button).Content));
        }
        private void ButtonAction(object sender, RoutedEventArgs e)
        {
            if (sender is Button)
            {
                var button = sender as Button;
                if (button.Content.ToString() == "*") Multipl();
                else if (button.Content.ToString() == "/") Division();
                else if (button.Content.ToString() == "+") Add();
                else if (button.Content.ToString() == "-") Minus();
                else if (button.Content.ToString() == "=") Equal();
            }
        }
        private void ButtonPoint_Click(object sender, RoutedEventArgs e)
        {
            Point();
        }
        private void ButtonBackspace_Click(object sender, RoutedEventArgs e)
        {
            BackSpase();
        }
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            int tmp = Convert.ToInt32(e.Key);
            if (tmp >= 74 && tmp <= 83) Digit((char)(tmp - 26));
            else if (tmp == 88) Point();
            else if (tmp == 6) Equal();
            else if (tmp == 85) Add();
            else if (tmp == 87) Minus();
            else if (tmp == 89) Division();
            else if (tmp == 84) Multipl();
            else if (tmp == 2) BackSpase();
            else if (tmp == 13) Esc();
        }


        private void Action()
        {
            switch (action)
            {
                case PrevAction.Add:
                    equal += tmp;
                    break;
                case PrevAction.Minus:
                    equal -= tmp;
                    break;
                case PrevAction.Multipl:
                    equal *= tmp;
                    break;
                case PrevAction.Division:
                    equal /= tmp;
                    break;
                default:
                    break;
            }
        }
        private void Digit(char sumbol)
        {
            if (action != PrevAction.Equal)
            {
                if (clear || textBoxEqual.Text == "0")
                {
                    textBoxEqual.Text = "";
                    clear = false;
                }
                if (textBoxEqual.Text.Length >= 9) return;
                if (textBoxEqual.Text == "-0")
                {
                    textBoxEqual.Text = "-" + sumbol.ToString();
                }
                else
                {
                    textBoxEqual.Text += sumbol.ToString();
                }
                tmp = Convert.ToDouble(textBoxEqual.Text);
            }
        }
        private void Esc()
        {
            equal = 0;
            tmp = 0;
            action = PrevAction.Add;
            clear = false;
            textBoxEqual.Text = "0";
            textBoxActivity.Text = "";
        }
        private void BackSpase()
        {
            if (textBoxEqual.Text.Length > 1)
                textBoxEqual.Text = textBoxEqual.Text.Remove(textBoxEqual.Text.Length - 1);
            else textBoxEqual.Text = "0";
            tmp = Convert.ToDouble(textBoxEqual.Text);
        }
        private void Point()
        {
            if (textBoxEqual.Text.Length == 0)
            {
                textBoxEqual.Text = "0,";
            }
            else
            {
                textBoxEqual.Text += ",";
            }
            tmp = Convert.ToDouble(textBoxEqual.Text);
        }
        private void Add()
        {
            if (action == PrevAction.Equal) textBoxActivity.Text += " + ";
            else if (textBoxEqual.Text.Length != 0 && !clear)
            {
                textBoxActivity.Text += (textBoxEqual.Text + " + ");
                textBoxEqual.Text = "";
            }
            else textBoxActivity.Text = textBoxActivity.Text.Remove(textBoxActivity.Text.Length - 3) + " + ";
            Action();
            action = PrevAction.Add;
            clear = true;
            tmp = 0;
            textBoxEqual.Text = Convert.ToString(equal);
        }
        private void Minus()
        {
            if (action == PrevAction.Equal) textBoxActivity.Text += " + ";
            else if (textBoxEqual.Text.Length != 0 && !clear)
            {
                textBoxActivity.Text += (textBoxEqual.Text + " - ");
                textBoxEqual.Text = "";
            }
            else textBoxActivity.Text = textBoxActivity.Text.Remove(textBoxActivity.Text.Length - 3) + " - ";
            Action();
            action = PrevAction.Minus;
            clear = true;
            tmp = 0;
            textBoxEqual.Text = Convert.ToString(equal);
        }
        private void Multipl()
        {
            if (action == PrevAction.Equal) textBoxActivity.Text += " * ";
            else if (textBoxEqual.Text.Length != 0 && !clear)
            {
                textBoxActivity.Text += (textBoxEqual.Text + " * ");
                textBoxEqual.Text = "";
            }
            else textBoxActivity.Text = textBoxActivity.Text.Remove(textBoxActivity.Text.Length - 3) + " * ";
            Action();
            action = PrevAction.Multipl;
            clear = true;
            tmp = 0;
            textBoxEqual.Text = Convert.ToString(equal);
        }
        private void Division()
        {
            if (action == PrevAction.Equal) textBoxActivity.Text += " / ";
            else if (textBoxEqual.Text.Length != 0 && !clear)
            {
                textBoxActivity.Text += (textBoxEqual.Text + " / ");
                textBoxEqual.Text = "";
            }
            else textBoxActivity.Text = textBoxActivity.Text.Remove(textBoxActivity.Text.Length - 3) + " / ";
            Action();
            action = PrevAction.Division;
            clear = true;
            tmp = 0;
            textBoxEqual.Text = Convert.ToString(equal);
        }
        private void Equal()
        {
            if (action != PrevAction.Equal && action != PrevAction.none)
            {
                Action();
                action = PrevAction.Equal;
                textBoxActivity.Text = Convert.ToString(equal);
                textBoxEqual.Text = Convert.ToString(equal);
                tmp = Convert.ToDouble(textBoxEqual.Text);
            }
        }
    }
}
