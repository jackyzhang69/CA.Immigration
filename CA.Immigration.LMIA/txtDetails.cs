using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CA.Immigration.Utility;

namespace CA.Immigration.LMIA
{
    public partial class txtDetails : Form
    {
        string _source;
        string _question;
        private bool _txtChanged;
        public txtDetails(string question, string source)
        {
            InitializeComponent();
            _source = source;
            _question = question;
        }


        private void btnTxtDetailsSave_Click(object sender, EventArgs e)
        {
            if (LMIAJobOffer.detailDict.ContainsKey(_source)) LMIAJobOffer.detailDict[_source] = txtTxtDetails.Text;
            else LMIAJobOffer.detailDict.Add(_source, txtTxtDetails.Text);

            btnTxtDetailsSave.Visible = false;
            _txtChanged = false;
        }

        private void txtDetails_Load(object sender, EventArgs e)
        {
            if(LMIAJobOffer.detailDict.ContainsKey(_source)) txtTxtDetails.Text = LMIAJobOffer.detailDict[_source];
            lblTopic.Text = _question;
            btnTxtDetailsSave.Visible = false;
            _txtChanged = false;
        }

        private void txtTxtDetails_TextChanged(object sender, EventArgs e)
        {
            btnTxtDetailsSave.Visible = true;
            _txtChanged = true;
        }

        private void btnTxtDetailsClose_Click(object sender, EventArgs e)
        {
            if(_txtChanged == false) this.Close();
            else if (MessageBox.Show("You haven't save your data. Do you really want to close without saving?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) this.Close();
        }
    }
}
