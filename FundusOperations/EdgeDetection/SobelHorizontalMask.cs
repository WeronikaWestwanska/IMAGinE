using System;
using System.Drawing;
using FundusOperations.BaseClasses;

namespace FundusOperations.EdgeDetection
{
    public class SobelHorizontalMask : FundusFilterBase
    {
        #region Ctor

        public SobelHorizontalMask(Bitmap inputBitmap, bool storeAsColor) : base(inputBitmap, storeAsColor)
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
                    float gx11 = _inputLuminance[y - 1, x - 1];
                    float gx13 = _inputLuminance[y - 1, x + 1];
                    float gx21 = _inputLuminance[y, x - 1];
                    float gx23 = _inputLuminance[y, x + 1];
                    float gx31 = _inputLuminance[y + 1, x - 1];
                    float gx33 = _inputLuminance[y + 1, x + 1];

                    float gx = gx11 - gx13 + 2.0f * gx21 - 2.0f * gx23 + gx31 - gx33;
                    _outputLuminance[y, x] = gx;
                }
            }
            var resultBitmap = ResultLuminanceToOutput();
            return resultBitmap;
        }

        #endregion // Public Methods
    }
}
