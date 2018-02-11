using System;
using System.Drawing;

namespace FundusOperations.ColorsConversion
{
    public class ColorChannels
    {        
        #region Attributes
         #endregion // Attributes

        #region Private Methods

        private Color GetRedChannel(Color inputColor)
        {
            var result = Color.FromArgb(inputColor.R, inputColor.R, inputColor.R);
            return result;
        }

        private Color GetBlueChannel(Color inputColor)
        {
            var result = Color.FromArgb(inputColor.B, inputColor.B, inputColor.B);
            return result;
        }

        private Color GetGreenChannel(Color inputColor)
        {
            var result = Color.FromArgb(inputColor.G, inputColor.G, inputColor.G);
            return result;
        }
        public static Color GetContrastChannel(Color inputColor, float contrast)
        {
            float factor = (259.0f * ( contrast + 255.0f) / (255.0f * (255.0f - contrast)));
            int r = inputColor.R;
            int g = inputColor.G;
            int b = inputColor.B;
            int newRed = Convert.ToInt32((factor * (float)(r - 128) + 128.0f));
            if (newRed < 0)
            {
                newRed = 0;
            }
            else
            {
                newRed = (int)(Math.Min(newRed, 255.0f));
            }
            int newGreen = Convert.ToInt32((factor * (float)(g - 128) + 128.0f));
            if (newGreen < 0)
            {
                newGreen = 0;
            }
            else
            {
                newGreen = (int)(Math.Min(newGreen, 255.0f));
            }
            int newBlue = Convert.ToInt32(factor * (float)(b - 128) + 128.0f);
            if (newBlue < 0)
            {
                newBlue = 0;
            }
            else
            {
                newBlue = (int)(Math.Min(newBlue, 255.0f));
            }

            var result = Color.FromArgb(newRed, newGreen, newBlue);
            return result;
        }
        private Color GetOhta1Channel(Color inputColor)
        {
            var result = Color.FromArgb((inputColor.R + inputColor.G + inputColor.B) / 3, (inputColor.R + inputColor.G + inputColor.B) / 3,
                                        (inputColor.R + inputColor.G + inputColor.B) / 3);
            return result;
        }

        private Color GetOhta2Channel(Color inputColor)
        {
            var result = Color.FromArgb(Math.Abs(inputColor.R - inputColor.B) , Math.Abs(inputColor.R - inputColor.B) , Math.Abs(inputColor.R - inputColor.B) );
            return result;
        }

        private Color GetOhta3Channel(Color inputColor)
        {
            var result = Color.FromArgb(Math.Abs(2 * inputColor.G - inputColor.R - inputColor.B) / 2, Math.Abs(2 * inputColor.G - inputColor.R - inputColor.B) / 2,
                                        Math.Abs(2 * inputColor.G - inputColor.R - inputColor.B) / 2);
            return result;
        }

        private Color GetLChannel(Color inputColor, LabCoordinates helper)
        {
            return helper.GetLChannel(inputColor);
        }

        private Color GetAChannel(Color inputColor, LabCoordinates helper)
        {
            return helper.GetAChannel(inputColor);
        }

        private Color GetBChannel(Color inputColor, LabCoordinates helper)
        {
            return helper.GetBChannel(inputColor);
        }

        private Color GetSChannel(Color inputColor, HsvCoordinates helper)
        {
            return helper.GetSChannel(inputColor);
        }

        private Color GetVChannel(Color inputColor, HsvCoordinates helper)
        {
            return helper.GetVChannel(inputColor);
        }

        private Bitmap SaveChannel(Image inputImage, Func<Color, Color> colorExtractionFunction)
        {
            Bitmap result = new Bitmap(inputImage.Width, inputImage.Height);

            using (Bitmap bmp = new Bitmap(inputImage))
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    for (int y = 0; y < bmp.Height; y++)
                    {
                        Color pxl = colorExtractionFunction(bmp.GetPixel(x, y));
                        result.SetPixel(x, y, pxl);
                    }
                }
            }

            return result;
        }

        private Bitmap SaveChannelLab(Image inputImage, Func<Color, LabCoordinates, Color> colorExtractionFunction)
        {
            Bitmap result = new Bitmap(inputImage.Width, inputImage.Height);

            using (Bitmap bmp = new Bitmap(inputImage))
            {
                LabCoordinates coordinates = new LabCoordinates(bmp);

                for (int x = 0; x < bmp.Width; x++)
                {
                    for (int y = 0; y < bmp.Height; y++)
                    {
                        Color pxl = colorExtractionFunction(bmp.GetPixel(x, y), coordinates);
                        result.SetPixel(x, y, pxl);
                    }
                }
            }

            return result;
        }

        private Bitmap SaveChannelHsv(Image inputImage, Func<Color, HsvCoordinates, Color> colorExtractionFunction)
        {
            Bitmap result = new Bitmap(inputImage.Width, inputImage.Height);

            using (Bitmap bmp = new Bitmap(inputImage))
            {
                HsvCoordinates coordinates = new HsvCoordinates(bmp);

                for (int x = 0; x < bmp.Width; x++)
                {
                    for (int y = 0; y < bmp.Height; y++)
                    {
                        Color pxl = colorExtractionFunction(bmp.GetPixel(x, y), coordinates);
                        result.SetPixel(x, y, pxl);
                    }
                }
            }

            return result;
        }
        private Bitmap SaveContrastChannel(Image inputImage, float contrast)
        {
            Bitmap result = new Bitmap(inputImage.Width, inputImage.Height);

            using (Bitmap bmp = new Bitmap(inputImage))
            {
                for (int i = 0; i < bmp.Width; i++)
                {
                    for (int j = 0; j < bmp.Height; j++)
                    {
                        Color pxl = GetContrastChannel(bmp.GetPixel(i, j), contrast);
                        result.SetPixel(i, j, pxl);
                    }
                }
            }
            return result;
        }

        #endregion // Private Methods

        #region Public Methods

        public Bitmap SaveRedChannel(Image inputImage)
        {
            Bitmap result = SaveChannel(inputImage, GetRedChannel);
            return result;
        }

        public Bitmap SaveBlueChannel(Image inputImage)
        {
            Bitmap result = SaveChannel(inputImage, GetBlueChannel);
            return result;
        }

        public Bitmap SaveGreenChannel(Image inputImage)
        {
            Bitmap result = SaveChannel(inputImage, GetGreenChannel);
            return result;
        }

        public Bitmap SaveContrast (Image inputImage, float contrast)
        {
            Bitmap result = SaveContrastChannel(inputImage, contrast);
            return result;
        }
  
        public Bitmap SaveOhta1Channel(Image inputImage)
        {
            Bitmap result = SaveChannel(inputImage, GetOhta1Channel);
            return result;
        }

        public Bitmap SaveOhta2Channel(Image inputImage)
        {
            Bitmap result = SaveChannel(inputImage, GetOhta2Channel);
            return result;
        }

        public Bitmap SaveOhta3Channel(Image inputImage)
        {
            Bitmap result = SaveChannel(inputImage, GetOhta3Channel);
            return result;
        }

        public Bitmap SaveLChannel(Image inputImage)
        {
            Bitmap result = SaveChannelLab(inputImage, GetLChannel);
            return result;
        }
        public Bitmap SaveAChannel(Image inputImage)
        {
            Bitmap result = SaveChannelLab(inputImage, GetAChannel);
            return result;
        }
        public Bitmap SaveBChannel(Image inputImage)
        {
            Bitmap result = SaveChannelLab(inputImage, GetBChannel);
            return result;
        }

        public Bitmap SaveSChannel(Image inputImage)
        {
            Bitmap result = SaveChannelHsv(inputImage, GetSChannel);
            return result;
        }
        public Bitmap SaveVChannel(Image inputImage)
        {
            Bitmap result = SaveChannelHsv(inputImage, GetVChannel);
            return result;
        }

        #endregion // Public Methods
    }
}
