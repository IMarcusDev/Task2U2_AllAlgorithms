using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2U2_AllAlgorithms.src.components.parametricCurves
{
    internal class Bezier_Algorithm
    {
        public static PointF[] CalculateBezier(IList<PointF> controlPoints, int steps = 100)
        {
            if (controlPoints == null || controlPoints.Count < 2 || controlPoints.Count > 4)
                throw new ArgumentException("Solo se permiten curvas de Bézier de grado 1 a 3 (2 a 4 puntos de control)");

            List<PointF> curvePoints = new List<PointF>();

            for (int i = 0; i <= steps; i++)
            {
                float t = i / (float)steps;
                PointF point;
                switch (controlPoints.Count)
                {
                    case 2:
                        point = BezierLinear(controlPoints[0], controlPoints[1], t);
                        break;
                    case 3:
                        point = BezierQuadratic(controlPoints[0], controlPoints[1], controlPoints[2], t);
                        break;
                    case 4:
                        point = BezierCubic(controlPoints[0], controlPoints[1], controlPoints[2], controlPoints[3], t);
                        break;
                    default:
                        point = PointF.Empty;
                        break;
                }

                curvePoints.Add(point);
            }

            return curvePoints.ToArray();
        }

        private static PointF BezierLinear(PointF p0, PointF p1, float t)
        {
            return new PointF(
                (1 - t) * p0.X + t * p1.X,
                (1 - t) * p0.Y + t * p1.Y
            );
        }

        private static PointF BezierQuadratic(PointF p0, PointF p1, PointF p2, float t)
        {
            float u = 1 - t;
            return new PointF(
                u * u * p0.X + 2 * u * t * p1.X + t * t * p2.X,
                u * u * p0.Y + 2 * u * t * p1.Y + t * t * p2.Y
            );
        }

        private static PointF BezierCubic(PointF p0, PointF p1, PointF p2, PointF p3, float t)
        {
            float u = 1 - t;
            return new PointF(
                u * u * u * p0.X + 3 * u * u * t * p1.X + 3 * u * t * t * p2.X + t * t * t * p3.X,
                u * u * u * p0.Y + 3 * u * u * t * p1.Y + 3 * u * t * t * p2.Y + t * t * t * p3.Y
            );
        }
    }
}
