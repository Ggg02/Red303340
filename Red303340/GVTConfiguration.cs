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
    public partial class GVTConfiguration : Form
    {
        public GVTConfiguration()
        {
            InitializeComponent();
        }

        private void GVTConfiguration_Load(object sender, EventArgs e)
        {
            
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
            switch (treeView1.SelectedNode.Tag.ToString())
            {
                case "C1001":
                    GenCConfiguation newMDIChild = new GenCConfiguation();
                    // Set the Parent Form of the Child window.
                    //newMDIChild.MdiParent = this.Parent;
                    // Display the new form.
                    newMDIChild.ShowDialog();
                    if(newMDIChild.comboBox1.Text.Length >2)
                    {
                        treeReload();
                    }
                    break;
                case "C1002":
                    loadFile_click();
                    MessageBox.Show("C1002");
                    break;
                case "C1003":

                    break;
                case "P1001":
                    MessageBox.Show("P1001");
                    break;
                case "P1002":
                    loadFile_click();
                    MessageBox.Show("P1002");
                    break;
                case "P1003":
                    break;
                case "I1001":
                    MessageBox.Show("I1001");
                    break;
                case "I1002":
                    loadFile_click();
                    MessageBox.Show("I1002");
                    break;
                case "I1003":
                    break;
                default:
                    break;
            }


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
    }
}
