using FundusOperations.BaseClasses;
using System;
using System.Drawing;
using FundusOperations.Helpers;

namespace FundusOperations.NoiseFiltering
{
    public class ContrastEnhancementFilter : FundusFilterBase
    {
        #region Attributes And Ctor

        private int _filterSize;

        public ContrastEnhancementFilter(Bitmap inputBitmap, bool storeAsColor, int filterSize) : base(inputBitmap, storeAsColor)
        {
            _filterSize = filterSize;
            if (filterSize % 2 == 0)
            {
                throw new Exception("Filter size should be and odd number");
            }
        }

        #endregion // Attributes And Ctor

        #region Public Methods

        /// <summary>
        /// based on https://www.nature.com/articles/eye200080.pdf
        /// </summary>
        /// <returns></returns>

        public override Bitmap Filter()
        {
            Console.WriteLine("Constrast ehnancement");
            // get min and max luminance values

            ImageWindowAnalyser.MinMax(_inputLuminance, _inputBitmap.Height, _inputBitmap.Width, out var min, out var max);

            // do contrast enhancement
            int sizeHalf = _filterSize / 2;
            for (int y = sizeHalf; y < _inputBitmap.Height - sizeHalf - 1; y++)
            {
                Console.WriteLine("Processing y = {0}", y);
                for (int x = sizeHalf; x < _inputBitmap.Width - sizeHalf - 1; x++)
                {
                    // calculate average and variance
                    float mean = ImageWindowAnalyser.GetWindowAverage(_inputLuminance, y, x, _filterSize);
                    float standardDeviation = ImageWindowAnalyser.GetWindowStandardDeviation(_inputLuminance, y, x, _filterSize, mean);

                    // calculate sigmoids
                    var sigmoidXy = ImageWindowAnalyser.Sigmoid(_inputLuminance[y, x], mean, standardDeviation);
                    var sigmoidMin = ImageWindowAnalyser.Sigmoid(0.0f, mean, standardDeviation);
                    var sigmoidMax = ImageWindowAnalyser.Sigmoid(1.0f, mean, standardDeviation);

                    // normalization
                    _outputLuminance[y, x] = (255.0f * (sigmoidXy - sigmoidMin)) / (sigmoidMax - sigmoidMin);
                }
            }

            var resultBitmap = ResultLuminanceToOutput();
            return resultBitmap;
        }

        #endregion // Public Methods
    }
}
