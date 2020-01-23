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
using System.Text;
using System.Drawing;
//using System.Numeric;
using System.Windows.Forms;

namespace OpenRose
{

  public class OpenRoseGraph
  /*
    ---------------------------------------------------------------------------
     OpenRoseGraph - Class to draw a rose diagram.
    ---------------------------------------------------------------------------
  */
  {
    public enum RoseGraphType
    {
      Full = 0,
      Half = 1,
    }
    //
    // ----- get and set accessors
    //
    public string Title
    {
      get { return m_strTitle; }
      set { m_strTitle = value; }
    }
    public double BinSize
    {
      get { return m_dBinSize; }
      set { m_dBinSize = value; }
    }
    public Color PetalColor
    {
      get { return m_colorPetals; }
      set { m_colorPetals = value; }
    }
    public RoseGraphType Type
    {
      get { return m_enumType; }
      set { m_enumType = value; }
    }
    public bool ShowAngleScale
    {
      get { return m_bAngleScale; }
      set { m_bAngleScale = value; }
    }
    public double AngleScale
    {
      get { return m_dAngleScale; }
      set { m_dAngleScale = value; }
    }
    public double AngleScaleLabels
    {
      get { return m_dAngleScaleLabels; }
      set { m_dAngleScaleLabels = value; }
    }
    public Color AngleScaleColor
    {
      get { return m_colorAngleScale; }
      set { m_colorAngleScale = value; }
    }
    public bool ShowCircleScale
    {
      get { return m_bCircleScale; }
      set { m_bCircleScale = value; }
    }
    public Color CircleScaleColor
    {
      get { return m_colorCircleScale; }
      set { m_colorCircleScale = value; }
    }
    public int NumCircleScaleLines
    {
      get { return m_nCircleScaleLines; }
      set { m_nCircleScaleLines = value; }
    }

    //
    // ------ member variables
    //
    private string m_strClassName = "OpenRoseGraph";
    private string m_strTitle = "";
    private Rectangle m_rectGraph;  // drawing area for the graph
    private Point m_ptMidpoint;  // midpoint of drawing area (center of rose diagram)
    private double m_dBinSize = 25.0;
    private Color m_colorPetals = Color.SkyBlue;
    private Color m_colorAngleScale = Color.Gray;
    private Color m_colorCircleScale = Color.DarkGray;
    private RoseGraphType m_enumType = RoseGraphType.Full;
    private bool m_bAngleScale = true;
    private bool m_bCircleScale = true;
    private double m_dAngleScale = 45.0;
    private double m_dAngleScaleLabels = 45.0;
    private int m_nCircleScaleLines = 2;
    string[] dir = { "N", "NE", "E", "SE", "S", "SW","W","NW" };

    public OpenRoseGraph()
    /*
      -------------------------------------------------------------------------
       OpenRoseGraph()
      -------------------------------------------------------------------------
       Constructor.
      -------------------------------------------------------------------------
    */
    {
      m_strClassName = "OpenRoseGraph";
    }

    private void InitLayout(Graphics g)
    /*
      -------------------------------------------------------------------------
       InitLayout()
      -------------------------------------------------------------------------
       Initial the graph layout, this is called internally before 
       drawing anything.
      -------------------------------------------------------------------------
    */
    {
      //
      // ----- debug cross through drawing area
      //
      // g.DrawLine(Pens.Black, g.VisibleClipBounds.Width / 2, 0, g.VisibleClipBounds.Width / 2, g.VisibleClipBounds.Height);
      // g.DrawLine(Pens.Black, 0, g.VisibleClipBounds.Height / 2, g.VisibleClipBounds.Width, g.VisibleClipBounds.Height / 2);
      //
      // ----- midpoint of drawing area
      //
      m_ptMidpoint.X = Convert.ToInt32(g.VisibleClipBounds.Width / 2);
      m_ptMidpoint.Y = Convert.ToInt32(g.VisibleClipBounds.Height / 2);
      //
      // ----- figure out which axis controls the size of the graph
      //
      long nMax = Convert.ToInt32(g.VisibleClipBounds.Width);
      if (g.VisibleClipBounds.Height < nMax)
      {
        nMax = Convert.ToInt32(g.VisibleClipBounds.Height);
      }
      //
      // ----- set rectangle that graph needs to be in
      //
      nMax = Convert.ToInt32(nMax * 0.75);
      m_rectGraph.X = Convert.ToInt32(m_ptMidpoint.X - nMax / 2);
      m_rectGraph.Width = Convert.ToInt32(nMax);
      m_rectGraph.Y = Convert.ToInt32(m_ptMidpoint.Y - nMax / 2);
      m_rectGraph.Height = Convert.ToInt32(nMax);
      //
      // ----- draw an outer circle around the graph
      //
      DrawOutline(g);
    }

    private void DrawOutline(Graphics g)
    /*
      -------------------------------------------------------------------------
       DrawOutline()
      -------------------------------------------------------------------------
       Draw the outline around the rose diagram.
      -------------------------------------------------------------------------
    */
    {
      //
      // ----- draw an outer circle around the graph
      //
      Pen thickPen = new Pen(Color.Black, 2);
      if (thickPen != null)
      {
        g.DrawEllipse(thickPen, m_rectGraph);
        thickPen.Dispose();
      }
      else
      {
        MessageBox.Show("Unable to create a thick pen.", "OpenRose",
          MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void DrawStatistics(Graphics g, OpenRoseData data)
    /*
      -------------------------------------------------------------------------
       DrawStatistics()
      -------------------------------------------------------------------------
       Draw the statistics on the graph.
      -------------------------------------------------------------------------
    */
    {
      FontFamily arialFamily = new FontFamily("Arial");
      Font arialFont = new Font(arialFamily, 10);
      g.DrawString("N = " + data.Count.ToString(), arialFont, Brushes.Black, new PointF(10, g.VisibleClipBounds.Height - 80));
      // g.DrawString("Avg = " + data.Average.ToString("N1"), arialFont, Brushes.Black, new PointF(10, g.VisibleClipBounds.Height - 60));
      // g.DrawString("StdDev = " + data.GetStandardDeviation().ToString("N1"), arialFont, Brushes.Black, new PointF(10, g.VisibleClipBounds.Height - 40));
      g.DrawString("Min = " + data.Minimum.ToString(), arialFont, Brushes.Black, new PointF(10, g.VisibleClipBounds.Height - 60));
      g.DrawString("Max = " + data.Maximum.ToString(), arialFont, Brushes.Black, new PointF(10, g.VisibleClipBounds.Height - 40));
    }

    private void DrawTitle(Graphics g)
    /*
      -------------------------------------------------------------------------
       DrawTitle()
      -------------------------------------------------------------------------
       Draw the graph title, note that you have to call InitLayout() before
       calling this.
      -------------------------------------------------------------------------
    */
    {
      int nBorder = 10;
      FontFamily arialFamily = new FontFamily("Arial");
      Font arialFont = new Font(arialFamily, 12, FontStyle.Bold);
      StringFormat format = new StringFormat();
      //
      // ----- setup alignment
      //
      format.Alignment = StringAlignment.Center;
      format.LineAlignment = StringAlignment.Center;
      format.Trimming = StringTrimming.EllipsisCharacter;
      //
      // ----- rectangle for title to be in
      //
      Rectangle rect = new Rectangle();
      rect.X = nBorder;
      rect.Width = Convert.ToInt32(g.VisibleClipBounds.Width - (nBorder * 2));
      rect.Y = nBorder;
      rect.Height = m_rectGraph.Top - rect.Y - 12;
      //
      // ----- draw the text
      //
      // g.DrawRectangle(Pens.Black, rect);
      g.DrawString(Title, arialFont, Brushes.Black, rect, format);
      //
      // ----- dispose of graphics objects we used
      //
      arialFont.Dispose();
      arialFamily.Dispose();
    }

    private float NorthAzimuthToPieAzimuth(double dNorthAzimuth)
    /*
      -------------------------------------------------------------------------
       NorthAzimuthToPieAzimuth()
      -------------------------------------------------------------------------
       Convert a north azimuth to a pie azimuth.  A pie azimuth is degrees
       clockwise from the x axis.  A north azimuth is degrees clockwide from
       the y axis.
      -------------------------------------------------------------------------
    */
    {
      double dPieAzimuth = dNorthAzimuth - 90.0;
      if (dPieAzimuth < 0.0)
      {
        dPieAzimuth += 360.0;
      }
      return Convert.ToSingle(dPieAzimuth);
    }

    private double Interpolate(double dSrcVal, double dSrcMin, double dSrcMax,
                               double dDestMin, double dDestMax)
    /* 
      ------------------------------------------------------------------------
       Interpolate()
      ------------------------------------------------------------------------
       Simple linear interpolation between two points.
       dSrcVal  = value in source system
       dSrcMin  = endpoint1 in source system
       dSrcMax  = endpoint2 in source system
       dDestMin = endpoint1 in destination system
       dDestMax = endpoint2 in destination system
      ------------------------------------------------------------------------
    */
    {
      double ret = 0.0;
      double data_range = 0.0;
      double size_range = 0.0;
      if ((dDestMin == dDestMax) ||
          (dSrcVal <= dSrcMin))
      {
        ret = dDestMin;
      }
      else
      {
        if (dSrcVal >= dSrcMax)
        {
          ret = dDestMax;
        }
        else
        {
          //
          // ----- interpolate
          //
          data_range = dSrcMax - dSrcMin;
          size_range = dDestMax - dDestMin;
          if (data_range != 0.0)
            ret = dDestMin + ((size_range / data_range) * (dSrcVal - dSrcMin));
          else
            ret = dDestMin;
        }
      }
      return (ret);
    }

    private void DrawPetals(Graphics g, BinnedData bins, double dAverage, double dStdDev)
    /*
      -------------------------------------------------------------------------
       DrawPetals()
      -------------------------------------------------------------------------
       Draw the petals on the rose graph.
      -------------------------------------------------------------------------
    */
    {
      long nMaxCount = bins.GetMaxCount();
      int nInflate = 0;
      Rectangle rect = new Rectangle();
      double dLen = 0.0;
      double dStartAngle = 10.0;
      float dPieAzimuth = 0.0F;
      SolidBrush brushPetals = new SolidBrush(PetalColor);
      //
      // ----- loop through each bin
      //
      for (int i = 0; i < bins.NumBins; i++)
      {
        //
        // ----- figure out how wide pie slice needs to be
        //
        dLen = Interpolate(Convert.ToDouble(bins.GetCount(i)), 
                 0.0, Convert.ToDouble(nMaxCount), 0.0, m_rectGraph.Width / 2.0);
        nInflate = Convert.ToInt32(dLen - m_rectGraph.Width / 2.0);
        rect = m_rectGraph;
        rect.Inflate(nInflate, nInflate);
        //
        // ----- draw pie slice if it has width
        //
        if ((rect.Width > 0) && (rect.Height > 0))
        {
          dPieAzimuth = NorthAzimuthToPieAzimuth(dStartAngle);
          g.FillPie(brushPetals, rect, dPieAzimuth, Convert.ToSingle(BinSize));
          g.DrawPie(Pens.SkyBlue, rect, dPieAzimuth, Convert.ToSingle(BinSize));
        }
        dStartAngle += BinSize;
      }
      //
      // ----- show a line for the average
      //
      /*
      if (dAverage.CompareTo(double.NaN) != 0)
      {
        dPieAzimuth = NorthAzimuthToPieAzimuth(dAverage);
        rect = m_rectGraph;
        g.DrawPie(Pens.Black, rect, dPieAzimuth, Convert.ToSingle(0.1));
        dPieAzimuth = NorthAzimuthToPieAzimuth(dAverage - dStdDev);
        g.DrawPie(Pens.Blue, rect, dPieAzimuth, Convert.ToSingle(0.1));
        dPieAzimuth = NorthAzimuthToPieAzimuth(dAverage + dStdDev);
        g.DrawPie(Pens.Blue, rect, dPieAzimuth, Convert.ToSingle(0.1));
      }
      */
      //
      // ----- dispose of graphics object(s) we created
      //
      brushPetals.Dispose();
    }

    private Point AzimuthMove(Point pt, double dAzimuth, double dDist)
    /*
      -------------------------------------------------------------------------
       AzimuthMove()
      -------------------------------------------------------------------------
       Move a point a given distance along a north relative azimuth.
      -------------------------------------------------------------------------
    */
    {
      Point ptRet = pt;
      if (dDist > 0.0)
      {
        double x = Convert.ToDouble(pt.X);
        double y = Convert.ToDouble(pt.Y);
        x += (dDist * Math.Sin((dAzimuth * Math.PI) / 180.0));
        //
        // ----- note that y decreases here due to an origin in the 
        //       upper-left corner
        //
        y -= (dDist * Math.Cos((dAzimuth * Math.PI) / 180.0));
        ptRet.X = Convert.ToInt32(x);
        ptRet.Y = Convert.ToInt32(y);
      }
      return ptRet;
    }

    private void DrawAngleScale(Graphics g)
    /*
      -------------------------------------------------------------------------
       DrawAngleScale()
      -------------------------------------------------------------------------
       Draw the angle scale lines and labels.
      -------------------------------------------------------------------------
    */
    {
      double dAzimuth = 0.0;
      float dRotationAngle = 0.0F;
      Point p1;
      Point p2;
      if (ShowAngleScale)
      {
        Pen penAngleScale = new Pen(m_colorAngleScale, 1);
        if (penAngleScale != null)
        {
          //
          // ----- loop and draw the angle scale lines
          //
          while (dAzimuth < 360.0)
          {
            p1 = m_ptMidpoint;
            p2 = AzimuthMove(p1, dAzimuth, Convert.ToDouble(m_rectGraph.Height / 2));
            g.DrawLine(penAngleScale, p1, p2);
            dAzimuth += m_dAngleScale;
          }
          penAngleScale.Dispose();
        }
        else
        {
          MessageBox.Show("Unable to create a Pen object.", "OpenRose",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //
        // ----- create font for scale labels
        //
        FontFamily arialFamily = new FontFamily("Arial");
        Font arialFont = new Font(arialFamily, 8, FontStyle.Regular);
        StringFormat format = new StringFormat();
        if (arialFamily != null)
        {
          if (arialFont != null)
          {
            //
            // ----- setup alignment
            //
            format.Alignment = StringAlignment.Far;
            format.LineAlignment = StringAlignment.Far;
            format.Trimming = StringTrimming.None;
            //
            // ----- loop and plot the labels
            //
            dAzimuth = 0.0; 
              int i=0;
            while (dAzimuth < 360.0)
            {
              p1 = m_ptMidpoint;
              p1 = AzimuthMove(p1, dAzimuth, Convert.ToDouble(m_rectGraph.Height / 2) * 1.03);
              //
              // ----- some effort here to get all the labels plotting the best way possible
              //
              if (dAzimuth > 0.0)
              {
                g.TranslateTransform(p1.X, p1.Y);
                if (dAzimuth <= 180.0)
                {
                  format.Alignment = StringAlignment.Near;
                  dRotationAngle = NorthAzimuthToPieAzimuth(dAzimuth);
                }
                else
                {
                  format.Alignment = StringAlignment.Far;
                  dRotationAngle = NorthAzimuthToPieAzimuth(dAzimuth - 180.0);
                }
                g.RotateTransform(dRotationAngle);
                g.DrawString(dir[i], arialFont, Brushes.DarkGray, 0.0f, 0.0f, format);
                g.ResetTransform();
              }
              else
              {
                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Far;
                g.DrawString(dAzimuth.ToString(), arialFont, Brushes.Black, p1, format);
                format.Alignment = StringAlignment.Near;
                format.LineAlignment = StringAlignment.Center;
              }
              dAzimuth += m_dAngleScaleLabels;
              i++;
            }
            //
            // ----- dispose of the font
            //
            arialFont.Dispose();
          }
          else
          {
            MessageBox.Show("Unable to create a Font object.", "OpenRose",
              MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
          //
          // ----- dispose of the font family
          //
          arialFamily.Dispose();
        }
        else
        {
          MessageBox.Show("Unable to create a FontFamily object.", "OpenRose",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    private void DrawCircleScale(Graphics g, OpenRoseData data, BinnedData bins)
    /*
      -------------------------------------------------------------------------
       DrawCircleScale()
      -------------------------------------------------------------------------
       Draw the circular (binned data) scale.
      -------------------------------------------------------------------------
    */
    {
      if (ShowCircleScale)
      {
        Rectangle rect = m_rectGraph;
        Pen scalePen = new Pen(CircleScaleColor, 1);
        if (scalePen != null)
        {
          if (data.Count == 0)
          {
            //
            // ----- if no data this draws default scale lines
            //
            int nDeflateWidth = (m_rectGraph.Width / 2) / (m_nCircleScaleLines + 1) * -1;
            int nDeflateHeight = (m_rectGraph.Height / 2) / (m_nCircleScaleLines + 1) * -1;
            rect = m_rectGraph;
            for (int i = 0; i < m_nCircleScaleLines; i++)
            {
              rect.Inflate(nDeflateWidth, nDeflateHeight);
              g.DrawEllipse(scalePen, rect);
            }
          }
          else
          {
            //
            // ----- create font for scale labels
            //
            FontFamily arialFamily = new FontFamily("Arial");
            Font arialFont = new Font(arialFamily, 8, FontStyle.Regular);
            StringFormat format = new StringFormat();
            Point p1 = m_ptMidpoint;
            if (arialFamily != null)
            {
              if (arialFont != null)
              {
                double dLen = 0.0;
                long nScaleLineSpacing = bins.GetMaxCount() / (m_nCircleScaleLines + 1);
                long nCurDist = nScaleLineSpacing;
                int nInflate = 0;
                //
                //
                //
                for (int i = 0; i < m_nCircleScaleLines + 1; i++)
                {
                  //
                  // ----- 
                  //
                  dLen = Interpolate(Convert.ToDouble(nCurDist),
                           0.0, Convert.ToDouble(bins.GetMaxCount()), 0.0, m_rectGraph.Width / 2.0);
                  nInflate = Convert.ToInt32(dLen - m_rectGraph.Width / 2.0);
                  rect = m_rectGraph;
                  rect.Inflate(nInflate, nInflate);
                  if ((rect.Width <= m_rectGraph.Width) && (rect.Height <= m_rectGraph.Height))
                  {
                    p1.X = rect.Right;
                    p1.Y = rect.Top + (rect.Height / 4);
                    g.DrawString(Convert.ToInt32(((float)nCurDist / (float)data.Count) * 100)+"%", arialFont, Brushes.Black, p1, format);
                    g.DrawEllipse(scalePen, rect);
                  }
                  nCurDist += nScaleLineSpacing;
                }
                arialFont.Dispose();
              }
              else
              {
                MessageBox.Show("Unable to create a Font object.", "OpenRose",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
              }
              arialFamily.Dispose();
            }
            else
            {
              MessageBox.Show("Unable to create a FontFamily object.", "OpenRose",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          }
          scalePen.Dispose();
        }
        else
        {
          MessageBox.Show("Unable to create a scale pen.", "OpenRose",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    public void Draw(Graphics g, OpenRoseData data)
    /*
      -------------------------------------------------------------------------
       Draw()
      -------------------------------------------------------------------------
       Draw the graph, this is the publically visible drawing function.
      -------------------------------------------------------------------------
    */
    {
      g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
      g.Clear(Color.White);
      InitLayout(g);
      DrawTitle(g);
      //
      // ----- draw statistics
      //
      if (data.Count > 0)
      {
        DrawStatistics(g, data);
      }
      DrawAngleScale(g);
      //
      // ----- bin the data
      //
      BinnedData bins = new BinnedData();
      if (bins.SetupBins(0.0, 360.0, BinSize))
      {
        for (int i = 0; i < data.Count; i++)
        {
          bins.BinValue(data.GetValue(i));
        }
        //
        // ----- draw the circular scale lines
        //
        DrawCircleScale(g, data, bins);
        //
        // ----- draw the petals
        //
        DrawPetals(g, bins, data.Average, data.GetStandardDeviation());
      }
      //
      // ----- draw a neat outline again
      //
      DrawOutline(g);
    }

  }

}
