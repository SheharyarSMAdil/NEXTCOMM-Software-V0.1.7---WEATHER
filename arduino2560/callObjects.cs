using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arduino2560
{
    class callObjects
    {
        public static APN apn = new APN();
        public static Analysis analysis = new Analysis();
        public static BackUpData bud = new BackUpData();
        public static Connect con = new Connect();
        public static MB_message mb = new MB_message();
        public static Scan scan = new Scan();
        public static Setup setup = new Setup();
        public static SystemInfo sys = new SystemInfo();
        public static Splash splash = new Splash();

    }
}
