namespace EditableChart
{
    partial class AudioGram
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxR = new System.Windows.Forms.GroupBox();
            this.rdbMaskedR = new System.Windows.Forms.RadioButton();
            this.rdbUnmaskedR = new System.Windows.Forms.RadioButton();
            this.btnPrintChartR = new System.Windows.Forms.Button();
            this.Btn_ChartR_RemovePoint = new System.Windows.Forms.Button();
            this.Btn_ChartR_Reset = new System.Windows.Forms.Button();
            this.Btn_ChR_2D_3D = new System.Windows.Forms.Button();
            this.btnPrintChartL = new System.Windows.Forms.Button();
            this.Btn_ChartL_RemovePoint = new System.Windows.Forms.Button();
            this.Btn_ChartL_Reset = new System.Windows.Forms.Button();
            this.Btn_ChL_2D_3D = new System.Windows.Forms.Button();
            this.groupBoxL = new System.Windows.Forms.GroupBox();
            this.rdbMaskedL = new System.Windows.Forms.RadioButton();
            this.rdbUnmaskedL = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.chartL = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxSex = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtMaskingDetails = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRemarksR = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRemarksL = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRecommendation = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartR)).BeginInit();
            this.groupBoxR.SuspendLayout();
            this.groupBoxL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartL)).BeginInit();
            this.SuspendLayout();
            // 
            // chartR
            // 
            this.chartR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.Area3DStyle.WallWidth = 8;
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Blue;
            chartArea1.AxisX.LabelStyle.Interval = 0D;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Blue;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Blue;
            chartArea1.AxisX.Title = "FREQUENCY (Hz)";
            chartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Near;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.Blue;
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Blue;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Blue;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Blue;
            chartArea1.AxisY.Title = "HEARING LEVEL IN DECIBELS (DB)";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.Red;
            chartArea1.Name = "ChartArea1";
            this.chartR.ChartAreas.Add(chartArea1);
            this.chartR.Cursor = System.Windows.Forms.Cursors.Hand;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            legend1.Title = "Edit Chart";
            this.chartR.Legends.Add(legend1);
            this.chartR.Location = new System.Drawing.Point(16, 100);
            this.chartR.Name = "chartR";
            this.chartR.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Blue;
            series1.Legend = "Legend1";
            series1.MarkerSize = 10;
            series1.Name = "Series1";
            series1.ShadowOffset = 1;
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.MarkerSize = 10;
            series2.Name = "Series2";
            series2.ShadowOffset = 1;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Color = System.Drawing.Color.Black;
            series3.Legend = "Legend1";
            series3.Name = "Series3";
            this.chartR.Series.Add(series1);
            this.chartR.Series.Add(series2);
            this.chartR.Series.Add(series3);
            this.chartR.Size = new System.Drawing.Size(450, 316);
            this.chartR.TabIndex = 11;
            this.chartR.Text = "chart3";
            this.chartR.PostPaint += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ChartPaintEventArgs>(this.chartR_PostPaint);
            this.chartR.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chartR_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(194, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "RIGHT EAR";
            // 
            // groupBoxR
            // 
            this.groupBoxR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxR.Controls.Add(this.rdbMaskedR);
            this.groupBoxR.Controls.Add(this.rdbUnmaskedR);
            this.groupBoxR.Location = new System.Drawing.Point(16, 421);
            this.groupBoxR.Name = "groupBoxR";
            this.groupBoxR.Size = new System.Drawing.Size(170, 46);
            this.groupBoxR.TabIndex = 17;
            this.groupBoxR.TabStop = false;
            this.groupBoxR.Text = "Select Modality";
            // 
            // rdbMaskedR
            // 
            this.rdbMaskedR.AutoSize = true;
            this.rdbMaskedR.Location = new System.Drawing.Point(103, 19);
            this.rdbMaskedR.Name = "rdbMaskedR";
            this.rdbMaskedR.Size = new System.Drawing.Size(63, 17);
            this.rdbMaskedR.TabIndex = 12;
            this.rdbMaskedR.Text = "Masked";
            this.rdbMaskedR.UseVisualStyleBackColor = true;
            // 
            // rdbUnmaskedR
            // 
            this.rdbUnmaskedR.AutoSize = true;
            this.rdbUnmaskedR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rdbUnmaskedR.Checked = true;
            this.rdbUnmaskedR.Location = new System.Drawing.Point(9, 19);
            this.rdbUnmaskedR.Name = "rdbUnmaskedR";
            this.rdbUnmaskedR.Size = new System.Drawing.Size(76, 17);
            this.rdbUnmaskedR.TabIndex = 11;
            this.rdbUnmaskedR.TabStop = true;
            this.rdbUnmaskedR.Text = "Unmasked";
            this.rdbUnmaskedR.UseVisualStyleBackColor = true;
            // 
            // btnPrintChartR
            // 
            this.btnPrintChartR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintChartR.Location = new System.Drawing.Point(243, 437);
            this.btnPrintChartR.Name = "btnPrintChartR";
            this.btnPrintChartR.Size = new System.Drawing.Size(98, 23);
            this.btnPrintChartR.TabIndex = 21;
            this.btnPrintChartR.Text = "Single Chart Print";
            this.btnPrintChartR.UseVisualStyleBackColor = true;
            this.btnPrintChartR.Click += new System.EventHandler(this.btnPrintChartR_Click);
            // 
            // Btn_ChartR_RemovePoint
            // 
            this.Btn_ChartR_RemovePoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_ChartR_RemovePoint.Location = new System.Drawing.Point(341, 437);
            this.Btn_ChartR_RemovePoint.Name = "Btn_ChartR_RemovePoint";
            this.Btn_ChartR_RemovePoint.Size = new System.Drawing.Size(73, 23);
            this.Btn_ChartR_RemovePoint.TabIndex = 20;
            this.Btn_ChartR_RemovePoint.Text = "Remove <";
            this.Btn_ChartR_RemovePoint.UseVisualStyleBackColor = true;
            this.Btn_ChartR_RemovePoint.Click += new System.EventHandler(this.Btn_ChartR_RemovePoint_Click);
            // 
            // Btn_ChartR_Reset
            // 
            this.Btn_ChartR_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_ChartR_Reset.Location = new System.Drawing.Point(414, 437);
            this.Btn_ChartR_Reset.Name = "Btn_ChartR_Reset";
            this.Btn_ChartR_Reset.Size = new System.Drawing.Size(52, 23);
            this.Btn_ChartR_Reset.TabIndex = 19;
            this.Btn_ChartR_Reset.Text = "Reset";
            this.Btn_ChartR_Reset.UseVisualStyleBackColor = true;
            this.Btn_ChartR_Reset.Click += new System.EventHandler(this.Btn_ChartR_Reset_Click);
            // 
            // Btn_ChR_2D_3D
            // 
            this.Btn_ChR_2D_3D.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_ChR_2D_3D.Location = new System.Drawing.Point(191, 437);
            this.Btn_ChR_2D_3D.Name = "Btn_ChR_2D_3D";
            this.Btn_ChR_2D_3D.Size = new System.Drawing.Size(52, 23);
            this.Btn_ChR_2D_3D.TabIndex = 18;
            this.Btn_ChR_2D_3D.Text = "3D/2D";
            this.Btn_ChR_2D_3D.UseVisualStyleBackColor = true;
            this.Btn_ChR_2D_3D.Click += new System.EventHandler(this.Btn_ChR_2D_3D_Click);
            // 
            // btnPrintChartL
            // 
            this.btnPrintChartL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintChartL.Location = new System.Drawing.Point(750, 434);
            this.btnPrintChartL.Name = "btnPrintChartL";
            this.btnPrintChartL.Size = new System.Drawing.Size(102, 23);
            this.btnPrintChartL.TabIndex = 28;
            this.btnPrintChartL.Text = "Single Chart Print";
            this.btnPrintChartL.UseVisualStyleBackColor = true;
            this.btnPrintChartL.Click += new System.EventHandler(this.btnPrintChartL_Click);
            // 
            // Btn_ChartL_RemovePoint
            // 
            this.Btn_ChartL_RemovePoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_ChartL_RemovePoint.Location = new System.Drawing.Point(852, 434);
            this.Btn_ChartL_RemovePoint.Name = "Btn_ChartL_RemovePoint";
            this.Btn_ChartL_RemovePoint.Size = new System.Drawing.Size(73, 23);
            this.Btn_ChartL_RemovePoint.TabIndex = 27;
            this.Btn_ChartL_RemovePoint.Text = "Remove <";
            this.Btn_ChartL_RemovePoint.UseVisualStyleBackColor = true;
            this.Btn_ChartL_RemovePoint.Click += new System.EventHandler(this.Btn_ChartL_RemovePoint_Click);
            // 
            // Btn_ChartL_Reset
            // 
            this.Btn_ChartL_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_ChartL_Reset.Location = new System.Drawing.Point(925, 434);
            this.Btn_ChartL_Reset.Name = "Btn_ChartL_Reset";
            this.Btn_ChartL_Reset.Size = new System.Drawing.Size(52, 23);
            this.Btn_ChartL_Reset.TabIndex = 26;
            this.Btn_ChartL_Reset.Text = "Reset";
            this.Btn_ChartL_Reset.UseVisualStyleBackColor = true;
            this.Btn_ChartL_Reset.Click += new System.EventHandler(this.Btn_ChartL_Reset_Click);
            // 
            // Btn_ChL_2D_3D
            // 
            this.Btn_ChL_2D_3D.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_ChL_2D_3D.Location = new System.Drawing.Point(698, 434);
            this.Btn_ChL_2D_3D.Name = "Btn_ChL_2D_3D";
            this.Btn_ChL_2D_3D.Size = new System.Drawing.Size(52, 23);
            this.Btn_ChL_2D_3D.TabIndex = 25;
            this.Btn_ChL_2D_3D.Text = "3D/2D";
            this.Btn_ChL_2D_3D.UseVisualStyleBackColor = true;
            this.Btn_ChL_2D_3D.Click += new System.EventHandler(this.Btn_ChL_2D_3D_Click);
            // 
            // groupBoxL
            // 
            this.groupBoxL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxL.Controls.Add(this.rdbMaskedL);
            this.groupBoxL.Controls.Add(this.rdbUnmaskedL);
            this.groupBoxL.Location = new System.Drawing.Point(526, 421);
            this.groupBoxL.Name = "groupBoxL";
            this.groupBoxL.Size = new System.Drawing.Size(170, 46);
            this.groupBoxL.TabIndex = 24;
            this.groupBoxL.TabStop = false;
            this.groupBoxL.Text = "Select Modality";
            // 
            // rdbMaskedL
            // 
            this.rdbMaskedL.AutoSize = true;
            this.rdbMaskedL.Location = new System.Drawing.Point(103, 19);
            this.rdbMaskedL.Name = "rdbMaskedL";
            this.rdbMaskedL.Size = new System.Drawing.Size(63, 17);
            this.rdbMaskedL.TabIndex = 12;
            this.rdbMaskedL.Text = "Masked";
            this.rdbMaskedL.UseVisualStyleBackColor = true;
            // 
            // rdbUnmaskedL
            // 
            this.rdbUnmaskedL.AutoSize = true;
            this.rdbUnmaskedL.Checked = true;
            this.rdbUnmaskedL.Location = new System.Drawing.Point(9, 19);
            this.rdbUnmaskedL.Name = "rdbUnmaskedL";
            this.rdbUnmaskedL.Size = new System.Drawing.Size(76, 17);
            this.rdbUnmaskedL.TabIndex = 11;
            this.rdbUnmaskedL.TabStop = true;
            this.rdbUnmaskedL.Text = "Unmasked";
            this.rdbUnmaskedL.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(711, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "LEFT EAR";
            // 
            // chartL
            // 
            this.chartL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea2.Area3DStyle.WallWidth = 8;
            chartArea2.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea2.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Red;
            chartArea2.AxisX.LabelStyle.Interval = 0D;
            chartArea2.AxisX.LineColor = System.Drawing.Color.Red;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Red;
            chartArea2.AxisX.Title = "FREQUENCY (Hz)";
            chartArea2.AxisX.TitleAlignment = System.Drawing.StringAlignment.Near;
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.Red;
            chartArea2.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Red;
            chartArea2.AxisY.LineColor = System.Drawing.Color.Red;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Red;
            chartArea2.AxisY.Title = "HEARING LEVEL IN DECIBELS (DB)";
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.TitleForeColor = System.Drawing.Color.Blue;
            chartArea2.Name = "ChartArea1";
            this.chartL.ChartAreas.Add(chartArea2);
            this.chartL.Cursor = System.Windows.Forms.Cursors.Hand;
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            legend2.Title = "Edit Chart";
            this.chartL.Legends.Add(legend2);
            this.chartL.Location = new System.Drawing.Point(526, 100);
            this.chartL.Name = "chartL";
            this.chartL.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Blue;
            series4.Legend = "Legend1";
            series4.MarkerSize = 10;
            series4.Name = "Series1";
            series4.ShadowOffset = 1;
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Red;
            series5.Legend = "Legend1";
            series5.MarkerSize = 10;
            series5.Name = "Series2";
            series5.ShadowOffset = 1;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series6.Color = System.Drawing.Color.Black;
            series6.Legend = "Legend1";
            series6.Name = "Series3";
            this.chartL.Series.Add(series4);
            this.chartL.Series.Add(series5);
            this.chartL.Series.Add(series6);
            this.chartL.Size = new System.Drawing.Size(450, 316);
            this.chartL.TabIndex = 22;
            this.chartL.Text = "chart3";
            this.chartL.PostPaint += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ChartPaintEventArgs>(this.chartL_PostPaint);
            this.chartL.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chartL_MouseClick);
            // 
            // BtnPrint
            // 
            this.BtnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPrint.Location = new System.Drawing.Point(902, 473);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(75, 23);
            this.BtnPrint.TabIndex = 30;
            this.BtnPrint.Text = "Print";
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(16, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 32;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(122, 34);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(119, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(226, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Sex";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(291, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Date";
            // 
            // cbxSex
            // 
            this.cbxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSex.FormattingEnabled = true;
            this.cbxSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbxSex.Location = new System.Drawing.Point(228, 34);
            this.cbxSex.Name = "cbxSex";
            this.cbxSex.Size = new System.Drawing.Size(60, 21);
            this.cbxSex.TabIndex = 37;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(294, 34);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(95, 20);
            this.dateTimePicker.TabIndex = 38;
            // 
            // txtMaskingDetails
            // 
            this.txtMaskingDetails.Location = new System.Drawing.Point(16, 493);
            this.txtMaskingDetails.Multiline = true;
            this.txtMaskingDetails.Name = "txtMaskingDetails";
            this.txtMaskingDetails.Size = new System.Drawing.Size(450, 60);
            this.txtMaskingDetails.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 477);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Masking Details";
            // 
            // txtRemarksR
            // 
            this.txtRemarksR.Location = new System.Drawing.Point(16, 577);
            this.txtRemarksR.Multiline = true;
            this.txtRemarksR.Name = "txtRemarksR";
            this.txtRemarksR.Size = new System.Drawing.Size(450, 32);
            this.txtRemarksR.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 561);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Remarks R";
            // 
            // txtRemarksL
            // 
            this.txtRemarksL.Location = new System.Drawing.Point(526, 577);
            this.txtRemarksL.Multiline = true;
            this.txtRemarksL.Name = "txtRemarksL";
            this.txtRemarksL.Size = new System.Drawing.Size(450, 32);
            this.txtRemarksL.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(523, 561);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Remarks L";
            // 
            // txtRecommendation
            // 
            this.txtRecommendation.Location = new System.Drawing.Point(16, 634);
            this.txtRecommendation.Multiline = true;
            this.txtRecommendation.Name = "txtRecommendation";
            this.txtRecommendation.Size = new System.Drawing.Size(960, 32);
            this.txtRecommendation.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 618);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "Recommendation";
            // 
            // AudioGram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 678);
            this.Controls.Add(this.txtRecommendation);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtRemarksL);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtRemarksR);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMaskingDetails);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.cbxSex);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.btnPrintChartL);
            this.Controls.Add(this.Btn_ChartL_RemovePoint);
            this.Controls.Add(this.Btn_ChartL_Reset);
            this.Controls.Add(this.Btn_ChL_2D_3D);
            this.Controls.Add(this.groupBoxL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chartL);
            this.Controls.Add(this.btnPrintChartR);
            this.Controls.Add(this.Btn_ChartR_RemovePoint);
            this.Controls.Add(this.Btn_ChartR_Reset);
            this.Controls.Add(this.Btn_ChR_2D_3D);
            this.Controls.Add(this.groupBoxR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartR);
            this.Name = "AudioGram";
            this.Text = "AudioGram";
            this.Load += new System.EventHandler(this.AudioGram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartR)).EndInit();
            this.groupBoxR.ResumeLayout(false);
            this.groupBoxR.PerformLayout();
            this.groupBoxL.ResumeLayout(false);
            this.groupBoxL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxR;
        private System.Windows.Forms.RadioButton rdbMaskedR;
        private System.Windows.Forms.RadioButton rdbUnmaskedR;
        private System.Windows.Forms.Button btnPrintChartR;
        private System.Windows.Forms.Button Btn_ChartR_RemovePoint;
        private System.Windows.Forms.Button Btn_ChartR_Reset;
        private System.Windows.Forms.Button Btn_ChR_2D_3D;
        private System.Windows.Forms.Button btnPrintChartL;
        private System.Windows.Forms.Button Btn_ChartL_RemovePoint;
        private System.Windows.Forms.Button Btn_ChartL_Reset;
        private System.Windows.Forms.Button Btn_ChL_2D_3D;
        private System.Windows.Forms.GroupBox groupBoxL;
        private System.Windows.Forms.RadioButton rdbMaskedL;
        private System.Windows.Forms.RadioButton rdbUnmaskedL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartL;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxSex;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox txtMaskingDetails;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRemarksR;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRemarksL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRecommendation;
        private System.Windows.Forms.Label label10;
    }
}