/*
  This file is part of the OpenRose application, and is distributed
  as open source software under the terms of the MIT software license
  included below.
  
  Copyright (c) 2009 Brian Krzys (cokrzys@gmail.com)
  https://sourceforge.net/projects/openrose/

  Permission is hereby granted, free of charge, to any person
  obtaining a copy of this software and associated documentation
  files (the "Software"), to deal in the Software without
  restriction, including without limitation the rights to use,
  copy, modify, merge, publish, distribute, sublicense, and/or sell
  copies of the Software, and to permit persons to whom the
  Software is furnished to do so, subject to the following
  conditions:

  The above copyright notice and this permission notice shall be
  included in all copies or substantial portions of the Software.

  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
  EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
  OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
  NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
  HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
  WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
  FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
  OTHER DEALINGS IN THE SOFTWARE.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using arduino2560;
using ExcelDataReader;
using System.Data;

namespace OpenRose
{

   
   //  IExcelDataReader excelReader;
  class Worker
  /*
    ---------------------------------------------------------------------------
     Worker - This is the class that does all the work.
    ---------------------------------------------------------------------------
  */
  {
    //
    // ----- get and set accessors
    //
    public string DataFilename
    {
      get { return m_strDataFilename; }
      set { m_strDataFilename = value; }
    }
    //
    // ----- member variables
    //
    private string m_strDataFilename = "";
    private OpenRoseData m_data = null;
    private string m_strAppName = "OpenRose";
    private OpenRoseGraph m_graph = null;
    IExcelDataReader excelReader;

    public static List<string> temp = new List<string>();
    public static List<string> hum = new List<string>();
    public static List<string> pressure = new List<string>();
    public static List<string> windDir = new List<string>();
    public static List<string> cur_rain = new List<string>();
    public static List<string> prev_rain = new List<string>();
    public static List<string> windSpeed = new List<string>();
    public static List<string> solarRadiation = new List<string>();
    public static List<string> dateTime = new List<string>();

    public static double mTemp=0, mHum=0, mPressure=0, mWindDir=0, mCur_rain=0, mPrev_rain=0, mWindSpeed=0, mSolar=0;

    int i = 0, j = 0;


    public Worker()
    /*
      -------------------------------------------------------------------------
       Worker()
      -------------------------------------------------------------------------
       Constructor.
      -------------------------------------------------------------------------
    */
    {



        
      m_data = new OpenRoseData();
      if (m_data == null)
      {
        MessageBox.Show("Unable to create the data class.", m_strAppName,
          MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      m_graph = new OpenRoseGraph();
      if (m_graph == null)
      {
        MessageBox.Show("Unable to create the graph class.", m_strAppName,
          MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void ParseDataLine(string strLine, ref long nErrors)
    /*
      -------------------------------------------------------------------------
       ParseDataLine()
      -------------------------------------------------------------------------
       Parse and store a line of data.
      -------------------------------------------------------------------------
    */
       

    {
      double dBearing = 0.0;
      //
      // ----- very, very simple right now just one piece of data on a line
      //
      try
      {
          String filePath = Analysis.filepath;
            String extension = Path.GetExtension(filePath);
            filePath.Replace(extension, extension.ToLower());
            FileStream stream = File.Open(filePath, FileMode.Open, FileAccess.Read);
          //  MessageBox.Show(filePath);
            if (File.Exists((string)filePath))
            {
                if (extension == ".xls")
                {

                    excelReader = ExcelReaderFactory.CreateBinaryReader(stream);
                }
                else
                {
                    excelReader = ExcelReaderFactory.CreateCsvReader(stream);
                }


                DataSet result = excelReader.AsDataSet();
                DataTable dt = result.Tables[0];



                int header = 0;

                String str = dt.Rows[j][i].ToString();
                Double val, sum = 0;
                i = 1;
               while(true)
                {
                    try
                    {
                       // MessageBox.Show("yes");
                        // MessageBox.Show(dt.Rows[i][0].ToString());
                        if (dt.Rows[i][0].ToString() != "NAN" && dt.Rows[i][0].ToString() !="" )
                        {
                            temp.Add(( dt.Rows[i][0]).ToString());

                            //if (Convert.ToDouble(dt.Rows[i][0]) > mTemp)
                            //{
                            //    MessageBox.Show("temp");
                            //    mTemp = Convert.ToDouble(dt.Rows[i][0]);
                            //}

                          
                        }
                        if (dt.Rows[i][1].ToString() != "NAN" && dt.Rows[i][1].ToString() != "")
                        {
                            hum.Add(dt.Rows[i][1].ToString());

                            //if (Convert.ToDouble(dt.Rows[i][1]) > mHum)
                            //{
                            //    MessageBox.Show("hum");
                            //    mHum = Convert.ToDouble(dt.Rows[i][1]);
                            //}

                        }
                        if (dt.Rows[i][2].ToString() != "NAN" && dt.Rows[i][2].ToString() != "")
                        {
                            pressure.Add(dt.Rows[i][2].ToString());
                           
                            //if (Convert.ToDouble(dt.Rows[i][2]) > mPressure)
                            //{
                            //    MessageBox.Show("press");
                            //    mPressure = Convert.ToDouble(dt.Rows[i][2]);
                            //}

                        }
                        if (dt.Rows[i][4].ToString() != "NAN" && dt.Rows[i][4].ToString() != "")
                        {
                            cur_rain.Add(dt.Rows[i][4].ToString());

                            //if (Convert.ToDouble(dt.Rows[i][4]) > mCur_rain)
                            //{
                            //  //  MessageBox.Show("rain");
                            //    mCur_rain = Convert.ToDouble(dt.Rows[i][4]);
                            //}

                        }
                        if (dt.Rows[i][5].ToString() != "NAN" && dt.Rows[i][5].ToString() != "")
                        {
                            prev_rain.Add(dt.Rows[i][5].ToString());

                            //if (Convert.ToDouble(dt.Rows[i][5]) > mPrev_rain)
                            //{
                            //    MessageBox.Show("pre_rain");
                            //    mPrev_rain = Convert.ToDouble(dt.Rows[i][5]);
                            //}
                        }
                        if (dt.Rows[i][6].ToString() != "NAN" && dt.Rows[i][6].ToString() != "")
                        {
                            windSpeed.Add(dt.Rows[i][6].ToString());

                            //if (Convert.ToDouble(dt.Rows[i][6]) > mWindSpeed)
                            //{
                            //    MessageBox.Show("speed");
                            //    mWindSpeed = Convert.ToDouble(dt.Rows[i][6]);
                            //}

                        }
                        if (dt.Rows[i][7].ToString() != "NAN" && dt.Rows[i][7].ToString() != "")
                        {
                            solarRadiation.Add(dt.Rows[i][7].ToString());

                            //if (Convert.ToDouble(dt.Rows[i][7]) > mSolar)
                            //{
                            //    MessageBox.Show("solar");
                            //    mSolar = Convert.ToDouble(dt.Rows[i][7]);
                            //}
                        }
                        if (dt.Rows[i][8].ToString() != "NAN" && dt.Rows[i][8].ToString() != "")
                        {
                            dateTime.Add(dt.Rows[i][8].ToString());

                          
                        }

                        //arr_col2.Add(dt.Rows[i][5].ToString());


                      //  MessageBox.Show(dt.Rows[i][3].ToString());
                        if ((Convert.ToDouble(dt.Rows[i][3]) >= 0.0) && (Convert.ToDouble(dt.Rows[i][3]) <= 360.0))
                        {
                          //  MessageBox.Show("windDirection");
                            if (m_data != null)
                            {
                               
                                m_data.AddValue(Convert.ToDouble(dt.Rows[i][3]));
                              //  MessageBox.Show(m_data.ToString());
                            }
                            else
                            {
                               // MessageBox.Show("error");
                                nErrors++;
                            }
                        }


                        // MessageBox.Show(arr_col1[k].ToString() + "\t" + arr_col2[k].ToString());

                        i++;


                        // k++;

                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        //  MessageBox.Show(arr_col1[i].ToString() + "\t" + arr_col2[i].ToString());
                        //MessageBox.Show(ex.Message);
                        break;
                    }
                }













                //
                // ----- convert data to a double and save to memory list
                //
                //dBearing = Convert.ToDouble(strLine);
                //if ((dBearing >= 0.0) && (dBearing <= 360.0))
                //{
                //  if (m_data != null)
                //  {
                //    m_data.AddValue(dBearing);
                //  }
                //  else
                //  {
                //    nErrors++;
                //  }
                //}
            }
      }
      catch (Exception ex)
      {
        nErrors++;
      }
    }

    public bool ReadDataFile(string strFilename)
    /*
      -------------------------------------------------------------------------
       ReadDataFile()
      -------------------------------------------------------------------------
       Open the data file and read all data into memory.
      -------------------------------------------------------------------------
    */
    {
        

      string line = "";
      long nCurLine = 0;
      long nErrors = 0;
      m_strDataFilename = strFilename;



      ParseDataLine("true", ref nErrors);
      try
      {
        //
        // ----- Create an instance of StreamReader to read from a file.
        //       The using statement also closes the StreamReader.
        //
        //using (StreamReader sr = new StreamReader(strFilename))
        //{
        //  //
        //  // ----- clear any data already in memory
        //  //
        //  if (m_data != null)
        //  {
        //    m_data.Clear();
        //  }
        //  //
        //  // ----- loop and read all lines from the file
        //  //
        //  while ((line = sr.ReadLine()) != null)
        //  {
        //    nCurLine++;
        //    //
        //    // ----- first line is for the headers
        //    //
        //    if (nCurLine > 1)
        //    {
        //      ParseDataLine(line, ref nErrors);
        //    }
        //  }
        //}
        //
        // ----- messages about what was loaded
        //
        if (m_data != null)
        {
          if (m_data.Count > 0)
          {
              MB_message mb = new MB_message();
              mb.Theme_success(m_data.Count.ToString() + " row(s) were loaded Successfully.");
              mb.Show();
          //  MessageBox.Show(m_data.Count.ToString() + " data value(s) were loaded with " +
          //    nErrors.ToString() + " error(s).", m_strAppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
          else
          {
              MB_message mb = new MB_message();
              mb.Theme_error("No data was loaded. Please Check whether the file format is correct or not.");
              mb.Show();
           // MessageBox.Show("No data was loaded. Please Check whether the file format is correct or not.", m_strAppName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
          }
        }
        //
        // ----- if graph title is blank set it to the filename
        //
        if (m_graph != null)
        {
          if (m_graph.Title.Length == 0)
          {
            try
            {
              m_graph.Title = Path.GetFileNameWithoutExtension(strFilename);
            }
            catch (Exception ex)
            {
              MessageBox.Show("Unable to parse the filename out of the path, " + ex.Message,
                m_strAppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          }
        }
        //
        // ----- return true if any data was loaded
        //
        if (m_data.Count > 0)
        {
          return true;
        }
      }
      catch (Exception ex)
      {
        //
        // ----- error message if anything goes wrong reading the file
        //
        MessageBox.Show("The file could not be read: " + ex.Message, m_strAppName,
          MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      return false;
    }

    public void Draw(Graphics g)
    /*
      -------------------------------------------------------------------------
       Draw()
      -------------------------------------------------------------------------
       Draw the rose diagram.
      -------------------------------------------------------------------------
    */
    {
      if ((g != null) && (m_data != null) && (m_graph != null))
      {
        m_graph.Draw(g, m_data);
      }
    }

    //public bool EditProperties()
    ///*
    //  -------------------------------------------------------------------------
    //   EditProperties()
    //  -------------------------------------------------------------------------
    //   Open form to edit the properties for the graph.
    //  -------------------------------------------------------------------------
    //*/
    //{
    //  PropertiesForm prop = new PropertiesForm();
    //  if (prop != null)
    //  {
    //    if (m_graph != null)
    //    {
    //      prop.Title = m_graph.Title;
    //      prop.BinSize = m_graph.BinSize;
    //      prop.PetalColor = m_graph.PetalColor;
    //      prop.ShowAngleScale = m_graph.ShowAngleScale;
    //      prop.AngleScale = m_graph.AngleScale;
    //      prop.AngleScaleLabels = m_graph.AngleScaleLabels;
    //      prop.AngleScaleColor = m_graph.AngleScaleColor;
    //      prop.ShowCircleScale = m_graph.ShowCircleScale;
    //      prop.CircleScaleColor = m_graph.CircleScaleColor;
    //      //
    //      // ----- open the properties form
    //      //
    //      if (prop.ShowDialog() == DialogResult.OK)
    //      {
    //        m_graph.Title = prop.Title;
    //        m_graph.BinSize = prop.BinSize;
    //        m_graph.PetalColor = prop.PetalColor;
    //        m_graph.ShowAngleScale = prop.ShowAngleScale;
    //        m_graph.AngleScale = prop.AngleScale;
    //        m_graph.AngleScaleLabels = prop.AngleScaleLabels;
    //        m_graph.AngleScaleColor = prop.AngleScaleColor;
    //        m_graph.ShowCircleScale = prop.ShowCircleScale;
    //        m_graph.CircleScaleColor = prop.CircleScaleColor;
    //        return true;
    //      }
    //    }
    //    else
    //    {
    //      MessageBox.Show("Graph object does not exist in Worker.EditProperties().", "OpenRose",
    //        MessageBoxButtons.OK, MessageBoxIcon.Error);
    //    }
    //  }
    //  else
    //  {
    //    MessageBox.Show("Unable to create the properties form.", "OpenRose",
    //      MessageBoxButtons.OK, MessageBoxIcon.Error);
    //  }
    //  return false;
    //}


  }

}
