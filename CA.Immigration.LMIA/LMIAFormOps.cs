using System;
using System.Collections.Generic;
using System.Linq;
using CA.Immigration.Data;
using System.Windows.Forms;
using CA.Immigration.Utility;

namespace CA.Immigration.LMIA
{
    public class LMIAFormOps
    {

        public static void formConstruction(LMIAForm lf)
        {
            lf.lblAnotherEmployer.Visible = false;
            lf.txtAnotherEmployer.Visible = false;
            if(lf.ckbOtherEmployer.Checked == true) { lf.lblAnotherEmployer.Visible = true; lf.txtAnotherEmployer.Visible = true; }
            else lf.ckbOtherEmployer.Checked = false;
            using(CommonDataContext cdc = new CommonDataContext())
            {
                lf.cmbLMIAProgram.DataSource = cdc.tblPrograms.Where(x => x.CategoryId == 1).Select(x => x.Name);
                foreach(KeyValuePair<int, string> kvp in Definition.LMIAStream) lf.cmbStream.Items.Add(kvp.Value);
            }

            // Get data from definition to fill LMIA 11 factors
            foreach(KeyValuePair<int, string> kvp in Definition.LMIA11Factors) lf.ckbLmFactor.Items.Add(kvp.Value);
            // Get data from definition to fill employee benefit
            foreach(KeyValuePair<int, string> kvp in Definition.LMIABenefit) lf.chkJobAdBenefit.Items.Add(kvp.Value);
            // Get data from definition to fill education requirement
            foreach(KeyValuePair<int, string> kvp in Definition.LMIAEduLevel) lf.cmbLMIAEduReq.Items.Add(kvp.Value);
            //Get data from definition to fill Job offer Duration Unit
            foreach(KeyValuePair<int, string> kvp in Definition.DurationUnit) lf.cmbDurationUnit.Items.Add(kvp.Value);
            //set another employer if in low wage stream

            // Media & Job posting
            Media.initialDGVMedia(lf);

            lf.DTPQ8.Format = DateTimePickerFormat.Custom;
            lf.DTPQ8.CustomFormat = "yyyy-MM-dd";
            lf.dtpJobOfferStartDate.Format = DateTimePickerFormat.Custom;
            lf.dtpJobOfferStartDate.CustomFormat = "yyyy-MM-dd";

        }
        public static void formLoadInitialization(LMIAForm lf)
        {
            if(GlobalData.CurrentApplicationId != null)
            {
                GlobalData.CurrentApplicationIdReadOnly = true;
                GlobalData.CurrentEmployerIdReadOnly = true;
                GlobalData.CurrentPersonIdReadOnly = true;
                GlobalData.CurrentRCICIdReadOnly = true;
                using(CommonDataContext cdc = new CommonDataContext())
                {

                    GlobalData.CurrentEmployerId = cdc.tblLMIAApplications.Where(x => x.Id == GlobalData.CurrentApplicationId).Select(x => x.EmployerId).FirstOrDefault();
                    GlobalData.CurrentPersonId = cdc.tblLMIAApplications.Where(x => x.Id == GlobalData.CurrentApplicationId).Select(x => x.EmployeeId).FirstOrDefault();
                    GlobalData.CurrentRCICId = cdc.tblLMIAApplications.Where(x => x.Id == GlobalData.CurrentApplicationId).Select(x => x.RCICId).FirstOrDefault();
                    GlobalData.CurrentProgramId = cdc.tblLMIAApplications.Where(x => x.Id == GlobalData.CurrentApplicationId).Select(x => x.ProgramType).FirstOrDefault();
                    GlobalData.CurrentStreamId = cdc.tblLMIAApplications.Where(x => x.Id == GlobalData.CurrentApplicationId).Select(x => x.StreamType).FirstOrDefault();
                    GlobalData.CurrentWorkingHours = getValue.getDoubleValue(lf.jobPositionAdvisor.txtWorkingHours.Text);
                    // load program and stream info
                    lf.cmbLMIAProgram.SelectedIndex = GlobalData.CurrentProgramId==null? - 1:(int)GlobalData.CurrentProgramId-1;
                    lf.cmbStream.SelectedIndex = GlobalData.CurrentStreamId==null?-1:(int)GlobalData.CurrentStreamId;  // don't minus one, since stream comes from form instead of database

                    //// Get data from definition to fill LMIA 11 factors
                    //foreach(KeyValuePair<int, string> kvp in Definition.LMIA11Factors) lf.ckbLmFactor.Items.Add(kvp.Value);
                    ////Get data from definition to fill Job offer Duration Unit
                    //foreach(KeyValuePair<int, string> kvp in Definition.DurationUnit) lf.cmbDurationUnit.Items.Add(kvp.Value);
                    //set another employer if in low wage stream
                    if(GlobalData.CurrentStreamId == 0) lf.ckbOtherEmployer.Visible = false;
                    if(GlobalData.CurrentStreamId == 1)
                    {
                        lf.ckbOtherEmployer.Visible = true;
                        tblLMIAApplication ap = cdc.tblLMIAApplications.Where(x => x.Id == GlobalData.CurrentApplicationId).Select(x => x).FirstOrDefault();
                        if(ap != null)
                        {
                            lf.ckbOtherEmployer.Checked = true;
                            lf.txtAnotherEmployer.Visible = true;
                            lf.txtAnotherEmployer.Text = ap.SecondEmployer;
                        }
                    }
                }
                LMIAAnalysis.analysisLoadInitialization(lf);
                lf.btnAnalysisInsert.Visible = false;
                // load business details
                LMIABusinessDetail.loadFromDB(lf);
                LMIABusinessDetail.fillForm(lf);
                //load job ad
                JobAd.loadFromDB(lf);
                JobAd.fillForm(lf);
                // Initialize job offer form
                LMIAJobOffer.loadFromDB(lf);
                LMIAJobOffer.fillForm(lf);
                //Setup Media Form
                lf.btnMediaSave.Visible = false;

            }
            else lf.btnAnalysisInsert.Visible = true;
        }
        public static void showMainStatus(LMIAForm lf)
        {
            string emp= GlobalData.CurrentEmployerId.getEmployerFromId();
            string empe = GlobalData.CurrentPersonId == null ? null : ((int)GlobalData.CurrentPersonId).getEmployeeFromId(); 
            string rcic = GlobalData.CurrentRCICId == null ? null : ((int)GlobalData.CurrentRCICId).getRCICFromId();
            string prog=GlobalData.CurrentProgramId == null ? null : ((int)GlobalData.CurrentProgramId).getProgramFromId();
            string strm= GlobalData.CurrentStreamId == null ? null : Definition.LMIAStream[(int)GlobalData.CurrentStreamId]; 
            lf.tssLMIAEmployer.Text = "Employer: " + emp+" | ";
            lf.tssLMIAEmployee.Text = "Employee:" + empe+" | ";
            lf.tssLMIARCIC.Text = "RCIC: " + rcic + " | ";
            lf.tssLMIAProgram.Text = "Program: " + prog + " | ";
            lf.tssLMIAStream.Text = "Stream: " + strm+" | ";
            lf.tssLMIAApplication.Text = "Application Id: " + GlobalData.CurrentApplicationId;
        }




    }
}

