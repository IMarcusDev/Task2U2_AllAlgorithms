using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task2U2_AllAlgorithms.src.components;
using Task2U2_AllAlgorithms.src.components.Animations;
using Task2U2_AllAlgorithms.src.components.regionsFill;

namespace Task2U2_AllAlgorithms
{
    public partial class Main : Form
    {
        private Polygon polygon;
        private DDA_Algorithm dda_lines;
        private Bresenham_Lines_Algorithm bresenham_lines;

        private List<PointF> linePoints = new List<PointF>();
        private List<PointF> canvasPoints = new List<PointF>();
        private PointF[] clippedPoints;
        List<Color> colors = new List<Color> { Color.Violet, Color.Red, Color.Purple, Color.Green, Color.DarkGreen, Color.DarkOrange, Color.Orange, Color.Peru, Color.Pink, Color.Tan };
        private Pen pen;
        private CanvasAnimator animator;

        private Dictionary<string, bool> dictionaryAlgorithms = new Dictionary<string, bool>();

        bool rasterizationMenuExpand = false;
        bool parametricMenuExpand = false;
        bool regionFillMenuExpand = false;
        bool clippingMenuExpand = false;
        bool sideBarExpand = true;
        Bitmap picCanvasCopy;
        public Main()
        {
            InitializeComponent();
            picCanvasCopy = new Bitmap(picCanvas.Width, picCanvas.Height);
            picCanvas.Image = picCanvasCopy;
            picCanvas.SizeChanged += picCanvas_SizeChanged;
            picCanvas.Paint += picCanvas_Paint;
            pen = new Pen(Color.Black, 1);
            animator = new CanvasAnimator(picCanvas, picCanvasCopy, colors);

            dictionaryAlgorithms.Add("dda_enabled", false);
            dictionaryAlgorithms.Add("bresenham_lines_enabled", false);
            dictionaryAlgorithms.Add("bresenham_circunferencce_enabled", false);
            dictionaryAlgorithms.Add("bresenham_ellipse_enabled", false);
            dictionaryAlgorithms.Add("floodFill_enable", false);
            dictionaryAlgorithms.Add("incrementalFill", false);
            dictionaryAlgorithms.Add("cohen_sutherland", false);
            dictionaryAlgorithms.Add("sutherland_hodgman", false);
            dictionaryAlgorithms.Add("beizer_enable", false);
            dictionaryAlgorithms.Add("bSplines_enabled", false);
        }
        private PointF getCenter()
        {
            PointF center = new PointF(
                picCanvas.Width / 2,
                picCanvas.Height / 2
                );
            return center;

        }

        private void enableSelectedAlgorithm(string algorithm, bool value = true)
        {
            dictionaryAlgorithms = dictionaryAlgorithms.ToDictionary(p => p.Key, p => false);
            dictionaryAlgorithms[algorithm] = value;
        }
        private void picCanvas_SizeChanged(object sender, EventArgs e)
        {
            if (picCanvas.Width > 0 && picCanvas.Height > 0)
            {
                if (picCanvasCopy.Width != picCanvas.Width || picCanvasCopy.Height != picCanvas.Height)
                {
                    Bitmap newBitmap = new Bitmap(picCanvas.Width, picCanvas.Height);

                    using (Graphics g = Graphics.FromImage(newBitmap))
                    {
                        g.DrawImage(picCanvasCopy, 0, 0);
                    }

                    animator.UpdateBitmap(newBitmap);
                    picCanvasCopy.Dispose();
                    picCanvasCopy = newBitmap;
                    picCanvas.Image = picCanvasCopy;
                }
            }
        }

        private void btnHamburger_Click(object sender, EventArgs e)
        {
            sideBarTimer.Start();
        }
        private void btnClipping_Click(object sender, EventArgs e)
        {
            clippingTimer.Start();
        }

        private void btnRasterization_Click(object sender, EventArgs e)
        {
            rasterizationTransition.Start();
        }

        private void btnRegionFill_Click(object sender, EventArgs e)
        {
            regionTimer.Start();
        }

        private void btnParametric_Click(object sender, EventArgs e)
        {
            parametricTimer.Start();
        }

        private void RasterizationTransition_Tick(object sender, EventArgs e)
        {
            if (rasterizationMenuExpand == false) 
            {
                rasterizationContainer.Height += 10;
                if (rasterizationContainer.Height >= 230)
                {
                    rasterizationTransition.Stop();
                    rasterizationMenuExpand = true;
                }
            }
            else
            {
                rasterizationContainer.Height -= 10;
                if(rasterizationContainer.Height <= 59)
                {
                    rasterizationTransition.Stop();
                    rasterizationMenuExpand = false;
                }
            }
        }

        private void parametricTimer_Tick(object sender, EventArgs e)
        {
            if (parametricMenuExpand == false)
            {
                parametricContainer.Height += 10;
                if (parametricContainer.Height >= 150)
                {
                    parametricTimer.Stop();
                    parametricMenuExpand = true;
                }
            }
            else
            {
                parametricContainer.Height -= 10;
                if (parametricContainer.Height <= 57)
                {
                    parametricTimer.Stop();
                    parametricMenuExpand = false;
                }
            }
        }

        private void regionTimer_Tick(object sender, EventArgs e)
        {
            if (regionFillMenuExpand == false)
            {
                regionFillContainer.Height += 10;
                if (regionFillContainer.Height >= 130)
                {
                    regionTimer.Stop();
                    regionFillMenuExpand = true;
                }
            }
            else
            {
                regionFillContainer.Height -= 10;
                if (regionFillContainer.Height <= 57)
                {
                    regionTimer.Stop();
                    regionFillMenuExpand = false;
                }
            }
        }

        private void clippingTimer_Tick(object sender, EventArgs e)
        {
            if (clippingMenuExpand == false)
            {
                clippingContainer.Height += 10;
                if (clippingContainer.Height >= 150)
                {
                    clippingTimer.Stop();
                    clippingMenuExpand = true;
                }
            }
            else
            {
                clippingContainer.Height -= 10;
                if (clippingContainer.Height <= 40)
                {
                    clippingTimer.Stop();
                    clippingMenuExpand = false;
                }
            }
        }

        private void sideBarTimer_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                sideBarContainer.Width -= 10;
                picCanvas.Left -= 10;   
                picCanvas.Width += 10;  

                if (sideBarContainer.Width <= 70)
                {
                    sideBarExpand = false;
                    sideBarTimer.Stop();
                }
            }
            else
            {
                sideBarContainer.Width += 10;
                picCanvas.Left += 10;   
                picCanvas.Width -= 10;  

                if (sideBarContainer.Width >= 220)
                {
                    sideBarExpand = true;
                    sideBarTimer.Stop();
                }
            }
        }

        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                linePoints.Add(new PointF(e.X, e.Y));
                picCanvas.Invalidate();
            }
        }

        private void drawInitArea()
        {
            polygon = new Polygon(4, 100, getCenter());
            polygon.SetRotation(polygon.GetRad() / 2);
            canvasPoints = new List<PointF>(polygon.GetOutline());
            picCanvas.Invalidate();
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < linePoints.Count; i++){
                int colorIndex = i % colors.Count;
                Color currentColor = this.colors[colorIndex];
                int index = i;

                using (Pen localPen = new Pen(currentColor, 2))
                {
                    e.Graphics.DrawEllipse(localPen, linePoints[i].X, linePoints[i].Y,2, 2);
                }
            }

            if (polygon != null)
            {
                PointF[] points = polygon.GetOutline(); 

                using (Pen localPen = new Pen(Color.Black, 2))
                {
                    e.Graphics.DrawPolygon(localPen, points);
                }
            }
            if (polygon == null & linePoints.Count % 2 == 0)
            {
                for (int i = 0; i < linePoints.Count; i += 2)
                {
                    e.Graphics.DrawLine(pen, linePoints[i], linePoints[i + 1]);
                }
            }

            if (polygon != null & linePoints.Count > 2)
            {
                e.Graphics.DrawPolygon(pen, linePoints.ToArray());
            }

            if (clippedPoints != null && clippedPoints.Length > 2)
            {
                for (int i = 0; i < clippedPoints.Length; i += 2)
                {
                    e.Graphics.DrawEllipse(new Pen(Color.Blue, 2), clippedPoints[i].X, clippedPoints[i].Y, 2, 2);
                    e.Graphics.DrawEllipse(new Pen(Color.Orange, 2), clippedPoints[i + 1].X, clippedPoints[i + 1].Y, 2, 2);
                    e.Graphics.DrawLine(new Pen(Color.Red), clippedPoints[i], clippedPoints[i + 1]);
                }
                //e.Graphics.DrawPolygon(new Pen(Color.Red), clippedPoints);
            }
        }

        private void btnDDA_Click(object sender, EventArgs e)
        {
            if (dictionaryAlgorithms["dda_enabled"] == false)
            {
                linePoints.Clear();
                picCanvas.Invalidate();
                polygon = null;

                picCanvas.Paint -= picCanvas_Paint;
                enableSelectedAlgorithm("dda_enabled");
            }
            else if (dictionaryAlgorithms["dda_enabled"] == true) {
                for (int i = 0; i < linePoints.Count; i += 2) 
                {
                    Point p1 = new Point();
                    Point p2 = new Point();

                    p1.X = (int) linePoints[i].X;
                    p1.Y = (int) linePoints[i].Y;

                    p2.X = (int) linePoints[i + 1].X;
                    p2.Y = (int) linePoints[i + 1].Y;

                    DrawDDA_Algorithm(p1, p2);
                }
            }
        }

        private void btnBresenhamLines_Click(object sender, EventArgs e)
        {

        }

        private void btnBresenhamCircunference_Click(object sender, EventArgs e)
        {

        }

        private void btnBresenhamEllipse_Click(object sender, EventArgs e)
        {

        }

        private void btnBeizerCurves_Click(object sender, EventArgs e)
        {

        }

        private void btnBSplinesCurves_Click(object sender, EventArgs e)
        {

        }

        private void btnFloodFill_Click(object sender, EventArgs e)
        {

        }

        private void btnIncrementalFill_Click(object sender, EventArgs e)
        {

        }

        private void btnCohenSutherland_Click(object sender, EventArgs e)
        {
            linePoints.Clear();
            picCanvas.Invalidate();
            drawInitArea();
        }

        private void btnSutherlandHodgman_Click(object sender, EventArgs e)
        {
            linePoints.Clear();
            picCanvas.Invalidate();
            drawInitArea();
        }

        private void DrawDDA_Algorithm(Point p1, Point p2)
        {
            dda_lines = new DDA_Algorithm(p1, p2);
            Point[] linePoints = dda_lines.getLinePoints();

            animator.ClearFrames();
            animator.EnsureFramesUpTo(linePoints.Length, linePoints);
            animator.Play(50);
        }

        private void InputsLinesBresenham_OnDrawClicked(Point p1, Point p2)
        {
            bresenham_lines = new Bresenham_Lines_Algorithm(p1, p2);
            Point[] linePoints = bresenham_lines.getBresenhamPoints();

            animator.ClearFrames();
            animator.EnsureFramesUpTo(linePoints.Length, linePoints);
            animator.Play(50);
        }

        private Point[] GetCirclePointsUnique(int xc, int yc, int r)
        {
            HashSet<Point> points = new HashSet<Point>();
            Bresenham_Circunference_Algorithm.DrawCircle(xc, yc, r, (x, y) => points.Add(new Point(x, y)));
            return points.ToArray();
        }

        private void CircunferenceBresenham_OnDrawClicked(int radio)
        {
            int xc = picCanvas.Width / 2;
            int yc = picCanvas.Height / 2;

            Point[] circlePointsUnique = GetCirclePointsUnique(xc, yc, radio);

            animator.ClearFrames();
            animator.EnsureFramesFill(circlePointsUnique.Length, circlePointsUnique);
            animator.Play(20);
        }

        private void InputsPolygon_OnDrawClicked(int lados, float magnitud, PointF center)
        {
            polygon = new Polygon(lados, magnitud, center);
            PointF[] outline = polygon.GetOutline();

            using (Graphics g = Graphics.FromImage(picCanvasCopy))
            {
                g.Clear(Color.White);
                g.DrawPolygon(pen, outline);
            }

            animator.SetOutline(outline);

            Point seed = new Point((int)center.X, (int)center.Y);
            Point[] filledPixels = FloodFill_Algorithm.Recursive_Flood_Fill(picCanvasCopy, seed.X, seed.Y, Color.Blue);

            animator.ClearFrames();
            animator.EnsureFramesFill(filledPixels.Length, filledPixels);
            animator.Play(10);
        }

        private void InputsPolygonParallel_OnDrawClicked(int lados, float magnitud, PointF center)
        {
            polygon = new Polygon(lados, magnitud, center);
            PointF[] outline = polygon.GetOutline();

            using (Graphics g = Graphics.FromImage(picCanvasCopy))
            {
                g.Clear(Color.White);
                g.DrawPolygon(pen, outline);
            }

            animator.SetOutline(outline);

            Point seed = new Point((int)center.X, (int)center.Y);
            Point[] filledPixels = FloodFill_Algorithm.Iterative_Parallel_Flood_Fill(picCanvasCopy, seed.X, seed.Y, Color.Blue);

            animator.ClearFrames();
            animator.EnsureFramesFill(filledPixels.Length, filledPixels);
            animator.Play(2);
        }

    }
}
