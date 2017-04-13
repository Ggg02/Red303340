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
    public partial class gvtConnectStringFrm : Form
    {
        private string Msg;
        public gvtConnectStringFrm()
        {
            InitializeComponent();
        }
        public gvtConnectStringFrm(string Title)
        {
            InitializeComponent();
            this.Text = Title;
        }
        public string GetMsg()
        {
            return Msg;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Msg = textBox1.Text.ToString();
        }

        private void gvtConnectStringFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
