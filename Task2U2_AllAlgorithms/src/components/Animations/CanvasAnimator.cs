using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2U2_AllAlgorithms.src.components.Animations
{
    internal class CanvasAnimator
    {
        private List<Action<Graphics>> frames = new List<Action<Graphics>>();
        private Timer animationTimer;
        private int indexAnimation = 0;
        private readonly PictureBox canvas;
        private Bitmap canvasBitmap;
        private readonly List<Color> colors;
        private PointF[] lastPolygonOutline;
        private Pen pen;

        public CanvasAnimator(PictureBox canvas, Bitmap bitmap, List<Color> colors, Pen pen = null)
        {
            this.canvas = canvas;
            this.canvasBitmap = bitmap;
            this.colors = colors;
            this.pen = pen ?? Pens.Black;

            animationTimer = new Timer();
            animationTimer.Tick += AnimationTimer_Tick;
        }

        public void UpdateBitmap(Bitmap newBitmap)
        {
            canvasBitmap?.Dispose();
            canvasBitmap = newBitmap;
        }

        public void SetOutline(PointF[] outline)
        {
            this.lastPolygonOutline = outline;
        }

        public void ClearFrames()
        {
            frames.Clear();
        }

        public void EnsureFramesUpTo(int target, Point[] points)
        {
            for (int i = 0; i < target && i < points.Length; i++)
            {
                int colorIndex = i % colors.Count;
                Color currentColor = colors[colorIndex];
                int index = i;

                frames.Add(g =>
                {
                    using (Pen localPen = new Pen(currentColor, 2))
                    {
                        g.DrawRectangle(localPen, points[index].X, points[index].Y, 2, 2);
                    }
                });
            }
        }

        public void EnsureFramesFill(int target, Point[] points)
        {
            for (int i = 0; i < target && i < points.Length; i++)
            {
                int colorIndex = i % colors.Count;
                Color currentColor = colors[colorIndex];
                int index = i;

                frames.Add(g =>
                {
                    using (SolidBrush brush = new SolidBrush(currentColor))
                    {
                        g.FillRectangle(brush, points[index].X, points[index].Y, 1, 1);
                    }
                });
            }
        }

        public void Play(int interval = 100)
        {
            if (frames.Count == 0) return;

            indexAnimation = 0;
            animationTimer.Interval = interval;
            animationTimer.Start();
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            if (indexAnimation <= frames.Count)
            {
                DrawAll();
                indexAnimation++;
            }
            else
            {
                animationTimer.Stop();
            }
        }

        private void DrawAll()
        {
            using (Graphics g = Graphics.FromImage(canvasBitmap))
            {
                g.Clear(Color.White);

                for (int i = 0; i < indexAnimation && i < frames.Count; i++)
                {
                    frames[i](g);
                }

                if (lastPolygonOutline != null)
                {
                    g.DrawPolygon(pen, lastPolygonOutline);
                }
            }

            canvas.Invalidate();
        }
    }
}
