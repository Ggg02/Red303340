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
    public partial class Sensitivity : DockContent
    {
        bool dataGridView1init = false;
        public Sensitivity()
        {
            InitializeComponent();
        }

        private void Sensitivity_Load(object sender, EventArgs e)
        {
            dataGridInit();
        }
        void dataGridInit()
        {
            string[] ac1string = { "T_AC1", "T_AC2", "T2_AC1", "T2_AC2" };

            foreach (string s in ac1string)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = s;
                dataGridView1.Rows.Add(row);
            }
            DataGridViewRow row2 = (DataGridViewRow)dataGridView2.Rows[0].Clone();
            row2.CreateCells(dataGridView2, "", "DVB-T", "DVB-T2", "DVB-T", "DVB-T2");
            dataGridView2.Rows.Add(row2);
            DataGridViewRow row3 = (DataGridViewRow)dataGridView2.Rows[0].Clone();
            row3.CreateCells(dataGridView2, "VHF", "-77", "-75");

            dataGridView2.Rows.Add(row3);
            DataGridViewRow row4 = (DataGridViewRow)dataGridView2.Rows[0].Clone();
            row4.CreateCells(dataGridView2, "UHF", "-77", "-75");
            dataGridView2.Rows.Add(row4);
            dataGridView1init = true;
        }
    }
}
