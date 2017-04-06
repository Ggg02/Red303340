using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Red303340
{
   
   public class GVTCommonConfig
    {
        public const string GVTKEY = "GVT";
        public static string[] testEnv = { "DVBT_7M", "DVBT_8M", "DVBT2_7M", "DVBT2_8M" };
        public static string GeneratorCConnectString = "";
        public static string GeneratorIConnectString = "";
        public static string GeneratorCSCPIFilePath = "";
        public static string GeneratorISCPIFilePath = "";
        public static string PowerMeterConnectString = "";
        public static string PowerMeterSCPIFilePath = "";
        public static string GeneratorCSWclass = "";
        public static string GeneratorISWclass = "";
        public static string PowerMeterSWclass = "";
    }
    
}
