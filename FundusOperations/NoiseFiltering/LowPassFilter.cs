using System;
using System.Drawing;
using FundusOperations.BaseClasses;

namespace FundusOperations.EdgeDetection
{
    public class LowPassFilter : FundusFilterBase
    {
        #region Ctor

        public LowPassFilter(Bitmap inputBitmap, bool storeAsColor) : base(inputBitmap, storeAsColor)
        {
        }

        #endregion // Ctor

        #region Public Methods

        // based on https://diffractionlimited.com/help/maximdl/Low-Pass_Filtering.htm
        public override Bitmap Filter()
        {
            for (int y = 1; y < _inputBitmap.Height - 1; y++)
            {
                for (int x = 1; x < _inputBitmap.Width - 1; x++)
                {
                    float l1 = _inputLuminance[y - 1, x];
                    float l2 = _inputLuminance[y, x - 1];
                    float l3 = _inputLuminance[y, x + 1];
                    float l4 = _inputLuminance[y + 1, x];
                    float l5 = _inputLuminance[y, x];
                    float lowPassFilter = (4.0f*l5 + (l1 + l2 + l3 + l4));

                    _outputLuminance[y, x] = lowPassFilter;
                }
            }

            var resultBitmap = ResultLuminanceToOutput();
            return resultBitmap;
        }



        #endregion // Public Methods
    }
}
