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
    public delegate void SetPowerMeterMsgBodyDelegate(GVTPowerMeter pmBody);
    public delegate void SetSGMsgBodyDelegate(GVTSG value);
    public delegate void SetVSGBodyDelegate(GVTESG value,GVTPowerMeter value2);
    public partial class Form1 : Form
    { 
        
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
        
            Form2 newMDIChild = new Form2();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        
    }

        private void CongurationMenuItem_Click(object sender, EventArgs e)
        {
            GVTConfiguration newGVTConfigutationForm = new GVTConfiguration();
            //newGVTConfigutationForm.MdiParent = this;
            // Display the new form.

            newGVTConfigutationForm.Show(dockPanel1, DockState.DockLeft);
        }

        private void sensitivityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sensitivity newSensitivity = new Sensitivity();
            newSensitivity.Show(dockPanel1);
        }

        private void sensityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gvtDocument newDocumenthild = new gvtDocument();
            // Set the Parent Form of the Child window.
            newDocumenthild.MdiParent = this;
            // Display the new form.
            newDocumenthild.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            

            GVTConfiguration newGVTConfigutationForm = new GVTConfiguration();
    
           
            PowerMeterFrm newPowerMeterFrm = new PowerMeterFrm();
          
            SGMasterfrm newSGMasterfrm = new SGMasterfrm();
            VSGFrm newVsgFrm = new VSGFrm();
            // newVsgFrm.Show(dockPanel1, DockState.DockRight);
            newGVTConfigutationForm.setPowerMeterMsgBodyEvent += new SetPowerMeterMsgBodyDelegate(newPowerMeterFrm.setPowerMeterMsgBodyEvent);
            newGVTConfigutationForm.setSGMsgBodEvent += new SetSGMsgBodyDelegate(newSGMasterfrm.SGConnectEvent);
            newGVTConfigutationForm.setVSGMsgBodEvent += new SetVSGBodyDelegate(newVsgFrm.VSGConnectEvent);

            newPowerMeterFrm.Show(dockPanel1, DockState.DockRight);
            newSGMasterfrm.Show(newPowerMeterFrm.Pane, DockAlignment.Bottom, 0.75);
            newGVTConfigutationForm.Show(newSGMasterfrm.Pane, DockAlignment.Bottom, 0.5);
          
            newVsgFrm.Show(newGVTConfigutationForm.Pane, newGVTConfigutationForm);

            //--
            GVTCommonConfig.PowerMeterConnectString = "GPIB0::13::INSTR";
            GVTCommonConfig.GeneratorIConnectString = "TCPIP0::192.168.1.190::inst1::INSTR";
            //--
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void dockPanel1_ActiveContentChanged(object sender, EventArgs e)
        {

        }

        private void adjacentChannelSelectivityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adjacentchannelselectivity newAdjacentchannelselectivity = new Adjacentchannelselectivity();
            newAdjacentchannelselectivity.Show(dockPanel1);
        }

        private void findGPIBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindResrouce newFindResrouceFrm = new FindResrouce();
                newFindResrouceFrm.ShowDialog();
        }

        private void blockingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Blocking newBlocking = new Blocking();
            newBlocking.Show(dockPanel1);
        }

        private void overloadingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Overloading newOverloading = new Overloading();
            newOverloading.Show(dockPanel1);
        }
    }
}
