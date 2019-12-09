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

namespace Zad2
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double parsedValue;
            if (!double.TryParse(TextBoxWprowadzanie1.Text, out parsedValue) || !double.TryParse(TextBoxWprowadzanie2.Text, out parsedValue))
            {
                MessageBox.Show("Tylko liczby");
                return;
            }
            else
            {
                double wynik = double.Parse(TextBoxWprowadzanie1.Text) + double.Parse(TextBoxWprowadzanie2.Text);
                TextBoxWynik.Text = wynik.ToString();
            }
        }

        private void ButtonOdejmowanie_Click(object sender, RoutedEventArgs e)
        {
            double parsedValue;
            if (!double.TryParse(TextBoxWprowadzanie1.Text, out parsedValue) || !double.TryParse(TextBoxWprowadzanie2.Text, out parsedValue))
            {
                MessageBox.Show("Tylko liczby");
                return;
            }
            else
            {
                double wynik = double.Parse(TextBoxWprowadzanie1.Text) - double.Parse(TextBoxWprowadzanie2.Text);
                TextBoxWynik.Text = wynik.ToString();
            }
        }

        private void ButtonMnozenie_Click(object sender, RoutedEventArgs e)
        {
            double parsedValue;
            if (!double.TryParse(TextBoxWprowadzanie1.Text, out parsedValue) || !double.TryParse(TextBoxWprowadzanie2.Text, out parsedValue))
            {
                MessageBox.Show("Tylko liczby");
                return;
            }
            else
            {
                double wynik = double.Parse(TextBoxWprowadzanie1.Text) * double.Parse(TextBoxWprowadzanie2.Text);
                TextBoxWynik.Text = wynik.ToString();
            }
        }

        private void ButtonDzielenie_Click(object sender, RoutedEventArgs e)
        {
            double parsedValue;
            if (!double.TryParse(TextBoxWprowadzanie1.Text, out parsedValue) || !double.TryParse(TextBoxWprowadzanie2.Text, out parsedValue))
            {
                MessageBox.Show("Tylko liczby");
                return;
            }
            else
            {
                if (double.Parse(TextBoxWprowadzanie2.Text) != 0)
                {
                    double wynik = double.Parse(TextBoxWprowadzanie1.Text) / double.Parse(TextBoxWprowadzanie2.Text);
                    TextBoxWynik.Text = wynik.ToString();
                }
                else
                    MessageBox.Show("Nie dziel przez 0");
            }
        }
    }
}
