using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using ExcelDataReader;
using Utility;
using OpenRose;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Defaults;
using System.Windows.Forms.DataVisualization.Charting;


namespace arduino2560
{
    public partial class Analysis : Form
    {
        
        private Worker  m_worker= null;
        public static string filepath;

        private string dir = Environment.GetEnvironmentVariable("windir") + @"\Next-Comm";

        public Analysis()
        {
            InitializeComponent();

            m_worker = new Worker();
            if (m_worker == null)
            {
                MessageBox.Show("Unable to create the worker class.", "OpenRose",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DrawGraph()
        /*
          -------------------------------------------------------------------------
           DrawGraph()
          -------------------------------------------------------------------------
           Draw the rose diagram.
          -------------------------------------------------------------------------
        */
        {
           // Graphics g = panel2.CreateGraphics();
            //if (g != null)
            //{
            //    if (m_worker != null)
            //    {
            //        m_worker.Draw(g);
            //    }
            //    g.Dispose();
            //}
            //else
            //{
            //    MessageBox.Show("Unable to create a graphics object.", "OpenRose",
            //      MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }




        DataSet result;
        string[] sheet = new string[10];



        private void Analysis_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + @"\config.ini"))
            {
              
                    StreamWriter sw= new StreamWriter(Application.StartupPath + @"\config.ini");

                    sw.WriteLine(Environment.GetEnvironmentVariable("windir") + @"\Next-Comm");

                    sw.Close();


            }
            if (File.Exists(Application.StartupPath + @"\config.ini"))
            {
                StreamReader sr = new StreamReader(Application.StartupPath + @"\config.ini");
                tb_folderPath.Text = sr.ReadLine()  ;
               
            }


            Form1.analLoad = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

           // SelectFolder_dialog.Text = dir;
           // tb_folderPath.Text = dir;
            openFile();

          //  panel1.Visible = true;




        }

        private void openFile()
        {
            DirectoryInfo d = new DirectoryInfo(tb_folderPath.Text);//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*.csv"); //Getting Text files
            string str = "";
            // dd_fileList_bu.AddItem("Select File Name");
            foreach (FileInfo file in Files)
            {
                // str = str + ", " + file.Name;
                dd_fileList_bu.AddItem(file.Name);
                // MessageBox.Show(str);
            }
        }

        private void btn_analysis_Click(object sender, EventArgs e)
        {
            if (dd_fileList_bu.selectedIndex>0)
            {
                if (m_worker != null)
                {
                    if (m_worker.ReadDataFile(filepath))
                    {
                        DrawGraph();
                      //  LoadChart();
                     //   chart1.Visible = true;
                        pnl_tool.Visible = true;


                        //cb_temp.Enabled = true;
                        //cb_hum.Enabled = true;
                        //cb_press.Enabled = true;
                        //cb_solar.Enabled = true;
                        //cb_cur_rain.Enabled = true;
                        //cb_pre_rain.Enabled = true;
                        //cb_wind_dir.Enabled = true;

                        //cb_temp.CheckedColor = Color.Maroon;
                        //cb_hum.CheckedColor = Color.FromArgb(255, 128, 0);
                        //cb_pre_rain.CheckedColor = Color.FromArgb(192, 0, 192);
                        //cb_cur_rain.CheckedColor = Color.FromArgb(51, 205, 117);
                        //cb_press.CheckedColor = Color.Teal;
                        //cb_solar.CheckedColor = Color.LightCoral;
                        //cb_wind_dir.CheckedColor = Color.FromArgb(0, 114, 188);

                    }
                }
            }

            
        }


        Point? prevPosition = null;
        ToolTip tooltip = new ToolTip();

        void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            var pos = e.Location;
            if (prevPosition.HasValue && pos == prevPosition.Value)
                return;
            tooltip.RemoveAll();
            prevPosition = pos;
           // var results = chart1.HitTest(pos.X, pos.Y, false, ChartElementType.DataPoint);
                                           
            //foreach (var result in results)
            //{
            //    if (result.ChartElementType == ChartElementType.DataPoint)
            //    {
            //        var prop = result.Object as DataPoint;
            //        if (prop != null)
            //        {
            //            var pointXPixel = result.ChartArea.AxisX.ValueToPixelPosition(prop.XValue);
            //            var pointYPixel = result.ChartArea.AxisY.ValueToPixelPosition(prop.YValues[0]);

            //            // check if the cursor is really close to the point (2 pixels around the point)
            //            if (Math.Abs(pos.X - pointXPixel) < 2 &&
            //                Math.Abs(pos.Y - pointYPixel) < 2)
            //            {
            //                tooltip.Show("X=" + prop.XValue + ", Y=" + prop.YValues[0], this.chart1,
            //                                pos.X, pos.Y - 15);
            //            }
            //        }
            //    }
            //}

        }



        //private void LoadChart()
        //{
        //     try
        //        {
           
        //    if (cb_temp.Checked == true)
        //    {

               

        //            var chart = chart1.ChartAreas[0];
        //            chart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;

        //            chart.AxisX.LabelStyle.Format = "";
        //            chart.AxisY.LabelStyle.Format = "";
        //            chart.AxisX.LabelStyle.IsEndLabelVisible = true;

        //            chart.AxisX.Minimum = 0;
        //            chart.AxisY.Minimum = 0;
        //            //  chart.AxisY.Maximum = 100;

        //            // chart.AxisX.Interval = 0.5; 
        //            // chart.AxisY.Interval = 5;
        //            chart1.Series[0].IsVisibleInLegend = false;




        //            if (chart1.Series.IsUniqueName("Temperature"))
        //            {

        //                //  chart.AxisY.Maximum = Worker.mTemp;

        //                chart1.Series.Add("Temperature");

        //                chart1.Series["Temperature"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
        //                chart1.Series["Temperature"].Color = Color.Maroon;
        //                chart1.Series["Temperature"].BorderWidth = 3;
        //                chart1.Series["Temperature"].IsVisibleInLegend = false;
        //                //chart1.Series["Temperature"].MarkerStyle = MarkerStyle.Circle;
        //                //chart1.Series["Temperature"].MarkerSize = 8;
        //                //chart1.Series["Temperature"].MarkerColor = Color.Black;
        //                // chart1.Series["Temperature"]. = Color.Black;

        //                int i = 0;

        //                foreach (string s in Worker.dateTime)
        //                {
        //                    if (!Convert.ToString(Worker.temp[i]).Contains("NAN") && Convert.ToString(Worker.temp[i]) != "")
        //                    {
        //                        // MessageBox.Show(Worker.arr_col1[i] + "  " + s);

        //                        chart1.Series["Temperature"].Points.AddXY((s), ((Worker.temp[i])));

        //                    }
        //                    i++;
        //                }
        //            }
               
        //     }

        //    if (cb_hum.Checked == true)
        //    {
        //        var chart = chart2.ChartAreas[0];
        //        chart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;

        //        chart.AxisX.LabelStyle.Format = "";
        //        chart.AxisY.LabelStyle.Format = "";
        //        chart.AxisX.LabelStyle.IsEndLabelVisible = true;

        //        chart.AxisX.Minimum = 0;
        //        chart.AxisY.Minimum = 0;
        //        //  chart.AxisY.Maximum = 100;

        //        // chart.AxisX.Interval = 0.5; 
        //        // chart.AxisY.Interval = 5;
        //        chart2.Series[0].IsVisibleInLegend = false;

              

        //            if (chart2.Series.IsUniqueName("Humidity"))
        //            {
        //                chart2.Series.Add("Humidity");
        //                chart2.Series["Humidity"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
        //                chart2.Series["Humidity"].Color = Color.FromArgb(255, 128, 0);
        //                chart2.Series["Humidity"].BorderWidth = 3;
        //                chart2.Series["Humidity"].IsVisibleInLegend = false;
        //                int i = 0;

        //                foreach (string s in Worker.dateTime)
        //                {
        //                    if (!Convert.ToString(Worker.hum[i]).Contains("NAN") && Convert.ToString( Worker.hum[i]) != "")
        //                    {
        //                        // MessageBox.Show(Worker.arr_col1[i] + "  " + s);

        //                        chart2.Series["Humidity"].Points.AddXY((s), ((Worker.hum[i])));

        //                    }
        //                    i++;
        //                }
        //            }
               
        //    }
        //    else
        //    {
        //       // chart1.Series.Remove(chart1.Series["Humidity"]);
        //    }


        //    if (cb_cur_rain.Checked == true)
        //    {
        //        var chart = chart3.ChartAreas[0];
        //        chart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;

        //        chart.AxisX.LabelStyle.Format = "";
        //        chart.AxisY.LabelStyle.Format = "";
        //        chart.AxisX.LabelStyle.IsEndLabelVisible = true;

        //        chart.AxisX.Minimum = 0;
        //        chart.AxisY.Minimum = 0;
        //        //  chart.AxisY.Maximum = 100;

        //        // chart.AxisX.Interval = 0.5; 
        //        // chart.AxisY.Interval = 5;
        //        chart3.Series[0].IsVisibleInLegend = false;

              

        //        if (chart3.Series.IsUniqueName("Current Rain"))
        //        {
        //            chart3.Series.Add("Current Rain");
        //            chart3.Series["Current Rain"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
        //            chart3.Series["Current Rain"].Color = Color.FromArgb(51, 205, 117);
        //            chart3.Series["Current Rain"].BorderWidth = 3;
        //            chart3.Series["Current Rain"].IsVisibleInLegend = false;
        //            int i = 0;

        //            foreach (string s in Worker.dateTime)
        //            {
        //                if (! Convert.ToString(Worker.cur_rain[i]).Contains("NAN") && Convert.ToString(Worker.cur_rain[i]) != "")
        //                {

        //                    // MessageBox.Show(Worker.arr_col1[i] + "  " + s);

        //                    chart3.Series["Current Rain"].Points.AddXY((s), ((Worker.cur_rain[i])));

        //                }
        //                i++;
        //            }
        //        }

        //    }
        //    else
        //    {
        //        // chart1.Series.Remove(chart1.Series["Humidity"]);
        //    }

        //    if (cb_pre_rain.Checked == true)
        //    {
        //        var chart = chart4.ChartAreas[0];
        //        chart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;

        //        chart.AxisX.LabelStyle.Format = "";
        //        chart.AxisY.LabelStyle.Format = "";
        //        chart.AxisX.LabelStyle.IsEndLabelVisible = true;

        //        chart.AxisX.Minimum = 0;
        //        chart.AxisY.Minimum = 0;
        //        //  chart.AxisY.Maximum = 100;

        //        // chart.AxisX.Interval = 0.5; 
        //        // chart.AxisY.Interval = 5;
        //        chart4.Series[0].IsVisibleInLegend = false;

               

        //        if (chart4.Series.IsUniqueName("Previous Rain"))
        //        {
        //            chart4.Series.Add("Previous Rain");
        //            chart4.Series["Previous Rain"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
        //            chart4.Series["Previous Rain"].Color = Color.FromArgb(192, 0, 192);
        //            chart4.Series["Previous Rain"].BorderWidth = 3;
        //            chart4.Series["Previous Rain"].IsVisibleInLegend = false;
        //            int i = 0;

        //            foreach (string s in Worker.dateTime)
        //            {
        //                if (!Convert.ToString(Worker.prev_rain[i]).Contains("NAN") && Convert.ToString(Worker.prev_rain[i]) != "")
        //                {
        //                    // MessageBox.Show(Worker.arr_col1[i] + "  " + s);

        //                    chart4.Series["Previous Rain"].Points.AddXY((s), ((Worker.prev_rain[i])));

        //                }
        //                i++;
        //            }
        //        }

        //    }
        //    else
        //    {
        //        // chart1.Series.Remove(chart1.Series["Humidity"]);
        //    }

        //    if (cb_press.Checked == true)
        //    {
        //        var chart = chart5.ChartAreas[0];
        //        chart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;

        //        chart.AxisX.LabelStyle.Format = "";
        //        chart.AxisY.LabelStyle.Format = "";
        //        chart.AxisX.LabelStyle.IsEndLabelVisible = true;

        //        chart.AxisX.Minimum = 0;
        //        chart.AxisY.Minimum = 0;
        //        //  chart.AxisY.Maximum = 100;

        //        // chart.AxisX.Interval = 0.5; 
        //        // chart.AxisY.Interval = 5;
        //        chart5.Series[0].IsVisibleInLegend = false;

               

        //        if (chart5.Series.IsUniqueName("Pressure"))
        //        {
                   

        //            chart5.Series.Add("Pressure");
        //            chart5.Series["Pressure"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
        //            chart5.Series["Pressure"].Color = Color.Teal;
        //            chart5.Series["Pressure"].BorderWidth = 3;
        //            chart5.Series["Pressure"].IsVisibleInLegend = false;

        //            int i = 0;

        //            foreach (string s in Worker.dateTime)
        //            {
        //                if (!Convert.ToString(Worker.pressure[i]).Contains("NAN") && Convert.ToString(Worker.pressure[i]) != "")
        //                {
        //                    // MessageBox.Show(Worker.arr_col1[i] + "  " + s);

        //                    chart5.Series["Pressure"].Points.AddXY((s), ( Worker.pressure[i]));

        //                }
        //                i++;
        //            }
        //        }

        //    }
        //    else
        //    {
        //        // chart1.Series.Remove(chart1.Series["Humidity"]);
        //    }


        //    if (cb_solar.Checked == true)
        //    {
        //        var chart = chart6.ChartAreas[0];
        //        chart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;

        //        chart.AxisX.LabelStyle.Format = "";
        //        chart.AxisY.LabelStyle.Format = "";
        //        chart.AxisX.LabelStyle.IsEndLabelVisible = true;

        //        chart.AxisX.Minimum = 0;
        //        chart.AxisY.Minimum = 0;
        //        //  chart.AxisY.Maximum = 100;

        //        // chart.AxisX.Interval = 0.5; 
        //        // chart.AxisY.Interval = 5;
        //        chart6.Series[0].IsVisibleInLegend = false;

                

        //        if (chart6.Series.IsUniqueName("Solar Radiation"))
        //        {


        //            chart6.Series.Add("Solar Radiation");
        //            chart6.Series["Solar Radiation"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
        //            chart6.Series["Solar Radiation"].Color = Color.LightCoral;
        //            chart6.Series["Solar Radiation"].BorderWidth = 3;
        //            chart6.Series["Solar Radiation"].IsVisibleInLegend = false;
        //           // chart6.Series["Solar Radiation"].IsValueShownAsLabel = true;


        //            int i = 0;

        //            foreach (string s in Worker.dateTime)
        //            {
        //                if (!Convert.ToString(Worker.solarRadiation[i]).Contains("NAN") && Convert.ToString(Worker.solarRadiation[i]) != "")
        //                {
        //                   // MessageBox.Show(Worker.solarRadiation[i] + "  " + s);

        //                    chart6.Series["Solar Radiation"].Points.AddXY((s), (((Worker.solarRadiation[i]))));

        //                }
        //                i++;
        //            }
        //        }

        //    }
        //    else
        //    {
        //        // chart1.Series.Remove(chart1.Series["Humidity"]);
        //    }
        //        }
        //     catch (ArgumentOutOfRangeException ex)
        //     {
        //        // MessageBox.Show(ex.Message);
        //     }

        //}



        //private void LoadChart()
        //{
        //     List<double> temp = new List<double>();

        //     //try
        //     //{
                
        //            // temp.Add(Convert.ToDouble(val));


        //             // MessageBox.Show(temp);





        //         ColumnSeries col = new ColumnSeries() {DataLabels=true,Values= new ChartValues<double>(), LabelPoint= point => point.Y.ToString() };


        //         Axis ax = new Axis()
        //         {
        //             Separator = new Separator() { Step = 1, IsEnabled = false }
        //         };
        //         ax.Labels = new List<string>();
        //         int i = 1;
        //         foreach (string a in ( Worker.arr_col1))
        //         {
                   
        //             if (!a.Contains("NAN") && a!="")
        //             {
        //                // MessageBox.Show("@" + a + "@  " + Worker.arr_col2[i]);
        //                 col.Values.Add(Convert.ToDouble(a));
        //                // ax.Labels.Add((Worker.arr_col2[i]));
        //                 i++;
        //             }
        //         }
        //        // cartesianChart1.ForeColor = Color.Maroon;
            
        //        // cartesianChart1.Series.Add(col);



        ////   cartesianChart1.Series = new SeriesCollection(col)
        //    //{
        //    //    new LineSeries{
        //    //        Title= "Temperature",
        //    //   // Values= new ChartValues<ObservablePoint> { },
        //    //    PointGeometry = DefaultGeometries.Square,
        //    //        PointGeometrySize = 15
        //    //    }
        //    //};
        //        // cartesianChart1.AxisX.Add(ax);
        //         //cartesianChart1.AxisY.Add(new Axis
        //         //{
        //         //    LabelFormatter = value => value.ToString(),
        //         //    Separator = new Separator()
        //         //});

        //    //  cartesianChart1.Series = new SeriesCollection
        //    //    {
                
        //    //    new LineSeries
        //    //    {
        //    //        Title = "Series 1",
                    
        //    //        Values = new ChartValues<ObservablePoint>
        //    //        {
        //    //             //foreach (string val in Worker.arr_col1)
        //    //             //   {

        //    //             //}
        //    //        }
        //    //    },
        //    //    new LineSeries
        //    //    {
        //    //        Title = "Series 2",
        //    //        Values = new ChartValues<double> {6, 7, 3, 4, 6},
        //    //        PointGeometry = null
        //    //    },
        //    //    new LineSeries
        //    //    {
        //    //        Title = "Series 2",
        //    //        Values = new ChartValues<double> {5, 2, 8, 3},
        //    //        PointGeometry = DefaultGeometries.Square,
        //    //        PointGeometrySize = 15
        //    //    }
        //    //};

                 

                 
        //     //}
        //     //catch (Exception ex)
        //     //{
        //     //    MessageBox.Show(ex.Message);
        //     //}
           
        //    //YFormatter = value => value.ToString("C");
        //}


        private void dd_fileList_bu_onItemSelected(object sender, EventArgs e)
        {
            try
            {
                filepath = (tb_folderPath.Text + "\\" + dd_fileList_bu.selectedValue);
                if (dd_fileList_bu.selectedIndex > 0)
                {
                    FileStream fs = File.Open(filepath, FileMode.Open, FileAccess.Read);
                    IExcelDataReader reader = ExcelReaderFactory.CreateCsvReader(fs);

                    result = reader.AsDataSet();
                    foreach (DataTable dt in result.Tables)
                    {
                      //  dd_sheetList.AddItem(dt.TableName);
                        sheet[0] = dt.TableName;
                        reader.Close();
                    }
                    dataGridView1.DataSource = result.Tables[sheet[0]];
                }
                else
                {
                    dataGridView1.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dd_sheetList_onItemSelected(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            DrawGraph();
        }

        //private void cb_windDirection_OnChange(object sender, EventArgs e)
        //{
        //    if (cb_wind_dir.Checked == true)
        //    {
        //        cb_temp.Checked = false;
        //        cb_hum.Checked = false;
        //        cb_press.Checked = false;
        //        cb_solar.Checked = false;
        //        cb_cur_rain.Checked = false;
        //        cb_pre_rain.Checked = false;

        //        chart1.Visible = false;
        //        chart2.Visible = false;
        //        chart3.Visible = false;
        //        chart4.Visible = false;
        //        chart5.Visible = false;
        //        chart6.Visible = false;


        //        pnl_tool.Visible = false;

        //        //cb_temp.Checked = false;
        //        //cb_temp.Checked = false;
        //    }
        //    else
        //    {
        //        try
        //        {
        //            chart1.Visible = true;
        //            pnl_tool.Visible = true;

        //            if (chart1.Series["Temperature"].Enabled == true)
        //            {
        //                cb_temp.Checked = true;

        //            }
        //            if (chart1.Series["Humidity"].Enabled == true)
        //            {
        //                cb_hum.Checked = true;

        //            }
        //            if (chart1.Series["Current Rain"].Enabled == true)
        //            {
        //                cb_cur_rain.Checked = true;

        //            }
        //            if (chart1.Series["Previous Rain"].Enabled == true)
        //            {
        //                cb_pre_rain.Checked = true;

        //            }
        //            if (chart1.Series["Pressure"].Enabled == true)
        //            {
        //                cb_press.Checked = true;

        //            }
        //            if (chart1.Series["Solar Radiation"].Enabled == true)
        //            {
        //                cb_solar.Checked = true;

        //            }
        //        }
        //        catch (Exception ex)
        //        {

        //        }
        //    }

            
        //}

        public string[] Labels { get; set; }

    //    private void cb_SolarRadiation_OnChange(object sender, EventArgs e)
    //    {
    //        LoadChart();
    //        pnl_tool.Visible = true;
    //      //  cb_dataValues.Checked = false;

    //        cb_temp.Checked = false;
    //        cb_hum.Checked = false;
    //        cb_press.Checked = false;
    //        //cb_solar.Checked = false;
    //        cb_cur_rain.Checked = false;
    //        cb_pre_rain.Checked = false;

    //        if (cb_wind_dir.Checked == true)
    //        {
    //            chart1.Visible = true;
    //            cb_wind_dir.Checked = false;
    //        }



    //        if (cb_solar.Checked == false)
    //        {

    //           // var chart = chart1.ChartAreas[0];
    //            // chart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
    //            // MessageBox.Show(Worker.mCur_rain.ToString());
    //            // Worker w = new Worker();
    //          //  chart.AxisY.Maximum = Worker.mSolar;

    //            //chart1.Series["Solar Radiation"].Enabled = false;
    //            chart2.Visible = false;
    //            chart3.Visible = false;
    //            chart4.Visible = false;
    //            chart5.Visible = false;
    //            chart6.Visible = false;
    //            chart1.Visible = false;

    //            cb_wind_dir.Checked = true;
                
                
                
    //        }
    //        else
    //        {
    //           // chart1.Series["Solar Radiation"].Enabled = true;

    //            chart2.Visible = false;
    //            chart3.Visible = false;
    //            chart4.Visible = false;
    //            chart5.Visible = false;
    //            chart6.Visible = true;
    //            chart1.Visible = false;
    //        } 
    //    }

    //    private void cb_Pressure_OnChange(object sender, EventArgs e)
    //    {
    //        LoadChart();
    //        pnl_tool.Visible = true;
    //       // cb_dataValues.Checked = false;

    //        cb_temp.Checked = false;
    //        cb_hum.Checked = false;
    //      //  cb_press.Checked = false;
    //        cb_solar.Checked = false;
    //        cb_cur_rain.Checked = false;
    //        cb_pre_rain.Checked = false;

    //        if (cb_wind_dir.Checked == true)
    //        {
    //            chart1.Visible = true;
    //            cb_wind_dir.Checked = false;
    //        }

    //        if (cb_press.Checked == false)
    //        {
    //            var chart = chart1.ChartAreas[0];
    //            // chart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
    //            // MessageBox.Show(Worker.mCur_rain.ToString());
    //            // Worker w = new Worker();
    //          //  chart.AxisY.Maximum = Worker.mPressure;
    //          //  chart1.Series["Pressure"].Enabled = false;
    //            chart2.Visible = false;
    //            chart3.Visible = false;
    //            chart4.Visible = false;
    //            chart5.Visible = false ;
    //            chart6.Visible = false;
    //            chart1.Visible = false;

    //            cb_wind_dir.Checked = true;
    //        }
    //        else
    //        {
    //            chart2.Visible = false;
    //            chart3.Visible = false;
    //            chart4.Visible = false;
    //            chart5.Visible = true;
    //            chart6.Visible = false;
    //            chart1.Visible = false;
    //            //chart1.Series["Pressure"].Enabled = true;
    //        }
    //    }

    //    private void cb_Rain_OnChange(object sender, EventArgs e)
    //    {
    //        LoadChart();
    //        pnl_tool.Visible = true;
    //       // cb_dataValues.Checked = false;

    //        cb_temp.Checked = false;
    //        cb_hum.Checked = false;
    //        cb_press.Checked = false;
    //        cb_solar.Checked = false;
    //       // cb_cur_rain.Checked = false;
    //        cb_pre_rain.Checked = false;

    //        if (cb_wind_dir.Checked == true)
    //        {
    //            chart1.Visible = true;
    //            cb_wind_dir.Checked = false;
    //        }

    //        if (cb_cur_rain.Checked == false)
    //        {
    //            var chart = chart1.ChartAreas[0];
    //            // chart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
    //           // MessageBox.Show(Worker.mCur_rain.ToString());
    //           // Worker w = new Worker();
    //          //  chart.AxisY.Maximum = Worker.mCur_rain;

    //           // chart1.Series["Current Rain"].Enabled = false;
    //            chart2.Visible = false;
    //            chart3.Visible = false;
    //            chart4.Visible = false;
    //            chart5.Visible = false;
    //            chart6.Visible = false;
    //            chart1.Visible = false;

    //            cb_wind_dir.Checked = true;
               
               
    //        }
    //        else
    //        {
    //            chart2.Visible = false;
    //            chart3.Visible = true;
    //            chart4.Visible = false;
    //            chart5.Visible = false;
    //            chart6.Visible = false;
    //            chart1.Visible = false;
    //          //  chart1.Series["Current Rain"].Enabled = true;
    //        }
    //    }

    //    private void cb_Humidity_OnChange(object sender, EventArgs e)
    //    {

    //        LoadChart();
    //        pnl_tool.Visible = true;
    //      //  cb_dataValues.Checked = false;

    //        cb_temp.Checked = false;
    //       // cb_hum.Checked = false;
    //        cb_press.Checked = false;
    //        cb_solar.Checked = false;
    //        cb_cur_rain.Checked = false;
    //        cb_pre_rain.Checked = false;

    //        if (cb_wind_dir.Checked == true)
    //        {
    //            chart1.Visible = true;
    //            cb_wind_dir.Checked = false;
    //        }

    //        if (cb_hum.Checked == false)
    //        {
    //           // var chart = chart1.ChartAreas[0];
    //            // chart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
    //            // MessageBox.Show(Worker.mCur_rain.ToString());
    //            // Worker w = new Worker();
    //         //   chart.AxisY.Maximum = Worker.mHum;

    //           // chart1.Series["Humidity"].Enabled = false;


    //            chart2.Visible = false;
    //            chart3.Visible = false;
    //            chart4.Visible = false;
    //            chart5.Visible = false;
    //            chart6.Visible = false;
    //            chart1.Visible = false;

    //            cb_wind_dir.Checked = true;
    //        }
    //        else
    //        {
    //           // chart1.Series["Humidity"].Enabled = true;
    //            chart2.Visible = true;
    //            chart3.Visible = false;
    //            chart4.Visible = false;
    //            chart5.Visible = false;
    //            chart6.Visible = false;
    //            chart1.Visible = false;

    //        }
    //    }

    //    private void cb_Temperature_OnChange(object sender, EventArgs e)
    //    {
    //        LoadChart();
    //        pnl_tool.Visible = true;
    //      //  cb_dataValues.Checked = false;
    //       // cb_Temperature.Checked = false;
    //        cb_hum.Checked = false;
    //        cb_press.Checked = false;
    //        cb_solar.Checked = false;
    //        cb_cur_rain.Checked = false;
    //        cb_pre_rain.Checked = false;

    //        if (cb_wind_dir.Checked == true)
    //        {
    //            chart1.Visible = true;
    //            cb_wind_dir.Checked = false;
    //        }

    //        if (cb_temp.Checked == false)
    //        {
    //            var chart = chart1.ChartAreas[0];
    //            // chart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
    //            // MessageBox.Show(Worker.mCur_rain.ToString());
    //            // Worker w = new Worker();
    //          //  chart.AxisY.Maximum = Worker.mTemp;

    //           // chart1.Series["Temperature"].Enabled = false;

    //            chart2.Visible = false;
    //            chart3.Visible = false;
    //            chart4.Visible = false;
    //            chart5.Visible = false;
    //            chart6.Visible = false;
    //            chart1.Visible = false;

    //            cb_wind_dir.Checked = true;
               
    //        }
    //        else
    //        {
    //           // chart1.Series["Temperature"].Enabled = true;

    //            chart2.Visible = false;
    //            chart3.Visible = false;
    //            chart4.Visible = false;
    //            chart5.Visible = false;
    //            chart6.Visible = false;
    //            chart1.Visible = true;
    //        }
    //    }

    //    private void lbl_Solar_Click(object sender, EventArgs e)
    //    {
    //        //if (cb_solar.Checked != true)
    //        //    cb_solar.Checked = true;
    //        //else
    //        //    cb_solar.Checked = false;
    //    }

    //    private void lbl_pressure_Click(object sender, EventArgs e)
    //    {
    //        //if (cb_press.Checked != true)
    //        //    cb_press.Checked = true;
    //        //else
    //        //    cb_press.Checked = false;
    //    }

    //    private void lbl_rain_Click(object sender, EventArgs e)
    //    {
    //        //if (cb_cur_rain.Checked != true)
    //        //    cb_cur_rain.Checked = true;
    //        //else
    //        //    cb_cur_rain.Checked = false;
    //    }

    //    private void lbl_humidity_Click(object sender, EventArgs e)
    //    {
    //        //if (cb_hum.Checked != true)
    //        //    cb_hum.Checked = true;
    //        //else
    //        //    cb_hum.Checked = false;
    //    }

    //    private void lbl_temperature_Click(object sender, EventArgs e)
    //    {
    //        //if (cb_Temperature.Checked != true)
    //        //    cb_Temperature.Checked = true;
    //        //else
    //        //    cb_Temperature.Checked = false;
    //    }

    //    private void lbl_WindDir_Click(object sender, EventArgs e)
    //    {
    //        //if (cb_wind_dir.Checked != true)
    //        //{
    //        //  //  MessageBox.Show("H");
    //        //    cb_wind_dir.OnChange += cb_wind_dir_OnChange;
    //        //    cb_wind_dir.Checked = true;
    //        //}

    //        //else
    //        //{
    //        //    cb_wind_dir.OnChange += cb_wind_dir_OnChange;
    //        //    cb_wind_dir.Checked = false;
    //        //}
    //    }

    //    private void cb_preRain_OnChange(object sender, EventArgs e)
    //    {
    //        LoadChart();
    //        pnl_tool.Visible = true;
    //        //cb_dataValues.Checked = false;

    //        cb_temp.Checked = false;
    //        cb_hum.Checked = false;
    //        cb_press.Checked = false;
    //        cb_solar.Checked = false;
    //        cb_cur_rain.Checked = false;
    //       // cb_pre_rain.Checked = false;

    //        if (cb_wind_dir.Checked == true)
    //        {
    //            chart1.Visible = true;
    //            cb_wind_dir.Checked = false;
    //        }

    //        if (cb_pre_rain.Checked == false)
    //        {
    //            var chart = chart1.ChartAreas[0];
    //            // chart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
    //            // MessageBox.Show(Worker.mCur_rain.ToString());
    //            // Worker w = new Worker();
    //           // chart.AxisY.Maximum = Worker.mPrev_rain;
    //           // chart1.Series["Previous Rain"].Enabled = false;

    //            chart2.Visible = false;
    //            chart3.Visible = false;
    //            chart4.Visible = false;
    //            chart5.Visible = false;
    //            chart6.Visible = false;
    //            chart1.Visible = false;

    //            cb_wind_dir.Checked = true;
    //        }
    //        else
    //        {
    //            chart2.Visible = false;
    //            chart3.Visible = false;
    //            chart4.Visible = true;
    //            chart5.Visible = false;
    //            chart6.Visible = false;
    //            chart1.Visible = false;

    //          //  chart1.Series["Previous Rain"].Enabled = true;
    //        }
    //    }

    //    private void cb_dataValues_OnChange(object sender, EventArgs e)
    //    {
    //        try
    //        {
    //            if (cb_dataValues.Checked == true)
    //            {
    //                if (chart1.Series.IsUniqueName("Temperature"))
    //                {
    //                    chart1.Series["Temperature"].MarkerStyle = MarkerStyle.Circle;
    //                    chart1.Series["Temperature"].MarkerSize = 8;
    //                    chart1.Series["Temperature"].MarkerColor = Color.Black;
    //                }
    //                if (chart1.Series.IsUniqueName("Humidity"))
    //                {
    //                    chart2.Series["Humidity"].MarkerStyle = MarkerStyle.Circle;
    //                    chart2.Series["Humidity"].MarkerSize = 8;
    //                    chart2.Series["Humidity"].MarkerColor = Color.Black;
    //                }
    //                if (chart1.Series.IsUniqueName("Current Rain"))
    //                {
    //                    chart3.Series["Current Rain"].MarkerStyle = MarkerStyle.Circle;
    //                    chart3.Series["Current Rain"].MarkerSize = 8;
    //                    chart3.Series["Current Rain"].MarkerColor = Color.Black;
    //                }
    //                if (chart1.Series.IsUniqueName("Previous Rain"))
    //                {
    //                    chart4.Series["Previous Rain"].MarkerStyle = MarkerStyle.Circle;
    //                    chart4.Series["Previous Rain"].MarkerSize = 8;
    //                    chart4.Series["Previous Rain"].MarkerColor = Color.Black;
    //                }
    //                if (chart1.Series.IsUniqueName("Pressure"))
    //                {
    //                    chart5.Series["Pressure"].MarkerStyle = MarkerStyle.Circle;
    //                    chart5.Series["Pressure"].MarkerSize = 8;
    //                    chart5.Series["Pressure"].MarkerColor = Color.Black;
    //                }
    //                if (chart1.Series.IsUniqueName("Solar Radiation"))
    //                {
    //                    chart6.Series["Solar Radiation"].MarkerStyle = MarkerStyle.Circle;
    //                    chart6.Series["Solar Radiation"].MarkerSize = 8;
    //                    chart6.Series["Solar Radiation"].MarkerColor = Color.Black;
    //                }



    //            }
    //            else
    //            {
    //                chart1.Series["Temperature"].MarkerSize = 0;
    //                chart2.Series["Humidity"].MarkerSize = 0;
    //                chart3.Series["Current Rain"].MarkerSize = 0;
    //                chart4.Series["Previous Rain"].MarkerSize = 0;
    //                chart5.Series["Pressure"].MarkerSize = 0;
    //                chart6.Series["Solar Radiation"].MarkerSize = 0;
    //            }
    //        }
    //        catch (Exception ex)
    //        {

    //        }
    //    }

    //    private void btn_openFolder_Click(object sender, EventArgs e)
    //    {
    //        if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
    //        {
    //            tb_folderPath.Text = folderBrowserDialog1.SelectedPath;
    //            dd_fileList_bu.Clear();
    //            // dd_fileList_bu.AddItem("Select File");
    //            openFile();


    //            DialogResult dr = MessageBox.Show("Do you want to make this as a default folder?", "Set as Default?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
    //            if (dr == DialogResult.Yes)
    //            {
    //                StreamWriter sw = new StreamWriter((Application.StartupPath + @"\config.ini"));
    //                sw.WriteLine(folderBrowserDialog1.SelectedPath);
    //                sw.Close();

    //            }
    //        }

    //    }

    //    //private void SelectFolder_dialog_TextChanged(object sender, EventArgs e)
    //    //{
    //    //    openFile();
    //    //}
    }
}
