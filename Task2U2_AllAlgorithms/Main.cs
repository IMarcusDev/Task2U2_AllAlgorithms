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

namespace Task2U2_AllAlgorithms
{
    public partial class Main : Form
    {
        private Polygon polygon;
        private List<PointF> linePoints = new List<PointF>();
        private List<PointF> canvasPoints = new List<PointF>();
        private PointF[] clippedPoints;
        private Pen pen;
        public Main()
        {
            InitializeComponent();
            picCanvasCopy = new Bitmap(picCanvas.Width, picCanvas.Height);
            picCanvas.Image = picCanvasCopy;
            picCanvas.SizeChanged += picCanvas_SizeChanged;
            picCanvas.Paint += picCanvas_Paint;
            pen = new Pen(Color.Black, 1);
        }

        bool rasterizationMenuExpand = false;
        bool parametricMenuExpand = false;
        bool regionFillMenuExpand = false;
        bool clippingMenuExpand = false;
        bool sideBarExpand = true;
        Bitmap picCanvasCopy;

        private PointF getCenter()
        {
            PointF center = new PointF(
                picCanvas.Width / 2,
                picCanvas.Height / 2
                );
            return center;

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
            //polygon.SetCenter(getCenter());
            polygon.SetRotation(polygon.GetRad() / 2);
            canvasPoints = new List<PointF>(polygon.GetOutline());
            picCanvas.Invalidate();
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (polygon != null)
            {
                PointF[] points = polygon.GetOutline();

                using (Pen localPen = new Pen(Color.Black, 2))
                {
                    e.Graphics.DrawPolygon(localPen, points);
                }
                // e.Graphics.DrawEllipse(new Pen(Color.Orange, 2), points[0].X, points[0].Y, 2, 2);
            }
            if (linePoints.Count > 2)
            {
                //for (int i = 0; i < linePoints.Count; i += 2)
                //{
                //    e.Graphics.DrawLine(pen, linePoints[i], linePoints[i + 1]);
                //}

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
            drawInitArea();
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

        }

        private void btnSutherlandHodgman_Click(object sender, EventArgs e)
        {

        }
    }
}
