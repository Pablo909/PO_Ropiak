using Microsoft.Win32;
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

namespace C09_Zad3
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

        private void TextBlock_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {

        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Uri.AbsoluteUri);
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            TextBlockCheck.Text += "Zaznaczono " + CheckBox1.Content + ".\n";
        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            TextBlockCheck.Text += "Zaznaczono " + CheckBox2.Content + ".\n";
        }

        private void CheckBox_Checked_2(object sender, RoutedEventArgs e)
        {
            TextBlockCheck.Text += "Zaznaczono " + CheckBox3.Content + ".\n";
        }

        private void BtnLoadFromFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                Uri fileUri = new Uri(openFileDialog.FileName);
                Img.Source = new BitmapImage(fileUri);
            }
        }

        private void BtnLoadFromResource_Click(object sender, RoutedEventArgs e)
        {
            Uri resourceUri = new Uri("Users/local/source/repos/C09_Zad3/lewy.jpg", UriKind.Relative);
            Img.Source = new BitmapImage(resourceUri);
        }
    }
}
