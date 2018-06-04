using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Drawing.Imaging;
using CrystalDecisions.CrystalReports.Engine;

namespace EditableChart
{
    public partial class AudioGram : Form
    {
        public AudioGram()
        {
            InitializeComponent();
        }

        List<double> MyIntervalARight = new List<double>();//125,250,500
        List<double> MyIntervalBRight = new List<double>();//(8000/7)

        List<double> MyIntervalALeft = new List<double>();//125,250,500
        List<double> MyIntervalBLeft = new List<double>();//(8000/7)

        private void AudioGram_Load(object sender, EventArgs e)
        {
            MyIntervalARight.AddRange(new[] { 125, 250, 500.0, 1000, 2000, 4000, 8000 });
            MyIntervalBRight.AddRange(new[] { 1142.85, 2285.71, 3428.55, 4571.4, 5714.25, 6857.1, 7999.95 });///(8000/7)

            MyIntervalALeft.AddRange(new[] { 125, 250, 500.0, 1000, 2000, 4000, 8000 });
            MyIntervalBLeft.AddRange(new[] { 1142.85, 2285.71, 3428.55, 4571.4, 5714.25, 6857.1, 7999.95 });///(8000/7)

            SetChartR();
            SetChartL();

            ////////////
            //chartR.Titles["Title1"].Text = "My Chart";
            ///////////
            this.cbxSex.SelectedIndex = 0;
        }

        private void SetChartL()
        {
            chartL.ChartAreas[0].AxisX.Minimum = 0;//0 //IF REQUIRED
            chartL.ChartAreas[0].AxisX.Maximum = 8000;//8000 //SET

            //chart3.ChartAreas[0].AxisX.IntervalOffset = 125;//IF REQUIRED

            chartL.ChartAreas[0].AxisX.Interval = 250; //SET

            chartL.ChartAreas[0].AxisY.Minimum = -10;
            chartL.ChartAreas[0].AxisY.Maximum = 120;
            chartL.ChartAreas[0].AxisY.Interval = 10;

            ////NOW THE START POINT IS NOT DECIDED BY PROGRAMMER
            //chart3.Series["Series1"].Points.AddXY(0, 0);
            //chart3.Series["Series2"].Points.AddXY(0, 0);
            chartL.Series["Series3"].Points.AddXY(0, 0);

            chartL.Series["Series1"].MarkerStyle = MarkerStyle.Cross;
            chartL.Series["Series2"].MarkerStyle = MarkerStyle.Square;


            chartL.ChartAreas[0].AxisX.LabelStyle.Interval = 10000;///////HAVE SET TO FAREST POINT

            //////////////HIDEING Y AXIS LINES
            chartL.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartL.ChartAreas[0].AxisX.MajorTickMark.Enabled = false;
            chartL.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
        }

        private void SetChartR()
        {
            chartR.ChartAreas[0].AxisX.Minimum = 0;//0 //IF REQUIRED
            chartR.ChartAreas[0].AxisX.Maximum = 8000;//8000 //SET

            //chart3.ChartAreas[0].AxisX.IntervalOffset = 125;//IF REQUIRED

            chartR.ChartAreas[0].AxisX.Interval = 250; //SET

            chartR.ChartAreas[0].AxisY.Minimum = -10;
            chartR.ChartAreas[0].AxisY.Maximum = 120;
            chartR.ChartAreas[0].AxisY.Interval = 10;

            ////NOW THE START POINT IS NOT DECIDED BY PROGRAMMER
            //chart3.Series["Series1"].Points.AddXY(0, 0);
            //chart3.Series["Series2"].Points.AddXY(0, 0);
            chartR.Series["Series3"].Points.AddXY(0, 0);

            chartR.Series["Series1"].MarkerStyle = MarkerStyle.Triangle;
            chartR.Series["Series2"].MarkerStyle = MarkerStyle.Circle;


            chartR.ChartAreas[0].AxisX.LabelStyle.Interval = 10000;///////HAVE SET TO FAREST POINT

            //////////////HIDEING Y AXIS LINES
            chartR.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartR.ChartAreas[0].AxisX.MajorTickMark.Enabled = false;
            chartR.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
        }

        private void chartR_MouseClick(object sender, MouseEventArgs e)
        {
            if (chartR.Series.Count > 0)
            {
                if (rdbMaskedR.Checked)
                {
                    chartR.Series["Series1"].Points.AddXY(Math.Round(chartR.ChartAreas[0].AxisX.PixelPositionToValue(e.X), 2), chartR.ChartAreas[0].AxisY.PixelPositionToValue(e.Y));
                }
                else
                {
                    chartR.Series["Series2"].Points.AddXY(Math.Round(chartR.ChartAreas[0].AxisX.PixelPositionToValue(e.X), 2), chartR.ChartAreas[0].AxisY.PixelPositionToValue(e.Y));
                }

            }
            else
            {

            }
        }
        int indexR;
        private void chartR_PostPaint(object sender, ChartPaintEventArgs e)
        {
            indexR = 0;

            Graphics g = e.ChartGraphics.Graphics;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

            ChartArea ca = chartR.ChartAreas[0];

            Font font = ca.AxisX.LabelStyle.Font;
            Color col = ca.AxisX.MajorGrid.LineColor;
            int padding = 12;

            int y0 = (int)ca.AxisY.ValueToPixelPosition(ca.AxisY.Minimum);
            int y1 = (int)ca.AxisY.ValueToPixelPosition(ca.AxisY.Maximum);

            foreach (int sx in MyIntervalBRight)
            {
                int x = (int)ca.AxisX.ValueToPixelPosition(sx);

                ///////////////////COMMENT 2 LINES TO NOT LET IT DRAW Y LINES ON GRAPH//////////////////////////////
                using (Pen pen = new Pen(col))
                    g.DrawLine(pen, x, y0, x, y1);

                string s = MyIntervalARight[indexR] + "Hz";
                if (ca.AxisX.LabelStyle.Format != "")
                    s = string.Format(ca.AxisX.LabelStyle.Format, s);

                SizeF sz = g.MeasureString(s, font, 999);
                g.DrawString(s, font, Brushes.Blue, (int)(x - sz.Width / 2), y0 + padding);

                /////hide default x axis lines of chart
                ca.AxisX.MajorGrid.Enabled = false;
                ca.AxisX.MajorTickMark.Enabled = false;
                ca.AxisX.LabelStyle.Enabled = false;

                indexR++;
            }
        }

        private void Btn_ChR_2D_3D_Click(object sender, EventArgs e)
        {
            if (chartR.ChartAreas[0].Area3DStyle.Enable3D)
            {
                chartR.ChartAreas[0].Area3DStyle.Enable3D = false;
            }
            else
            {
                chartR.ChartAreas[0].Area3DStyle.Enable3D = true;
            }
        }

        private void btnPrintChartR_Click(object sender, EventArgs e)
        {
            chartR.Printing.PrintPreview();
        }

        private void Btn_ChartR_RemovePoint_Click(object sender, EventArgs e)
        {
            if (rdbMaskedR.Checked)
            {
                if ((chartR.Series[0].Points.Count) > 1)
                {
                    chartR.Series[0].Points.RemoveAt(chartR.Series[0].Points.Count - 1);
                }
                else
                {
                    Btn_ChartR_Reset_Click(sender, e);
                }
            }
            else
            {
                if ((chartR.Series[1].Points.Count) > 1)
                {
                    chartR.Series[1].Points.RemoveAt(chartR.Series[1].Points.Count - 1);
                }
                else
                {
                    Btn_ChartR_Reset_Click(sender, e);
                }
            }
        }

        private void Btn_ChartR_Reset_Click(object sender, EventArgs e)
        {
            if (rdbMaskedR.Checked)
            {
                chartR.Series[0].Points.Clear();
            }
            else
            {
                chartR.Series[1].Points.Clear();
            }
        }

        private void chartL_MouseClick(object sender, MouseEventArgs e)
        {
            if (chartL.Series.Count > 0)
            {
                if (rdbMaskedL.Checked)
                {
                    chartL.Series["Series1"].Points.AddXY(Math.Round(chartL.ChartAreas[0].AxisX.PixelPositionToValue(e.X), 2), chartL.ChartAreas[0].AxisY.PixelPositionToValue(e.Y));
                }
                else
                {
                    chartL.Series["Series2"].Points.AddXY(Math.Round(chartL.ChartAreas[0].AxisX.PixelPositionToValue(e.X), 2), chartL.ChartAreas[0].AxisY.PixelPositionToValue(e.Y));
                }

            }
            else
            {

            }
        }

        int indexL;
        private void chartL_PostPaint(object sender, ChartPaintEventArgs e)
        {
            indexL = 0;

            Graphics g = e.ChartGraphics.Graphics;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

            ChartArea ca = chartL.ChartAreas[0];

            Font font = ca.AxisX.LabelStyle.Font;
            Color col = ca.AxisX.MajorGrid.LineColor;
            int padding = 12;

            int y0 = (int)ca.AxisY.ValueToPixelPosition(ca.AxisY.Minimum);
            int y1 = (int)ca.AxisY.ValueToPixelPosition(ca.AxisY.Maximum);

            foreach (int sx in MyIntervalBLeft)
            {
                int x = (int)ca.AxisX.ValueToPixelPosition(sx);

                ///////////////////COMMENT 2 LINES TO NOT LET IT DRAW Y LINES ON GRAPH//////////////////////////////
                using (Pen pen = new Pen(col))
                    g.DrawLine(pen, x, y0, x, y1);

                string s = MyIntervalALeft[indexL] + "Hz";
                if (ca.AxisX.LabelStyle.Format != "")
                    s = string.Format(ca.AxisX.LabelStyle.Format, s);

                SizeF sz = g.MeasureString(s, font, 999);
                g.DrawString(s, font, Brushes.Red, (int)(x - sz.Width / 2), y0 + padding);

                /////hide default x axis lines of chart
                ca.AxisX.MajorGrid.Enabled = false;
                ca.AxisX.MajorTickMark.Enabled = false;
                ca.AxisX.LabelStyle.Enabled = false;

                indexL++;
            }
        }

        private void Btn_ChL_2D_3D_Click(object sender, EventArgs e)
        {
            if (chartL.ChartAreas[0].Area3DStyle.Enable3D)
            {
                chartL.ChartAreas[0].Area3DStyle.Enable3D = false;
            }
            else
            {
                chartL.ChartAreas[0].Area3DStyle.Enable3D = true;
            }
        }

        private void btnPrintChartL_Click(object sender, EventArgs e)
        {
            chartL.Printing.PrintPreview();
        }

        private void Btn_ChartL_RemovePoint_Click(object sender, EventArgs e)
        {
            if (rdbMaskedL.Checked)
            {
                if ((chartL.Series[0].Points.Count) > 1)
                {
                    chartL.Series[0].Points.RemoveAt(chartL.Series[0].Points.Count - 1);
                }
                else
                {
                    Btn_ChartL_Reset_Click(sender, e);
                }
            }
            else
            {
                if ((chartL.Series[1].Points.Count) > 1)
                {
                    chartL.Series[1].Points.RemoveAt(chartL.Series[1].Points.Count - 1);
                }
                else
                {
                    Btn_ChartL_Reset_Click(sender, e);
                }
            }
        }

        private void Btn_ChartL_Reset_Click(object sender, EventArgs e)
        {
            if (rdbMaskedL.Checked)
            {
                chartL.Series[0].Points.Clear();
            }
            else
            {
                chartL.Series[1].Points.Clear();
            }
        }
        
        private void BtnPrint_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("sr");
            dt.Columns.Add("Name");
            dt.Columns.Add("Age");
            dt.Columns.Add("Sex");
            dt.Columns.Add("Date");
            dt.Columns.Add("Recommendation");
            dt.Columns.Add("MaskingDetails");
            dt.Columns.Add("RemarksR");
            dt.Columns.Add("RemarksL");

            DataColumn colByteArray = new DataColumn("ChartR");
            colByteArray.DataType = System.Type.GetType("System.Byte[]");
            dt.Columns.Add(colByteArray);

            colByteArray = new DataColumn("ChartL");
            colByteArray.DataType = System.Type.GetType("System.Byte[]");
            dt.Columns.Add(colByteArray);

            dt.Rows.Add("0");

            //////////////

            Bitmap MyChartPanel = new Bitmap(this.chartR.Width, chartR.Height);
            chartR.DrawToBitmap(MyChartPanel, new Rectangle(0, 0, chartR.Width, chartR.Height));

            //using (MemoryStream memory = new MemoryStream())
            //{
            //    using (FileStream fs = new FileStream(Application.StartupPath + "\\" + "ChartR.jpeg", FileMode.Create, FileAccess.ReadWrite))
            //    {
            //        MyChartPanel.Save(memory, ImageFormat.Jpeg);
            //        byte[] bytes = memory.ToArray();
            //        fs.Write(bytes, 0, bytes.Length);
            //    }
            //}

            /////////////
            ImageConverter converter = new ImageConverter();
            dt.Rows[0]["ChartR"] = (byte[])converter.ConvertTo(MyChartPanel, typeof(byte[]));
            dt.Rows[0]["ChartR"] = dt.Rows[0]["ChartR"] = (byte[])converter.ConvertTo(MyChartPanel, typeof(byte[]));
            ////////////

            chartL.DrawToBitmap(MyChartPanel, new Rectangle(0, 0, chartL.Width, chartL.Height));

            //using (MemoryStream memory = new MemoryStream())
            //{
            //    using (FileStream fs = new FileStream(Application.StartupPath + "\\" + "ChartL.jpeg", FileMode.Create, FileAccess.ReadWrite))
            //    {
            //        MyChartPanel.Save(memory, ImageFormat.Jpeg);
            //        byte[] bytes = memory.ToArray();
            //        fs.Write(bytes, 0, bytes.Length);
            //    }
            //}

            /////////////
            dt.Rows[0]["ChartL"] = (byte[])converter.ConvertTo(MyChartPanel, typeof(byte[]));
            dt.Rows[0]["ChartL"] = dt.Rows[0]["ChartL"] = (byte[])converter.ConvertTo(MyChartPanel, typeof(byte[]));
            ////////////

            dt.Rows[0]["Name"] = this.txtName.Text;
            dt.Rows[0]["Age"] = this.txtAge.Text;
            dt.Rows[0]["Sex"] = this.cbxSex.Text;
            dt.Rows[0]["Date"] = this.dateTimePicker.Value;
            dt.Rows[0]["MaskingDetails"] = this.txtMaskingDetails.Text;
            dt.Rows[0]["RemarksR"] = this.txtRemarksR.Text;
            dt.Rows[0]["RemarksL"] = this.txtRemarksL.Text;
            dt.Rows[0]["Recommendation"] = this.txtRecommendation.Text;

            ReportDocument rd = new ReportDocument();
            string thepath = Application.StartupPath + "\\Reports\\PrintAudiogram.rpt";
            rd.Load(thepath);

            rd.Database.Tables[0].SetDataSource(dt);

            ReportViwer rptV = new ReportViwer();
            rptV.rptRD1 = rd;
            rptV.rptTitle = "Audiogram";
            rptV.Show();
        }
    }
}
