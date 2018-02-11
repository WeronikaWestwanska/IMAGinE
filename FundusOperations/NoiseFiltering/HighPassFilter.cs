using System;
using System.Drawing;
using FundusOperations.BaseClasses;

namespace FundusOperations.EdgeDetection
{
    public class HighPassFilter : FundusFilterBase
    {
        #region Ctor

        public HighPassFilter(Bitmap inputBitmap, bool storeAsColor) : base(inputBitmap, storeAsColor)
        {
        }

        #endregion // Ctor

        #region Public Methods

        // based on https://diffractionlimited.com/help/maximdl/High-Pass_Filtering.htm
        public override Bitmap Filter()
        {
            for (int y = 1; y < _inputBitmap.Height - 1; y++)
            {
                for (int x = 1; x < _inputBitmap.Width - 1; x++)
                {
                    float l1 = _inputLuminance[y, x];
                    float l2 = _inputLuminance[y, x - 1];
                    float l3 = _inputLuminance[y - 1, x];
                    float l4 = _inputLuminance[y, x + 1];
                    float l5 = _inputLuminance[y + 1, x];
                    float highPassFilter = 2.0f * l1 - 0.25f * (l2 + l3 + l4 + l5);

                    _outputLuminance[y, x] = highPassFilter;
                }
            }

            var resultBitmap = ResultLuminanceToOutput();
            return resultBitmap;
        }



        #endregion // Public Methods
    }
}
