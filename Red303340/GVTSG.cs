using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Red303340
{
    public class GVTSG
    {
        gvtMessageSession mbSession;
        GvtSCPIFile scpi;
        public string connecterStr = "";
        public GVTSG()
        {
          
        }
        public GVTSG(string connectstr)
        {
            mbSession.InstrumentConnect(connectstr);
        }
    }
}
