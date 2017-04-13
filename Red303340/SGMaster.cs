using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Red303340
{
    public partial class SGMasterfrm : DockContent
    {
        GVTSG gvtSGbody;
        public SGMasterfrm()
        {
            InitializeComponent();
            CloseButton = false;
            CloseButtonVisible = false;
        }

        private void SGMasterfrm_Load(object sender, EventArgs e)
        {

        }
        public void SGConnectEvent(GVTSG sgBody)
        {
            gvtSGbody = sgBody;
            MessageBox.Show("hello");

        }
    }
}
