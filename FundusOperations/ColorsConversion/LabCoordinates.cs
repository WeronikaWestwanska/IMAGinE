using System;
using System.Drawing;

namespace FundusOperations
{
    // https://en.wikipedia.org/wiki/CIE_1931_color_space
    // https://en.wikipedia.org/wiki/Lab_color_space
    public class LabCoordinates
    {
        private readonly double x0;
        private readonly double y0;
        private readonly double z0;

        private static readonly double delta = 6.0 / 29.0;
        private readonly double max = Math.Pow(delta, 3);

        private double minl = Double.MaxValue;
        private double maxl = Double.MinValue;

        private double mina = Double.MaxValue;
        private double maxa = Double.MinValue;

        private double minb = Double.MaxValue;
        private double maxb = Double.MinValue;

        private double f(double x)
        {
            if (x > max)
            {
                return Math.Pow(x, 0.333);
            }
            else
            {
                return x / (3.0 * delta * delta) + 4.0 / 29.0;
            }
        }

        private double GetX(int r, int g, int b)
        {
            double result = (1 / 0.17697) * (0.490 * r + 0.310 * g + 0.200 * b);
            return result;
        }

        private double GetY(int r, int g, int b)
        {
            double result = (1 / 0.17697) * (0.17697 * r + 0.81240 * g + 0.010630 * b);
            return result;
        }

        private double GetZ(int r, int g, int b)
        {
            double result = (1 / 0.17697) * (0.000 * r + 0.01000 * g + 0.99900 * b);
            return result;
        }

        public LabCoordinates(Bitmap image)
        {
            x0 = GetX(95, 95, 95);
            y0 = GetY(100, 100, 100);
            z0 = GetZ(109, 109, 109);

            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    Color c = image.GetPixel(i, j);
                    double l = GetLChannelInternal(c);
                    double a = GetAChannelInternal(c);
                    double b = GetBChannelInternal(c);

                    if (l > maxl)
                    {
                        maxl = l;
                    }
                    if (l < minl)
                    {
                        minl = l;
                    }
                    if (a > maxa)
                    {
                        maxa = a;
                    }
                    if (a < mina)
                    {
                        mina = a;
                    }
                    if (b > maxb)
                    {
                        maxb = b;
                    }
                    if (b < minb)
                    {
                        minb = b;
                    }
                }
            }
        }

        private double GetLChannelInternal(Color inputColor)
        {
            double y = GetY(inputColor.R, inputColor.G, inputColor.B);
            double helper = 116.0 * f(y / y0) - 16.0;

            return helper;
        }

        private double GetAChannelInternal(Color inputColor)
        {
            double x = GetX(inputColor.R, inputColor.G, inputColor.B);
            double y = GetY(inputColor.R, inputColor.G, inputColor.B);
            double helper = 500.0 * (f(x / x0) - f(y / y0));

            return helper;
        }

        private double GetBChannelInternal(Color inputColor)
        {
            double y = GetY(inputColor.R, inputColor.G, inputColor.B);
            double z = GetZ(inputColor.R, inputColor.G, inputColor.B);
            double helper = 200.0 * (f(y / y0) - f(z / z0));

            return helper;
        }

        public Color GetLChannel(Color inputColor)
        {
            var l = GetLChannelInternal(inputColor);
            var scaledL = ((l - minl) / (maxl - minl)) * 255.0;
            int intScaledL = (int)scaledL;

            return Color.FromArgb(intScaledL, intScaledL, intScaledL);
        }

        public Color GetAChannel(Color inputColor)
        {
            var a = GetAChannelInternal(inputColor);
            var scaledA = ((a - mina) / (maxa - mina)) * 255.0;
            int intScaledA = (int)scaledA;

            return Color.FromArgb(intScaledA, intScaledA, intScaledA);
        }

        public Color GetBChannel(Color inputColor)
        {
            var b = GetBChannelInternal(inputColor);
            var scaledB = ((b - minb) / (maxb - minb)) * 255.0;
            int intScaledB = (int)scaledB;

            return Color.FromArgb(intScaledB, intScaledB, intScaledB);
        }
    }
}
