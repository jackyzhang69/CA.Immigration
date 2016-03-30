using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CA.Immigration.Data;
using CA.Immigration.PDF;
using CA.Immigration.Utility;
using System.Diagnostics;

namespace CA.Immigration.LMIA
{
    public partial class LMIAForm : Form
    {
        public bool textChanged = false;
        public LMIAForm()
        {
            InitializeComponent();

            LMIAFormOps.formConstruction(this);
        }

        private void LMIAForm_Load(object sender, EventArgs e)
        {
            LMIAFormOps.formLoadInitialization(this);
            LMIAFormOps.showMainStatus(this);
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
            LMIAFormOps.showMainStatus(this);
            LMIAAnalysis.getIndicators(this);
        }
        private void btnAnalysisInsert_Click(object sender, EventArgs e)
        {
            LMIAAnalysis.insertApplication(this);
            LMIAFormOps.showMainStatus(this);


        }
        private void btnEMP5575_Click(object sender, EventArgs e)
        {
            if(GlobalData.CurrentApplicationId != null)
            {
                //    Dictionary<string, string> emp5575 = RepDict.EMP5575((int)GlobalData.CurrentApplicationId);
                //    FormOPs.fillForm(@"c:\data\emp5575.pdf", emp5575);
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
            // Here delete all application related records
            try
            {
                LMIAJobOffer.deleteRecord(this);
                LMIABusinessDetail.deleteRecord(this);
                LMIAAnalysis.deleteApplication(this);
                MessageBox.Show("Application has been deleted from database. \nHowever, Employer or/and employee Id is still there", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetGlobalData();
                LMIAFormOps.showMainStatus(this);
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void btnInsertBD_Click(object sender, EventArgs e)
        {
            LMIABusinessDetail.getInput(this);
            LMIABusinessDetail.Insert2DB(this);
            LMIAFormOps.showMainStatus(this);
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
            LMIAFormOps.showMainStatus(this);
        }

        private void btnUpdateBD_Click(object sender, EventArgs e)
        {
            if(GlobalData.CurrentApplicationId != null)
            {
                LMIABusinessDetail.getInput(this);
                LMIABusinessDetail.updateRecord((int)GlobalData.CurrentApplicationId);
            }
            else
            {
                MessageBox.Show("There is no active application. Please create on in Analysis");
            }
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
            GlobalData.CurrentProgramId = null;
            GlobalData.CurrentProgramIdReadOnly = false;
            GlobalData.CurrentStreamId = null;
            GlobalData.CurrentStreamIdReadOnly = false;

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
            if(MessageBox.Show("Are you sure to clear all inputs?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) LMIAJobOffer.clearForm(this);
        }

        private void btnJobOfferBenefitDetails_Click(object sender, EventArgs e)
        {
            txtDetails dt = new txtDetails("Please justify why hiring TFW can bring this benefits to Canada", "_detailedBenefit");
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
            txtDetails dt = new txtDetails("Who is currently filling the duties and responsibilities of the position?", "_whoIsFillingDetail");
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

        private void cmbLMIAProgram_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GlobalData.CurrentProgramId = cmbLMIAProgram.SelectedIndex + 1;
            LMIAFormOps.showMainStatus(this);
        }

        private void LMIAForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalData.CurrentApplicationId = null;
            GlobalData.CurrentProgramId = null;
            GlobalData.CurrentStreamId = null;
            GlobalData.CurrentApplicationIdReadOnly = false;
            GlobalData.CurrentEmployerIdReadOnly = false;
            GlobalData.CurrentPersonIdReadOnly = false;
            GlobalData.CurrentRCICIdReadOnly = false;
            GlobalData.CurrentWorkingHours = null;
            Media.mediaIndex.Clear();
        }

        private void LMIAForm_TextChanged(object sender, EventArgs e)
        {
            textChanged = true;
        }

        private void btnJobAdSave_Click(object sender, EventArgs e)
        {
            if(GlobalData.CurrentApplicationId != null)
            {
                JobAd.SaveRecord(this);
            }
            else { MessageBox.Show("There is no active application yet. Please create in Analysis"); }
        }

        private void cmbLMIAEduReq_SelectionChangeCommitted(object sender, EventArgs e)
        {
            JobAd._education = cmbLMIAEduReq.SelectedIndex;
        }

        private void btnJobAdClear_Click(object sender, EventArgs e)
        {
            JobAd.clearForm(this);
            JobAd.fillForm(this);
        }

        private void btnJobAdPreview_Click(object sender, EventArgs e)
        {
            JobAd.generatePreview(this);
        }

        private void dgvMedia_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            btnMediaSave.Visible = true;
            // update media data
        }

        private void dgvMedia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // do something
        }

        private void btnGoForPosting_Click(object sender, EventArgs e)
        {
            List<int> checkedIndecies = new List<int>();
            for(int i = 0; i < dgvMedia.Rows.Count; i++)
            {
                if(Convert.ToBoolean(dgvMedia.Rows[i].Cells[0].Value)) checkedIndecies.Add(i);
            }
            Media.SetJobPosting(this, checkedIndecies);
        }

        private void btnUmemploymentRate_Click(object sender, EventArgs e)
        {
            String url = "http://www.esdc.gc.ca/en/foreign_workers/hire/service_tables.page";
            Process.Start(url);
        }

        private void btnCOPSRate_Click(object sender, EventArgs e)
        {
            String url = "http://occupations.esdc.gc.ca/sppc-cops/w.2lc.4m.2@-eng.jsp";
            Process.Start(url);
        }

        private void btnOccupationProfile_Click(object sender, EventArgs e)
        {

            String url = "http://www.esdc.gc.ca/en/jobs/opportunities/index.page";
            switch(jobPositionAdvisor.cmbProvince.SelectedIndex)
            {
                case 1: //BC
                    url = "https://www.workbc.ca/Jobs-Careers/Explore-Careers/Browse-Career-Profile/" + jobPositionAdvisor.txtNoc.Text + "#section-outlook";
                    break;
                default:
                    break;
            }
            Process.Start(url);
        }

        private void btnNocSave_Click(object sender, EventArgs e)
        {
            using(CommonDataContext cdc = new CommonDataContext())
            {
                tblNOC noc = cdc.tblNOCs.Where(x => x.NOC.Equals(jobPositionAdvisor.txtNoc.Text)).FirstOrDefault();
                if(noc == null)  //insert
                {
                    tblNOC n = new tblNOC
                    {
                        NOC = jobPositionAdvisor.txtNoc.Text,
                        MainDuties = txtNOCMainDuties.Text,
                        EmploymentRequirement = txtESDCQualification.Text
                    };
                    cdc.tblNOCs.InsertOnSubmit(n);
                }
                else  //update
                {
                    noc.MainDuties = txtNOCMainDuties.Text;
                    noc.EmploymentRequirement = txtESDCQualification.Text;
                }
                try
                {
                    cdc.SubmitChanges();
                    MessageBox.Show("Main duties and qualification have been saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}

