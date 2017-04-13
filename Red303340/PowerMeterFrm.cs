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
    public partial class PowerMeterFrm : DockContent
    {
        GVTPowerMeter _gvtPmBody;
        GVTPowerMeter gvtPmBody
        {
            get
            {
                return _gvtPmBody;
            }
            set
            {
                _gvtPmBody = value;
                timerPowCach.Enabled = true;
                button1.BackColor = Color.Green;
            }
        }
        public PowerMeterFrm()
        {
            InitializeComponent();
            CloseButton = false;
            CloseButtonVisible = false;
        }
        public void powerMetterConnectEvent(GVTPowerMeter pmBody)
        {
            gvtPmBody = pmBody;
            MessageBox.Show("hello");

        }
        private void PowerMeterFrm_Load(object sender, EventArgs e)
        {

        }
        public void setPowerMeterMsgBodyEvent(GVTPowerMeter pmBody)
        {
            gvtPmBody = pmBody;
            if (gvtPmBody.connecterStr.Length < 2)
            {
                timerPowCach.Enabled = false;
                
            }
            MessageBox.Show("power connect pass");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(gvtPmBody.connecterStr);
        }

        private void timerPowCach_Tick(object sender, EventArgs e)
        {
            if (gvtPmBody == null) return;
            
            LBCurrentDB.Text = gvtPmBody.getCurrentDB();
        }
    }
}
