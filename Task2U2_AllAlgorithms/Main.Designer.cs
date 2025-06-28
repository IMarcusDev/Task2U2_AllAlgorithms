namespace Task2U2_AllAlgorithms
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.btnHamburger = new System.Windows.Forms.PictureBox();
            this.sideBarContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.rasterizationContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRasterization = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnDDA = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btnBresenhamLines = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBresenhamCircunference = new System.Windows.Forms.Button();
            this.panel15 = new System.Windows.Forms.Panel();
            this.btnBresenhamEllipse = new System.Windows.Forms.Button();
            this.parametricContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnParametric = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnBeizerCurves = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnBSplinesCurves = new System.Windows.Forms.Button();
            this.regionFillContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRegionFill = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnFloodFill = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnIncrementalFill = new System.Windows.Forms.Button();
            this.clippingContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnClipping = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnCohenSutherland = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnSutherlandHodgman = new System.Windows.Forms.Button();
            this.rasterizationTransition = new System.Windows.Forms.Timer(this.components);
            this.parametricTimer = new System.Windows.Forms.Timer(this.components);
            this.regionTimer = new System.Windows.Forms.Timer(this.components);
            this.clippingTimer = new System.Windows.Forms.Timer(this.components);
            this.sideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.trbRadious = new ReaLTaiizor.Controls.PoisonTrackBar();
            this.trbNumLados = new System.Windows.Forms.TrackBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHamburger)).BeginInit();
            this.sideBarContainer.SuspendLayout();
            this.rasterizationContainer.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel15.SuspendLayout();
            this.parametricContainer.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.regionFillContainer.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.clippingContainer.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbNumLados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.bigLabel1);
            this.panel1.Controls.Add(this.nightControlBox1);
            this.panel1.Controls.Add(this.btnHamburger);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1299, 100);
            this.panel1.TabIndex = 0;
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.bigLabel1.ForeColor = System.Drawing.Color.White;
            this.bigLabel1.Location = new System.Drawing.Point(85, 12);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(451, 67);
            this.bigLabel1.TabIndex = 3;
            this.bigLabel1.Text = "Graphic Algorithms";
            // 
            // nightControlBox1
            // 
            this.nightControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMaximizeButton = true;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.Location = new System.Drawing.Point(1160, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 2;
            // 
            // btnHamburger
            // 
            this.btnHamburger.Image = ((System.Drawing.Image)(resources.GetObject("btnHamburger.Image")));
            this.btnHamburger.Location = new System.Drawing.Point(12, 12);
            this.btnHamburger.Name = "btnHamburger";
            this.btnHamburger.Size = new System.Drawing.Size(50, 50);
            this.btnHamburger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnHamburger.TabIndex = 1;
            this.btnHamburger.TabStop = false;
            this.btnHamburger.Click += new System.EventHandler(this.btnHamburger_Click);
            // 
            // sideBarContainer
            // 
            this.sideBarContainer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sideBarContainer.Controls.Add(this.rasterizationContainer);
            this.sideBarContainer.Controls.Add(this.parametricContainer);
            this.sideBarContainer.Controls.Add(this.regionFillContainer);
            this.sideBarContainer.Controls.Add(this.clippingContainer);
            this.sideBarContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBarContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sideBarContainer.Location = new System.Drawing.Point(0, 100);
            this.sideBarContainer.Name = "sideBarContainer";
            this.sideBarContainer.Size = new System.Drawing.Size(330, 717);
            this.sideBarContainer.TabIndex = 1;
            // 
            // rasterizationContainer
            // 
            this.rasterizationContainer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rasterizationContainer.Controls.Add(this.panel4);
            this.rasterizationContainer.Controls.Add(this.panel9);
            this.rasterizationContainer.Controls.Add(this.panel14);
            this.rasterizationContainer.Controls.Add(this.panel2);
            this.rasterizationContainer.Controls.Add(this.panel15);
            this.rasterizationContainer.Location = new System.Drawing.Point(0, 0);
            this.rasterizationContainer.Margin = new System.Windows.Forms.Padding(0);
            this.rasterizationContainer.Name = "rasterizationContainer";
            this.rasterizationContainer.Size = new System.Drawing.Size(327, 61);
            this.rasterizationContainer.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnRasterization);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(324, 61);
            this.panel4.TabIndex = 1;
            // 
            // btnRasterization
            // 
            this.btnRasterization.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRasterization.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRasterization.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRasterization.Image = ((System.Drawing.Image)(resources.GetObject("btnRasterization.Image")));
            this.btnRasterization.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRasterization.Location = new System.Drawing.Point(-9, -38);
            this.btnRasterization.Margin = new System.Windows.Forms.Padding(0);
            this.btnRasterization.Name = "btnRasterization";
            this.btnRasterization.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnRasterization.Size = new System.Drawing.Size(342, 134);
            this.btnRasterization.TabIndex = 2;
            this.btnRasterization.Text = "              Rasterization";
            this.btnRasterization.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRasterization.UseVisualStyleBackColor = false;
            this.btnRasterization.Click += new System.EventHandler(this.btnRasterization_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnDDA);
            this.panel9.Location = new System.Drawing.Point(3, 70);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(293, 61);
            this.panel9.TabIndex = 7;
            // 
            // btnDDA
            // 
            this.btnDDA.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDDA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDDA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDDA.Image = ((System.Drawing.Image)(resources.GetObject("btnDDA.Image")));
            this.btnDDA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDDA.Location = new System.Drawing.Point(-9, -38);
            this.btnDDA.Name = "btnDDA";
            this.btnDDA.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnDDA.Size = new System.Drawing.Size(342, 134);
            this.btnDDA.TabIndex = 2;
            this.btnDDA.Text = "              DDA";
            this.btnDDA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDDA.UseVisualStyleBackColor = false;
            this.btnDDA.Click += new System.EventHandler(this.btnDDA_Click);
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.btnBresenhamLines);
            this.panel14.Location = new System.Drawing.Point(3, 137);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(293, 61);
            this.panel14.TabIndex = 6;
            // 
            // btnBresenhamLines
            // 
            this.btnBresenhamLines.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBresenhamLines.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBresenhamLines.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBresenhamLines.Image = ((System.Drawing.Image)(resources.GetObject("btnBresenhamLines.Image")));
            this.btnBresenhamLines.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBresenhamLines.Location = new System.Drawing.Point(-9, -38);
            this.btnBresenhamLines.Name = "btnBresenhamLines";
            this.btnBresenhamLines.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnBresenhamLines.Size = new System.Drawing.Size(342, 134);
            this.btnBresenhamLines.TabIndex = 2;
            this.btnBresenhamLines.Text = "              Bresenham                           Lines";
            this.btnBresenhamLines.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBresenhamLines.UseVisualStyleBackColor = false;
            this.btnBresenhamLines.Click += new System.EventHandler(this.btnBresenhamLines_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnBresenhamCircunference);
            this.panel2.Location = new System.Drawing.Point(3, 204);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 61);
            this.panel2.TabIndex = 7;
            // 
            // btnBresenhamCircunference
            // 
            this.btnBresenhamCircunference.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBresenhamCircunference.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBresenhamCircunference.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBresenhamCircunference.Image = ((System.Drawing.Image)(resources.GetObject("btnBresenhamCircunference.Image")));
            this.btnBresenhamCircunference.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBresenhamCircunference.Location = new System.Drawing.Point(-9, -38);
            this.btnBresenhamCircunference.Name = "btnBresenhamCircunference";
            this.btnBresenhamCircunference.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnBresenhamCircunference.Size = new System.Drawing.Size(342, 134);
            this.btnBresenhamCircunference.TabIndex = 2;
            this.btnBresenhamCircunference.Text = "              Bresenham                           Circuference";
            this.btnBresenhamCircunference.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBresenhamCircunference.UseVisualStyleBackColor = false;
            this.btnBresenhamCircunference.Click += new System.EventHandler(this.btnBresenhamCircunference_Click);
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.btnBresenhamEllipse);
            this.panel15.Location = new System.Drawing.Point(3, 271);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(293, 61);
            this.panel15.TabIndex = 8;
            // 
            // btnBresenhamEllipse
            // 
            this.btnBresenhamEllipse.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBresenhamEllipse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBresenhamEllipse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBresenhamEllipse.Image = ((System.Drawing.Image)(resources.GetObject("btnBresenhamEllipse.Image")));
            this.btnBresenhamEllipse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBresenhamEllipse.Location = new System.Drawing.Point(-9, -38);
            this.btnBresenhamEllipse.Name = "btnBresenhamEllipse";
            this.btnBresenhamEllipse.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnBresenhamEllipse.Size = new System.Drawing.Size(342, 134);
            this.btnBresenhamEllipse.TabIndex = 2;
            this.btnBresenhamEllipse.Text = "              Bresenham                           Ellipse";
            this.btnBresenhamEllipse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBresenhamEllipse.UseVisualStyleBackColor = false;
            this.btnBresenhamEllipse.Click += new System.EventHandler(this.btnBresenhamEllipse_Click);
            // 
            // parametricContainer
            // 
            this.parametricContainer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.parametricContainer.Controls.Add(this.panel8);
            this.parametricContainer.Controls.Add(this.panel7);
            this.parametricContainer.Controls.Add(this.panel6);
            this.parametricContainer.Location = new System.Drawing.Point(0, 131);
            this.parametricContainer.Margin = new System.Windows.Forms.Padding(0, 70, 0, 0);
            this.parametricContainer.Name = "parametricContainer";
            this.parametricContainer.Size = new System.Drawing.Size(330, 61);
            this.parametricContainer.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnParametric);
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(327, 61);
            this.panel8.TabIndex = 8;
            // 
            // btnParametric
            // 
            this.btnParametric.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnParametric.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParametric.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnParametric.Image = ((System.Drawing.Image)(resources.GetObject("btnParametric.Image")));
            this.btnParametric.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParametric.Location = new System.Drawing.Point(-9, -38);
            this.btnParametric.Margin = new System.Windows.Forms.Padding(0);
            this.btnParametric.Name = "btnParametric";
            this.btnParametric.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnParametric.Size = new System.Drawing.Size(347, 134);
            this.btnParametric.TabIndex = 2;
            this.btnParametric.Text = "              Parametric                            Curves";
            this.btnParametric.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParametric.UseVisualStyleBackColor = false;
            this.btnParametric.Click += new System.EventHandler(this.btnParametric_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnBeizerCurves);
            this.panel7.Location = new System.Drawing.Point(3, 70);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(327, 61);
            this.panel7.TabIndex = 7;
            // 
            // btnBeizerCurves
            // 
            this.btnBeizerCurves.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBeizerCurves.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeizerCurves.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBeizerCurves.Image = ((System.Drawing.Image)(resources.GetObject("btnBeizerCurves.Image")));
            this.btnBeizerCurves.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBeizerCurves.Location = new System.Drawing.Point(-9, -38);
            this.btnBeizerCurves.Margin = new System.Windows.Forms.Padding(0);
            this.btnBeizerCurves.Name = "btnBeizerCurves";
            this.btnBeizerCurves.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnBeizerCurves.Size = new System.Drawing.Size(347, 134);
            this.btnBeizerCurves.TabIndex = 2;
            this.btnBeizerCurves.Text = "              Beizer Curves";
            this.btnBeizerCurves.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBeizerCurves.UseVisualStyleBackColor = false;
            this.btnBeizerCurves.Click += new System.EventHandler(this.btnBeizerCurves_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnBSplinesCurves);
            this.panel6.Location = new System.Drawing.Point(3, 137);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(327, 61);
            this.panel6.TabIndex = 6;
            // 
            // btnBSplinesCurves
            // 
            this.btnBSplinesCurves.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBSplinesCurves.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBSplinesCurves.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBSplinesCurves.Image = ((System.Drawing.Image)(resources.GetObject("btnBSplinesCurves.Image")));
            this.btnBSplinesCurves.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBSplinesCurves.Location = new System.Drawing.Point(-9, -38);
            this.btnBSplinesCurves.Margin = new System.Windows.Forms.Padding(0);
            this.btnBSplinesCurves.Name = "btnBSplinesCurves";
            this.btnBSplinesCurves.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnBSplinesCurves.Size = new System.Drawing.Size(347, 134);
            this.btnBSplinesCurves.TabIndex = 2;
            this.btnBSplinesCurves.Text = "              B-Splines                              Curves";
            this.btnBSplinesCurves.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBSplinesCurves.UseVisualStyleBackColor = false;
            this.btnBSplinesCurves.Click += new System.EventHandler(this.btnBSplinesCurves_Click);
            // 
            // regionFillContainer
            // 
            this.regionFillContainer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.regionFillContainer.Controls.Add(this.panel3);
            this.regionFillContainer.Controls.Add(this.panel12);
            this.regionFillContainer.Controls.Add(this.panel13);
            this.regionFillContainer.Location = new System.Drawing.Point(0, 262);
            this.regionFillContainer.Margin = new System.Windows.Forms.Padding(0, 70, 0, 0);
            this.regionFillContainer.Name = "regionFillContainer";
            this.regionFillContainer.Size = new System.Drawing.Size(330, 61);
            this.regionFillContainer.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnRegionFill);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(327, 61);
            this.panel3.TabIndex = 4;
            // 
            // btnRegionFill
            // 
            this.btnRegionFill.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegionFill.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegionFill.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegionFill.Image = ((System.Drawing.Image)(resources.GetObject("btnRegionFill.Image")));
            this.btnRegionFill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegionFill.Location = new System.Drawing.Point(-9, -38);
            this.btnRegionFill.Margin = new System.Windows.Forms.Padding(0);
            this.btnRegionFill.Name = "btnRegionFill";
            this.btnRegionFill.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnRegionFill.Size = new System.Drawing.Size(354, 134);
            this.btnRegionFill.TabIndex = 2;
            this.btnRegionFill.Text = "              Region filling";
            this.btnRegionFill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegionFill.UseVisualStyleBackColor = false;
            this.btnRegionFill.Click += new System.EventHandler(this.btnRegionFill_Click);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btnFloodFill);
            this.panel12.Location = new System.Drawing.Point(3, 70);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(327, 61);
            this.panel12.TabIndex = 7;
            // 
            // btnFloodFill
            // 
            this.btnFloodFill.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFloodFill.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFloodFill.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFloodFill.Image = ((System.Drawing.Image)(resources.GetObject("btnFloodFill.Image")));
            this.btnFloodFill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFloodFill.Location = new System.Drawing.Point(-9, -38);
            this.btnFloodFill.Name = "btnFloodFill";
            this.btnFloodFill.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnFloodFill.Size = new System.Drawing.Size(347, 134);
            this.btnFloodFill.TabIndex = 2;
            this.btnFloodFill.Text = "              Flood Fill";
            this.btnFloodFill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFloodFill.UseVisualStyleBackColor = false;
            this.btnFloodFill.Click += new System.EventHandler(this.btnFloodFill_Click);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.btnIncrementalFill);
            this.panel13.Location = new System.Drawing.Point(3, 137);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(327, 61);
            this.panel13.TabIndex = 6;
            // 
            // btnIncrementalFill
            // 
            this.btnIncrementalFill.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIncrementalFill.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncrementalFill.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIncrementalFill.Image = ((System.Drawing.Image)(resources.GetObject("btnIncrementalFill.Image")));
            this.btnIncrementalFill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncrementalFill.Location = new System.Drawing.Point(-9, -38);
            this.btnIncrementalFill.Name = "btnIncrementalFill";
            this.btnIncrementalFill.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnIncrementalFill.Size = new System.Drawing.Size(347, 134);
            this.btnIncrementalFill.TabIndex = 2;
            this.btnIncrementalFill.Text = "              Incremental                         Fill";
            this.btnIncrementalFill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncrementalFill.UseVisualStyleBackColor = false;
            this.btnIncrementalFill.Click += new System.EventHandler(this.btnIncrementalFill_Click);
            // 
            // clippingContainer
            // 
            this.clippingContainer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clippingContainer.Controls.Add(this.panel5);
            this.clippingContainer.Controls.Add(this.panel10);
            this.clippingContainer.Controls.Add(this.panel11);
            this.clippingContainer.Location = new System.Drawing.Point(0, 393);
            this.clippingContainer.Margin = new System.Windows.Forms.Padding(0, 70, 0, 0);
            this.clippingContainer.Name = "clippingContainer";
            this.clippingContainer.Size = new System.Drawing.Size(330, 61);
            this.clippingContainer.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnClipping);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(327, 61);
            this.panel5.TabIndex = 5;
            // 
            // btnClipping
            // 
            this.btnClipping.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClipping.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClipping.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClipping.Image = ((System.Drawing.Image)(resources.GetObject("btnClipping.Image")));
            this.btnClipping.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClipping.Location = new System.Drawing.Point(-9, -38);
            this.btnClipping.Margin = new System.Windows.Forms.Padding(0);
            this.btnClipping.Name = "btnClipping";
            this.btnClipping.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnClipping.Size = new System.Drawing.Size(345, 134);
            this.btnClipping.TabIndex = 2;
            this.btnClipping.Text = "                Clipping";
            this.btnClipping.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClipping.UseVisualStyleBackColor = false;
            this.btnClipping.Click += new System.EventHandler(this.btnClipping_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnCohenSutherland);
            this.panel10.Location = new System.Drawing.Point(3, 70);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(327, 61);
            this.panel10.TabIndex = 7;
            // 
            // btnCohenSutherland
            // 
            this.btnCohenSutherland.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCohenSutherland.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCohenSutherland.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCohenSutherland.Image = ((System.Drawing.Image)(resources.GetObject("btnCohenSutherland.Image")));
            this.btnCohenSutherland.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCohenSutherland.Location = new System.Drawing.Point(-9, -38);
            this.btnCohenSutherland.Name = "btnCohenSutherland";
            this.btnCohenSutherland.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnCohenSutherland.Size = new System.Drawing.Size(345, 134);
            this.btnCohenSutherland.TabIndex = 2;
            this.btnCohenSutherland.Text = "                Cohen-                                 Sutherland";
            this.btnCohenSutherland.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCohenSutherland.UseVisualStyleBackColor = false;
            this.btnCohenSutherland.Click += new System.EventHandler(this.btnCohenSutherland_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btnSutherlandHodgman);
            this.panel11.Location = new System.Drawing.Point(3, 137);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(327, 61);
            this.panel11.TabIndex = 6;
            // 
            // btnSutherlandHodgman
            // 
            this.btnSutherlandHodgman.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSutherlandHodgman.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSutherlandHodgman.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSutherlandHodgman.Image = ((System.Drawing.Image)(resources.GetObject("btnSutherlandHodgman.Image")));
            this.btnSutherlandHodgman.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSutherlandHodgman.Location = new System.Drawing.Point(-9, -38);
            this.btnSutherlandHodgman.Name = "btnSutherlandHodgman";
            this.btnSutherlandHodgman.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnSutherlandHodgman.Size = new System.Drawing.Size(345, 134);
            this.btnSutherlandHodgman.TabIndex = 2;
            this.btnSutherlandHodgman.Text = "                Sutherland-                          Hodgman";
            this.btnSutherlandHodgman.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSutherlandHodgman.UseVisualStyleBackColor = false;
            this.btnSutherlandHodgman.Click += new System.EventHandler(this.btnSutherlandHodgman_Click);
            // 
            // rasterizationTransition
            // 
            this.rasterizationTransition.Interval = 10;
            this.rasterizationTransition.Tick += new System.EventHandler(this.RasterizationTransition_Tick);
            // 
            // parametricTimer
            // 
            this.parametricTimer.Interval = 10;
            this.parametricTimer.Tick += new System.EventHandler(this.parametricTimer_Tick);
            // 
            // regionTimer
            // 
            this.regionTimer.Interval = 10;
            this.regionTimer.Tick += new System.EventHandler(this.regionTimer_Tick);
            // 
            // clippingTimer
            // 
            this.clippingTimer.Interval = 10;
            this.clippingTimer.Tick += new System.EventHandler(this.clippingTimer_Tick);
            // 
            // sideBarTimer
            // 
            this.sideBarTimer.Interval = 10;
            this.sideBarTimer.Tick += new System.EventHandler(this.sideBarTimer_Tick);
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.SystemColors.Window;
            this.picCanvas.Location = new System.Drawing.Point(330, 100);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(969, 717);
            this.picCanvas.TabIndex = 2;
            this.picCanvas.TabStop = false;
            this.picCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseClick);
            // 
            // trbRadious
            // 
            this.trbRadious.BackColor = System.Drawing.Color.Transparent;
            this.trbRadious.Enabled = false;
            this.trbRadious.Location = new System.Drawing.Point(503, 123);
            this.trbRadious.Minimum = 10;
            this.trbRadious.Name = "trbRadious";
            this.trbRadious.Size = new System.Drawing.Size(665, 38);
            this.trbRadious.TabIndex = 6;
            this.trbRadious.Text = "poisonTrackBar1";
            this.trbRadious.Value = 49;
            this.trbRadious.Visible = false;
            this.trbRadious.ValueChanged += new System.EventHandler(this.trbRadious_ValueChanged);
            // 
            // trbNumLados
            // 
            this.trbNumLados.Enabled = false;
            this.trbNumLados.Location = new System.Drawing.Point(362, 170);
            this.trbNumLados.Minimum = 3;
            this.trbNumLados.Name = "trbNumLados";
            this.trbNumLados.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trbNumLados.Size = new System.Drawing.Size(69, 460);
            this.trbNumLados.TabIndex = 12;
            this.trbNumLados.Value = 3;
            this.trbNumLados.Visible = false;
            this.trbNumLados.ValueChanged += new System.EventHandler(this.trbNumLados_ValueChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1299, 817);
            this.Controls.Add(this.trbNumLados);
            this.Controls.Add(this.trbRadious);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.sideBarContainer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHamburger)).EndInit();
            this.sideBarContainer.ResumeLayout(false);
            this.rasterizationContainer.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.parametricContainer.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.regionFillContainer.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.clippingContainer.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbNumLados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnHamburger;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.FlowLayoutPanel sideBarContainer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnRasterization;
        private System.Windows.Forms.FlowLayoutPanel parametricContainer;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnParametric;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnBeizerCurves;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnBSplinesCurves;
        private System.Windows.Forms.FlowLayoutPanel clippingContainer;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnClipping;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnCohenSutherland;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnSutherlandHodgman;
        private System.Windows.Forms.FlowLayoutPanel regionFillContainer;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btnFloodFill;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btnIncrementalFill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRegionFill;
        private System.Windows.Forms.FlowLayoutPanel rasterizationContainer;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnDDA;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button btnBresenhamLines;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBresenhamCircunference;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button btnBresenhamEllipse;
        private System.Windows.Forms.Timer rasterizationTransition;
        private System.Windows.Forms.Timer parametricTimer;
        private System.Windows.Forms.Timer regionTimer;
        private System.Windows.Forms.Timer clippingTimer;
        private System.Windows.Forms.Timer sideBarTimer;
        private System.Windows.Forms.PictureBox picCanvas;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.PoisonTrackBar trbRadious;
        private System.Windows.Forms.TrackBar trbNumLados;
    }
}

