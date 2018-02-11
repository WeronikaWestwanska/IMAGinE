using FundusOperations.BaseClasses;
using System.Drawing;

namespace FundusOperations.EdgeDetection
{
    public class LaplacianFilter : FundusFilterBase
    {
        #region Ctor

        public LaplacianFilter (Bitmap inputBitmap, bool storeAsColor) : base(inputBitmap, storeAsColor)
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
                    float l1 = _inputLuminance[y, x];
                    float l2 = _inputLuminance[y, x-1];
                    float l3 = _inputLuminance[y-1, x];
                    float l4 = _inputLuminance[y , x + 1];
                    float l5 = _inputLuminance[y + 1, x];
                    float laplacian = -4.0f*l1+l2+l3+l4+l5;

                    _outputLuminance[y, x] = laplacian;
                }
            }

            var resultBitmap = ResultLuminanceToOutput();
            return resultBitmap;
        }

        #endregion // Public Methods
    }
}
