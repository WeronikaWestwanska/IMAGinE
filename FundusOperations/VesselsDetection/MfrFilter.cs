using FundusOperations.BaseClasses;
using System;
using System.Drawing;
using System.Linq;
using System.Threading;

namespace FundusOperations.VesselsDetection
{
    public class MfrFilter : FundusFilterBase
    {
        #region Attributes And Ctor

        private int _filterSize;
        private double _sigma;
        private double _fixedSegmentLength;
        private double[,,] _filterBank;
        private int _height;
        private int _width;

        private readonly int _numberOfFilters = 12;
        private readonly double _scalingFactor = 10;
        private readonly double _sigmaTruncation = 3;

        public MfrFilter(Bitmap inputBitmap, bool storeAsColor,
            int filterSize, double scalingFactor, int numberOfFilters,
            double fixedSegmentLength, double sigma, double sigmaTruncation) :
            base(inputBitmap, storeAsColor)
        {
                _filterSize = Convert.ToInt16(filterSize, Thread.CurrentThread.CurrentCulture);
                _scalingFactor = Convert.ToInt16(scalingFactor, Thread.CurrentThread.CurrentCulture);
                _numberOfFilters = numberOfFilters;
                _fixedSegmentLength = Convert.ToDouble(fixedSegmentLength, Thread.CurrentThread.CurrentCulture);
                _sigma = Convert.ToDouble(sigma, Thread.CurrentThread.CurrentCulture);
                _sigmaTruncation = Convert.ToDouble(sigmaTruncation,Thread.CurrentThread.CurrentCulture);

            _filterBank = new double[_numberOfFilters, _filterSize, _filterSize];
            for (int i = 0; i < _numberOfFilters; i++)
            {
                for (int j = 0; j < _filterSize; j++)
                {
                    for (int k = 0; k < _filterSize; k++)
                    {
                        _filterBank[i, j, k] = 0.0;
                    }
                }
            }
            _height = inputBitmap.Height;
            _width = inputBitmap.Width;

            CreateFilterBank();
        }

        #endregion // Attributes And Ctor

        #region Public Methods

        public override Bitmap Filter()
        {
            int xmin = _filterSize / 2;
            int ymin = xmin;
            int xmax = _width - xmin;
            int ymax = _height - ymin;
            int x, y;
            int dx, dy;
            int half = _filterSize / 2;
            double[] responses = new double[_numberOfFilters];
            for (x = xmin; x < xmax; x++)
            {
                Console.WriteLine("x = {0}, xmax = {1}", x, xmax);
                for (y = ymin; y < ymax; y++)
                {
                    // find max response amongst filter bank
                    for (int k = 0; k < _numberOfFilters; k++)
                    {
                        responses[k] = 0;
                        double normal = 0;
                        for (dx = -half; dx <= half; dx++)
                        {
                            for (dy = -half; dy <= half; dy++)
                            {
                                responses[k] += _filterBank[k, half + dy, half + dx] * _inputLuminance[y + dy, x + dx];
                                normal += _filterBank[k, half + dy, half + dx];
                            }
                        }
                        responses[k] /= normal;
                    }
                    _outputLuminance[y, x] = (float)responses.Max();
                }
            }

            var resultBitmap = ResultLuminanceToOutput();
            return resultBitmap;
        }

        #endregion // Public Methods

        #region Private Methods

        private void CreateFilterBank()
        {
            for (int i = 0; i < _numberOfFilters; i++)
            {
                double angle = (Math.PI / (double)_numberOfFilters) * ((double)i);
                CreateFilter(i, angle);
            }
        }

        private void CreateFilter(int filterIndex, double angle)
        {
            double u = 0, v = 0;
            double avg = 0;
            double denominator = 0;
            double x, y;
            int halfFilter = _filterSize / 2;
            for (x = -halfFilter; x <= halfFilter; x++)
            {
                for (y = -halfFilter; y <= halfFilter; y++)
                {
                    u = x * Math.Cos(angle) - y * Math.Sin(angle);
                    v = x * Math.Sin(angle) + y * Math.Cos(angle);
                    if (IsInside(u, v))
                    {
                        int row = (int)y + halfFilter;
                        int column = (int)x + halfFilter;
                        double value = -Math.Exp(-(u * u) / (2.0 * Math.Pow(_sigma, 2.0)));
                        _filterBank[filterIndex, row, column] = value;
                        avg += value;
                        denominator++;
                    }
                }
            }
            avg /= denominator;

            // scaling stuff
            for (x = -halfFilter; x <= halfFilter; x++)
            {
                for (y = -halfFilter; y <= halfFilter; y++)
                {
                    u = x * Math.Cos(angle) - y * Math.Sin(angle);
                    v = x * Math.Sin(angle) + y * Math.Cos(angle);
                    if (IsInside(u, v))
                    {
                        int row = (int)y + halfFilter;
                        int column = (int)x + halfFilter;
                        _filterBank[filterIndex, row, column] -= avg;
                        _filterBank[filterIndex, row, column] *= _scalingFactor;
                    }
                }
            }

        }

        private bool IsInside(double u, double v)
        {
            if ((Math.Abs(u) <= (_sigmaTruncation * _sigma)) &&
                (Math.Abs(v) <= (_fixedSegmentLength / 2.0)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void PrintFilterBank(int filterBank)
        {
            for (int m = 0; m < _filterSize; m++)
            {
                for (int n = 0; n < _filterSize; n++)
                {
                    Console.Write(((int)Math.Round(_filterBank[filterBank, m, n])).ToString("000") + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }


        #endregion // Private Methods
    }
}
