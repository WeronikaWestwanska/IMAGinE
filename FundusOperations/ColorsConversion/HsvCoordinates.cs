using System;
using System.Drawing;

namespace FundusOperations.ColorsConversion
{
    class HsvCoordinates
    {
        public HsvCoordinates(Bitmap image)
        {
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    Color c = image.GetPixel(i, j);
                }
            }
        }

        public Color GetSChannel(Color inputColor)
        {

            int r = inputColor.R;
            int g = inputColor.G;
            int b = inputColor.B;

            double min = (double)Math.Min(Math.Min(r, g), b);
            double max = (double)Math.Max(Math.Max(r, g), b);
            if (max - min == 0)
            {
                return Color.FromArgb(0, 0, 0);
            }

            double helper = (max - min) / max;
            int intHelper = (int)Math.Round(helper * 255);
            return Color.FromArgb(intHelper, intHelper, intHelper);
        }

        public Color GetVChannel(Color inputColor)
        {
            int r = inputColor.R;
            int g = inputColor.G;
            int b = inputColor.B;

            int max = Math.Max(Math.Max(r, g), b);

            double helper = max;
            int intHelper = (int)helper;
            return Color.FromArgb(intHelper, intHelper, intHelper);
        }
    }
}
