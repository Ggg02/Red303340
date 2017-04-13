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
    public partial class GVTConfiguration : DockContent
    {
         public SetPowerMeterMsgBodyDelegate setPowerMeterMsgBodyEvent;
        public SetSGMsgBodyDelegate setSGMsgBodEvent;
        public SetVSGBodyDelegate setVSGMsgBodEvent;
        public GVTConfiguration()
        {
            InitializeComponent();
            CloseButton = false;
            CloseButtonVisible = false;
        }
        public void powerConnect(GVTPowerMeter pmBody)
        {
            if(setPowerMeterMsgBodyEvent != null)
            {
                setPowerMeterMsgBodyEvent(pmBody);
            }
        }
        public void sgConnect(GVTSG sgBody)
        {
            if (setSGMsgBodEvent != null)
            {
                setSGMsgBodEvent(sgBody);
            }
        }
        public void vsgConnect(GVTESG vsgBody,GVTPowerMeter pmBody)
        {
            if (setVSGMsgBodEvent != null)
            {
                setVSGMsgBodEvent(vsgBody, pmBody);
            }
        }
        private void GVTConfiguration_Load(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
            
        }
        public  void treeReload()
        {
            CallRecursive(treeView1);
            Console.WriteLine(GVTCommonConfig.GeneratorCSWclass);
        }
        public void CallRecursive(TreeView treeView)
        {
            // Print each node recursively.
            TreeNodeCollection nodes = treeView.Nodes;
            foreach (TreeNode n in nodes)
            {
                PrintRecursive(n);
            }
        }
        void setTreeNodeValue(TreeNode treeNode)
        {
            switch(treeNode.Tag.ToString())
            {
                case "C1001":
                    treeNode.Text = GVTCommonConfig.GeneratorCSWclass.Length<2 ? treeNode.Text : ("DEVICE:"+GVTCommonConfig.GeneratorCSWclass);
                    break;
                case "C1002":

                    treeNode.Text = GVTCommonConfig.GeneratorCSCPIFilePath.Length < 2 ? treeNode.Text : ("SCPFILE:" + GVTCommonConfig.GeneratorCSCPIFilePath);
                    break;
                case "C1003":
                    treeNode.Text = GVTCommonConfig.GeneratorCConnectString.Length < 2 ? treeNode.Text : ("Connect:" + GVTCommonConfig.GeneratorCConnectString);
                    break;
                case "P1001":
                    treeNode.Text = GVTCommonConfig.PowerMeterSWclass.Length < 2 ? treeNode.Text : ("DEVICE:" + GVTCommonConfig.PowerMeterSWclass);
                    break;
                case "P1002":
                    treeNode.Text = GVTCommonConfig.PowerMeterSCPIFilePath.Length < 2 ? treeNode.Text : ("SCPFILE:" + GVTCommonConfig.PowerMeterSCPIFilePath);
                    break;
                case "P1003":
                    treeNode.Text = GVTCommonConfig.PowerMeterConnectString.Length < 2 ? treeNode.Text : ("Connect:" + GVTCommonConfig.PowerMeterConnectString);
                    break;
                case "I1001":
                    treeNode.Text = GVTCommonConfig.GeneratorISWclass.Length < 2 ? treeNode.Text : ("DEVICE:" + GVTCommonConfig.GeneratorISWclass);
                    break;
                case "I1002":
                    treeNode.Text = GVTCommonConfig.GeneratorISCPIFilePath.Length < 2 ? treeNode.Text : ("SCPFILE:" + GVTCommonConfig.GeneratorISCPIFilePath);
                    break;
                case "I1003":
                    treeNode.Text = GVTCommonConfig.GeneratorIConnectString.Length < 2 ? treeNode.Text : ("Connect:" + GVTCommonConfig.GeneratorIConnectString);
                    break;
                default:
                    break;
            }
        }
        private void PrintRecursive(TreeNode treeNode)
        {
            // Print the node.
            // System.Diagnostics.Debug.WriteLine(treeNode.Tag);
            // MessageBox.Show(treeNode.Text);
            // Print each node recursively.
            setTreeNodeValue(treeNode);
            foreach (TreeNode tn in treeNode.Nodes)
            {

                PrintRecursive(tn);
            }
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string cFileName = "";
            GenCConfiguation newMDIChild = new GenCConfiguation();
            switch (treeView1.SelectedNode.Tag.ToString())
            {
                case "C1001":

                    // Set the Parent Form of the Child window.
                    //newMDIChild.MdiParent = this.Parent;
                    // Display the new form.
                    newMDIChild.comboBox1.Items.Clear();
                    string[] CstrArray = { "ProTelevision", "SFU" };
                    newMDIChild.comboBox1.Items.AddRange(CstrArray);
                    newMDIChild.openBy = (int)SWCLASSNUM.GeneratorC;
                    newMDIChild.ShowDialog();
                    if(newMDIChild.comboBox1.Text.Length >2)
                    {
                        treeReload();
                    }
                    break;
                case "C1002":
                    

                    cFileName = loadFile_click();
                    GVTCommonConfig.GeneratorCSCPIFilePath = cFileName;
                  
                   
                    break;
                case "C1003":
                    gvtConnectStringFrm input = new gvtConnectStringFrm("SG Connect String");
                    DialogResult dr = input.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        GVTCommonConfig.GeneratorCConnectString = input.GetMsg();
                        
                    }

                    break;
                case "P1001":
                    newMDIChild.comboBox1.Items.Clear();
                    string[] PstrArray = { "E4417A", "E4416B" };
                    newMDIChild.openBy = (int)SWCLASSNUM.PowerMeter;
                    newMDIChild.comboBox1.Items.AddRange(PstrArray);
                    newMDIChild.ShowDialog();
                   // MessageBox.Show("P1001");
                    break;
                case "P1002":
                   
                    cFileName = loadFile_click();
                    GVTCommonConfig.PowerMeterSCPIFilePath = cFileName;
                   
                   
                    break;
                case "P1003":
                    gvtConnectStringFrm inputPM = new gvtConnectStringFrm("PowerMeter Connect String");
                    DialogResult PMdr = inputPM.ShowDialog();
                    if (PMdr == DialogResult.OK)
                    {
                        GVTCommonConfig.PowerMeterConnectString = inputPM.GetMsg();
                        
                       // MessageBox.Show(inputPM.GetMsg());
                    }
                    break;
                case "I1001":
                    newMDIChild.comboBox1.Items.Clear();
                    string[] IstrArray = { "M5182", "SMW200" };
                    newMDIChild.openBy = (int)SWCLASSNUM.GeneratorI;
                    newMDIChild.comboBox1.Items.AddRange(IstrArray);
                    newMDIChild.ShowDialog();
                  
                    break;
                case "I1002":
                    cFileName= loadFile_click();
                    GVTCommonConfig.GeneratorISCPIFilePath = cFileName;
                   
                    break;
                case "I1003":
                    gvtConnectStringFrm inputESG = new gvtConnectStringFrm("PowerMeter Connect String");
                    DialogResult ESGdr = inputESG.ShowDialog();
                    if (ESGdr == DialogResult.OK)
                    {
                        GVTCommonConfig.GeneratorIConnectString = ipToConStr(inputESG.GetMsg());
                        
                    }
                    break;
                default:
                    break;
            }
            treeReload();

        }
        string ipToConStr(string ip)
        {
            string retStr = "";
            retStr = "TCPIP0::" + ip + "::inst1::INSTR";
            return retStr;
        }
        string loadFile_click()
        {
            
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select file";
            dialog.InitialDirectory = ".\\";
            dialog.Filter = "xls files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string[] lines = System.IO.File.ReadAllLines(dialog.FileName);
                return dialog.FileName;
            }
            return "";
    }
        private void GVTConfiguration_Activated(object sender, EventArgs e)
        {
          
        }

        private void GVTConfiguration_Deactivate(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(GVTCommonConfig.GeneratorCSWclass);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("please confirm your setting ", "GVT Setting", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                //do something

                GVTCommonConfig.gvtPowerMeter = new GVTPowerMeter();
                GVTCommonConfig.gvtPowerMeter.connecterStr = GVTCommonConfig.PowerMeterConnectString;
                GVTPowerMeter gvtPM = GVTCommonConfig.gvtPowerMeter;
                powerConnect(gvtPM);

                System.Threading.Thread.Sleep(1000);
                GVTCommonConfig.gvtVSG = new GVTESG();
                GVTCommonConfig.gvtVSG.connecterStr = GVTCommonConfig.GeneratorIConnectString;
                GVTESG gvtVSG = GVTCommonConfig.gvtVSG;
                vsgConnect(gvtVSG, gvtPM);

                GVTCommonConfig.gvtSG = new GVTSG();
                GVTCommonConfig.gvtSG.connecterStr = GVTCommonConfig.GeneratorCConnectString;

            }
            else if (dialogResult == DialogResult.Cancel)
            {
                //do something else
            }
        }
    }
}
