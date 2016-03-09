using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CA.Immigration.LMIA
{
    public partial class JobPosition : UserControl
    {
        public JobPosition()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNoSame.Checked == true)
            {
                lblSameLowest.Visible = false;
                txtSameLowest.Visible = false;
                lblSameHighest.Visible = false;
                txtSameHighest.Visible = false;
            }
            else {
                lblSameLowest.Visible = true;
                txtSameLowest.Visible = true;
                lblSameHighest.Visible = true;
                txtSameHighest.Visible = true;
            }
        }

        private void btnTop100_Click(object sender, EventArgs e)
        {
            Top100 t1 = new Top100();
            t1.Show();
        }

        private void grbPosition_Paint(object sender, PaintEventArgs e)
        {
            txtNoc.Text = GlobalData.CurrentNOC;
        }

        private void btnJobBank_Click(object sender, EventArgs e)
        {
            String url = "http://www.jobbank.gc.ca/show-search-results.do?reportOption=wage&titleKeyword=" + txtNoc.Text + "&searchJobTitle=Search";
            Process.Start(url);
        }

        private void btnCheckNOC_Click(object sender, EventArgs e)
        {
            String url = "http://www5.hrsdc.gc.ca/NOC/English/NOC/2011/QuickSearch.aspx?val65=" + txtJobTitle.Text + "&searchJobTitle=Search";
            Process.Start(url);
        }
    }
}
