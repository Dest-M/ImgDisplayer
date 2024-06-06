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

namespace ImgDisplayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); 


            //InitImage();
            
        }

        //public void InitImage()
        //{
        //    var bi = new BitmapImage();
        //    bi.BeginInit();
        //    bi.UriSource = new Uri("https://i5.walmartimages.com/seo/Fresh-Gala-Apple-Each_f46d4fa7-6108-4450-a610-cc95a1ca28c5_3.38c2c5b2f003a0aafa618f3b4dc3cbbd.jpeg");
        //    bi.EndInit();

        //    //var img = new Image();
        //    image1.Source = bi;
        //}

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            notFound_Label.Content = "";
            try
            {
                var bi = new BitmapImage();
                bi.BeginInit();
                bi.UriSource = new Uri(inputText.Text);
                bi.EndInit();

                //var img = new Image();
                image1.Source = bi;
            }
            catch {
                notFound_Label.Content = "IMAGE NOT FOUND";
            }
        }
    }
}