using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA.Immigration.LMIA
{
    public partial class ApplicationStream : UserControl
    {
        public ApplicationStream()
        {
            InitializeComponent();
            ckbOtherEmployer.Checked = false;
            lblAnotherEmployer.Visible = false;
            txtAnotherEmployer.Visible = false;
        }

        private void ckbOtherEmployer_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbOtherEmployer.Checked) { lblAnotherEmployer.Visible = true; txtAnotherEmployer.Visible = true; }
            else { lblAnotherEmployer.Visible = false; txtAnotherEmployer.Visible = false; }
        }
    }
}
