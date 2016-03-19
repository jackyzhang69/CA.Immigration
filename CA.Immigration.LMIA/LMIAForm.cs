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
using CA.Immigration.Utility;

namespace CA.Immigration.LMIA
{
    public partial class LMIAForm : Form
    {
        public LMIAForm()
        {
            InitializeComponent();
            using(CommonDataContext cdc = new CommonDataContext())
            {
                txtProgram.Text = cdc.tblPrograms.Where(x => x.Id == GlobalData.CurrentProgramId).Select(x => x.Name).FirstOrDefault();
                txtProgram.ReadOnly = true;
            }
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
            if(ckbOtherEmployer.Checked) { lblAnotherEmployer.Visible = true; txtAnotherEmployer.Visible = true; }
            else { lblAnotherEmployer.Visible = false; txtAnotherEmployer.Visible = false; }
        }
        private void cmbStream_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(cmbStream.SelectedIndex == 0)
            {
                ckbOtherEmployer.Visible = false;// high wage stream has no second employer
                lblAnotherEmployer.Visible = false;
                txtAnotherEmployer.Visible = false;
            }
            if(cmbStream.SelectedIndex == 1) { ckbOtherEmployer.Visible = true; }
            GlobalData.CurrentStreamId = cmbStream.SelectedIndex;
            LMIAAnalysis.getIndicators(this);
        }
        private void btnAnalysisInsert_Click(object sender, EventArgs e)
        {
            LMIAAnalysis.insertApplication(this);


        }
        private void btnEMP5575_Click(object sender, EventArgs e)
        {
            if(GlobalData.CurrentApplicationId != null)
            {
                Dictionary<string, string> emp5575 = RepDict.EMP5575((int)GlobalData.CurrentApplicationId);
                FormOPs.fillForm(@"c:\data\emp5575.pdf", emp5575);
            }
            else MessageBox.Show("There is no current application existed");
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
            LMIAAnalysis.updateApplication(this);

        }
        private void btnAnalysisDelete_Click(object sender, EventArgs e)
        {
            LMIAAnalysis.deleteApplication(this);
            MessageBox.Show("Application has been deleted from database. \nHowever, Employer or/and employee Id is still there", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            resetGlobalData();

        }


        private void btnInsertBD_Click(object sender, EventArgs e)
        {
            LMIABusinessDetail.getInput(this);
            LMIABusinessDetail.Insert2DB(this);
        }

        private void tabBusinessDetails_Layout(object sender, LayoutEventArgs e)
        {
            if(GlobalData.CurrentApplicationId != null)
            {
                LMIABusinessDetail.loadFromDB(this);
                LMIABusinessDetail.fillForm(this);
            }

        }

        private void btnDeleteBD_Click(object sender, EventArgs e)
        {
            LMIABusinessDetail.deleteRecord(this);
            LMIABusinessDetail.clearForm(this);
        }

        private void btnUpdateBD_Click(object sender, EventArgs e)
        {
            LMIABusinessDetail.getInput(this);
            LMIABusinessDetail.updateRecord((int)GlobalData.CurrentApplicationId);
        }
        private void btnNewBD_Click(object sender, EventArgs e)
        {
            LMIABusinessDetail.clearForm(this);
        }  // consider it?!

        private void btnAnalysisNew_Click(object sender, EventArgs e)
        {
            LMIAAnalysis.clearForm(this);
        }
        private void resetGlobalData()
        {
            GlobalData.CurrentApplicationId = null;
            GlobalData.CurrentApplicationIdReadOnly = false;

        }

        private void btnJobOfferSave_Click(object sender, EventArgs e)
        {
            LMIAJobOffer.SaveRecord(this);
        }

        private void btnJobOfferDelete_Click(object sender, EventArgs e)
        {
            LMIAJobOffer.deleteRecord(this);
        }

        private void btnJobOfferClear_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure to clear all inputs?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes) LMIAJobOffer.clearForm(this);
        }

        private void btnJobOfferBenefitDetails_Click(object sender, EventArgs e)
        {
            txtDetails dt = new txtDetails("Please justify why hiring TFW can bring this benifits to Canada", "_detailedBenefit");
            dt.Show();
        }

        private void btnJobOfferRationale_Click(object sender, EventArgs e)
        {
            txtDetails dt = new txtDetails("The rational providing this job to the TFW", "_detailedRationaleOfferingJob");
            dt.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtDetails dt = new txtDetails("Please explain your training plan for Canadians", "_trainPlanDetails");
            dt.Show();
        }

        private void btnJobOfferWhoFillInTheJob_Click(object sender, EventArgs e)
        {
            txtDetails dt = new txtDetails("Who is currently filling the duties and responsibilities of the positio?", "_whoIsFillingDetail");
            dt.Show();
        }

        private void btnJobOfferHowDidYouFind_Click(object sender, EventArgs e)
        {
            txtDetails dt = new txtDetails("How did you find or identify the foreign worker for this position?", "_howDidYouFindDetail");
            dt.Show();
        }

        private void btnJobOfferHowtoDetermine_Click(object sender, EventArgs e)
        {
            txtDetails dt = new txtDetails("How did you determine the foreign worker was qualified for the job?", "_howDidYouDetermineDetail");
            dt.Show();
        }

        private void btnJobOfferWhentoOffer_Click(object sender, EventArgs e)
        {
            txtDetails dt = new txtDetails("How and when did you offer this job to the foreign worker?", "_howAndWhenOfferDetail");
            dt.Show();
        }
    }
}

