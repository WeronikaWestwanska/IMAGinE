using System.Drawing;
using Accord.Imaging;

namespace FundusOperations.BaseClasses
{
    public abstract class FundusFilterBase
    {
        #region Attributes And Ctor

        protected int[,] _inputHue;
        protected float[,] _inputSaturation;
        protected float[,] _inputLuminance;
        protected float[,] _outputLuminance;
        protected Bitmap _inputBitmap;
        protected bool storeAsColor;

        public FundusFilterBase(Bitmap inputBitmap, bool storeAsColor)
        {
            this.storeAsColor = storeAsColor;
            _inputBitmap = inputBitmap;
            _inputLuminance = new float[_inputBitmap.Height, _inputBitmap.Width];
            _inputHue = new int[_inputBitmap.Height, _inputBitmap.Width];
            _inputSaturation = new float[_inputBitmap.Height, _inputBitmap.Width];
            _outputLuminance = new float[_inputBitmap.Height, _inputBitmap.Width];

            for (int x = 0; x < _inputBitmap.Width; x++)
            {
                for (int y = 0; y < _inputBitmap.Height; y++)
                {
                    var pixelInMask = inputBitmap.GetPixel(x, y);
                    RGB rgbInMask = new RGB(pixelInMask);
                    HSL hslInMask = HSL.FromRGB(rgbInMask);
                    float luminanceOfPixelInMask = hslInMask.Luminance;
                    _inputLuminance[y, x] = luminanceOfPixelInMask;
                    _inputHue[y, x] = hslInMask.Hue;
                    _inputSaturation[y, x] = hslInMask.Saturation;
                }
            }
        }

        #endregion // Attributes And Ctor

        #region Protected Methods

        protected Bitmap ResultLuminanceToOutput()
        {
            Bitmap result = null;
            if (this.storeAsColor)
            {
                result = ResultLuminanceToOutputBitmapAsColor();
            }
            else
            {
                result = ResultLuminanceToOutputBitmapAsGrey();
            }

            return result;
        }

        protected Bitmap ResultLuminanceToOutputBitmapAsGrey()
        {
            // normalize luminance
            float max = float.MinValue;
            float min = float.MaxValue;

            // data for normalization from 0 to 255
            for (int x = 0; x < _inputBitmap.Width; x++)
            {
                for (int y = 0; y < _inputBitmap.Height; y++)
                {
                    if (_outputLuminance[y, x] > max) max = _outputLuminance[y, x];
                    if (_outputLuminance[y, x] < min) min = _outputLuminance[y, x];
                }
            }

            Bitmap resultBitmap = new Bitmap(_inputBitmap);

            for (int x = 0; x < _inputBitmap.Width; x++)
            {
                for (int y = 0; y < _inputBitmap.Height; y++)
                {
                    // make it grey
                    byte grey = (byte)(((_outputLuminance[y, x] - min) / (max - min)) * 255.0f);
                    Color color = Color.FromArgb(grey, grey, grey);
                    resultBitmap.SetPixel(x, y, color);
                }
            }

            return resultBitmap;
        }

        protected Bitmap ResultLuminanceToOutputBitmapAsColor()
        {
            // normalize luminance
            float max = float.MinValue;
            float min = float.MaxValue;

            // data for normalization from 0 to 255
            for (int x = 0; x < _inputBitmap.Width; x++)
            {
                for (int y = 0; y < _inputBitmap.Height; y++)
                {
                    if (_outputLuminance[y, x] > max) max = _outputLuminance[y, x];
                    if (_outputLuminance[y, x] < min) min = _outputLuminance[y, x];
                }
            }

            Bitmap resultBitmap = new Bitmap(_inputBitmap);

            for (int x = 0; x < _inputBitmap.Width; x++)
            {
                for (int y = 0; y < _inputBitmap.Height; y++)
                {
                    // make it color
                    var luminanceOutputScaledFrom0to1 = (_outputLuminance[y, x] - min) / (max - min);
                    HSL hslOutput = new HSL()
                    {
                        Luminance = luminanceOutputScaledFrom0to1,
                        Saturation = _inputSaturation[y, x],
                        Hue = _inputHue[y, x]
                    };
                    RGB rgbOutput = new RGB();
                    HSL.ToRGB(hslOutput, rgbOutput);
                    Color color = Color.FromArgb(rgbOutput.Red, rgbOutput.Green, rgbOutput.Blue);
                    resultBitmap.SetPixel(x, y, color);
                }
            }

            return resultBitmap;
        }

        #endregion // Protected Methods

        #region Public Methods

        public virtual Bitmap Filter()
        {
            return null;
        }

        #endregion 
    }
}
