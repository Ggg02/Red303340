using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Red303340
{
    public class GVTMsg
    {
        private static GVTMsg instance;

        private GVTMsg() { }
        public static GVTMsg Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GVTMsg();
                }
                return instance;
            }
        }
    }
}
