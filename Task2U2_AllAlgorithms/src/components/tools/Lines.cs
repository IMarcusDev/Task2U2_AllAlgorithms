using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2U2_AllAlgorithms.src.components.tools
{
    internal class Lines
    {
        public static PointF InterseccionSimple(PointF p1, PointF p2, PointF p3, PointF p4)
        {
            PointF interseccion;

            bool vertical1 = (p2.X - p1.X == 0);
            bool vertical2 = (p4.X - p3.X == 0);

            if (vertical1 && vertical2)
            {
                return new PointF();
            }
            else if (vertical1)
            {
                float x = p1.X;
                float m2 = (p4.Y - p3.Y) / (p4.X - p3.X);
                float b2 = p3.Y - m2 * p3.X;
                float y = m2 * x + b2;
                return new PointF(x, y);
            }
            else if (vertical2)
            {
                float x = p3.X;
                float m1 = (p2.Y - p1.Y) / (p2.X - p1.X);
                float b1 = p1.Y - m1 * p1.X;
                float y = m1 * x + b1;
                return new PointF(x, y);
            }
            else
            {
                float m1 = (p2.Y - p1.Y) / (p2.X - p1.X);
                float b1 = p1.Y - m1 * p1.X;

                float m2 = (p4.Y - p3.Y) / (p4.X - p3.X);
                float b2 = p3.Y - m2 * p3.X;

                if (Math.Abs(m1 - m2) < 1e-6)
                {
                    return new PointF();
                }

                float x = (b2 - b1) / (m1 - m2);
                float y = m1 * x + b1;

                interseccion = new PointF(x, y);
                return interseccion;
            }
        }
    }
}
