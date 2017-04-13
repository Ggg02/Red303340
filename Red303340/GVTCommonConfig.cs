using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Red303340
{
   
   public static class GVTCommonConfig
    {

       
        public static GVTESG gvtVSG;//= new GVTESG();
        public static GVTSG gvtSG;// = new GVTSG();
        public static GVTPowerMeter gvtPowerMeter;// = new GVTPowerMeter();
        public const string GVTKEY = "GVT";
        public static int GVTDiagForDB = 1;
        public static int GVTDiagForFreq = 2;
        public static double offsetSGreducePM = 0;
        public static double offsetVSGreducePM = 0;
        public static string[] testEnv = { "DVBT_7M", "DVBT_8M", "DVBT2_7M", "DVBT2_8M" };
        public static string GeneratorCConnectString = "";
        public static string GeneratorIConnectString = "";
        public static string GeneratorCSCPIFilePath = "";
        public static string GeneratorISCPIFilePath = "";
        public static string PowerMeterConnectString = "";
        public static string PowerMeterSCPIFilePath = "";
        public static string _GeneratorCSWclass = "";
        public static string GeneratorCSWclass 
        {
            get {
                return _GeneratorCSWclass;
            }
            set {

                _GeneratorCSWclass = value;
              GeneratorCConnectString = "192.168.1.227"; }
        }
        public static string _GeneratorISWclass = "";
        public static string GeneratorISWclass
        {
            get
           {
                return _GeneratorISWclass;
            }
            set {
                _GeneratorISWclass = value;
                GeneratorIConnectString = "TCPIP0::192.168.1.190::inst0::INSTR";
            }
        }
        public static string _PowerMeterSWclass = "";
        public static string PowerMeterSWclass
        {
            get {
                return _PowerMeterSWclass;
            }
            set {
                _PowerMeterSWclass = value;
                PowerMeterConnectString = "GPIB0::13::INSTR";
            }
        }
       

    }
    
}
