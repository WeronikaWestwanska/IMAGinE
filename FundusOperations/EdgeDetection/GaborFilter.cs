using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using Accord.Imaging;
using Accord.Imaging.Filters;
using Accord.Math;

namespace FundusOperations.EdgeDetection
{
    internal class GaborFilter : BaseFilter
    {
        private Dictionary<PixelFormat, PixelFormat> formatTranslations
            = new Dictionary<PixelFormat, PixelFormat>();

        private double[,] kernel;

        private int size = 7; // kernel size
        private double lambda = 4.0; // wavelength
        private double theta = 0.6; // orientation
        private double psi = 0.0; // phase offset
        private double sigma = 2.0; // Gaussian variance
        private double gamma = 1.0; // aspect ratio

        bool recompute = true;

        /// <summary>
        ///   Gets or sets the size of the filter. Default is 3.
        /// </summary>
        /// 
        public int Size
        {
            get { return size; }
            set
            {
                size = value;
                recompute = true;
            }
        }

        /// <summary>
        ///   Gets or sets the Gaussian variance for the filter. Default is 2.
        /// </summary>
        /// 
        public double Sigma
        {
            get { return sigma; }
            set
            {
                sigma = value;
                recompute = true;
            }
        }

        /// <summary>
        ///   Gets or sets the orientation for the filter, in radians. Default is 0.6.
        /// </summary>
        /// 
        public double Theta
        {
            get { return theta; }
            set
            {
                theta = value;
                recompute = true;
            }
        }

        /// <summary>
        ///   Gets or sets the wavelength for the filter. Default is 4.0.
        /// </summary>
        /// 
        public double Lambda
        {
            get { return lambda; }
            set
            {
                lambda = value;
                recompute = true;
            }
        }

        /// <summary>
        ///   Gets or sets the aspect ratio for the filter. Default is 0.3.
        /// </summary>
        /// 
        public double Gamma
        {
            get { return gamma; }
            set
            {
                gamma = value;
                recompute = true;
            }
        }

        /// <summary>
        ///   Gets or sets the phase offset for the filter. Default is 1.0.
        /// </summary>
        /// 
        public double Psi
        {
            get { return psi; }
            set
            {
                psi = value;
                recompute = true;
            }
        }

        /// <summary>
        ///   Initializes a new instance of the <see cref="GaborFilter"/> class.
        /// </summary>
        /// 
        public GaborFilter()
        {
            formatTranslations[PixelFormat.Format8bppIndexed] = PixelFormat.Format8bppIndexed;
            formatTranslations[PixelFormat.Format24bppRgb] = PixelFormat.Format24bppRgb;
            recompute = true;
        }


        /// <summary>
        ///   Format translations dictionary.
        /// </summary>
        /// 
        public override Dictionary<PixelFormat, PixelFormat> FormatTranslations
        {
            get { return formatTranslations; }
        }

        /// <summary>
        ///   Process the filter on the specified image.
        /// </summary>
        /// 
        /// <param name="sourceData">Source image data.</param>
        /// <param name="destinationData">Destination image data.</param>
        /// 
        protected unsafe override void ProcessFilter(UnmanagedImage sourceData, UnmanagedImage destinationData)
        {
            // check image format
            if ((sourceData.PixelFormat != PixelFormat.Format8bppIndexed) &&
                (sourceData.PixelFormat != PixelFormat.Format24bppRgb))
                throw new UnsupportedImageFormatException("Unsupported image format.");

            if (sourceData.PixelFormat != PixelFormat.Format8bppIndexed)
            {
                sourceData = Grayscale.CommonAlgorithms.BT709.Apply(sourceData);
            }

            if (recompute)
            {
                recompute = false;
                kernel = Gabor.Kernel2D(size: size,
                    lambda: lambda,
                    theta: theta,
                    psi: psi,
                    sigma: sigma,
                    gamma: gamma,
                    normalized: true,
                    function: GaborKernelKind.Real);
            }

            int kernelHeight = kernel.GetLength(0);
            int kernelWidth = kernel.GetLength(1);

            int centerX = kernelHeight / 2;
            int centerY = kernelWidth / 2;

            int width = sourceData.Width;
            int height = sourceData.Height;

            int srcStride = sourceData.Stride;
            int srcOffset = srcStride - width;

            byte* src = (byte*)sourceData.ImageData.ToPointer();


            double[,] response = new double[height, width];

            double max = Double.MinValue;
            double min = Double.MaxValue;

            // for each image row
            for (int y = 0; y < height; y++)
            {
                // for each pixel in the row
                for (int x = 0; x < width; x++, src++)
                {
                    double sum = 0;

                    // for each kernel row
                    for (int i = 0; i < kernelHeight; i++)
                    {
                        int ir = i - centerY;
                        int t = y + ir;

                        // skip row
                        if (t < 0)
                            continue;

                        // break
                        if (t >= height)
                            break;

                        int col = ir * srcStride;

                        // for each kernel value in the row
                        for (int j = 0; j < kernelWidth; j++)
                        {
                            int jr = j - centerX;
                            t = x + jr;

                            // skip column
                            if (t < 0)
                                continue;

                            if (t < width)
                            {
                                double k = kernel[i, j];
                                sum += k * src[col + jr];
                            }
                        }

                        double v = response[y, x] = sum;

                        if (v > max)
                        {
                            max = v;
                        }
                        if (v < min)
                        {
                            min = v;
                        }
                    }
                }

                src += srcOffset;
            }

            byte* dst = (byte*)destinationData.ImageData.ToPointer();
            int pixelSize = System.Drawing.Image.GetPixelFormatSize(destinationData.PixelFormat) / 8;
            int dstStride = destinationData.Stride;
            int dstOffset = dstStride - width * pixelSize;

            Standardize(response, min, max, height, width);

            // for each image row
            for (int y = 0; y < height; y++)
            {
                // for each pixel in the row
                for (int x = 0; x < width; x++, dst += pixelSize)
                {
                    byte v = (byte)response[y, x];
                    dst[RGB.R] = v;
                    dst[RGB.G] = v;
                    dst[RGB.B] = v;
                }

                dst += dstOffset;
            }
        }

        private void Standardize(double[,] input, double min, double max, int height, int width)
        {
            for (int row = 0; row < height; row++)
            {
                for (int column = 0; column < width; column++)
                {
                    input[row, column] = (input[row, column] - min) / (max - min);
                    input[row, column] = input[row, column] * 255.0;
                }
            }
        }
    }

}
