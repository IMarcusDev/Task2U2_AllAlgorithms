using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2U2_AllAlgorithms.src.components
{
    internal class DDA_Algorithm
    {
        private Point pointInit;
        private Point pointEnd;


        public DDA_Algorithm(Point pointInit, Point pointEnd)
        {
            this.pointInit = pointInit;
            this.pointEnd = pointEnd;
        }

        public Point[] getLinePoints()
        {
            List<Point> points = new List<Point>();

            int deltaX = this.pointEnd.X - this.pointInit.X;
            int deltaY = this.pointEnd.Y - this.pointInit.Y;

            int iter = (Math.Abs(deltaX) > Math.Abs(deltaY)) ? Math.Abs(deltaX) : Math.Abs(deltaY);


            double pendiente = (deltaX != 0) ? (double)deltaY / deltaX : 0;

            points.Add(new Point(this.pointInit.X, this.pointInit.Y));

            if (Math.Abs(pendiente) >= 1)
            {
                double aux = this.pointInit.X;
                int yk = this.pointInit.Y;
                double xk = aux;
                int yStep = (deltaY > 0) ? 1 : -1;

                for (int i = 0; i < iter; i++)
                {
                    xk = aux + (1.0 / pendiente) * yStep;
                    aux = xk;
                    Point point = new Point();
                    point.X = (int)Math.Round(xk);
                    point.Y = yk + yStep;
                    yk = point.Y;

                    points.Add(point);
                }
            }
            else if (Math.Abs(pendiente) < 1 && deltaX != 0)
            {
                double aux = this.pointInit.Y;
                int xk = this.pointInit.X;
                double yk = aux;
                int xStep = (deltaX > 0) ? 1 : -1;

                for (int i = 0; i < iter; i++)
                {
                    yk = aux + pendiente * xStep;
                    aux = yk;
                    Point point = new Point();
                    point.X = xk + xStep;
                    xk = point.X;
                    point.Y = (int)Math.Round(yk);

                    points.Add(point);
                }
            }
            return points.ToArray();
        }
    }
}
