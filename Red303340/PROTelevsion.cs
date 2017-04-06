using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Red303340
{
    class PROTelevsion
    {
        gvtMessageSession mbSession;
        GvtSCPIFile scpi;
        public string connecterStr = "";
        public PROTelevsion()
        {
            mbSession.InstrumentConnect(connecterStr);
        }
        public PROTelevsion(string connectstr)
        {
            mbSession.InstrumentConnect(connectstr);
        }

    }
}
