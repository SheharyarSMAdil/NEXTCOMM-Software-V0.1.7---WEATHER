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

namespace OpenRose
{

  public class OpenRoseData
  /*
    ---------------------------------------------------------------------------
     OpenRoseData - Class to manage rose diagram data.
    ---------------------------------------------------------------------------
  */
  {
    //
    // ----- get and set accessors
    //
    public long Count
    {
      get { return m_data.Count; }
    }
    public double Minimum
    {
      get { return m_dMin; }
    }
    public double Maximum
    {
      get { return m_dMax; }
    }
    public double Average
    {
      get
      {
        if (Count > 0)
        {
          return m_dSum / Count;
        }
        else
        {
          return double.NaN;
        }
      }
    }

    //
    // ----- member variables
    //
    private List<double> m_data;
    private double m_dMin = double.NaN;
    private double m_dMax = double.NaN;
    private double m_dSum = double.NaN;
    private double m_dSumSquares = double.NaN;

    public OpenRoseData()
    /*
      -------------------------------------------------------------------------
       OpenRoseData()
      -------------------------------------------------------------------------
       Constructor.
      -------------------------------------------------------------------------
    */
    {
      m_data = new List<double>();
    }

    public void Clear()
    /*
      -------------------------------------------------------------------------
       Clear()
      -------------------------------------------------------------------------
       Clear out all the data and re-initialize the statistics.
      -------------------------------------------------------------------------
    */
    {
      m_data.Clear();
      m_dMax = double.NaN;
      m_dMin = double.NaN;
      m_dSum = double.NaN;
      m_dSumSquares = double.NaN;
    }

    public bool AddValue(double dVal)
    /*
      -------------------------------------------------------------------------
       AddValue()
      -------------------------------------------------------------------------
       Add a value to the statistic.
      -------------------------------------------------------------------------
    */
    {
      m_data.Add(dVal);
      //
      // ----- keep track of the min and max
      //
      if (m_data.Count == 1)
      {
        m_dMin = dVal;
        m_dMax = dVal;
        m_dSum = dVal;
        m_dSumSquares = dVal * dVal;
      }
      else
      {
        if (dVal < m_dMin) m_dMin = dVal;
        if (dVal > m_dMax) m_dMax = dVal;
        m_dSum += dVal;
        m_dSumSquares += (dVal * dVal);
      }
      return true;
    }

    public double GetValue(int nIndex)
    /*
      -------------------------------------------------------------------------
       GetValue()
      -------------------------------------------------------------------------
       Get a value at a specific index position.
      -------------------------------------------------------------------------
    */
    {
      double dRet = double.NaN;
      if ((nIndex >= 0) && (nIndex < m_data.Count))
      {
        dRet = m_data[nIndex];
      }
      return dRet;
    }

    public double GetStandardDeviation()
    /*
      -------------------------------------------------------------------------
       GetStandardDeviation()
      -------------------------------------------------------------------------
       Get the standard deviation.
      -------------------------------------------------------------------------
    */
    {
      double dStdDev = double.NaN;
      //
      // ----- standard deviation, from Davis (1993)
      //
      if (Count > 1)
      {
        double ss = m_dSumSquares - (m_dSum * m_dSum) / Convert.ToDouble(Count);
        double sq = ss / Convert.ToDouble(Count - 1);
        if (sq >= 0.0)
        {
          dStdDev = Math.Sqrt(sq);
        }
      }
      return dStdDev;
    }

  }

}
