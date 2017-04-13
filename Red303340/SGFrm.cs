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
    public partial class VSGFrm : DockContent
    {
        GVTESG gvtVSGBody;
        GVTPowerMeter gvtPMBody;
        bool RF = false;
        bool MOD = false;
        bool ARB = false;
        public VSGFrm()
        {
            InitializeComponent();
            CloseButton = false;
            CloseButtonVisible = false;
        }

        private void VSGFrm_Load(object sender, EventArgs e)
        {

        }
        public void VSGConnectEvent(GVTESG vsgBody , GVTPowerMeter pmBody)
        {
            gvtVSGBody = vsgBody;
            gvtPMBody = pmBody;
            btnConnect.BackColor = Color.Green;
            updateVar();
            MessageBox.Show("VSG connect Pass");
          //  timerVSGSync.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gvtVSGBody.connect();
            //MessageBox.Show(gvtVSGBody.connecterStr);
            //LBCurrentDB.Text = gvtVSGBody.getCurrentDB();
        }
        public void updateBtn()
        {
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (RF) {
                gvtVSGBody.setRF(false);
                    RF = false;
                BtnRF.BackColor = Color.Red;
            }
            else {
                gvtVSGBody.setRF(true);
                RF = true;
                BtnRF.BackColor = Color.Green;
            }
            
        }

        private void timerVSGSync_Tick(object sender, EventArgs e)
        {
            LBCurrentDB.Text = gvtVSGBody.getCurrentDB();
            LBFreq.Text = gvtVSGBody.getFREQ();
        }
        private void setDB(string DB)
        {
            gvtVSGBody.setCurrentDB(DB);
            LBCurrentDB.Text = DB;
            updateVar();
        }
        private void setDB(double DB)
        {

            gvtVSGBody.setCurrentDB(DB.ToString());
            updateVar();
        }
        private void LBCurrentDB_Click(object sender, EventArgs e)
        {
            setDBFrm input = new setDBFrm("VSG Current DB", LBCurrentDB.Text,GVTCommonConfig.GVTDiagForDB);
            DialogResult dr = input.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string setValueStr = input.GetMsg();
                gvtVSGBody.setCurrentDB(setValueStr);
                updateVar();
            }
        }
        public void updateVar()
        {
          
            double currentDB = 0;
            
            currentDB = getDB();
            //currentDB = double.Parse(gvtVSGBody.getCurrentDB().Substring(0, 5)) * 10;
            LBCurrentDB.Text = currentDB.ToString();
            LBFreq.Text = gvtVSGBody.getFREQ();
            LBcurrentFile.Text = getCurrentFile();
        }
        private string getCurrentFile()
        {
            return gvtVSGBody.getCurrentFile();
        }
        private void LBFreq_Click(object sender, EventArgs e)
        {
            setDBFrm input = new setDBFrm("VSG Current Frequency", LBFreq.Text, GVTCommonConfig.GVTDiagForFreq);
            DialogResult dr = input.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string setValueStr = input.GetMsg();
                double setValue = 0;
                setValue = double.Parse(setValueStr);
                setValue = setValue * 1000000;
                gvtVSGBody.setFREQ(setValue.ToString());
                updateVar();
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (MOD)
            {
                gvtVSGBody.setMod(false);
                MOD = false;
                btnMod.BackColor = Color.Red;

            }
            else
            {
                gvtVSGBody.setMod(true);
                MOD = true;
                btnMod.BackColor = Color.Green;
            }
        }

        private void BtnARB_Click(object sender, EventArgs e)
        {
            if (ARB)
            {
                gvtVSGBody.setARB(false);
                ARB = false;
                btnARB.BackColor = Color.Red;

            }
            else
            {
                gvtVSGBody.setARB(true);
                ARB = true;
                btnARB.BackColor = Color.Green;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string fileList = "";
           /// fileList=gvtVSGBody.getWMList();
           frmSelectWM input = new frmSelectWM();
            DialogResult dr = input.ShowDialog();
            if (dr == DialogResult.OK)
            {
                //string cmdStr = ":SOURce: RADio: ARB: WAVeform "+ "\"WFM1:" + "123" + "\"";
                gvtVSGBody.selectWFM(input.GetMsg());
                updateVar();
            }
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {

            //getCurrentDB , if(x-y >3) ,c = X-y,x - c;
            syncDbOffset();
        }
        private void syncDbOffset()
        {
           
            double fixDb = double.Parse(txtFixDB.Text);
            double sgDB = getDB();
            double pmDB = getPMDB();
            double c = 0;
       
            //setDB(txtFixDB.Text);
            sgDB = getDB();
            
            if((c=sgDB-pmDB) > 3)
            {
               
                    pmDB = getPMDB();
                    sgDB = getDB();
                    c = fixDb - pmDB;
                    if (c < 0.1)
                        return;
                    double newDB = sgDB + c;
                    GVTCommonConfig.offsetVSGreducePM = c;
                    if(newDB <5)
                    setDB(newDB);
                      
            }
        }
        private double getPMDB()
        {
            GVTPowerMeter gvtPM = GVTCommonConfig.gvtPowerMeter;
            return double.Parse(gvtPM.getCurrentDB());
        }
        private double getDB()
        {
            double db = 0;
            string strDB = (gvtVSGBody.getCurrentDB()).Substring(0,6);
            db = double.Parse(strDB);
            if (double.Parse(strDB[1].ToString()) < 4)
                db = db * 10;
            
          
            return db;
        }
    }
}
