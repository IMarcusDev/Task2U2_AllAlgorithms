using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2U2_AllAlgorithms.src.components.regionsFill
{
    internal class FloodFill_Algorithm
    {
        public static Point[] Recursive_Flood_Fill(Bitmap canvas, int x, int y, Color fillColor, int maxDepth = 10000)
        {
            Color targetColor = canvas.GetPixel(x, y);
            if (targetColor.ToArgb() == fillColor.ToArgb())
                return new Point[0];

            HashSet<Point> visited = new HashSet<Point>();
            List<Point> result = new List<Point>();

            RecursiveFill(canvas, x, y, targetColor, fillColor, visited, result, 0, maxDepth);

            return result.ToArray();
        }

        private static void RecursiveFill(Bitmap canvas, int x, int y, Color targetColor, Color fillColor, HashSet<Point> visited, List<Point> result, int depth, int maxDepth)
        {
            if (depth > maxDepth)
                return;
            if (x < 0 || y < 0 || x >= canvas.Width || y >= canvas.Height)
                return;

            Point p = new Point(x, y);
            if (visited.Contains(p))
                return;

            if (canvas.GetPixel(x, y).ToArgb() != targetColor.ToArgb())
                return;

            canvas.SetPixel(x, y, fillColor);
            result.Add(p);
            visited.Add(p);

            RecursiveFill(canvas, x, y + 1, targetColor, fillColor, visited, result, depth + 1, maxDepth);
            RecursiveFill(canvas, x + 1, y, targetColor, fillColor, visited, result, depth + 1, maxDepth);
            RecursiveFill(canvas, x, y - 1, targetColor, fillColor, visited, result, depth + 1, maxDepth);
            RecursiveFill(canvas, x - 1, y, targetColor, fillColor, visited, result, depth + 1, maxDepth);
        }
    
        public static Point[] Iterative_Parallel_Flood_Fill(Bitmap canvas, int x, int y, Color color)
        {
            int width = canvas.Width;
            int height = canvas.Height;
            Color targetColor;
            lock (canvas)
            {
                targetColor = canvas.GetPixel(x, y);
            }
            if (targetColor.ToArgb() == color.ToArgb())
                return new Point[0];

            var points = new ConcurrentBag<Point>();
            var queue = new ConcurrentQueue<Point>();
            var visited = new ConcurrentDictionary<Point, byte>();

            queue.Enqueue(new Point(x, y));
            visited.TryAdd(new Point(x, y), 0);

            object bmpLock = new object();

            while (!queue.IsEmpty)
            {
                var batch = new List<Point>();
                Point p;
                while (batch.Count < Environment.ProcessorCount * 8 && queue.TryDequeue(out p))
                {
                    batch.Add(p);
                }

                Parallel.ForEach(batch, point =>
                {
                    int px = point.X;
                    int py = point.Y;

                    if (px < 0 || py < 0 || px >= width || py >= height)
                        return;

                    Color currentColor;
                    lock (bmpLock)
                    {
                        currentColor = canvas.GetPixel(px, py);
                    }
                    if (currentColor.ToArgb() != targetColor.ToArgb())
                        return;

                    lock (bmpLock)
                    {
                        canvas.SetPixel(px, py, color);
                    }
                    points.Add(point);

                    foreach (var neighbor in new[] {
                        new Point(px, py - 1),
                        new Point(px + 1, py),
                        new Point(px, py + 1),
                        new Point(px - 1, py)
                    })
                    {
                        if (neighbor.X >= 0 && neighbor.Y >= 0 && neighbor.X < width && neighbor.Y < height)
                        {
                            if (visited.TryAdd(neighbor, 0))
                            {
                                queue.Enqueue(neighbor);
                            }
                        }
                    }
                });
            }

            return points.ToArray();
        }
    }
}
