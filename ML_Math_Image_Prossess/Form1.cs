namespace ML_Math_Image_Prossess
{
    public partial class Form1 : Form
    {
        Bitmap? originalImage;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                originalImage = new Bitmap(ofd.FileName);
                // Resmi biraz küçültelim ki işlem hızlı sürsün 
                originalImage = new Bitmap(originalImage, new Size(800, 600));
                pictureBox1.Image = originalImage;
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (originalImage == null) return;

            Bitmap output = new Bitmap(originalImage.Width, originalImage.Height);

            for (int x = 1; x < originalImage.Width - 1; x++)
            {
                for (int y = 1; y < originalImage.Height - 1; y++)
                {
                    // X ve Y yönündeki renk değişimlerini (Türev) hesaplıyoruz
                    Color pixelX1 = originalImage.GetPixel(x - 1, y);
                    Color pixelX2 = originalImage.GetPixel(x + 1, y);
                    int diffX = pixelX2.R - pixelX1.R; // Kırmızı kanal farkı yeterli

                    Color pixelY1 = originalImage.GetPixel(x, y - 1);
                    Color pixelY2 = originalImage.GetPixel(x, y + 1);
                    int diffY = pixelY2.R - pixelY1.R;

                    // Pisagor ile büyüklük hesapla
                    int distance = (int)Math.Sqrt((diffX * diffX) + (diffY * diffY));

                    // Sınırları 0-255 arasına çek
                    if (distance > 255) distance = 255;
                    if (distance < 0) distance = 0;

                    // Yeni pikseli boya
                    output.SetPixel(x, y, Color.FromArgb(distance, distance, distance));
                }
            }

            pictureBox1.Image = output;
        }
    }
}
