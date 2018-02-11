using System;
using System.Drawing;
using FundusOperations.BaseClasses;

namespace FundusOperations.EdgeDetection
{
    public class MedianLightnessEqualisationFilter : FundusFilterBase
    {
        #region Ctor
        private int _filterSize;

        public MedianLightnessEqualisationFilter(Bitmap inputBitmap, bool storeAsColor, int filterSize) : base(inputBitmap, storeAsColor)
        {
            _filterSize = filterSize;
        }

        #endregion // Ctor

        #region Public Methods

        /// <summary>
        /// median filter luminance equalization
        /// </summary>
        /// <returns></returns>

        public override Bitmap Filter()
        {
            Console.WriteLine("median filter: ");
            float[] window = new float[_filterSize * _filterSize];
            int offset = _filterSize / 2;
            for (int y = offset; y < _inputBitmap.Height - offset; y++)
            {
                Console.WriteLine("Median filter y = {0}", y);
                for (int x = offset; x < _inputBitmap.Width - offset; x++)
                {
                    // find median in window
                    int i = 0;
                    for (int deltaY = -offset; deltaY < offset; deltaY++)
                    {
                        for (int deltaX = -offset; deltaX < offset + 1; deltaX++)
                        {
                            window[i] = _inputLuminance[y + deltaY, x + deltaX];
                            i++;
                        }
                    }

                    Array.Sort(window);
                    // take middle value after sorting
                    var medianValue = window[_filterSize * _filterSize / 2];
                    _outputLuminance[y, x] -= _inputLuminance[y,x] -  medianValue;
                }
            }

            var resultBitmap = ResultLuminanceToOutput();
            return resultBitmap;
        }

        #endregion // Public Methods
    }
}
