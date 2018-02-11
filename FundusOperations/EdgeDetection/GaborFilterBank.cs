using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;
using FundusOperations.BaseClasses;
using FundusOperations.Helpers;

namespace FundusOperations.EdgeDetection
{
    public class GaborFilterBank : FundusFilterBase
    {
        #region Ctor

        public GaborFilterBank(Bitmap inputBitmap, bool storeAsColor) : base(inputBitmap, storeAsColor)
        {
        }

        #endregion // Ctor

        #region Public Methods

        public Image Filter(string size, string lambda, string filterBankCount, string psi, string sigma, string gamma)
        {
            Image result = null;
            if (_inputBitmap == null)
            {
                return result;
            }

            Bitmap input = Accord.Imaging.Image.Clone(_inputBitmap, PixelFormat.Format24bppRgb);

            Cursor.Current = Cursors.WaitCursor;

            GaborFilter filter = new GaborFilter();
            try
            {
                filter.Size = Convert.ToInt16(size, Thread.CurrentThread.CurrentCulture);
                filter.Lambda = Double.Parse(lambda, Thread.CurrentThread.CurrentCulture);
                filter.Psi = Double.Parse(psi, Thread.CurrentThread.CurrentCulture);
                filter.Sigma = Double.Parse(sigma, Thread.CurrentThread.CurrentCulture);
                filter.Gamma = Double.Parse(gamma, Thread.CurrentThread.CurrentCulture);
            }
            catch (FormatException)
            {
                MessageBox.Show("FormatException");
            }
            catch (OverflowException)
            {
                MessageBox.Show("OverflowException");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Choose another set of values. The one you have chosen is invalid.");
            }

            Cursor.Current = Cursors.Default;

            result = FilterByGaborBank(filter, input, Int32.Parse(filterBankCount));

            return result;
        }

        #endregion // Public Static Methods

        #region Private Methods

        private Bitmap FilterByGaborBank(GaborFilter filter, Bitmap inputBitmap, int gaborFilterCount)
        {
            ImagesNormalizer imagesNormalizer = new ImagesNormalizer(inputBitmap);

            double radiansStep = 2.0d * Math.PI / ((double)gaborFilterCount);
            for (double radians = 0.0d; radians < 2.0d * Math.PI; radians += radiansStep)
            {
                Console.WriteLine("Processing gabor by angle = {0}", radians);
                // perform Gabor filtering and add result to a sum of other maps
                filter.Theta = radians;
                Bitmap outputBitmap = filter.Apply(inputBitmap);
                imagesNormalizer.AddBitmap(outputBitmap);
            }

            // normalize all added filters into one image in luminance channel
            Bitmap result = imagesNormalizer.Normalize();
            return result;
        }

        #endregion // Private Methods
    }
}
