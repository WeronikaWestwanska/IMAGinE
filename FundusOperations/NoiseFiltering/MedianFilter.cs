using System;
using System.Drawing;
using FundusOperations.BaseClasses;

namespace FundusOperations.NoiseFiltering
{
    public class MedianFilter : FundusFilterBase
    {
        #region Ctor

        public MedianFilter(Bitmap inputBitmap, bool storeAsColor) : base(inputBitmap, storeAsColor)
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
                    float[] medianF = new float[9];
                    int n = 0;
                    for (int k = 1; k<4; k++)
                    {
                        for(int l = 1; l < 4; l++)
                        {
                            float m = _inputLuminance[y - 2 + k, x - 2 + l];
                            medianF[n] = m;
                            n++;
                        }
                    }
                    Array.Sort(medianF);
                    float medianFilter = medianF[5];
                    Console.WriteLine("median value {0} , {1} = {2}", x, y, medianFilter);
                    _outputLuminance[y, x] = medianFilter;
                }
            }
            var resultBitmap = ResultLuminanceToOutput();
            return resultBitmap;
        }
        #endregion // Public Methods
    }
}
