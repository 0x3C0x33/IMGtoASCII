using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IMGtoASCII {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            inicio();
        }

        private void inicio() {
            this.Title = "Image to ASCII";
            
        }

        private void btnLoadImage_Click(object sender, RoutedEventArgs e) {
            var dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.FileName = "Image";

            bool? result = dialog.ShowDialog();

            if (result == true) {
                string filename = dialog.FileName;
                imgImagen.Source = new BitmapImage(new Uri(filename));
            }
        }

        private void btnGenerateHtml_Click(object sender, RoutedEventArgs e) {
            
        }

        private void btnConvertToPNG_Click(object sender, RoutedEventArgs e) {

        }
    }
}