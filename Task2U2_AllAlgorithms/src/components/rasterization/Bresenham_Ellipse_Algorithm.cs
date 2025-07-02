using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2U2_AllAlgorithms.src.components
{
    internal class Bresenham_Ellipse_Algorithm
    {
        public static void DrawEllipse(int xc, int yc, int rx, int ry, Action<int, int> drawPixel)
        {
            int x = 0;
            int y = ry;

            int rx2 = rx * rx;
            int ry2 = ry * ry;

            int twoRx2 = 2 * rx2;
            int twoRy2 = 2 * ry2;

            int px = 0;
            int py = twoRx2 * y;

            int p1 = (int)(ry2 - (rx2 * ry) + 0.25 * rx2);
            while (px < py)
            {
                DrawSymmetricPixels(xc, yc, x, y, drawPixel);

                x++;
                px += twoRy2;

                if (p1 < 0)
                {
                    p1 += ry2 + px;
                }
                else
                {
                    y--;
                    py -= twoRx2;
                    p1 += ry2 + px - py;
                }
            }

            int p2 = (int)(ry2 * (x + 0.5f) * (x + 0.5f) + rx2 * (y - 1) * (y - 1) - rx2 * ry2);
            while (y >= 0)
            {
                DrawSymmetricPixels(xc, yc, x, y, drawPixel);

                y--;
                py -= twoRx2;

                if (p2 > 0)
                {
                    p2 += rx2 - py;
                }
                else
                {
                    x++;
                    px += twoRy2;
                    p2 += rx2 - py + px;
                }
            }
        }

        private static void DrawSymmetricPixels(int xc, int yc, int x, int y, Action<int, int> drawPixel)
        {
            drawPixel(xc + x, yc + y);
            drawPixel(xc - x, yc + y);
            drawPixel(xc + x, yc - y);
            drawPixel(xc - x, yc - y);
        }
    }

}
