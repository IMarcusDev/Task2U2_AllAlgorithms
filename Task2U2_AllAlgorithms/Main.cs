using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2U2_AllAlgorithms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            picCanvasCopy = new Bitmap(picCanvas.Width, picCanvas.Height);
            picCanvas.Image = picCanvasCopy;
            picCanvas.SizeChanged += picCanvas_SizeChanged;

        }

        bool rasterizationMenuExpand = false;
        bool parametricMenuExpand = false;
        bool regionFillMenuExpand = false;
        bool clippingMenuExpand = false;
        bool sideBarExpand = true;
        Bitmap picCanvasCopy;
        
        

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

    }
}
