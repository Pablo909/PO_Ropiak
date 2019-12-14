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

namespace Kalkulator
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

        private void ComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            // ... lista
            List<string> data = new List<string>();
            data.Add("Dodawanie");
            data.Add("Odejmowanie");
            data.Add("Mnożenie");
            data.Add("Dzielenie");

            // ... ustawienie referencji
            var comboBox = sender as ComboBox;

            // ... ustawienie zródla
            comboBox.ItemsSource = data;

            // ... czy cos domyslnie ma byc wybrane
            comboBox.SelectedIndex = 0;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // ... dostep do combo.
            var comboBox = sender as ComboBox;

            // ... ustawiemy wybraną opcję jako tytul okna
            string value = comboBox.SelectedItem as string;
            this.Title = "Selected: " + value;
        }

        private void ButtonPolicz_Click(object sender, RoutedEventArgs e)
        {
            double parsedValue;
            if (!double.TryParse(TextBoxWprowadzanie1.Text, out parsedValue) || !double.TryParse(TextBoxWprowadzanie2.Text, out parsedValue))
            {
                MessageBox.Show("Tylko liczby");
                return;
            }
            double x = double.Parse(TextBoxWprowadzanie1.Text);
            double y = double.Parse(TextBoxWprowadzanie2.Text);
            if(ComboBoxWybor.SelectedItem.ToString() == "Dodawanie")
            {
                TextBoxWynik.Text = Dzialania.Dodawanie(x, y);
            }
            if (ComboBoxWybor.SelectedItem.ToString() == "Odejmowanie")
            {
                TextBoxWynik.Text = Dzialania.Odejmowanie(x, y);
            }
            if (ComboBoxWybor.SelectedItem.ToString() == "Mnożenie")
            {
                TextBoxWynik.Text = Dzialania.Mnozenie(x, y);
            }
            if (ComboBoxWybor.SelectedItem.ToString() == "Dzielenie")
            {
                TextBoxWynik.Text = Dzialania.Dzielenie(x, y);
            }

        }
    }
}
