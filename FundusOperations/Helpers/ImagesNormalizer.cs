using System;
using System.Drawing;
using Accord.Imaging;

namespace FundusOperations.Helpers
{
    internal class ImagesNormalizer
    {
        #region Attributes And Ctor

        public Bitmap OriginalImage { get; private set; }

        // matrix with Value channel (or L from HSV/HSL)
        // indexed with row, column
        private float[,] Matrix { get; set; }

        public ImagesNormalizer(Bitmap image)
        {
            OriginalImage = image;
            Matrix = new float[image.Height, image.Width];

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    var pixel = image.GetPixel(x, y);
                    RGB rgb = new RGB(pixel);
                    Matrix[y, x] = HSL.FromRGB(rgb).Luminance;
                }
            }
        }

        #endregion // Attributes And Ctor

        #region Public Methods

        public void AddBitmap(Bitmap anotherLayer)
        {
            for (int y = 0; y < OriginalImage.Height; y++)
            {
                for (int x = 0; x < OriginalImage.Width; x++)
                {
                    var pixel = anotherLayer.GetPixel(x, y);
                    RGB rgb = new RGB(pixel);
                    Matrix[y, x] += HSL.FromRGB(rgb).Luminance;
                }
            }
        }

        public Bitmap Normalize()
        {
            float max = float.MinValue;
            float min = float.MaxValue;
            for (int y = 0; y < OriginalImage.Height; y++)
            {
                for (int x = 0; x < OriginalImage.Width; x++)
                {
                    if (Matrix[y, x] < min) min = Matrix[y, x];
                    if (Matrix[y, x] > max) max = Matrix[y, x];
                }
            }

            for (int y = 0; y < OriginalImage.Height; y++)
            {
                for (int x = 0; x < OriginalImage.Width; x++)
                {
                    Matrix[y, x] = ((Matrix[y, x] - min) / (max - min));
                }
            }

            var resultBitmap = new Bitmap(OriginalImage);
            for (int y = 0; y < OriginalImage.Height; y++)
            {
                for (int x = 0; x < OriginalImage.Width; x++)
                {
                    // make it grey
                    byte grey = (byte)(Matrix[y, x] * 255.0f);
                    Color color = Color.FromArgb(grey, grey, grey);
                    resultBitmap.SetPixel(x, y, color);
                }
            }

            return resultBitmap;
        }

        #endregion // Public Methods
    }
}
