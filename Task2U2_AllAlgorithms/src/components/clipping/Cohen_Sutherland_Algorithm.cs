using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2U2_AllAlgorithms.src.components.tools;

namespace Task2U2_AllAlgorithms.src.components.clipping
{
    internal class Cohen_Sutherland_Algorithm
    {
        public static PointF[] clippingCohenSutherlandAlgorithm(List<PointF> points, PointF[] pointsCanvas)
        {
            List<PointF> clipedPoints = new List<PointF>();
            if (points.Count % 2 != 0)
                points.RemoveAt(points.Count - 1);

            float minX = pointsCanvas.Min(pt => pt.X);
            float maxX = pointsCanvas.Max(pt => pt.X);
            float minY = pointsCanvas.Min(pt => pt.Y);
            float maxY = pointsCanvas.Max(pt => pt.Y);

            int auxIndex = 0;
            for (int i = 0; i < points.Count / 2; i++)
            {
                auxIndex = (i == 0) ? i + 1 : (i * 2) + 1;

                PointF p1 = points[auxIndex - 1];
                PointF p2 = points[auxIndex];

                string codeP1 = GetRegionCode(p1, minX, maxX, minY, maxY);
                string codeP2 = GetRegionCode(p2, minX, maxX, minY, maxY);

                bool out1 = codeP1 != "0000";
                bool out2 = codeP2 != "0000";

                if (!out1 && !out2)
                {
                    clipedPoints.Add(p2);
                    clipedPoints.Add(p1);
                }
                else if (out1 && out2)
                {
                    var (edgeP1Start, edgeP1End) = GetClippingEdge(codeP1, minX, maxX, minY, maxY);
                    var (edgeP2Start, edgeP2End) = GetClippingEdge(codeP2, minX, maxX, minY, maxY);

                    if (edgeP1Start != PointF.Empty && edgeP1End != PointF.Empty)
                    {
                        PointF inter1 = Lines.InterseccionSimple(p1, p2, edgeP1Start, edgeP1End);
                        if (inter1 != PointF.Empty)
                            clipedPoints.Add(inter1);
                    }

                    if (edgeP2Start != PointF.Empty && edgeP2End != PointF.Empty)
                    {
                        PointF inter2 = Lines.InterseccionSimple(p1, p2, edgeP2Start, edgeP2End);
                        if (inter2 != PointF.Empty)
                            clipedPoints.Add(inter2);
                    }
                }
                else if (out1 ^ out2)
                {
                    int insideIdx = !out1 ? auxIndex - 1 : auxIndex;
                    int outsideIdx = out1 ? auxIndex - 1 : auxIndex;

                    PointF inside = points[insideIdx];
                    PointF outside = points[outsideIdx];

                    var borders = GetBorders(outside, minX, maxX, minY, maxY);
                    PointF? inter = GetIntersectionWithBorders(p1, p2, borders);

                    if (inter.HasValue)
                    {
                        clipedPoints.Add(inside);
                        clipedPoints.Add(inter.Value);
                    }
                }
            }

            return clipedPoints.ToArray();
        }

        private static string GetRegionCode(PointF p, float minX, float maxX, float minY, float maxY)
        {
            bool top = p.Y > maxY;
            bool bottom = p.Y < minY;
            bool right = p.X > maxX;
            bool left = p.X < minX;

            return $"{(top ? 1 : 0)}{(bottom ? 1 : 0)}{(right ? 1 : 0)}{(left ? 1 : 0)}";
        }

        private static (PointF, PointF) GetClippingEdge(string code, float minX, float maxX, float minY, float maxY)
        {
            if (code == "1001" || code == "0001" || code == "0101")
                return (new PointF(minX, minY), new PointF(minX, maxY)); // Left
            else if (code == "1010" || code == "0010" || code == "0110")
                return (new PointF(maxX, minY), new PointF(maxX, maxY)); // Right
            else if (code == "1000")
                return (new PointF(minX, maxY), new PointF(maxX, maxY)); // Top
            else if (code == "0100")
                return (new PointF(minX, minY), new PointF(maxX, minY)); // Bottom
            else
                return (PointF.Empty, PointF.Empty);
        }


        private static List<(PointF, PointF)> GetBorders(PointF p, float minX, float maxX, float minY, float maxY)
        {
            List<(PointF, PointF)> borders = new List<(PointF, PointF)>();

            if (p.Y > maxY)
                borders.Add((new PointF(minX, maxY), new PointF(maxX, maxY))); // Top
            if (p.Y < minY)
                borders.Add((new PointF(minX, minY), new PointF(maxX, minY))); // Bottom
            if (p.X > maxX)
                borders.Add((new PointF(maxX, minY), new PointF(maxX, maxY))); // Right
            if (p.X < minX)
                borders.Add((new PointF(minX, minY), new PointF(minX, maxY))); // Left

            return borders;
        }

        private static PointF? GetIntersectionWithBorders(PointF p1, PointF p2, List<(PointF, PointF)> borders)
        {
            foreach (var (b1, b2) in borders)
            {
                PointF inter = Lines.InterseccionSimple(p1, p2, b1, b2);
                if (inter != PointF.Empty)
                    return inter;
            }
            return null;
        }
    }
}
