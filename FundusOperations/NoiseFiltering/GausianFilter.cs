using System;
using System.Drawing;
using FundusOperations.BaseClasses;

namespace FundusOperations.EdgeDetection
{
    public class GausianFilter : FundusFilterBase
    {
        #region Ctor

        public GausianFilter(Bitmap inputBitmap, bool storeAsColor) : base(inputBitmap, storeAsColor)
        {
        }

        #endregion // Ctor

        #region Public Methods

        public override Bitmap Filter()
        {
            for (int y = 1; y < _inputBitmap.Height - 1; y++)
            {
                for (int x = 1; x < _inputBitmap.Width - 1; x++)
                {
                    float g11 = _inputLuminance[y - 1, x - 1];
                    float g12 = _inputLuminance[y - 1, x];
                    float g13 = _inputLuminance[y - 1, x + 1];
                    float g21 = _inputLuminance[y, x - 1];
                    float g22 = _inputLuminance[y, x];
                    float g23 = _inputLuminance[y, x + 1];
                    float g31 = _inputLuminance[y + 1, x - 1];
                    float g32 = _inputLuminance[y + 1, x];
                    float g33 = _inputLuminance[y + 1, x + 1];
                    float gausianFilter = (float)((0.135 * g11 + 0.368 * g12 + 0.135 * g13 + 0.368 * g21
                        + g22 + 0.368 * g23 + 0.135 * g31 + 0.368 * g32 + 0.135 * g33) / 3.01285);

                    _outputLuminance[y, x] = gausianFilter;
                }
            }

            var resultBitmap = ResultLuminanceToOutput();
            return resultBitmap;
        }



        #endregion // Public Methods
    }
}
