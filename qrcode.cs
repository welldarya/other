using QRCoder;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;


namespace ____
{
    public partial class Qrcode : Window
    {
        public Qrcode()
        {
            InitializeComponent();
        }

        private void generate_qr_Click(object sender, RoutedEventArgs e)
        {
            var gen = new QRCodeGenerator();
            var code = gen.CreateQrCode("", QRCodeGenerator.ECCLevel.H);
            var image = new PngByteQRCode(code);
            var qrImage = image.GetGraphic(40);

            var btm = new BitmapImage();
            btm.BeginInit();
            btm.StreamSource = new MemoryStream(qrImage);
            btm.EndInit();
            image_qr.Source = btm;
        }
    }
}
