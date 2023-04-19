using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace PM04
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private bool IsTextMinMaxValueValid(string Text, int MinLength, int MaxLength)
        {
            bool result = true;

            if (Text.Length < MinLength || Text.Length > MaxLength)
                result = false;

            return result;
        }

        private bool IsTextContainNumber(string Text)
        {
            return Text.All(x => Char.IsDigit(x));
        }

        private void CityTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;

            if (!IsTextMinMaxValueValid(textBox.Text, 2, 25))
            {
                CityTextBox.Foreground = new SolidColorBrush(Color.FromRgb(255, 0, 0));
            }

            else
                CityTextBox.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
        }

        private void StreetTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;

            if (!IsTextMinMaxValueValid(textBox.Text, 10, 50))
            {
                StreetTextBox.Foreground = new SolidColorBrush(Color.FromRgb(255, 0, 0));
            }

            else
                StreetTextBox.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
        }

        private void EmailIndexTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;

            if (!IsTextContainNumber(textBox.Text))
            {
                EmailIndexTextBox.Foreground = new SolidColorBrush(Color.FromRgb(255, 0, 0));
            }

            else
                EmailIndexTextBox.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
        }

        private void EmailIndexTextBox_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void EmailIndexTextBox_KeyDown(object sender, KeyEventArgs e)
        {
        }
    }
}
