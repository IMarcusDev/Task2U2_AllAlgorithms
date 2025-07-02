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
        public static void Recursive_Flood_Fill(Bitmap canvas, int x, int y, Color fillColor, int maxDepth = 10000)
        {
            Color targetColor = canvas.GetPixel(x, y);
            if (targetColor.ToArgb() == fillColor.ToArgb())
                return;

            HashSet<Point> visited = new HashSet<Point>();
            RecursiveFill(canvas, x, y, targetColor, fillColor, visited, 0, maxDepth);
        }

        private static void RecursiveFill(Bitmap canvas, int x, int y, Color targetColor, Color fillColor, HashSet<Point> visited, int depth, int maxDepth)
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
            visited.Add(p);

            RecursiveFill(canvas, x, y + 1, targetColor, fillColor, visited, depth + 1, maxDepth);
            RecursiveFill(canvas, x + 1, y, targetColor, fillColor, visited, depth + 1, maxDepth);
            RecursiveFill(canvas, x, y - 1, targetColor, fillColor, visited, depth + 1, maxDepth);
            RecursiveFill(canvas, x - 1, y, targetColor, fillColor, visited, depth + 1, maxDepth);
        }

        public static void Iterative_Parallel_Flood_Fill(Bitmap canvas, int x, int y, Color color)
        {
            int width = canvas.Width;
            int height = canvas.Height;
            Color targetColor;
            lock (canvas)
            {
                targetColor = canvas.GetPixel(x, y);
            }
            if (targetColor.ToArgb() == color.ToArgb())
                return;

            var queue = new Queue<Point>();
            var visited = new HashSet<Point>();

            queue.Enqueue(new Point(x, y));
            visited.Add(new Point(x, y));

            object bmpLock = new object();

            while (queue.Count > 0)
            {
                Point point = queue.Dequeue();
                int px = point.X;
                int py = point.Y;

                if (px < 0 || py < 0 || px >= width || py >= height)
                    continue;

                Color currentColor;
                lock (bmpLock)
                {
                    currentColor = canvas.GetPixel(px, py);
                }
                if (currentColor.ToArgb() != targetColor.ToArgb())
                    continue;

                lock (bmpLock)
                {
                    canvas.SetPixel(px, py, color);
                }

                foreach (var neighbor in new[] {
                    new Point(px, py - 1),
                    new Point(px + 1, py),
                    new Point(px, py + 1),
                    new Point(px - 1, py)
                })
                {
                    if (neighbor.X >= 0 && neighbor.Y >= 0 && neighbor.X < width && neighbor.Y < height)
                    {
                        if (!visited.Contains(neighbor))
                        {
                            visited.Add(neighbor);
                            queue.Enqueue(neighbor);
                        }
                    }
                }
            }
        }
    }
}
