using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            // set status in status strip : Application Id, employer id, employee id, Program id, maybe RCIC id
            //-- for Analysis table
            // set application program value and disable edit
            if (GlobalData.CurrentApplicationId!=null)
            {
                using (CommonDataContext cdc = new CommonDataContext())
                {

                    GlobalData.CurrentEmployerId = cdc.tblLMIAApplications.Where(x => x.Id == GlobalData.CurrentApplicationId).Select(x => x.EmployerId).Single();
                    GlobalData.CurrentPersonId = cdc.tblLMIAApplications.Where(x => x.Id == GlobalData.CurrentApplicationId).Select(x => x.EmployeeId).Single();
                    GlobalData.CurrentProgramId = cdc.tblLMIAApplications.Where(x => x.Id == GlobalData.CurrentApplicationId).Select(x => x.LMIAType).Single();
                    applicationStream.txtProgram.Text = cdc.tblPrograms.Where(x => x.Id == GlobalData.CurrentProgramId).Select(x => x.Name).Single();
                    applicationStream.txtProgram.ReadOnly = true;
                } 
            }
           
            

        }

        private void LMIAForm_Load(object sender, EventArgs e)
        {

            using (CommonDataContext cdc = new CommonDataContext())
            {
                tblLMIAPosition lp = cdc.tblLMIAPositions.Where(x => x != null && x.ApplicationId == GlobalData.CurrentApplicationId).Select(x => x).Single();
                if (lp != null)
                {
                    jobPositionAdvisor.txtJobTitle.Text = lp.JobTitle;
                    jobPositionAdvisor.txtNoc.Text = lp.NOC;
                    jobPositionAdvisor.cmbProvince.SelectedIndex = (int)lp.Province;
                    jobPositionAdvisor.txtWorkingHours.Text = lp.WorkingHours.ToString();
                    jobPositionAdvisor.txtHourlyRate.Text = lp.HourlyRate.ToString();
                    jobPositionAdvisor.txtProvincialMedian.Text = lp.ProvincialMedian.ToString();
                    jobPositionAdvisor.txtLocalNOCMedian.Text = lp.LocalNOCMedian.ToString();
                    jobPositionAdvisor.txtLocalNocLowest.Text = lp.LocalNOCLowest.ToString();
                    jobPositionAdvisor.txtLocalNocHighest.Text = lp.LocalNOCHighest.ToString();
                    jobPositionAdvisor.txtSameLowest.Text = lp.SamePlaceSamePositionLowest.ToString();
                    jobPositionAdvisor.txtSameHighest.Text = lp.SamePlaceSamePositionHighest.ToString();
                    jobPositionAdvisor.chkNoSame.Checked = lp.NoSamePosition==true?true:false;
                    lmFactorsAnalysis.txtUnemployRate.Text = lp.UmemploymentRate.ToString();
                    lmFactorsAnalysis.txtCOPSRating.Text = lp.COPSRating.ToString();
                    lmFactorsAnalysis.txtOccupationProfile.Text = lp.OccupationProfile.ToString();
                }
            }
                //UCAppStream.lblAnotherEmployer.Visible = false;
                //UCAppStream.txtAnotherEmployer.Visible = false;

         }

        private void btnAnalysisInsert_Click(object sender, EventArgs e)
        {
            // Create a new Application 
            using(CommonDataContext cdc = new CommonDataContext())
            {
                // Validation check

                // Insert data row to Table LMIAApplication
                tblLMIAApplication la = new tblLMIAApplication
                {
                    LMIAType = GlobalData.CurrentProgramId,
                    StreamType = applicationStream.cmbStream.SelectedIndex,
                    EmployerId = GlobalData.CurrentEmployerId,
                    EmployeeId = GlobalData.CurrentPersonId,
                    RCICId = GlobalData.CurrentRCICId,
                    CreatedDate = DateTime.Now,
                    SecondEmployer = (applicationStream.ckbOtherEmployer.Checked == true) ? applicationStream.txtAnotherEmployer.Text : null,

                };
                try
                {
                    cdc.tblLMIAApplications.InsertOnSubmit(la);
                    cdc.SubmitChanges();
                    GlobalData.CurrentApplicationId = la.Id;
                }
                catch(Exception)
                {
                    
                    throw;
                }
                // Create a new record of position with the application Id
                tblLMIAPosition ps = new tblLMIAPosition
                {
                    ApplicationId = GlobalData.CurrentApplicationId,
                    JobTitle = jobPositionAdvisor.txtJobTitle.Text,
                    NOC = jobPositionAdvisor.txtNoc.Text,
                    Province = jobPositionAdvisor.cmbProvince.SelectedIndex,
                    WorkingHours = double.Parse(jobPositionAdvisor.txtWorkingHours.Text),
                    HourlyRate = decimal.Parse(jobPositionAdvisor.txtHourlyRate.Text),
                    ProvincialMedian = decimal.Parse(jobPositionAdvisor.txtProvincialMedian.Text),
                    LocalNOCMedian = decimal.Parse(jobPositionAdvisor.txtLocalNOCMedian.Text),
                    LocalNOCLowest = decimal.Parse(jobPositionAdvisor.txtLocalNocLowest.Text),
                    LocalNOCHighest = decimal.Parse(jobPositionAdvisor.txtLocalNocHighest.Text),
                    SamePlaceSamePositionLowest = decimal.Parse(jobPositionAdvisor.txtSameLowest.Text),
                    SamePlaceSamePositionHighest = decimal.Parse(jobPositionAdvisor.txtSameHighest.Text),
                    NoSamePosition = (jobPositionAdvisor.chkNoSame.Checked == true) ? true : false,
                    UmemploymentRate = float.Parse(lmFactorsAnalysis.txtUnemployRate.Text),
                    COPSRating = int.Parse(lmFactorsAnalysis.txtCOPSRating.Text),
                    OccupationProfile = int.Parse(lmFactorsAnalysis.txtOccupationProfile.Text),
                    EmployerSituation = txtEmployerSituation.Text,
                    EmployerImact = txtSituationImpact.Text
                };
                try
                {
                    cdc.tblLMIAPositions.InsertOnSubmit(ps);
                    cdc.SubmitChanges();
                    btnAnalysisInsert.Visible = false;
                }
                catch(Exception exc)
                {

                    MessageBox.Show(exc.Message);
                }

            }


        }

        private void tabAnalysis_Paint(object sender, PaintEventArgs e)
        {
            if (btnAnalysisInsert.Visible == true)
            {
                selectRCICAdvisor.Visible = false;
                btnEMP5575.Visible = false;
            }
            else {
                selectRCICAdvisor.Visible = true;
                btnEMP5575.Visible = true;
            }

        }

        private void btnEMP5575_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> emp5575 = RepDict.EMP5575((int)GlobalData.CurrentApplicationId);
            FormOPs.fillForm(@"c:\data\emp5575.pdf", emp5575);
        }
    }
}
