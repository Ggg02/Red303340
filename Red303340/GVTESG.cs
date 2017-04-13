using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Red303340
{
    public class GVTESG
    {
        gvtMessageSession mbSession;
        GvtSCPIFile scpi;
        string _connecterStr = "";
        public string connecterStr 
         {
            get {
                return _connecterStr;
            }
    set {
                _connecterStr = value;
                if(mbSession == null)
                {
                    mbSession = new gvtMessageSession();
                }
                if(!mbSession.InstrumentConnect(_connecterStr))
                {
                    if (!mbSession.InstrumentConnect(_connecterStr))
                    {
                        mbSession.InstrumentConnect(_connecterStr);
                    }

                }
                //mbSession.InstrumentConnect(_connecterStr);
            }
        }
        public GVTESG()
        {
            
        }
        public GVTESG(string connectstr)
        {
            mbSession.InstrumentConnect(connectstr);
        }
        public string getCurrentDB()
        {
            string retStr = "";
            retStr= mbSession.QuerrySession("POW:AMPL?");
            return retStr;
        }
        public void setCurrentDB(string db)
        {
            string setStr = db.ToString();
            string cmdStr = "POW:AMPL " + setStr;

            mbSession.writeSession(cmdStr);
        }
        public void connect()
        {
            mbSession.InstrumentConnect(_connecterStr);
        }
        public string getFREQ()
        {
            string retStr = "";
            string[] freqStrArray;
            retStr = mbSession.QuerrySession("FREQ:CW?");
            retStr = retStr.Replace("\\n", "").Replace("+", "");
            freqStrArray = retStr.Split('E');
            double mul = double.Parse(freqStrArray[1]);
            double value = double.Parse(freqStrArray[0]);
            retStr = (value * Math.Pow(10, mul-6)).ToString();
            return retStr;
        }
        public void setFREQ(string freq)
        {
            string setStr = freq.ToString();
            string cmdStr = "FREQ:CW " + setStr;

            mbSession.writeSession(cmdStr);
           
        }
        public void setRF(bool RF)
        {
            string onOffstr = (RF) ? "ON" : "OFF";
            string cmdStr = "OUTP:STAT " + onOffstr;
            mbSession.writeSession(cmdStr);
        }
        public void setMod(bool mod)
        {
            string onOffstr = (mod) ? "ON" : "OFF";
            string cmdStr = "OUTP:MOD " + onOffstr;
            mbSession.writeSession(cmdStr);
        }
        public void setARB(bool ARB)
        {
            string onOffstr = (ARB) ? "ON" : "OFF";
            string cmdStr = "ARB:STATe " + onOffstr;
            mbSession.writeSession(cmdStr);
        }
        public string getWMList()
        {
            string retStr = "";
            string cmdStr = "MMEMory:CATalog? \"WFM1: \"";
            retStr=mbSession.QuerrySessionQ(cmdStr);
            return retStr;
        }
        public void selectWFM(string fileName)
        {
            
            string cmdStr = ":SOURce:RADio:ARB:WAVeform \"WFM1:"+ fileName.ToUpper()+"\"";
            mbSession.writeSession(cmdStr);
        }
        public string getCurrentFile()
        {
            string retStr = "";
            string cmdStr = "RAD:ARB:WAV?";
            retStr=mbSession.QuerrySession(cmdStr);
            retStr = retStr.Substring(6, retStr.Length-8);
            return retStr;
        }
    }
}
