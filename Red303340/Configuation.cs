using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Red303340
{
    public partial class GenCConfiguation : Form
    {
        public GenCConfiguation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GVTCommonConfig.GeneratorCSWclass = comboBox1.Text;
           
            this.Close();
        }
    }
}
