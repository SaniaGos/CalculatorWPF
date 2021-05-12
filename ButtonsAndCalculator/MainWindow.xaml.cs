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

namespace ButtonsAndCalculator
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
        private void NavyButton_Click(object sender, RoutedEventArgs e)
        {
            Background = Brushes.Navy;
        }
        private void BlueButton_Click(object sender, RoutedEventArgs e)
        {
            Background = Brushes.Blue;
        }
        private void AquaButton_Click(object sender, RoutedEventArgs e)
        {
            Background = Brushes.Aqua;
        }
        private void TealButton_Click(object sender, RoutedEventArgs e)
        {
            Background = Brushes.Teal;
        }
        private void OliveButton_Click(object sender, RoutedEventArgs e)
        {
            Background = Brushes.Olive;
        }
        private void GreenButton_Click(object sender, RoutedEventArgs e)
        {
            Background = Brushes.Green;
        }
        private void LimeButton_Click(object sender, RoutedEventArgs e)
        {
            Background = Brushes.Lime;
        }
        private void YellowButton_Click(object sender, RoutedEventArgs e)
        {
            Background = Brushes.Yellow;
        }
        private void OrangeButton_Click(object sender, RoutedEventArgs e)
        {
            Background = Brushes.Orange;
        }
        private void RedButton_Click(object sender, RoutedEventArgs e)
        {
            Background = Brushes.Red;
        }
        private void MaroonButton_Click(object sender, RoutedEventArgs e)
        {
            Background = Brushes.Maroon;
        }
        private void FuchsiaButton_Click(object sender, RoutedEventArgs e)
        {
            Background = Brushes.Fuchsia;
        }
        private void PurpleButton_Click(object sender, RoutedEventArgs e)
        {
            Background = Brushes.Purple;
        }
        private void BlackButton_Click(object sender, RoutedEventArgs e)
        {
            Background = Brushes.Black;
        }
        private void SilverButton_Click(object sender, RoutedEventArgs e)
        {
            Background = Brushes.Silver;
        }
        private void GrayButton_Click(object sender, RoutedEventArgs e)
        {
            Background = Brushes.Gray;
        }
        private void WhiteButton_Click(object sender, RoutedEventArgs e)
        {
            Background = Brushes.White;
        }
    }
}
