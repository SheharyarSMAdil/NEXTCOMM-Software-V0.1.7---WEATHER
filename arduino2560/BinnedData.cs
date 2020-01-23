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
using System.Windows.Forms;
using System.Text;

namespace OpenRose
{

  public class BinnedData
  /*
    ---------------------------------------------------------------------------
     BinnedData - Class to contain a set of binned data.
    ---------------------------------------------------------------------------
  */
  {

    //
    // ----- get and set accessors
    //
    public double Minimum
    {
      get { return m_dMin; }
    }
    public double Maximum
    {
      get { return m_dMax; }
    }
    public double BinSize
    {
      get { return m_dBinSize; }
    }
    public long NumBins
    {
      get { return m_nBins; }
    }

    //
    // ----- member variables
    //
    protected string m_strClassName = "BinnedData";
    private double m_dMin = double.NaN;
    private double m_dMax = double.NaN;
    private double m_dBinSize = double.NaN;
    private long m_nBins = 0;
    private long[] m_binData = null;

    public BinnedData()
    /*
      -------------------------------------------------------------------------
       BinnedData()
      -------------------------------------------------------------------------
       Constructor.
      -------------------------------------------------------------------------
    */
    {
      Clear();
    }

    public void Clear()
    /*
      -------------------------------------------------------------------------
       Clear()
      -------------------------------------------------------------------------
       Clear everything and re-initialize the class.
      -------------------------------------------------------------------------
    */
    {
      m_dMin = double.NaN;
      m_dMax = double.NaN;
      m_dBinSize = double.NaN;
      m_nBins = 0;
      m_binData = null;
    }

    public void ZeroBins()
    /*
      -------------------------------------------------------------------------
       ZeroBins()
      -------------------------------------------------------------------------
       Set all the bin values to zero.
      -------------------------------------------------------------------------
    */
    {
      if (m_binData != null)
      {
        for (int i = 0; i < NumBins; i++)
        {
          m_binData[i] = 0;
        }
      }
    }

    public bool SetupBins(double dMin, double dMax, double dBinSize)
    /*
      -------------------------------------------------------------------------
       SetupBins()
      -------------------------------------------------------------------------
       Setup the data bins.
      -------------------------------------------------------------------------
    */
    {
      bool bRet = false;
      string strEndMessage = m_strClassName + ".SetupBins()";
      //
      // ----- need various things set to allocate bins
      //
      if ((dMin.CompareTo(double.NaN) != 0) && (dMax.CompareTo(double.NaN) != 0) &&
           (dBinSize.CompareTo(double.NaN) != 0))
      {
        //
        // ----- determine the number of bins needed
        //
        m_nBins = Convert.ToInt32(Math.Ceiling((dMax - dMin) / dBinSize));
        if (m_nBins > 0)
        {
          m_binData = new long[m_nBins];
          //
          // ----- if bins created then get them configured
          //
          if (m_binData != null)
          {
            m_dMin = dMin;
            m_dMax = dMax;
            m_dBinSize = dBinSize;
            ZeroBins();
            bRet = true;
          }
          else
          {
            MessageBox.Show("Unable to allocate memory for " + m_nBins.ToString() + " bins.",
              "OpenRose", MessageBoxButtons.OK, MessageBoxIcon.Error);
            m_nBins = 0;
          }
        }
        else
        {
          MessageBox.Show("No bins in " + strEndMessage, "OpenRose",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
      }
      else
      {
        MessageBox.Show("Required parameters not set in " + strEndMessage, "OpenRose",
          MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      return bRet;
    }

    public bool BinValue(double dVal)
    /*
      -------------------------------------------------------------------------
       BinValue()
      -------------------------------------------------------------------------
       Bin and increment the bin count for a specific value.
      -------------------------------------------------------------------------
    */
    {
      if ((dVal >= Minimum) && (dVal <= Maximum))
      {
        int nBin = Convert.ToInt32(Math.Floor((dVal - Minimum) / BinSize));
        if ((nBin >= 0) && (nBin < m_binData.Length))
        {
          m_binData[nBin]++;
          return true;
        }
      }
      return false;
    }

    public long GetMaxCount()
    {
      long nMax = 0;
      if (m_binData != null)
      {
        for (int i = 0; i < m_binData.Length; i++)
        {
          if (m_binData[i] > nMax)
          {
            nMax = m_binData[i];
          }
        }
      }
      return nMax;
    }

    public long GetCount(int nBin)
    {
      long nCount = 0;
      if (m_binData != null)
      {
        if ((nBin >= 0) && (nBin < m_binData.Length))
        {
          nCount = m_binData[nBin];
        }
      }
      return nCount;
    }

  }

}
