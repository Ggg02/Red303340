using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 enum SWCLASSNUM: int
        {
            GeneratorC = 1,
            GeneratorI,
            PowerMeter
        }
namespace Red303340
{
    enum SWCLASSNUM : int
    {
        GeneratorC = 1,
        GeneratorI,
        PowerMeter
    }
    public partial class GenCConfiguation : Form
    {
       
        public int openBy = 0;
        public GenCConfiguation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (openBy)
            {
                case (int)SWCLASSNUM.GeneratorC:
                    GVTCommonConfig.GeneratorCSWclass = comboBox1.Text;
                    break;
                case (int)SWCLASSNUM.GeneratorI:
                    GVTCommonConfig.GeneratorISWclass = comboBox1.Text;
                    break;
                case (int)SWCLASSNUM.PowerMeter:
                    GVTCommonConfig.PowerMeterSWclass = comboBox1.Text;
                    break;
                default:
                    break;
            }
            GVTCommonConfig.GeneratorCSWclass = comboBox1.Text;
           
            this.Close();
        }
    }
}
