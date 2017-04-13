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
    public partial class frmSelectWM : Form
    {
        private string Msg;
        string filelist = "";
        string[] files;
        public frmSelectWM()
        {
            InitializeComponent();
            listFilebox.Items.Add("1-ETSI_Short.wfm");
            listFilebox.Items.Add("2-ETSI_Short.wfm");
            listFilebox.Items.Add("3-ETSI_Short.wfm");
        }
        public frmSelectWM(string filelistStr)
        {
            InitializeComponent();
            filelist = filelistStr;
            files = filelistParseToFiles(filelistStr);
            addArrayToList(files);
        }
        public void addArrayToList(string[] files)
        {
            foreach(string s in files)
            {
                listFilebox.Items.Add(s);
            }
           
        }
        public string[] filelistParseToFiles(string filelistStr)
        {
            string[] files;
            files = filelistStr.Split(',');
            return files;
        }
        private void frmSelectWM_Load(object sender, EventArgs e)
        {
            
        }
        public string GetMsg()
        {
            return Msg;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string retStr = "";
            retStr = listFilebox.SelectedItem.ToString();
            if (retStr.Length < 10)
                return;
            Msg = retStr;
        }
    }
}
