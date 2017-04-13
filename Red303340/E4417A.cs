using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Red303340
{
    class E4417A
    {
        gvtMessageSession mbSession;
        GvtSCPIFile scpi;
        public string connecterStr = "";
        public E4417A()
        {
            mbSession.InstrumentConnect(connecterStr);
        }
        public E4417A(string connectstr)
        {
            mbSession.InstrumentConnect(connectstr);
        }
    }
}
