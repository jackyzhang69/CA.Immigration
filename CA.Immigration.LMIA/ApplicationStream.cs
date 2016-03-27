using System;
using CA.Immigration.Data;
using System.Windows.Forms;

namespace CA.Immigration.LMIA
{
    public partial class ApplicationStream : UserControl
    {
        public ApplicationStream()
        {
            InitializeComponent();
            
           
            lblAnotherEmployer.Visible = false;
            txtAnotherEmployer.Visible = false;
            if (ckbOtherEmployer.Checked == true) { lblAnotherEmployer.Visible = true; txtAnotherEmployer.Visible = true; }
            else ckbOtherEmployer.Checked = false;
        }

        private void ckbOtherEmployer_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbOtherEmployer.Checked) { lblAnotherEmployer.Visible = true; txtAnotherEmployer.Visible = true; }
            else { lblAnotherEmployer.Visible = false; txtAnotherEmployer.Visible = false; }
        }

        private void cmbStream_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbStream.SelectedIndex == 0)
            {
                ckbOtherEmployer.Visible = false;// high wage stream has no second employer
                lblAnotherEmployer.Visible = false;
                txtAnotherEmployer.Visible = false;
            }
            if (cmbStream.SelectedIndex == 1) { ckbOtherEmployer.Visible = true; lblAnotherEmployer.Visible = true; txtAnotherEmployer.Visible = true; }
        }


    }
}
