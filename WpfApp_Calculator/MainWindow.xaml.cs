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

namespace WpfApp_Calculator
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

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (this.Width < 600)
            {
                List.Width = new GridLength(0);
                History.Visibility = Visibility.Visible;
            }
            else
            {
                List.Width = new GridLength(200);
                History.Visibility = Visibility.Hidden;
            }
        }

        private void Memory_Click(object sender, RoutedEventArgs e)
        {
            TextBlock.Text = "В памяти ничего\n не сохранено.";
        }

        private void Jornal_Click(object sender, RoutedEventArgs e)
        {
           TextBlock.Text = " 99 - 2\n 97\n 5 - 2\n 3\n 10 x 10\n 100";
        }
    }
}
