using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2U2_AllAlgorithms.src.components
{
    internal class Bresenham_Lines_Algorithm
    {
        private Point pointInit;
        private Point pointEnd;

        public Bresenham_Lines_Algorithm(Point pointInit, Point pointEnd)
        {
            this.pointInit = pointInit;
            this.pointEnd = pointEnd;
        }

        public Point[] getBresenhamPoints()
        {
            var points = new List<Point>();

            int x0 = pointInit.X;
            int y0 = pointInit.Y;
            int x1 = pointEnd.X;
            int y1 = pointEnd.Y;

            int dx = Math.Abs(x1 - x0);
            int dy = Math.Abs(y1 - y0);

            int sx = x0 < x1 ? 1 : -1;
            int sy = y0 < y1 ? 1 : -1;

            int p = dx - dy;

            while (true)
            {
                points.Add(new Point(x0, y0));
                if (x0 == x1 && y0 == y1) break;
                int p2 = 2 * p;
                if (p2 >= -dy)
                {
                    p -= dy;
                    x0 += sx;
                }
                if (p2 < dx)
                {
                    p += dx;
                    y0 += sy;
                }
            }

            return points.ToArray();
        }
    }
}
