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
    public partial class setDBFrm : Form
    {
        int diagType = 0;
        private string Msg;
        string[] strHint = {"NULL", "New  Level : ", "New Frequency :" };
        public setDBFrm()
        {
            InitializeComponent();
        }
        public setDBFrm(string Title,string currentValue , int  valueType)
        {
            InitializeComponent();
            this.Text = Title;
            LBCurrent.Text = currentValue;
            this.diagType = valueType;
            LBHint.Text = strHint[this.diagType];
        }

        private void setDBFrm_Load(object sender, EventArgs e)
        {

        }
        public string GetMsg()
        {
            return Msg;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Msg = textBox1.Text.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
