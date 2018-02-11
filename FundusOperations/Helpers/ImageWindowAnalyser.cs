using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundusOperations.Helpers
{
    /// <summary>
    /// class with helper methods to analyse square windows of data
    /// </summary>
    public class ImageWindowAnalyser
    {
        #region Public Static Methods

        public static float GetWindowAverage(float[,] image, int y, int x, int windowSize)
        {
            double result = 0.0f;
            int half = windowSize / 2;

            for (int dx = -half; dx < half + 1; dx++)
            {
                for (int dy = -half; dy < half + 1; dy++)
                {
                    result += image[y + dy, x + dx];
                }
            }

            result = result / (windowSize * windowSize);

            return (float)result;
        }

        public static float GetWindowStandardDeviation(float[,] image, int y, int x, int windowSize, double mean)
        {
            double result = 0.0f;
            int half = windowSize / 2;
            double sumSquared = 0;

            for (int dx = -half; dx < half + 1; dx++)
            {
                for (int dy = -half; dy < half + 1; dy++)
                {
                    sumSquared += Math.Pow(image[y + dy, x + dx] - mean, 2.0f);
                }
            }

            result = sumSquared / (windowSize * windowSize - windowSize);
            result = Math.Pow(result, 0.5);

            return (float)result;
        }

        public static float Sigmoid(float arg, float mean, float standardDeviation)
        {
            double expArg = (mean - arg) / standardDeviation;
            double sigmoid = 1.0f + Math.Exp(expArg);

            return (float)(1.0f / sigmoid);
        }

        public static void MinMax(float[,] image, int rows, int columns, out float min, out float max)
        {
            min = 255.0f;
            max = 0.0f;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    min = Math.Min(image[i, j], min);
                    max = Math.Max(image[i, j], max);
                }
            }
        }

        #endregion // Public Static Methods
    }
}
