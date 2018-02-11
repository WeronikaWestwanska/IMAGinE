using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundusOperations
{
    class GettingPixels
    {
        private System.Drawing.Color[,] GetPixels(string imagePath)
        {
            System.Drawing.Color[,] pixels = null;

            using (System.Drawing.Image image = System.Drawing.Image.FromFile(imagePath))
            {
                using (System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(image))
                {

                    pixels = new System.Drawing.Color[image.Width, image.Height];
                    for (int x = 0; x < image.Width; x++)
                    {
                        for (int y = 0; y < image.Height; y++)
                        {
                            pixels[x, y] = bitmap.GetPixel(x, y);
                        }
                    }
                }
            }

            return pixels;
        }
    }
}
