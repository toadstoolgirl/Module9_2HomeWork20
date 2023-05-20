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
using System.Xml.Linq;

namespace Module9_2HomeWork20
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Start(object sender, RoutedEventArgs e)
        {
                MessageBox.Show(
                    "Start typing",
                    this.Title,
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Information
                    );
        }

        private void Button_Separate(object sender, RoutedEventArgs e)
        {
            string[] filling = inputPhrase.Text.Split(' ');

            outputPhrase.ItemsSource = filling;
            
        }

        private void Button_Revert(object sender, RoutedEventArgs e)
        {
            string[] filling = inputPhrase.Text.Split(' ');
            Array.Reverse(filling);
            foreach (var sub in filling)
            {
                var t = String.Join(' ', filling);

            }
            outputPhrase.ItemsSource = filling;
        }
    }
}
