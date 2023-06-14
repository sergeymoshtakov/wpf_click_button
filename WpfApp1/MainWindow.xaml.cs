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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChangeColorButton_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            Color newColor = Color.FromRgb((byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256));

            ChangeColorButton.Background = new SolidColorBrush(newColor);
        }
    }
}
