using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace arduino2560
{
    class SerialPortCommunicator
    {
        private static SerialPort _serialPort = new SerialPort();

        public static SerialPort SerialPort
        {
            get { return _serialPort; }
            set { _serialPort = value; }
        }
    }
}
