namespace EditableChart
{
    partial class formchart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_Ch1_Print = new System.Windows.Forms.Button();
            this.MyPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.Btn_Ch2_Reset = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.Btn_Ch2_RemovePoint = new System.Windows.Forms.Button();
            this.rdbUnMasked = new System.Windows.Forms.RadioButton();
            this.rdbMasked = new System.Windows.Forms.RadioButton();
            this.Btn_Ch1_2D_3D = new System.Windows.Forms.Button();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rdbMasked3 = new System.Windows.Forms.RadioButton();
            this.rdbUnmasked3 = new System.Windows.Forms.RadioButton();
            this.Btn_Chart3_RemovePoint = new System.Windows.Forms.Button();
            this.Btn_Chart3_Reset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            chartArea7.AxisX.Title = "Products";
            chartArea7.AxisY.Title = "Price";
            chartArea7.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            chartArea7.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart1.Legends.Add(legend7);
            this.chart1.Location = new System.Drawing.Point(1, 1);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series11.Legend = "Legend1";
            series11.MarkerColor = System.Drawing.Color.Yellow;
            series11.MarkerImage = "C:\\Users\\primeit\\Desktop\\lab img\\refreshsmall.png";
            series11.MarkerSize = 8;
            series11.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Cross;
            series11.Name = "Products";
            series11.YValuesPerPoint = 4;
            this.chart1.Series.Add(series11);
            this.chart1.Size = new System.Drawing.Size(338, 211);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "Product Price";
            title3.Name = "Title1";
            title3.Text = "The Products And Price";
            this.chart1.Titles.Add(title3);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load 4M DB";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_Ch1_Print
            // 
            this.Btn_Ch1_Print.Location = new System.Drawing.Point(543, 218);
            this.Btn_Ch1_Print.Name = "Btn_Ch1_Print";
            this.Btn_Ch1_Print.Size = new System.Drawing.Size(75, 23);
            this.Btn_Ch1_Print.TabIndex = 2;
            this.Btn_Ch1_Print.Text = "Print to PIC";
            this.Btn_Ch1_Print.UseVisualStyleBackColor = true;
            this.Btn_Ch1_Print.Click += new System.EventHandler(this.Btn_Ch1_Print_Click);
            // 
            // MyPrintDocument
            // 
            this.MyPrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.MyPrintDocument_PrintPage);
            // 
            // Btn_Ch2_Reset
            // 
            this.Btn_Ch2_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Ch2_Reset.Location = new System.Drawing.Point(906, 218);
            this.Btn_Ch2_Reset.Name = "Btn_Ch2_Reset";
            this.Btn_Ch2_Reset.Size = new System.Drawing.Size(75, 23);
            this.Btn_Ch2_Reset.TabIndex = 3;
            this.Btn_Ch2_Reset.Text = "Reset";
            this.Btn_Ch2_Reset.UseVisualStyleBackColor = true;
            this.Btn_Ch2_Reset.Click += new System.EventHandler(this.Btn_Ch2_Reset_Click);
            // 
            // chart2
            // 
            this.chart2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            chartArea8.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea8.Area3DStyle.WallWidth = 8;
            chartArea8.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea8.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea8.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea8.AxisX.IsLabelAutoFit = false;
            chartArea8.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea8.AxisX.LabelStyle.Interval = 0D;
            chartArea8.AxisX.Title = "FREQUENCY (Hz)";
            chartArea8.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea8.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea8.AxisY.Title = "DECIBELS";
            chartArea8.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea8);
            legend8.Enabled = false;
            legend8.Name = "Legend1";
            legend8.Title = "Edit Chart";
            this.chart2.Legends.Add(legend8);
            this.chart2.Location = new System.Drawing.Point(345, 0);
            this.chart2.Name = "chart2";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Legend = "Legend1";
            series12.Name = "Series1";
            this.chart2.Series.Add(series12);
            this.chart2.Size = new System.Drawing.Size(639, 212);
            this.chart2.TabIndex = 4;
            this.chart2.Text = "chart2";
            this.chart2.PostPaint += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ChartPaintEventArgs>(this.chart2_PostPaint);
            this.chart2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chart2_MouseClick);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(984, 676);
            this.shapeContainer1.TabIndex = 5;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape1.BorderWidth = 3;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -1;
            this.lineShape1.X2 = 986;
            this.lineShape1.Y1 = 255;
            this.lineShape1.Y2 = 255;
            // 
            // Btn_Ch2_RemovePoint
            // 
            this.Btn_Ch2_RemovePoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Ch2_RemovePoint.Location = new System.Drawing.Point(827, 218);
            this.Btn_Ch2_RemovePoint.Name = "Btn_Ch2_RemovePoint";
            this.Btn_Ch2_RemovePoint.Size = new System.Drawing.Size(75, 23);
            this.Btn_Ch2_RemovePoint.TabIndex = 7;
            this.Btn_Ch2_RemovePoint.Text = "Remove <";
            this.Btn_Ch2_RemovePoint.UseVisualStyleBackColor = true;
            this.Btn_Ch2_RemovePoint.Click += new System.EventHandler(this.Btn_Ch2_RemovePoint_Click);
            // 
            // rdbUnMasked
            // 
            this.rdbUnMasked.AutoSize = true;
            this.rdbUnMasked.Checked = true;
            this.rdbUnMasked.Location = new System.Drawing.Point(6, 15);
            this.rdbUnMasked.Name = "rdbUnMasked";
            this.rdbUnMasked.Size = new System.Drawing.Size(76, 17);
            this.rdbUnMasked.TabIndex = 8;
            this.rdbUnMasked.TabStop = true;
            this.rdbUnMasked.Text = "Unmasked";
            this.rdbUnMasked.UseVisualStyleBackColor = true;
            this.rdbUnMasked.CheckedChanged += new System.EventHandler(this.rdbUnMasked_CheckedChanged);
            // 
            // rdbMasked
            // 
            this.rdbMasked.AutoSize = true;
            this.rdbMasked.Location = new System.Drawing.Point(100, 15);
            this.rdbMasked.Name = "rdbMasked";
            this.rdbMasked.Size = new System.Drawing.Size(63, 17);
            this.rdbMasked.TabIndex = 9;
            this.rdbMasked.Text = "Masked";
            this.rdbMasked.UseVisualStyleBackColor = true;
            this.rdbMasked.CheckedChanged += new System.EventHandler(this.rdbUnMasked_CheckedChanged);
            // 
            // Btn_Ch1_2D_3D
            // 
            this.Btn_Ch1_2D_3D.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Ch1_2D_3D.Location = new System.Drawing.Point(626, 585);
            this.Btn_Ch1_2D_3D.Name = "Btn_Ch1_2D_3D";
            this.Btn_Ch1_2D_3D.Size = new System.Drawing.Size(75, 23);
            this.Btn_Ch1_2D_3D.TabIndex = 6;
            this.Btn_Ch1_2D_3D.Text = "3D/2D";
            this.Btn_Ch1_2D_3D.UseVisualStyleBackColor = true;
            this.Btn_Ch1_2D_3D.Click += new System.EventHandler(this.Btn_Ch1_2D_3D_Click);
            // 
            // chart3
            // 
            this.chart3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            chartArea9.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea9.Area3DStyle.WallWidth = 8;
            chartArea9.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea9.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea9.AxisX.IsLabelAutoFit = false;
            chartArea9.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea9.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Blue;
            chartArea9.AxisX.LabelStyle.Interval = 0D;
            chartArea9.AxisX.LineColor = System.Drawing.Color.Blue;
            chartArea9.AxisX.MajorGrid.LineColor = System.Drawing.Color.Blue;
            chartArea9.AxisX.Title = "FREQUENCY (Hz)";
            chartArea9.AxisX.TitleAlignment = System.Drawing.StringAlignment.Near;
            chartArea9.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea9.AxisX.TitleForeColor = System.Drawing.Color.Blue;
            chartArea9.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea9.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Blue;
            chartArea9.AxisY.LineColor = System.Drawing.Color.Blue;
            chartArea9.AxisY.MajorGrid.LineColor = System.Drawing.Color.Blue;
            chartArea9.AxisY.Title = "HEARING LEVEL IN DECIBELS (DB)";
            chartArea9.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea9.AxisY.TitleForeColor = System.Drawing.Color.Red;
            chartArea9.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea9);
            this.chart3.Cursor = System.Windows.Forms.Cursors.Hand;
            legend9.Enabled = false;
            legend9.Name = "Legend1";
            legend9.Title = "Edit Chart";
            this.chart3.Legends.Add(legend9);
            this.chart3.Location = new System.Drawing.Point(-1, 268);
            this.chart3.Name = "chart3";
            this.chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series13.Color = System.Drawing.Color.Blue;
            series13.Legend = "Legend1";
            series13.MarkerSize = 10;
            series13.Name = "Series1";
            series13.ShadowOffset = 1;
            series13.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series14.Color = System.Drawing.Color.Red;
            series14.Legend = "Legend1";
            series14.MarkerSize = 10;
            series14.Name = "Series2";
            series14.ShadowOffset = 1;
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series15.Color = System.Drawing.Color.Black;
            series15.Legend = "Legend1";
            series15.Name = "Series3";
            this.chart3.Series.Add(series13);
            this.chart3.Series.Add(series14);
            this.chart3.Series.Add(series15);
            this.chart3.Size = new System.Drawing.Size(982, 311);
            this.chart3.TabIndex = 10;
            this.chart3.Text = "chart3";
            this.chart3.PostPaint += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ChartPaintEventArgs>(this.chart3_PostPaint);
            this.chart3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chart3_MouseClick);
            // 
            // rdbMasked3
            // 
            this.rdbMasked3.AutoSize = true;
            this.rdbMasked3.Location = new System.Drawing.Point(103, 19);
            this.rdbMasked3.Name = "rdbMasked3";
            this.rdbMasked3.Size = new System.Drawing.Size(63, 17);
            this.rdbMasked3.TabIndex = 12;
            this.rdbMasked3.Text = "Masked";
            this.rdbMasked3.UseVisualStyleBackColor = true;
            // 
            // rdbUnmasked3
            // 
            this.rdbUnmasked3.AutoSize = true;
            this.rdbUnmasked3.Checked = true;
            this.rdbUnmasked3.Location = new System.Drawing.Point(9, 19);
            this.rdbUnmasked3.Name = "rdbUnmasked3";
            this.rdbUnmasked3.Size = new System.Drawing.Size(76, 17);
            this.rdbUnmasked3.TabIndex = 11;
            this.rdbUnmasked3.TabStop = true;
            this.rdbUnmasked3.Text = "Unmasked";
            this.rdbUnmasked3.UseVisualStyleBackColor = true;
            // 
            // Btn_Chart3_RemovePoint
            // 
            this.Btn_Chart3_RemovePoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Chart3_RemovePoint.Location = new System.Drawing.Point(830, 585);
            this.Btn_Chart3_RemovePoint.Name = "Btn_Chart3_RemovePoint";
            this.Btn_Chart3_RemovePoint.Size = new System.Drawing.Size(75, 23);
            this.Btn_Chart3_RemovePoint.TabIndex = 14;
            this.Btn_Chart3_RemovePoint.Text = "Remove <";
            this.Btn_Chart3_RemovePoint.UseVisualStyleBackColor = true;
            this.Btn_Chart3_RemovePoint.Click += new System.EventHandler(this.Btn_Chart3_RemovePoint_Click);
            // 
            // Btn_Chart3_Reset
            // 
            this.Btn_Chart3_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Chart3_Reset.Location = new System.Drawing.Point(909, 585);
            this.Btn_Chart3_Reset.Name = "Btn_Chart3_Reset";
            this.Btn_Chart3_Reset.Size = new System.Drawing.Size(75, 23);
            this.Btn_Chart3_Reset.TabIndex = 13;
            this.Btn_Chart3_Reset.Text = "Reset";
            this.Btn_Chart3_Reset.UseVisualStyleBackColor = true;
            this.Btn_Chart3_Reset.Click += new System.EventHandler(this.Btn_Chart3_Reset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbUnMasked);
            this.groupBox1.Controls.Add(this.rdbMasked);
            this.groupBox1.Location = new System.Drawing.Point(345, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 35);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Modality";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.rdbMasked3);
            this.groupBox2.Controls.Add(this.rdbUnmasked3);
            this.groupBox2.Location = new System.Drawing.Point(3, 607);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 46);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Modality";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Location = new System.Drawing.Point(707, 585);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(117, 23);
            this.btnPrint.TabIndex = 17;
            this.btnPrint.Text = "Default Print Privew";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(189, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(624, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Print to File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(189, 650);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "frm2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(503, 585);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "Print The Whole Frm";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // formchart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 676);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_Chart3_RemovePoint);
            this.Controls.Add(this.Btn_Chart3_Reset);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.Btn_Ch2_RemovePoint);
            this.Controls.Add(this.Btn_Ch1_2D_3D);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.Btn_Ch2_Reset);
            this.Controls.Add(this.Btn_Ch1_Print);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "formchart";
            this.Text = "formchart";
            this.Load += new System.EventHandler(this.formchart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Btn_Ch1_Print;
        private System.Drawing.Printing.PrintDocument MyPrintDocument;
        private System.Windows.Forms.Button Btn_Ch2_Reset;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button Btn_Ch1_2D_3D;
        private System.Windows.Forms.Button Btn_Ch2_RemovePoint;
        private System.Windows.Forms.RadioButton rdbUnMasked;
        private System.Windows.Forms.RadioButton rdbMasked;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.RadioButton rdbMasked3;
        private System.Windows.Forms.RadioButton rdbUnmasked3;
        private System.Windows.Forms.Button Btn_Chart3_RemovePoint;
        private System.Windows.Forms.Button Btn_Chart3_Reset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button button4;
    }
}