using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using CA.Immigration.Utility;
using System.Windows.Forms;
using CA.Immigration.Data;
using CA.Immigration.PDF;

namespace CA.Immigration.LMIA
{
    public partial class LMIAForm : Form
    {
        public LMIAForm()
        {
            InitializeComponent();
        }
        public LMIAForm(int applicationid)
        {
            InitializeComponent();
            LMIAFormOps.formConstruction(this);
            
        }
        private void LMIAForm_Load(object sender, EventArgs e)
        {
            LMIAFormOps.formLoadInitialization(this);
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
            if (cmbStream.SelectedIndex == 1) { ckbOtherEmployer.Visible = true; }
            GlobalData.CurrentStreamId = cmbStream.SelectedIndex;
            LMIAAnalysis.getIndicators(this);
        }
        private void btnAnalysisInsert_Click(object sender, EventArgs e)
        {
            LMIAAnalysis.insertApplication(this);


        }
        private void btnEMP5575_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> emp5575 = RepDict.EMP5575((int)GlobalData.CurrentApplicationId);
            FormOPs.fillForm(@"c:\data\emp5575.pdf", emp5575);
        }
        private void jobPositionAdvisor_Leave(object sender, EventArgs e)
        {
            LMIAAnalysis.getIndicators(this);
        }
        private void financialAdvisor_Leave(object sender, EventArgs e)
        {
            LMIAAnalysis.getIndicators(this);
        }
        private void lmFactorsAnalysis_Leave(object sender, EventArgs e)
        {
            LMIAAnalysis.getIndicators(this);
        }
        
        private void tabAnalysis_Layout(object sender, LayoutEventArgs e)
        {
            LMIAAnalysis.getIndicators(this);
        }

        private void btnAnalysisUpdate_Click(object sender, EventArgs e)
        {
            LMIAAnalysis.UpdateApplication(this);

        }
        private void btnAnalysisDelete_Click(object sender, EventArgs e)
        {
            LMIAAnalysis.deleteApplication();
        }
        private void btnNewBD_Click(object sender, EventArgs e)
        {
            LMIABusinessDetail.clearForm(this);
        }  // consider it?!

        private void btnInsertBD_Click(object sender, EventArgs e)
        {
            LMIABusinessDetail.getInput(this);
            LMIABusinessDetail.Insert2DB((int)GlobalData.CurrentApplicationId, this);
        }

        private void tabBusinessDetails_Layout(object sender, LayoutEventArgs e)
        {
            LMIABusinessDetail.loadFromDB((int)GlobalData.CurrentApplicationId,this);
            LMIABusinessDetail.paintForm(this);

        }

        private void btnDeleteBD_Click(object sender, EventArgs e)
        {
            LMIABusinessDetail.deleteRecord((int)GlobalData.CurrentApplicationId);
        }

        private void btnUpdateBD_Click(object sender, EventArgs e)
        {
            LMIABusinessDetail.updateRecord((int)GlobalData.CurrentApplicationId);
        }
    }
}

