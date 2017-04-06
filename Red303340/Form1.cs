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
    public partial class Form1 : Form
    {
        GVTConfiguration newGVTConfigutationForm = new GVTConfiguration();
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
           // GVTConfiguration newGVTConfigutationForm = new GVTConfiguration();
            newGVTConfigutationForm.MdiParent = this;
            // Display the new form.
            newGVTConfigutationForm.Show();
        }
    }
}
