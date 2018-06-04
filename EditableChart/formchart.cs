using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing.Printing;
using System.Drawing.Imaging;
using System.IO;

namespace EditableChart
{
    public partial class formchart : Form
    {
        ////////////////////////////////////PRINTING OF WHOLE FORM
        private System.IO.Stream streamToPrint;
        string streamType;
        ////

        public formchart()
        {
            InitializeComponent();
        }

        ////////////////////////////////////PRINTING OF WHOLE FORM
        [System.Runtime.InteropServices.DllImportAttribute("gdi32.dll")]
        private static extern bool BitBlt
        (
            IntPtr hdcDest, // handle to destination DC
            int nXDest, // x-coord of destination upper-left corner
            int nYDest, // y-coord of destination upper-left corner
            int nWidth, // width of destination rectangle
            int nHeight, // height of destination rectangle
            IntPtr hdcSrc, // handle to source DC
            int nXSrc, // x-coordinate of source upper-left corner
            int nYSrc, // y-coordinate of source upper-left corner
            System.Int32 dwRop // raster operation code
        );
        ////


        List<double> MyInterval = new List<double>();//125,250,500 //USED IN CHART3 & CHART2
        List<double> MyInterval3 = new List<double>();//(8000/7) //USED IN CHART3

        private void formchart_Load(object sender, EventArgs e)
        {

            //chart1.Series["Names"].Points.AddXY("yellow", 15);
            //chart1.Series["Names"].Points.AddXY("black", 4);

            //chart1.Series["2ndName"].Points.AddXY(6, 6);

            GetData4MDB();

            SetChart3();

            chart2.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart2.ChartAreas[0].AxisX.MajorTickMark.Enabled = false;
            chart2.ChartAreas[0].AxisX.LabelStyle.Enabled = false;

            chart2.ChartAreas[0].AxisX.Minimum = 0;
            chart2.ChartAreas[0].AxisX.Maximum = 8000;
            //chart2.ChartAreas[0].AxisX.Interval = 10;

            MyInterval.AddRange(new[] { 125, 250, 500.0, 1000, 2000, 4000, 8000 });
            chart2.ChartAreas[0].AxisX.IntervalOffset = 125;


            chart2.ChartAreas[0].AxisY.Minimum = -10;
            chart2.ChartAreas[0].AxisY.Maximum = 120;
            chart2.ChartAreas[0].AxisY.Interval = 10;

            chart2.Series["Series1"].Points.AddXY(0, 0);

            ChartArea ca = chart1.ChartAreas[0];
            //ca.AxisX.Minimum = 0;  // optional
            ca.AxisX.MajorGrid.Enabled = false;
            ca.AxisX.MajorTickMark.Enabled = false;
            ca.AxisX.LabelStyle.Enabled = false;

            ////////////////
            //chart2.ChartAreas[0].AxisX.ScaleView.Zoomable = true;

            //////zoomin out
            //ChartArea CA = chart2.ChartAreas[0];  // quick reference
            //CA.AxisX.ScaleView.Zoomable = true;
            //CA.CursorX.AutoScroll = true;
            //CA.CursorX.IsUserSelectionEnabled = true;
        }

        private void SetChart3()
        {
            chart3.ChartAreas[0].AxisX.Minimum = 0;//0 //IF REQUIRED
            chart3.ChartAreas[0].AxisX.Maximum = 8000;//8000 //SET

            //chart3.ChartAreas[0].AxisX.IntervalOffset = 125;//IF REQUIRED

            chart3.ChartAreas[0].AxisX.Interval = 250; //SET

            chart3.ChartAreas[0].AxisY.Minimum = -10;
            chart3.ChartAreas[0].AxisY.Maximum = 120;
            chart3.ChartAreas[0].AxisY.Interval = 10;

            ////NOW THE START POINT IS NOT DECIDED BY PROGRAMMER
            //chart3.Series["Series1"].Points.AddXY(0, 0);
            //chart3.Series["Series2"].Points.AddXY(0, 0);
            chart3.Series["Series3"].Points.AddXY(0, 0);

            chart3.Series["Series1"].MarkerStyle = MarkerStyle.Triangle;
            chart3.Series["Series2"].MarkerStyle = MarkerStyle.Circle;

            /////////////////////////////INTERVAL INDICATED BY POINTS
            //chart3.Series["Series3"].Points.AddXY(125, -10);
            //chart3.Series["Series3"].Points.AddXY(250, -10);
            //chart3.Series["Series3"].Points.AddXY(500, -10);
            //chart3.Series["Series3"].Points.AddXY(1000, -10);
            //chart3.Series["Series3"].Points.AddXY(2000, -10);
            //chart3.Series["Series3"].Points.AddXY(4000, -10);
            //chart3.Series["Series3"].Points.AddXY(8000, -10);
            /////////////////////////////

            chart3.ChartAreas[0].AxisX.LabelStyle.Interval = 10000;///////HAVE SET TO FAREST POINT

            MyInterval3.AddRange(new[] { 1142.85, 2285.71, 3428.55, 4571.4, 5714.25, 6857.1, 7999.95});///(8000/7)

            //////////////HIDEING Y AXIS LINES
            chart3.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart3.ChartAreas[0].AxisX.MajorTickMark.Enabled = false;
            chart3.ChartAreas[0].AxisX.LabelStyle.Enabled = false;

        }

        private void GetData4MDB()
        {

            DataTable dt = new DataTable();

            chart1.Series.Clear();
            chart1.Series.Add("Products");

            chart1.Series["Products"].ChartType = SeriesChartType.Column;

            dt = FillProduct();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string name, price;

                name = dt.Rows[i][0].ToString();
                price = dt.Rows[i][1].ToString();

                chart1.Series["Products"].Points.AddXY(name, price);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetData4MDB();
        }

        public DataTable FillProduct()
        {
            //string query = "select ProductName,PurPrice from Products";

            //try
            //{
            //    DataSet ds = new DAL.Database().ExecuteForDataSet(query);
            //    DataTable dt = null;
            //    if (ds.Tables.Count != 0)
            //        dt = ds.Tables[0];
            //    return dt;

            //}
            //catch (Exception exc) { throw exc; }

            DataTable dt = new DataTable();
            return dt;
        }

        private void chart2_MouseClick(object sender, MouseEventArgs e)
        {
            ////PUT POINT
            if (chart2.Series.Count > 0)
            {
                chart2.Series["Series1"].Points.AddXY(Math.Round(chart2.ChartAreas[0].AxisX.PixelPositionToValue(e.X), 2), chart2.ChartAreas[0].AxisY.PixelPositionToValue(e.Y));
            }
            else
            {

            }
        }

        private void chart2_PostPaint(object sender, ChartPaintEventArgs e)
        {
            Graphics g = e.ChartGraphics.Graphics;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

            ChartArea ca = chart2.ChartAreas[0];

            Font font = ca.AxisX.LabelStyle.Font;
            Color col = ca.AxisX.MajorGrid.LineColor;
            int padding = 10;

            int y0 = (int)ca.AxisY.ValueToPixelPosition(ca.AxisY.Minimum);
            int y1 = (int)ca.AxisY.ValueToPixelPosition(ca.AxisY.Maximum);

            foreach (int sx in MyInterval)
            {
                int x = (int)ca.AxisX.ValueToPixelPosition(sx);

                ///////////////////COMMENT 2 LINES TO NOT LET IT DRAW LINES//////////////////////////////
                using (Pen pen = new Pen(col))
                    g.DrawLine(pen, x, y0, x, y1);

                string s = sx + "";
                if (ca.AxisX.LabelStyle.Format != "")
                    s = string.Format(ca.AxisX.LabelStyle.Format, s);

                SizeF sz = g.MeasureString(s, font, 999);
                g.DrawString(s, font, Brushes.Black, (int)(x - sz.Width / 2), y0 + padding);

                ca.AxisX.MajorGrid.Enabled = false;
                ca.AxisX.MajorTickMark.Enabled = false;
                ca.AxisX.LabelStyle.Enabled = false;
            }


            //private void panel1_MouseClick(object sender, MouseEventArgs e)
            //{
            //    Brush aBrush = (Brush)Brushes.Black;
            //    Graphics g = this.CreateGraphics();

            //    g.FillRectangle(aBrush, e.X, e.Y, 1, 1);
            //}

            //private void panel1_Paint(object sender, PaintEventArgs e)
            //{
            //    //Graphics g = e.Graphics;
            //    //Pen pen = new Pen(Color.Red);
            //    //g.DrawLine(pen, new Point(13, 13), new Point(20, 20)); 


            //}

        }

        private void Btn_Ch1_2D_3D_Click(object sender, EventArgs e)
        {
            if (chart3.ChartAreas[0].Area3DStyle.Enable3D)
            {
                chart3.ChartAreas[0].Area3DStyle.Enable3D = false;
            }
            else
            {
                chart3.ChartAreas[0].Area3DStyle.Enable3D = true;
            }
        }

        private void Btn_Ch1_Print_Click(object sender, EventArgs e)
        {
            Bitmap MyChartPanel = new Bitmap(this.chart2.Width, chart2.Height);
            chart2.DrawToBitmap(MyChartPanel, new Rectangle(0, 0, chart2.Width, chart2.Height));

            /////////////SHOW HOW IT WILL BE PRINTED//////////////
            //this.pictureBox1.Width = chart2.Width;
            //this.pictureBox1.Height = chart2.Height;

            this.pictureBox1.BackgroundImage = MyChartPanel;
            this.pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            ///////////////////////////

            /////////////SEND TO PRINTER//////////////
            //PrintDialog MyPrintDialog = new PrintDialog();

            //if (MyPrintDialog.ShowDialog() == DialogResult.OK)
            //{
            //    System.Drawing.Printing.PrinterSettings values;
            //    values = MyPrintDialog.PrinterSettings;

            //    MyPrintDialog.Document = MyPrintDocument;
            //    MyPrintDocument.PrintController = new System.Drawing.Printing.StandardPrintController();
                
            //    MyPrintDocument.Print();

            //}

            //MyPrintDocument.Dispose();
            ///////////////////////////

            /////////////BUILTIN PRINT/PRIVIEW ////////////
            //chart1.Printing.PrintPreview();
        }

        private void Btn_Ch2_RemovePoint_Click(object sender, EventArgs e)
        {
            if ((chart2.Series[0].Points.Count) > 1)
            {
                chart2.Series[0].Points.RemoveAt(chart2.Series[0].Points.Count - 1);
            }
            else
            {
                Btn_Ch2_Reset_Click(sender, e);
            }
        }

        private void Btn_Ch2_Reset_Click(object sender, EventArgs e)
        {
            //this.chart2.Series.Clear();

            //chart2.Series.Add("Series1");
            //chart2.Series["Series1"].ChartType = SeriesChartType.Line;

            //chart2.ChartAreas[0].AxisX.Minimum = 0;
            //chart2.ChartAreas[0].AxisX.Maximum = 8000;
            //////chart2.ChartAreas[0].AxisX.Interval = 10;
            //////chart2.ChartAreas[0].AxisX.IntervalOffset = 20;


            //chart2.ChartAreas[0].AxisY.Minimum = -10;
            //chart2.ChartAreas[0].AxisY.Maximum = 120;
            //chart2.ChartAreas[0].AxisY.Interval = 10;

            //chart2.Series["Series1"].Points.AddXY(0, 0);

            //chart2.Series["Series1"].MarkerImage="E:\\Projects\\Lab\\Lab\\Resources\\refreshsmall.png";

            //chart2.Series["Series1"].ChartType = SeriesChartType.Line;
            //chart2.Series["Series1"].MarkerStyle = MarkerStyle.Square;
            //chart2.Series["Series1"].Color = Color.Blue;
            //////chart2.Series["Series1"].Points.AddXY(2, 3);
            //////chart2.Series["Series1"].Points.AddXY(2, 3);
            //////chart2.Series["Series1"].Points(1).MarkerImage = "square_with_a_circle.png";
            //////chart2.Series["Series1"].Points(1).MarkerImageTransparentColor = Color.Black;

            chart2.Series[0].Points.Clear();
            formchart_Load(sender, e);
        }

        private void rdbUnMasked_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdbMasked.Checked)
            {
                //chart2.Series["Series1"].MarkerImage = "E:\\Projects\\Lab\\Lab\\Resources\\Masked.ico";
                chart2.Series["Series1"].MarkerStyle = MarkerStyle.Triangle;
            }
            else if (this.rdbUnMasked.Checked)
            {
                //chart2.Series["Series1"].MarkerImage = "E:\\Projects\\Lab\\Lab\\Resources\\Unmasked.ico";
                chart2.Series["Series1"].MarkerStyle = MarkerStyle.Circle;
            }
        }

        private void chart3_MouseClick(object sender, MouseEventArgs e)
        {
            //TESTING EXACT CLICK FIND NEAREST LINE///
            ///double nearest= Math.Round(chart3.ChartAreas[0].AxisX.PixelPositionToValue(e.X)/50,0)*50;

            if (chart3.Series.Count > 0)
            {
                if (rdbMasked3.Checked)
                {
                    chart3.Series["Series1"].Points.AddXY(Math.Round(chart3.ChartAreas[0].AxisX.PixelPositionToValue(e.X), 2), chart3.ChartAreas[0].AxisY.PixelPositionToValue(e.Y));
                }
                else
                {
                    chart3.Series["Series2"].Points.AddXY(Math.Round(chart3.ChartAreas[0].AxisX.PixelPositionToValue(e.X), 2), chart3.ChartAreas[0].AxisY.PixelPositionToValue(e.Y));
                }

            }
            else
            {

            }
        }

        private void Btn_Chart3_RemovePoint_Click(object sender, EventArgs e)
        {
            if (rdbMasked3.Checked)
            {
                if ((chart3.Series[0].Points.Count) > 1)
                {
                    chart3.Series[0].Points.RemoveAt(chart3.Series[0].Points.Count - 1);
                }
                else
                {
                    Btn_Chart3_Reset_Click(sender, e);
                }
            }
            else
            {
                if ((chart3.Series[1].Points.Count) > 1)
                {
                    chart3.Series[1].Points.RemoveAt(chart3.Series[1].Points.Count - 1);
                }
                else
                {
                    Btn_Chart3_Reset_Click(sender, e);
                }
            }
        }

        private void Btn_Chart3_Reset_Click(object sender, EventArgs e)
        {

            if (rdbMasked3.Checked)
            {
                chart3.Series[0].Points.Clear();
            }
            else
            {
                chart3.Series[1].Points.Clear();
            }

            //formchart_Load(sender, e);

            //if (chart3.Series[0].Points.Count <= 0 && chart3.Series[1].Points.Count <= 0)
            //{
            //    chart3.Series["Series1"].Points.AddXY(0, 0);
            //    chart3.Series["Series2"].Points.AddXY(0, 0);
            //}

        }

        int index;

        private void chart3_PostPaint(object sender, ChartPaintEventArgs e)
        {
            index = 0;

            Graphics g = e.ChartGraphics.Graphics;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

            ChartArea ca = chart3.ChartAreas[0];

            Font font = ca.AxisX.LabelStyle.Font;
            Color col = ca.AxisX.MajorGrid.LineColor;
            int padding = 10;

            int y0 = (int)ca.AxisY.ValueToPixelPosition(ca.AxisY.Minimum);
            int y1 = (int)ca.AxisY.ValueToPixelPosition(ca.AxisY.Maximum);

            foreach (int sx in MyInterval3)
            {
                int x = (int)ca.AxisX.ValueToPixelPosition(sx);

                ///////////////////COMMENT 2 LINES TO NOT LET IT DRAW Y LINES ON GRAPH//////////////////////////////
                using (Pen pen = new Pen(col))
                    g.DrawLine(pen, x, y0, x, y1);

                string s = MyInterval[index] + "Hz";
                if (ca.AxisX.LabelStyle.Format != "")
                    s = string.Format(ca.AxisX.LabelStyle.Format, s);

                SizeF sz = g.MeasureString(s, font, 999);
                g.DrawString(s, font, Brushes.Black, (int)(x - sz.Width / 2), y0 + padding);

                /////hide default y axis lines of chart
                ca.AxisX.MajorGrid.Enabled = false;
                ca.AxisX.MajorTickMark.Enabled = false;
                ca.AxisX.LabelStyle.Enabled = false;

                index++;
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            /////////builtin print of graph
            chart3.Printing.PrintPreview();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (MemoryStream memory = new MemoryStream())
            {
                using (FileStream fs = new FileStream(Application.StartupPath + "\\" + "Chart.jpeg", FileMode.Create, FileAccess.ReadWrite))
                {
                    this.pictureBox1.BackgroundImage.Save(memory, ImageFormat.Jpeg);
                    byte[] bytes = memory.ToArray();
                    fs.Write(bytes, 0, bytes.Length);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AudioGram ag = new AudioGram();
            ag.Show();
        }

        ////////////////////////////////////PRINTING OF WHOLE FORM
        private void MyPrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            System.Drawing.Image image = System.Drawing.Image.FromStream(this.streamToPrint);

            int x = e.MarginBounds.X;

            int y = e.MarginBounds.Y;

            int width = image.Width;

            int height = image.Height;

            if ((width / e.MarginBounds.Width) > (height / e.MarginBounds.Height))
            {
                width = e.MarginBounds.Width;
                height = image.Height * e.MarginBounds.Width / image.Width;
            }

            else
            {
                height = e.MarginBounds.Height;
                width = image.Width * e.MarginBounds.Height / image.Height;
            }

            System.Drawing.Rectangle destRect = new System.Drawing.Rectangle(x, y, width, height);
            e.Graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, System.Drawing.GraphicsUnit.Pixel);
        }

        public void StartPrint(Stream streamToPrint, string streamType)
        {
            this.MyPrintDocument.PrintPage += new PrintPageEventHandler(MyPrintDocument_PrintPage);

            this.streamToPrint = streamToPrint;

            this.streamType = streamType;

            System.Windows.Forms.PrintDialog PrintDialog1 = new PrintDialog();

            PrintDialog1.AllowSomePages = true;

            PrintDialog1.ShowHelp = true;

            PrintDialog1.Document = MyPrintDocument;

            DialogResult result = PrintDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                MyPrintDocument.Print();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /////////PRINTING OF WHOLE FORM
            Graphics g1 = this.CreateGraphics();
            Image MyImage = new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height, g1);
            Graphics g2 = Graphics.FromImage(MyImage);
            IntPtr dc1 = g1.GetHdc();
            IntPtr dc2 = g2.GetHdc();
            BitBlt(dc2, 0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height, dc1, 0, 0, 13369376);
            g1.ReleaseHdc(dc1);
            g2.ReleaseHdc(dc2);

            using (MemoryStream memory = new MemoryStream())
            {
                using (FileStream fs = new FileStream(@Application.StartupPath + "\\" + "Chart.jpeg", FileMode.Create, FileAccess.ReadWrite))
                {
                    MyImage.Save(memory, ImageFormat.Jpeg);
                    byte[] bytes = memory.ToArray();
                    fs.Write(bytes, 0, bytes.Length);
                }
            }

            FileStream fileStream = new FileStream(@Application.StartupPath + "\\" + "Chart.jpeg", FileMode.Open, FileAccess.Read);
            StartPrint(fileStream, "Image");
            fileStream.Close();

            //if (System.IO.File.Exists(@"c:\PrintPage.jpg"))
            //{
            //    System.IO.File.Delete(@"c:\PrintPage.jpg");
            //}
        }

    }
}
