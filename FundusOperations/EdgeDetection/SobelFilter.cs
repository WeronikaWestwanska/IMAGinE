using System;
using System.Drawing;
using FundusOperations.BaseClasses;

namespace FundusOperations.EdgeDetection
{
    public class SobelFilter : FundusFilterBase
    {
        #region Ctor

        public SobelFilter(Bitmap inputBitmap, bool storeAsColor) : base(inputBitmap, storeAsColor)
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

                    float gy11 = _inputLuminance[y - 1, x - 1];
                    float gy12 = _inputLuminance[y - 1, x];
                    float gy13 = _inputLuminance[y, x + 1];
                    float gy31 = _inputLuminance[y + 1, x - 1];
                    float gy32 = _inputLuminance[y + 1, x];
                    float gy33 = _inputLuminance[y + 1, x + 1];

                    float gx = gx11 - gx13 + 2.0f * gx21 - 2.0f * gx23 + gx31 - gx33;
                    float gy = gy11 + 2.0f * gy12 + gy13 - gy31 - 2.0f * gy32 - gy33;
                    float g = (float)Math.Sqrt(gx * gx + gy * gy);

                    _outputLuminance[y, x] = g;
                }
            }
            
            var resultBitmap = ResultLuminanceToOutput();
            return resultBitmap;
        }

        #endregion // Public Methods
    }
}
