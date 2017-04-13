using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Red303340
{
    public class GVTPowerMeter
    {
        gvtMessageSession mbSession;
        string _connecterStr="";
        GvtSCPIFile scpi;
        public string connecterStr
        {
            get
            {
                return _connecterStr;
            }
            set
            {
                _connecterStr = value;
                if(mbSession == null)
                { mbSession = new gvtMessageSession(); }
                bool connect=mbSession.InstrumentConnect(_connecterStr);
                if(connect)
                {

                   


                }
            }
        }
        public GVTPowerMeter()
        {
            
        }
        public GVTPowerMeter(string connectstr)
        {
            mbSession.InstrumentConnect(connectstr);
        }
        public string getCurrentDB()
        {
            string tempS;
            double powerDBM = 0;
           
            tempS = mbSession.QuerrySession("FETC1:POW:AC?").Substring(0, 7);

            powerDBM = double.Parse(tempS) * 10.0;
            return powerDBM.ToString();
          
        }
    }
}
