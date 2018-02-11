using System;
using System.Drawing;
using System.Linq;
using FundusOperations.BaseClasses;

namespace FundusOperations.NoiseFiltering
{
    public class MeanFilter : FundusFilterBase
    {
        #region Ctor

        public MeanFilter(Bitmap inputBitmap, bool storeAsColor) : base(inputBitmap, storeAsColor)
        {
        }

        #endregion // Ctor

        #region Public Methods
 
        // based on http://www.algorytm.org/przetwarzanie-obrazow/filtrowanie-obrazow.html
        public override Bitmap Filter()
        {
            for (int y = 1; y < _inputBitmap.Height - 1; y++)
            {
                for (int x = 1; x < _inputBitmap.Width - 1; x++)
                {
                    float l1 = _inputLuminance[y - 1, x];
                    float l2 = _inputLuminance[y - 1, x - 1];
                    float l3 = _inputLuminance[y - 1, x + 1];
                    float l4 = _inputLuminance[y, x];
                    float l5 = _inputLuminance[y, x - 1];
                    float l6 = _inputLuminance[y, x + 1];
                    float l7 = _inputLuminance[y + 1, x];
                    float l8 = _inputLuminance[y + 1, x - 1];
                    float l9 = _inputLuminance[y + 1, x + 1];
                    float meanFilter = (l1 + l2 + l3 + l4 + l5 + l6 + l7 + l8 + l9)/9.0f;

                    _outputLuminance[y, x] = meanFilter;
                }
            }

            var resultBitmap = ResultLuminanceToOutput();
            return resultBitmap;
        }
        #endregion // Public Methods
    }
}
