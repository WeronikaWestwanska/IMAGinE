using System;
using System.Drawing;
using FundusOperations.BaseClasses;

namespace FundusOperations.EdgeDetection
{
    public class SobelVerticalMask : FundusFilterBase
    {
        #region Ctor

        public SobelVerticalMask(Bitmap inputBitmap, bool storeAsColor) : base(inputBitmap, storeAsColor)
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
                    float gy11 = _inputLuminance[y - 1, x - 1];
                    float gy12 = _inputLuminance[y - 1, x];
                    float gy13 = _inputLuminance[y, x + 1];
                    float gy31 = _inputLuminance[y + 1, x - 1];
                    float gy32 = _inputLuminance[y + 1, x];
                    float gy33 = _inputLuminance[y + 1, x + 1];

                    float gy = gy11 + 2.0f * gy12 + gy13 - gy31 - 2.0f * gy32 - gy33;
                    _outputLuminance[y, x] = gy;
                }
            }
            var resultBitmap = ResultLuminanceToOutput();
            return resultBitmap;
        }

        #endregion // Public Methods
    }
}
