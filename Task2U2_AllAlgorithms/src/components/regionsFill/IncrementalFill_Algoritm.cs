using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2U2_AllAlgorithms.src.components.regionsFill
{
    internal class IncrementalFill_Algoritm
    {
        public static Point[] ScanlineFill(Bitmap bmp, int startX, int startY, Color fillColor)
        {
            Color targetColor = bmp.GetPixel(startX, startY);
            if (targetColor.ToArgb() == fillColor.ToArgb())
                return new Point[0];

            Stack<Point> stack = new Stack<Point>();
            List<Point> result = new List<Point>();
            HashSet<Point> visited = new HashSet<Point>();

            stack.Push(new Point(startX, startY));

            while (stack.Count > 0)
            {
                Point seed = stack.Pop();
                int x = seed.X;
                int y = seed.Y;

                // Buscar límite izquierdo correctamente
                int leftX = x;
                while (leftX >= 0 && bmp.GetPixel(leftX, y).ToArgb() == targetColor.ToArgb())
                    leftX--;
                leftX++; // Retrocede al último válido

                // Buscar límite derecho correctamente
                int rightX = x;
                while (rightX < bmp.Width && bmp.GetPixel(rightX, y).ToArgb() == targetColor.ToArgb())
                    rightX++;
                rightX--; // Retrocede al último válido

                // Rellenar la línea horizontal desde leftX hasta rightX
                for (int i = leftX; i <= rightX; i++)
                {
                    Point p = new Point(i, y);
                    if (!visited.Contains(p))
                    {
                        bmp.SetPixel(i, y, fillColor);
                        result.Add(p);
                        visited.Add(p);
                    }

                    // Revisar píxel arriba
                    if (y > 0)
                    {
                        Point above = new Point(i, y - 1);
                        if (!visited.Contains(above) && bmp.GetPixel(i, y - 1).ToArgb() == targetColor.ToArgb())
                            stack.Push(above);
                    }

                    // Revisar píxel abajo
                    if (y < bmp.Height - 1)
                    {
                        Point below = new Point(i, y + 1);
                        if (!visited.Contains(below) && bmp.GetPixel(i, y + 1).ToArgb() == targetColor.ToArgb())
                            stack.Push(below);
                    }
                }
            }

            return result.ToArray();
        }
    }
}
