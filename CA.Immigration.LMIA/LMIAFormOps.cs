using System;
using System.Collections.Generic;
using System.Linq;
using CA.Immigration.Data;
using System.Windows.Forms;
using CA.Immigration.PDF;

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

            // set status in status strip : Application Id, employer id, employee id, Program id, maybe RCIC id
            //-- for Analysis table
            // set application program value and disable edit
            if (GlobalData.CurrentApplicationId != null)
            {
                using (CommonDataContext cdc = new CommonDataContext())
                {

                    GlobalData.CurrentEmployerId = cdc.tblLMIAApplications.Where(x => x.Id == GlobalData.CurrentApplicationId).Select(x => x.EmployerId).FirstOrDefault();
                    GlobalData.CurrentPersonId = cdc.tblLMIAApplications.Where(x => x.Id == GlobalData.CurrentApplicationId).Select(x => x.EmployeeId).FirstOrDefault();
                    GlobalData.CurrentRCICId = cdc.tblLMIAApplications.Where(x => x.Id == GlobalData.CurrentApplicationId).Select(x => x.RCICId).FirstOrDefault();
                    GlobalData.CurrentProgramId = cdc.tblLMIAApplications.Where(x => x.Id == GlobalData.CurrentApplicationId).Select(x => x.LMIAType).FirstOrDefault();
                    lf.txtProgram.Text = cdc.tblPrograms.Where(x => x.Id == GlobalData.CurrentProgramId).Select(x => x.Name).FirstOrDefault();
                    lf.txtProgram.ReadOnly = true;

                    // Load stream info
                    GlobalData.CurrentStreamId = cdc.tblLMIAApplications.Where(x => x.Id == GlobalData.CurrentApplicationId).Select(x => x.StreamType).FirstOrDefault();
                    lf.cmbStream.SelectedIndex = (int)GlobalData.CurrentStreamId;
                    // Get data from definition to fill LMIA 11 factors
                    for (int i = 0; i < Definition.LMIA11Factors.Length / 2; i++)
                    {
                        lf.ckbLmFactor.Items.Add(Definition.LMIA11Factors[i, 1]);
                    }
                    //set another employer if in low wage stream
                    if (GlobalData.CurrentStreamId == 0) lf.ckbOtherEmployer.Visible = false;
                    if (GlobalData.CurrentStreamId == 1)
                    {
                        lf.ckbOtherEmployer.Visible = true;
                        tblLMIAApplication ap = cdc.tblLMIAApplications.Where(x => x.Id == GlobalData.CurrentApplicationId).Select(x => x).FirstOrDefault();
                        if (ap != null)
                        {
                            lf.ckbOtherEmployer.Checked = true;
                            lf.txtAnotherEmployer.Visible = true;
                            lf.txtAnotherEmployer.Text = ap.SecondEmployer;
                        }
                    }
                }
                GlobalData.CurrentApplicationIdReadOnly = true;
                GlobalData.CurrentEmployerIdReadOnly = true;
                GlobalData.CurrentPersonIdReadOnly = true;
                GlobalData.CurrentProgramIdReadOnly = true;
            }
            else {

                using (CommonDataContext cdc=new CommonDataContext())
                {
                    lf.txtProgram.Text = cdc.tblPrograms.Where(x => x.Id == GlobalData.CurrentProgramId).Select(x => x.Name).FirstOrDefault();
                    lf.txtProgram.ReadOnly = true; 
                }
            }
           
            lf.DTPQ8.Format = DateTimePickerFormat.Custom;
            lf.DTPQ8.CustomFormat = "yyyy-MM-dd";
            lf.dtpJobOfferStartDate.Format = DateTimePickerFormat.Custom;
            lf.dtpJobOfferStartDate.CustomFormat = "yyyy-MM-dd";

        }
        public static void formLoadInitialization(LMIAForm lf)
        {
            if(GlobalData.CurrentApplicationId != null)
            {
                LMIAAnalysis.analysisLoadInitialization(lf);
                lf.btnAnalysisInsert.Visible = false;
                if(GlobalData.CurrentBusinessDetailId != null)
                {
                    lf.btnInsertBD.Visible = false;
                    //Load Business details data
                    LMIABusinessDetail.loadFromDB(lf);
                    LMIABusinessDetail.fillForm(lf);
                }
                else lf.btnInsertBD.Visible = true;
                // Initialize job offer form
                LMIAJobOffer.loadFromDB(lf);
                LMIAJobOffer.fillForm(lf);
            }
            else {
                lf.btnAnalysisInsert.Visible = true;
                if(GlobalData.CurrentBusinessDetailId != null) lf.btnInsertBD.Visible = false;
                else lf.btnInsertBD.Visible = true;
            }
        }
       

    }
}

