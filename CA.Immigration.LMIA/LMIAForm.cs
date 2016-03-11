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

namespace CA.Immigration.LMIA
{
    public partial class LMIAForm : Form
    {
        int _employerId;
        int _employeeId;

        public LMIAForm()
        {
            InitializeComponent();
        }
        public LMIAForm(int employerId, int employeeId, int streamId)
        {
            InitializeComponent();
            _employerId = employerId;
            _employeeId = employeeId;

            GlobalData.CurrentEmployerId = employerId;
            GlobalData.CurrentPersonId = employeeId;


            // set status in status strip : Application Id, employer id, employee id, Program id, maybe RCIC id
            //-- for Analysis table
            // set application program value and disable edit
            using(CommonDataContext cdc = new CommonDataContext())
            {
                applicationStream.txtProgram.Text = cdc.tblPrograms.Where(x => x.Id == streamId).Select(x => x.Name).Single();
                applicationStream.txtProgram.ReadOnly = true;
            }




            // initial province data



        }

        private void LMIAForm_Load(object sender, EventArgs e)
        {

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
                    LMIAType = GlobalData.CurrentApplicationId,
                    StreamType = applicationStream.cmbStream.SelectedIndex,
                    EmployerId = GlobalData.CurrentEmployerId,
                    EmployeeId = GlobalData.CurrentPersonId,
                    RCICId = GlobalData.RCICId,
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
                    JobTitle = jobPosition1.txtJobTitle.Text,
                    NOC = jobPosition1.txtNoc.Text,
                    Province = jobPosition1.cmbProvince.SelectedText,
                    WorkingHours = double.Parse(jobPosition1.txtWorkingHours.Text),
                    HourlyRate = decimal.Parse(jobPosition1.txtHourlyRate.Text),
                    ProvincialMedian = decimal.Parse(jobPosition1.txtProvincialMedian.Text),
                    LocalNOCMedian = decimal.Parse(jobPosition1.txtLocalNOCMedian.Text),
                    LocalNOCLowest = decimal.Parse(jobPosition1.txtLocalNocLowest.Text),
                    LocalNOCHighest = decimal.Parse(jobPosition1.txtLocalNocHighest.Text),
                    SamePlaceSamePositionLowest = decimal.Parse(jobPosition1.txtSameLowest.Text),
                    SamePlaceSamePositionHighest = decimal.Parse(jobPosition1.txtSameHighest.Text),
                    NoSamePosition = (jobPosition1.chkNoSame.Checked == true) ? true : false,
                    UmemploymentRate = float.Parse(lmFactors1.txtUnemployRate.Text),
                    COPSRating = int.Parse(lmFactors1.txtCOPSRating.Text),
                    OccupationProfile = int.Parse(lmFactors1.txtOccupationProfile.Text),
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
    }
}
