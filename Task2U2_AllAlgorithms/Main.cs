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
using Task2U2_AllAlgorithms.src.components.clipping;
using Task2U2_AllAlgorithms.src.components.parametricCurves;
using Task2U2_AllAlgorithms.src.components.regionsFill;

namespace Task2U2_AllAlgorithms
{
    public partial class Main : Form
    {
        private Polygon polygon;
        private Polygon polygonFill;
        private DDA_Algorithm dda_lines;
        private Bresenham_Lines_Algorithm bresenham_lines;

        private List<PointF> linePoints = new List<PointF>();
        private List<PointF> canvasPoints = new List<PointF>();
        private PointF[] clippedPoints;
        private PointF[] curvePoints;
        List<Color> colors = new List<Color> { Color.Violet, Color.Red, Color.Purple, Color.Green, Color.DarkGreen, Color.DarkOrange, Color.Orange, Color.Peru, Color.Pink, Color.Tan };
        private Pen pen;
        private CanvasAnimator animator;
        HashSet<Point> visited = new HashSet<Point>();
        List<Point> dda_points = new List<Point>();
        List<Point> bresenham_points = new List<Point>();

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
            dictionaryAlgorithms.Add("bresenham_circunference_enabled", false);
            dictionaryAlgorithms.Add("bresenham_ellipse_enabled", false);
            dictionaryAlgorithms.Add("floodFill_enable", false);
            dictionaryAlgorithms.Add("incrementalFill_enabled", false);
            dictionaryAlgorithms.Add("cohen_sutherland_enable", false);
            dictionaryAlgorithms.Add("sutherland_hodgman_enable", false);
            dictionaryAlgorithms.Add("beizer_enable", false);
            dictionaryAlgorithms.Add("bSplines_enabled", false);

            MessageBox.Show("Bienvenidos al programa de graficación de algortimos gráficos. \n 🤖 Para utilizar el programa debe dar click en cada categoría que le dara acceso a las subcategorías \n 🤯 Luego debe seleccionar cualquiera de los metodos que desea y dependiendo del algoritmo puede colocar manualmente los puntos en el canvas sino tendra a su disposición slideBars para generar dianamicamente. \n Para el caso de los metodos donde coloca manualmente los puntos dando click sobre el canvas. Para ejecutar el metodo debe dar click nuevamente sobre el mismo metodo que selecciono para utilizar.", "WELCOME");
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
                if (dictionaryAlgorithms["beizer_enable"] && linePoints.Count() > 3) { return; }
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

        private void initPolygonToFill()
        {
            polygonFill = new Polygon(4, 49, getCenter());
            polygonFill.SetRotation(polygonFill.GetRad() / 2);
            canvasPoints = new List<PointF>(polygonFill.GetOutline());
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

            if (polygon != null || polygonFill != null)
            {
                if (polygonFill != null) {
                    canvasPoints.Clear();
                    canvasPoints.AddRange(polygonFill.GetOutline());
                }
                PointF[] points = canvasPoints.ToArray(); 

                using (Pen localPen = new Pen(Color.Black, 2))
                {
                    e.Graphics.DrawPolygon(localPen, points);
                }
            }
            if (linePoints.Count % 2 == 0 && (dictionaryAlgorithms["cohen_sutherland_enable"] == true || dictionaryAlgorithms["bresenham_lines_enabled"] == true || dictionaryAlgorithms["dda_enabled"] == true))
            {
                for (int i = 0; i < linePoints.Count; i += 2)
                {
                    e.Graphics.DrawLine(pen, linePoints[i], linePoints[i + 1]);
                }
            }

            if (linePoints.Count > 2 && dictionaryAlgorithms["sutherland_hodgman_enable"] == true)
            {
                e.Graphics.DrawPolygon(pen, linePoints.ToArray());
            }

            if (clippedPoints != null && clippedPoints.Length >= 2)
            {
                if(dictionaryAlgorithms["cohen_sutherland_enable"] == true)
                {
                    for (int i = 0; i < clippedPoints.Length; i += 2)
                    {
                        e.Graphics.DrawLine(new Pen(Color.Red, 2), clippedPoints[i], clippedPoints[i + 1]);
                    }
                }
                else
                {
                    for (int i = 1; i < clippedPoints.Length; i++)
                    {
                        e.Graphics.DrawLine(new Pen(Color.Red, 2), clippedPoints[i - 1], clippedPoints[i]);
                    }
                }
            }

            if(curvePoints != null && (dictionaryAlgorithms["beizer_enable"] == true || dictionaryAlgorithms["bSplines_enabled"] == true))
            {
                for (int i = 0; i < curvePoints.Length - 1; i += 2)
                {
                    e.Graphics.DrawEllipse(new Pen(Color.Blue, 2), curvePoints[i].X, curvePoints[i].Y, 2, 2);
                    e.Graphics.DrawEllipse(new Pen(Color.Orange, 2), curvePoints[i + 1].X, curvePoints[i + 1].Y, 2, 2);
                    e.Graphics.DrawLine(new Pen(Color.Red, 2), curvePoints[i], curvePoints[i + 1]);
                }
            }
        }

        private void ResetState(bool clearPolygon = true, bool clearPolygonFill = true, bool clearLines = true, bool clearVisited = true, bool clearAnimator = true, bool clearCanvas = true, bool clearDDA = true, bool clearBresenham = true, bool clearClippedPoints = true)
        {
            if (clearLines) linePoints.Clear();
            if (clearPolygon) polygon = null;
            if (clearPolygonFill) polygonFill = null;
            if (clearVisited) visited.Clear();
            if (clearAnimator)
            {
                animator.ClearFrames();
                animator.ClearImage();
            }
            if (clearCanvas)
            {
                canvasPoints.Clear();
                picCanvas.Invalidate();
            }
            if (clearDDA) dda_points.Clear();
            if (clearClippedPoints) clippedPoints = null;
            if (clearBresenham) bresenham_points.Clear();
            trbRadious.Visible = false;
            trbRadious.Enabled = false;
            trbNumLados.Visible = false;
            trbNumLados.Enabled = false;
        }

        private void btnDDA_Click(object sender, EventArgs e)
        {
            if (dictionaryAlgorithms["dda_enabled"] == false)
            {
                ResetState();
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
            if (dictionaryAlgorithms["bresenham_lines_enabled"] == false)
            {
                ResetState();
                enableSelectedAlgorithm("bresenham_lines_enabled");
            }
            else if (dictionaryAlgorithms["bresenham_lines_enabled"] == true)
            {
                for (int i = 0; i < linePoints.Count; i += 2)
                {
                    Point p1 = new Point();
                    Point p2 = new Point();

                    p1.X = (int)linePoints[i].X;
                    p1.Y = (int)linePoints[i].Y;

                    p2.X = (int)linePoints[i + 1].X;
                    p2.Y = (int)linePoints[i + 1].Y;

                    DrawBresenham_Lines_Algorithm(p1, p2);
                }
            }
        }

        private void btnBresenhamCircunference_Click(object sender, EventArgs e)
        {
            if (dictionaryAlgorithms["bresenham_circunference_enabled"] == false)
            {
                ResetState(clearPolygon: true, clearPolygonFill: true, clearLines: true, clearVisited: true, clearAnimator: true, clearCanvas: true, clearDDA: true, clearBresenham: true);
                trbRadious.Visible = true;
                trbRadious.Enabled = true;
                enableSelectedAlgorithm("bresenham_circunference_enabled");
            }
        }

        private void btnBresenhamEllipse_Click(object sender, EventArgs e)
        {
            if (dictionaryAlgorithms["bresenham_ellipse_enabled"] == false)
            {
                ResetState(clearPolygon: true, clearPolygonFill: true, clearLines: true, clearVisited: true, clearAnimator: true, clearCanvas: true, clearDDA: true, clearBresenham: true);
                trbRadious.Visible = true;
                trbRadious.Enabled = true;
                trbNumLados.Visible = true;
                trbNumLados.Enabled = true;
                enableSelectedAlgorithm("bresenham_ellipse_enabled");
            }
        }

        private void btnBeizerCurves_Click(object sender, EventArgs e)
        {
            if (dictionaryAlgorithms["beizer_enable"] == false)
            {
                ResetState();
                enableSelectedAlgorithm("beizer_enable");
            }
            else if (dictionaryAlgorithms["beizer_enable"] == true)
            {
                curvePoints = Bezier_Algorithm.CalculateBezier(linePoints);
                picCanvas.Invalidate();
                linePoints.Clear();
            }
        }

        private void btnBSplinesCurves_Click(object sender, EventArgs e)
        {
            if (dictionaryAlgorithms["bSplines_enabled"] == false)
            {
                ResetState();
                enableSelectedAlgorithm("bSplines_enabled");
            }
            else if (dictionaryAlgorithms["bSplines_enabled"] == true)
            {
                curvePoints = BSplines_Algorithm.BSplineCurve(linePoints.ToArray(), degree: linePoints.Count - 1);
                picCanvas.Invalidate();
                linePoints.Clear();
            }
        }

        private void btnFloodFill_Click(object sender, EventArgs e)
        {
            if (dictionaryAlgorithms["floodFill_enable"] == false)
            {
                ResetState();
                trbRadious.Visible = true;
                trbRadious.Enabled = true;
                trbNumLados.Visible = true;
                trbNumLados.Enabled = true;
                initPolygonToFill();
                enableSelectedAlgorithm("floodFill_enable");
            }
            else if (dictionaryAlgorithms["floodFill_enable"] == true)
            {
                animator.ClearFrames();
                animator.ClearImage();
                drawPolygonFill_FloodFillAlgorithm();
            }
        }

        private void btnIncrementalFill_Click(object sender, EventArgs e)
        {
            if (dictionaryAlgorithms["incrementalFill_enabled"] == false)
            {
                ResetState();
                trbRadious.Visible = true;
                trbRadious.Enabled = true;
                trbNumLados.Visible = true;
                trbNumLados.Enabled = true;
                initPolygonToFill();
                enableSelectedAlgorithm("incrementalFill_enabled");
            }
            else if (dictionaryAlgorithms["incrementalFill_enabled"] == true)
            {
                animator.ClearFrames();
                animator.ClearImage();
                drawPolygonFill_ScanFillAlgorithm();
            }
        }

        private void btnCohenSutherland_Click(object sender, EventArgs e)
        {
            if (dictionaryAlgorithms["cohen_sutherland_enable"] == false)
            {
                ResetState();
                drawInitArea();
                enableSelectedAlgorithm("cohen_sutherland_enable");
            }else if (dictionaryAlgorithms["cohen_sutherland_enable"] == true)
            {
                clippedPoints = Cohen_Sutherland_Algorithm.clippingCohenSutherlandAlgorithm(linePoints, canvasPoints.ToArray());
                linePoints.Clear();
                picCanvas.Invalidate();
            }
        }

        private void btnSutherlandHodgman_Click(object sender, EventArgs e)
        {
            if (dictionaryAlgorithms["sutherland_hodgman_enable"] == false)
            {
                ResetState();
                drawInitArea();
                enableSelectedAlgorithm("sutherland_hodgman_enable");
            }
            else if (dictionaryAlgorithms["sutherland_hodgman_enable"] == true)
            {
                if(linePoints.Count == 0) { return;  }
                linePoints.Add(linePoints[0]);
                clippedPoints = Sutherland_Hodgman_Algorithm.clippingSutherlandHodgmanAlgorithm(linePoints, canvasPoints.ToArray());
                linePoints.Clear();
                picCanvas.Invalidate();
            }
        }

        private void DrawDDA_Algorithm(Point p1, Point p2)
        {
            dda_lines = new DDA_Algorithm(p1, p2);
            Point[] aux_dda_points = dda_lines.getLinePoints();

            for (int i = 0; i < aux_dda_points.Length; i++) 
            {
                if (!visited.Contains(aux_dda_points[i]))
                {
                    dda_points.Add(aux_dda_points[i]);
                    visited.Add(aux_dda_points[i]);
                }
            }

            animator.ClearFrames();
            animator.EnsureFramesUpTo(dda_points.Count, dda_points.ToArray());
            animator.Play(10);
        }

        private void DrawBresenham_Lines_Algorithm(Point p1, Point p2)
        {
            bresenham_lines = new Bresenham_Lines_Algorithm(p1, p2);
            Point[] aux_bresenham_points = bresenham_lines.getBresenhamPoints();

            for (int i = 0; i < aux_bresenham_points.Length; i++)
            {
                if (!visited.Contains(aux_bresenham_points[i]))
                {
                    bresenham_points.Add(aux_bresenham_points[i]);
                    visited.Add(aux_bresenham_points[i]);
                }
            }

            animator.ClearFrames();
            animator.EnsureFramesUpTo(bresenham_points.Count, bresenham_points.ToArray());
            animator.Play(10);
        }

        private Point[] GetCirclePointsUnique(int xc, int yc, int r)
        {
            HashSet<Point> points = new HashSet<Point>();
            Bresenham_Circunference_Algorithm.DrawCircle(xc, yc, r, (x, y) => points.Add(new Point(x, y)));
            return points.ToArray();
        }
        private Point[] GetEllipsePointsUnique(int xc, int yc, int rx, int ry)
        {
            HashSet<Point> points = new HashSet<Point>();
            Bresenham_Ellipse_Algorithm.DrawEllipse(xc, yc, rx, ry, (x, y) => points.Add(new Point(x, y)));
            return points.ToArray();
        }

        private void DrawBresenham_Circunference_Algorithm(int radio)
        {
            int xc = picCanvas.Width / 2;
            int yc = picCanvas.Height / 2;

            Point[] circlePointsUnique = GetCirclePointsUnique(xc, yc, radio);

            animator.ClearFrames();
            animator.EnsureFramesFill(circlePointsUnique.Length, circlePointsUnique);
            animator.Play(10);
        }
        private void DrawBresenham_Ellipse_Algorithm(int radiox = 0, int radioy = 0)
        {
            int xc = picCanvas.Width / 2;
            int yc = picCanvas.Height / 2;

            Point[] circlePointsUnique = GetEllipsePointsUnique(xc, yc, radiox, radioy);

            animator.ClearFrames();
            animator.EnsureFramesFill(circlePointsUnique.Length, circlePointsUnique);
            animator.Play(10);
        }

        private void drawPolygonFill_FloodFillAlgorithm()
        {
            PointF[] outline = polygonFill.GetOutline();

            using (Graphics g = Graphics.FromImage(picCanvasCopy))
            {
                g.Clear(Color.White);
                g.DrawPolygon(pen, outline);
            }

            animator.SetOutline(outline);

            Point seed = new Point();
            seed.X = (int)getCenter().X;
            seed.Y = (int)getCenter().Y;

            Point[] filledPixels = new Point[0];
            if (polygonFill.GetNumLados() <= 4 && polygonFill.GetMagnitud() <= 49)
            {
                filledPixels = FloodFill_Algorithm.Recursive_Flood_Fill(picCanvasCopy, seed.X, seed.Y, Color.Blue);
            }
            else if (polygonFill.GetNumLados() > 4 || polygonFill.GetMagnitud() > 49) 
            {
                filledPixels = FloodFill_Algorithm.Iterative_Parallel_Flood_Fill(picCanvasCopy, seed.X, seed.Y, Color.Blue);
            }

            animator.ClearFrames();
            animator.EnsureFramesFill(filledPixels.Length, filledPixels);
            animator.Play(5);
        }

        private void drawPolygonFill_ScanFillAlgorithm()
        {
            PointF[] outline = polygonFill.GetOutline();

            using (Graphics g = Graphics.FromImage(picCanvasCopy))
            {
                g.Clear(Color.White);
                g.DrawPolygon(pen, outline);
            }

            animator.SetOutline(outline);

            Point seed = new Point();
            seed.X = (int)getCenter().X;
            seed.Y = (int)getCenter().Y;

            Point[] filledPixels = new Point[0];
            filledPixels = IncrementalFill_Algoritm.ScanlineFill(picCanvasCopy, seed.X, seed.Y, Color.Blue);

            animator.ClearFrames();
            animator.EnsureFramesFill(filledPixels.Length, filledPixels);
            animator.Play(5);
        }

        private void trbRadious_ValueChanged(object sender, EventArgs e)
        {
            int trValue = trbRadious.Value;
            if(dictionaryAlgorithms["bresenham_circunference_enabled"] == true)
            {
                DrawBresenham_Circunference_Algorithm(trValue);
            }
            if(dictionaryAlgorithms["floodFill_enable"] == true || dictionaryAlgorithms["incrementalFill_enabled"] == true)
            {
                animator.ClearFrames();
                animator.ClearImage();
                polygonFill.SetMagnitud(trValue);
                picCanvas.Invalidate();
            }if(dictionaryAlgorithms["bresenham_ellipse_enabled"] == true)
            {
                DrawBresenham_Ellipse_Algorithm(trValue, trbNumLados.Value);
            }
            
        }

        private void trbNumLados_ValueChanged(object sender, EventArgs e)
        {
            if(polygonFill != null)
            {
                animator.ClearFrames();
                animator.ClearImage();
                polygonFill.SetNumLados(trbNumLados.Value);
                picCanvas.Invalidate();
            }
            if (dictionaryAlgorithms["bresenham_ellipse_enabled"] == true)
            {
                trbNumLados.Maximum = 100;
                DrawBresenham_Ellipse_Algorithm(trbRadious.Value, trbNumLados.Value);
            }
            if (dictionaryAlgorithms["bresenham_ellipse_enabled"] == false)
            {
                trbNumLados.Maximum = 10;
            }
        }
    }
}
