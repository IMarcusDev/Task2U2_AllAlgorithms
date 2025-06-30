using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2U2_AllAlgorithms.src.components.parametricCurves
{
    internal class BSplines_Algorithm
    {
        public static PointF[] BSplineCurve(PointF[] controlPoints, int degree = 3, int steps = 100)
        {
            int n = controlPoints.Length - 1;
            int m = n + degree + 1;

            List<float> knotVector = new List<float>();
            for (int i = 0; i <= m; i++)
            {
                if (i <= degree)
                    knotVector.Add(0f);
                else if (i >= m - degree)
                    knotVector.Add(1f);
                else
                    knotVector.Add((float)(i - degree) / (m - 2 * degree));
            }

            List<PointF> curvePoints = new List<PointF>();
            float uStart = knotVector[degree];
            float uEnd = knotVector[n + 1];

            for (int i = 0; i <= steps; i++)
            {
                float u = uStart + (uEnd - uStart) * i / steps;

                int spanIdx;
                for (spanIdx = degree; spanIdx < n + 1; spanIdx++)
                {
                    if (u >= knotVector[spanIdx] && u < knotVector[spanIdx + 1])
                        break;
                }
                if (u == knotVector[n + 1]) spanIdx = n;

                List<PointF> d = new List<PointF>();
                for (int j = 0; j <= degree; j++)
                    d.Add(controlPoints[spanIdx - degree + j]);

                for (int r = 1; r <= degree; r++)
                {
                    for (int j = degree; j >= r; j--)
                    {
                        int idx = spanIdx - degree + j;
                        float alpha = (u - knotVector[idx]) / (knotVector[idx + degree - r + 1] - knotVector[idx]);

                        d[j] = new PointF(
                            (1 - alpha) * d[j - 1].X + alpha * d[j].X,
                            (1 - alpha) * d[j - 1].Y + alpha * d[j].Y
                        );
                    }
                }

                curvePoints.Add(Point.Round(d[degree]));
            }

            return curvePoints.ToArray();
        }
    }
}
