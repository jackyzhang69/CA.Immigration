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

            // set status in status strip : Application Id, employer id, employee id, Program id, maybe RCIC id
            //-- for Analysis table
            // set application program value and disable edit
            if (GlobalData.CurrentApplicationId != null)
            {
                using (CommonDataContext cdc = new CommonDataContext())
                {

                    GlobalData.CurrentEmployerId = cdc.tblLMIAApplications.Where(x => x.Id == GlobalData.CurrentApplicationId).Select(x => x.EmployerId).FirstOrDefault();
                    GlobalData.CurrentPersonId = cdc.tblLMIAApplications.Where(x => x.Id == GlobalData.CurrentApplicationId).Select(x => x.EmployeeId).FirstOrDefault();
                    GlobalData.CurrentProgramId = cdc.tblLMIAApplications.Where(x => x.Id == GlobalData.CurrentApplicationId).Select(x => x.LMIAType).FirstOrDefault();
                    applicationStream.txtProgram.Text = cdc.tblPrograms.Where(x => x.Id == GlobalData.CurrentProgramId).Select(x => x.Name).FirstOrDefault();
                    applicationStream.txtProgram.ReadOnly = true;
                    // Load stream info
                    GlobalData.CurrentStreamId = cdc.tblLMIAApplications.Where(x => x.Id == GlobalData.CurrentApplicationId).Select(x => x.StreamType).FirstOrDefault();
                    applicationStream.cmbStream.SelectedIndex = (int)GlobalData.CurrentStreamId;
                    // Get data from definition to fill LMIA 11 factors
                    for (int i = 0; i < Definition.LMIA11Factors.Length / 2; i++)
                    {
                        ckbLmFactor.Items.Add(Definition.LMIA11Factors[i, 1]);
                    }
                    //set another employer if in low wage stream
                    if (GlobalData.CurrentStreamId == 0) applicationStream.ckbOtherEmployer.Visible = false;
                    if (GlobalData.CurrentStreamId == 1)
                    {
                        applicationStream.ckbOtherEmployer.Visible = true;
                        tblLMIAApplication ap = cdc.tblLMIAApplications.Where(x => x.Id == GlobalData.CurrentApplicationId).Select(x => x).FirstOrDefault();
                        if (ap != null)
                        {
                            applicationStream.ckbOtherEmployer.Checked = true;
                            applicationStream.txtAnotherEmployer.Visible = true;
                            applicationStream.txtAnotherEmployer.Text = ap.SecondEmployer;
                        }
                    }
                }
                GlobalData.CurrentApplicationIdReadOnly = true;
                GlobalData.CurrentEmployerIdReadOnly = true;
                GlobalData.CurrentPersonIdReadOnly = true;
                GlobalData.CurrentProgramIdReadOnly = true;


            }



        }

        private void LMIAForm_Load(object sender, EventArgs e)
        {

            using (CommonDataContext cdc = new CommonDataContext())
            {
                // load position record
                tblLMIAPosition lp = cdc.tblLMIAPositions.Where(x => x != null && x.ApplicationId == GlobalData.CurrentApplicationId).Select(x => x).FirstOrDefault();
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
                    jobPositionAdvisor.chkNoSame.Checked = lp.NoSamePosition == true ? true : false;
                    txtUnemployRate.Text = lp.UmemploymentRate.ToString();
                    txtCOPSRating.Text = lp.COPSRating.ToString();
                    txtOccupationProfile.Text = lp.OccupationProfile.ToString();
                }
                // load financial record
                List<tblFinance> finance = cdc.tblFinances.Where(x => x != null && x.ApplicationId == GlobalData.CurrentApplicationId).Select(x => x).ToList();

                if (finance.Count >= 1)
                {
                    financialAdvisor.txtLast1Year.Text = finance[0].FiscalYear.ToString();
                    financialAdvisor.txtRevenue1.Text = finance[0].TotalRevenue.ToString();
                    financialAdvisor.txtCash1.Text = finance[0].Cash.ToString();
                    financialAdvisor.txtNetImcome1.Text = finance[0].NetIncome.ToString();
                    financialAdvisor.txtRetainedEarning1.Text = finance[0].RetainedEarning.ToString();
                    financialAdvisor.txtGrossPayroll1.Text = finance[0].GrossPayroll.ToString();
                    financialAdvisor.txtSlips1.Text = finance[0].T4SlipsIssued.ToString();

                }
                if (finance.Count == 2)
                {
                    financialAdvisor.txtLast2Year.Text = finance[1].FiscalYear.ToString();
                    financialAdvisor.txtRevenue2.Text = finance[1].TotalRevenue.ToString();
                    financialAdvisor.txtCash2.Text = finance[1].Cash.ToString();
                    financialAdvisor.txtNetImcome2.Text = finance[1].NetIncome.ToString();
                    financialAdvisor.txtRetainedEarning2.Text = finance[1].RetainedEarning.ToString();
                    financialAdvisor.txtGrossPayroll2.Text = finance[1].GrossPayroll.ToString();
                    financialAdvisor.txtSlips2.Text = finance[1].T4SlipsIssued.ToString();
                }
                tblLMIA11Factor factors = cdc.tblLMIA11Factors.Where(x => x != null && x.ApplicationId == GlobalData.CurrentApplicationId).Select(x => x).FirstOrDefault();
                if (factors != null)
                {
                    ckbLmFactor.SetItemChecked(0, factors.JobCreation == true ? true : false);
                    ckbLmFactor.SetItemChecked(1, factors.SkillTransfer == true ? true : false);
                    ckbLmFactor.SetItemChecked(2, factors.FillLabourShortage == true ? true : false);
                    ckbLmFactor.SetItemChecked(3, factors.PrevailingWageOffered == true ? true : false);
                    ckbLmFactor.SetItemChecked(4, factors.HireCanadianEffort == true ? true : false);
                    ckbLmFactor.SetItemChecked(5, factors.LabourDisputUnaffected == true ? true : false);
                    ckbLmFactor.SetItemChecked(6, factors.CommitmentFulfilled == true ? true : false);
                    ckbLmFactor.SetItemChecked(7, factors.BusinessEngagement == true ? true : false);
                    ckbLmFactor.SetItemChecked(8, factors.OfferConsistentwithDemand == true ? true : false);
                    ckbLmFactor.SetItemChecked(9, factors.AbletoFulfillTermofOffer == true ? true : false);
                    ckbLmFactor.SetItemChecked(10, factors.PastCompliance == true ? true : false);
                }

                //load reasonable employment need from business detail database
                tblBusinessDetail bd = cdc.tblBusinessDetails.Where(x => x.ApplicationId == GlobalData.CurrentApplicationId).Select(x => x).FirstOrDefault();
                if (bd != null)
                {
                    txtEmployerSituation.Text = bd.EmployerSituation;
                    txtSituationImpact.Text = bd.SituationImpact;
                }

            }
            // get average wage based on data loaded from database
            financialAdvisor.txtAverageWage1.Text = financialAdvisor.getAverage(financialAdvisor.txtGrossPayroll1.Text, financialAdvisor.txtSlips1.Text);
            financialAdvisor.txtAverageWage2.Text = financialAdvisor.getAverage(financialAdvisor.txtGrossPayroll2.Text, financialAdvisor.txtSlips2.Text);
            // set up and display qualification indicator
            dgvQualificationIndicator.Rows.Add(5);
            getIndicators();


        }

        private void btnAnalysisInsert_Click(object sender, EventArgs e)
        {
            // Create a new Application 
            using (CommonDataContext cdc = new CommonDataContext())
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
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
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
                    UmemploymentRate = float.Parse(txtUnemployRate.Text),
                    COPSRating = int.Parse(txtCOPSRating.Text),
                    OccupationProfile = int.Parse(txtOccupationProfile.Text),
                    EmployerSituation = txtEmployerSituation.Text,
                    EmployerImact = txtSituationImpact.Text
                };
                try
                {
                    cdc.tblLMIAPositions.InsertOnSubmit(ps);
                    cdc.SubmitChanges();
                }
                catch (Exception exc)
                {

                    MessageBox.Show(exc.Message);
                }
                //create a new record of financial analysis with application id
                tblFinance fn1 = new tblFinance
                {
                    ApplicationId = GlobalData.CurrentApplicationId,
                    FiscalYear = Validation.IsIntInRange(financialAdvisor.txtLast1Year.Text, 2000, 2050) ? int.Parse(financialAdvisor.txtLast1Year.Text) : (int?)null,
                    TotalRevenue = Validation.IsFloat(financialAdvisor.txtRevenue1.Text) ? decimal.Parse(financialAdvisor.txtRevenue1.Text) : (decimal?)null,
                    Cash = Validation.IsFloat(financialAdvisor.txtCash1.Text) ? decimal.Parse(financialAdvisor.txtCash1.Text) : (decimal?)null,
                    NetIncome = Validation.IsFloat(financialAdvisor.txtNetImcome1.Text) ? decimal.Parse(financialAdvisor.txtNetImcome1.Text) : (decimal?)null,
                    RetainedEarning = Validation.IsFloat(financialAdvisor.txtRetainedEarning1.Text) ? decimal.Parse(financialAdvisor.txtRetainedEarning1.Text) : (decimal?)null,
                    GrossPayroll = Validation.IsFloat(financialAdvisor.txtGrossPayroll1.Text) ? decimal.Parse(financialAdvisor.txtGrossPayroll1.Text) : (decimal?)null,
                    T4SlipsIssued = Validation.IsInt(financialAdvisor.txtSlips1.Text) ? int.Parse(financialAdvisor.txtSlips1.Text) : (int?)null
                };
                tblFinance fn2 = new tblFinance
                {
                    ApplicationId = GlobalData.CurrentApplicationId,
                    FiscalYear = Validation.IsIntInRange(financialAdvisor.txtLast2Year.Text, 2000, 2050) ? int.Parse(financialAdvisor.txtLast2Year.Text) : (int?)null,
                    TotalRevenue = Validation.IsFloat(financialAdvisor.txtRevenue2.Text) ? decimal.Parse(financialAdvisor.txtRevenue2.Text) : (decimal?)null,
                    Cash = Validation.IsFloat(financialAdvisor.txtCash2.Text) ? decimal.Parse(financialAdvisor.txtCash2.Text) : (decimal?)null,
                    NetIncome = Validation.IsFloat(financialAdvisor.txtNetImcome2.Text) ? decimal.Parse(financialAdvisor.txtNetImcome2.Text) : (decimal?)null,
                    RetainedEarning = Validation.IsFloat(financialAdvisor.txtRetainedEarning2.Text) ? decimal.Parse(financialAdvisor.txtRetainedEarning2.Text) : (decimal?)null,
                    GrossPayroll = Validation.IsFloat(financialAdvisor.txtGrossPayroll2.Text) ? decimal.Parse(financialAdvisor.txtGrossPayroll2.Text) : (decimal?)null,
                    T4SlipsIssued = Validation.IsInt(financialAdvisor.txtSlips2.Text) ? int.Parse(financialAdvisor.txtSlips2.Text) : (int?)null
                };
                try
                {
                    cdc.tblFinances.InsertOnSubmit(fn1);
                    cdc.tblFinances.InsertOnSubmit(fn2);
                    cdc.SubmitChanges();
                }
                catch (Exception exc)
                {

                    MessageBox.Show(exc.Message);
                }
                // create a new record of 11 factors
                foreach (int indexchecked in ckbLmFactor.CheckedIndices)
                {
                    Definition.LMIA11Factors[indexchecked, 0] = "1";

                }
                tblLMIA11Factor factor = new tblLMIA11Factor
                {
                    ApplicationId = GlobalData.CurrentApplicationId,
                    JobCreation = Definition.LMIA11Factors[0, 0] == "1" ? true : false,
                    SkillTransfer = Definition.LMIA11Factors[1, 0] == "1" ? true : false,
                    FillLabourShortage = Definition.LMIA11Factors[2, 0] == "1" ? true : false,
                    PrevailingWageOffered = Definition.LMIA11Factors[3, 0] == "1" ? true : false,
                    HireCanadianEffort = Definition.LMIA11Factors[4, 0] == "1" ? true : false,
                    LabourDisputUnaffected = Definition.LMIA11Factors[5, 0] == "1" ? true : false,
                    CommitmentFulfilled = Definition.LMIA11Factors[6, 0] == "1" ? true : false,
                    BusinessEngagement = Definition.LMIA11Factors[7, 0] == "1" ? true : false,
                    OfferConsistentwithDemand = Definition.LMIA11Factors[8, 0] == "1" ? true : false,
                    AbletoFulfillTermofOffer = Definition.LMIA11Factors[9, 0] == "1" ? true : false,
                    PastCompliance = Definition.LMIA11Factors[10, 0] == "1" ? true : false

                };
                try
                {
                    cdc.tblLMIA11Factors.InsertOnSubmit(factor);
                    cdc.SubmitChanges();
                }
                catch (Exception exc)
                {

                    MessageBox.Show(exc.Message);
                }
                // Create a new record of business details: only for employer situation and situation impact
                tblBusinessDetail bd = new tblBusinessDetail
                {
                    ApplicationId = GlobalData.CurrentApplicationId,
                    EmployerSituation = txtEmployerSituation.Text,
                    SituationImpact = txtSituationImpact.Text
                };
                try
                {
                    cdc.tblBusinessDetails.InsertOnSubmit(bd);
                    cdc.SubmitChanges();
                    btnAnalysisInsert.Visible = false;
                    btnInsertBD.Visible = false; // Tab Business details use the same table with employer situation and impact
                }
                catch (Exception exc)
                {

                    MessageBox.Show(exc.Message);
                }



            }


        }


        private void btnEMP5575_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> emp5575 = RepDict.EMP5575((int)GlobalData.CurrentApplicationId);
            FormOPs.fillForm(@"c:\data\emp5575.pdf", emp5575);
        }

        private void jobPositionAdvisor_Leave(object sender, EventArgs e)
        {
            getIndicators();
        }
        private void financialAdvisor_Leave(object sender, EventArgs e)
        {
            getIndicators();
        }
        private void lmFactorsAnalysis_Leave(object sender, EventArgs e)
        {
            getIndicators();
        }


        public void getIndicators()
        {

            float wage, provincialmedian, localnocmedian, lowestsameposition, highestsameposition;
            wage = (jobPositionAdvisor.txtHourlyRate.Text != null && jobPositionAdvisor.txtHourlyRate.Text != string.Empty) ? float.Parse(jobPositionAdvisor.txtHourlyRate.Text) : 0f;
            provincialmedian = (jobPositionAdvisor.txtProvincialMedian.Text != null && jobPositionAdvisor.txtProvincialMedian.Text != string.Empty) ? float.Parse(jobPositionAdvisor.txtProvincialMedian.Text) : 0f;
            localnocmedian = (jobPositionAdvisor.txtLocalNOCMedian.Text != null && jobPositionAdvisor.txtLocalNOCMedian.Text != string.Empty) ? float.Parse(jobPositionAdvisor.txtLocalNOCMedian.Text) : 0f;
            lowestsameposition = (jobPositionAdvisor.txtSameLowest.Text != null && jobPositionAdvisor.txtSameLowest.Text != string.Empty) ? float.Parse(jobPositionAdvisor.txtSameLowest.Text) : 0f;
            highestsameposition = (jobPositionAdvisor.txtSameHighest.Text != null && jobPositionAdvisor.txtSameHighest.Text != string.Empty) ? float.Parse(jobPositionAdvisor.txtSameHighest.Text) : 0f;



            switch (applicationStream.cmbStream.SelectedIndex)
            {


                case 0: // High wage stream
                        // 1. Check if the position wage bigger than provincial median wage
                    if (wage != 0f && provincialmedian != 0)
                    {
                        dgvQualificationIndicator.Rows[0].Cells[0].Value = (wage >= provincialmedian) ? "Wage >= Provincial Median " : "Wage < Provincial Median ";
                        dgvQualificationIndicator.Rows[0].Cells[1].Value = (wage >= provincialmedian) ? "Eligible" : "Ineligible";
                        dgvQualificationIndicator.Rows[0].DefaultCellStyle.ForeColor = (wage >= provincialmedian) ? Color.Green : Color.Red;

                    }
                    else {
                        dgvQualificationIndicator.Rows[0].Cells[0].Value = "No comparing data yet";
                        dgvQualificationIndicator.Rows[0].Cells[1].Value = "N/A";
                    }
                    //2. Check if the position wage bigger than local NOC median wage
                    if (wage != 0f && localnocmedian != 0)
                    {
                        dgvQualificationIndicator.Rows[1].Cells[0].Value = (wage >= localnocmedian) ? "Wage >= Local NOC Median " : "Wage < Local NOC Median ";
                        dgvQualificationIndicator.Rows[1].Cells[1].Value = (wage >= localnocmedian) ? "Eligible" : "Ineligible";
                        dgvQualificationIndicator.Rows[1].DefaultCellStyle.ForeColor = (wage >= localnocmedian) ? Color.Green : Color.Red;

                    }
                    else {
                        dgvQualificationIndicator.Rows[1].Cells[0].Value = "No comparing data yet";
                        dgvQualificationIndicator.Rows[1].Cells[1].Value = "N/A";
                    }
                    //3. check if the position wage between same place same position wage range
                    if (wage != 0 && lowestsameposition != 0 && highestsameposition != 0)
                    {
                        dgvQualificationIndicator.Rows[2].Cells[0].Value = (wage >= lowestsameposition && wage <= highestsameposition) ? "Wage in same position range " : "Wage not in same position range ";
                        dgvQualificationIndicator.Rows[2].Cells[1].Value = (wage >= lowestsameposition && wage <= highestsameposition) ? "Eligible" : "Ineligible";
                        dgvQualificationIndicator.Rows[2].DefaultCellStyle.ForeColor = (wage >= lowestsameposition && wage <= highestsameposition) ? Color.Green : Color.Red;
                    }
                    else
                    {
                        dgvQualificationIndicator.Rows[2].Cells[0].Value = "No comparing data yet";
                        dgvQualificationIndicator.Rows[2].Cells[1].Value = "N/A";
                    }
                    //4. Check if the position wage reasonable comparing to T4 summary (total paid divides by total pay slips)
                    if (wage != 0 && financialAdvisor.txtAverageWage1.Text != string.Empty && Validation.IsFloat(financialAdvisor.txtAverageWage1.Text) && jobPositionAdvisor.txtWorkingHours.Text != string.Empty && Validation.IsFloat(jobPositionAdvisor.txtWorkingHours.Text))
                    {
                        float average1 = float.Parse(jobPositionAdvisor.txtWorkingHours.Text);
                        float annualwage = wage * average1 * 365 / 7;
                        dgvQualificationIndicator.Rows[3].Cells[0].Value = (annualwage >= average1) ? "Annual age >=Company Average" : "Annual age < Company Average ";
                        dgvQualificationIndicator.Rows[3].Cells[1].Value = (annualwage >= average1) ? "Perfect" : "Reasonable?";
                        dgvQualificationIndicator.Rows[3].DefaultCellStyle.ForeColor = (wage >= lowestsameposition && wage <= highestsameposition) ? Color.Green : Color.Red;
                    }
                    else
                    {
                        dgvQualificationIndicator.Rows[3].Cells[0].Value = "No comparing data yet";
                        dgvQualificationIndicator.Rows[3].Cells[1].Value = "N/A";
                    }
                    if (txtCOPSRating.Text != string.Empty && Validation.IsInt(txtCOPSRating.Text))
                    {
                        switch (int.Parse(txtCOPSRating.Text))
                        {
                            case 1:
                                dgvQualificationIndicator.Rows[4].Cells[0].Value = "Labor market outlook is poor";
                                dgvQualificationIndicator.Rows[4].Cells[1].Value = "Be careful";
                                dgvQualificationIndicator.Rows[4].DefaultCellStyle.ForeColor = Color.Red;
                                break;
                            case 2:
                                dgvQualificationIndicator.Rows[4].Cells[0].Value = "Labor market outlook is moderate";
                                dgvQualificationIndicator.Rows[4].Cells[1].Value = "Ok";
                                dgvQualificationIndicator.Rows[4].DefaultCellStyle.ForeColor = Color.Blue;
                                break;
                            case 3:
                                dgvQualificationIndicator.Rows[4].Cells[0].Value = "Labor market outlook is positive";
                                dgvQualificationIndicator.Rows[4].Cells[1].Value = "Go";
                                dgvQualificationIndicator.Rows[4].DefaultCellStyle.ForeColor = Color.Green;
                                break;
                            default:
                                break;
                        }
                    }

                    break;
                case 1:
                    break;
            }
        }

        private void tabAnalysis_Layout(object sender, LayoutEventArgs e)
        {
            getIndicators();
        }

        private void btnAnalysisUpdate_Click(object sender, EventArgs e)
        {

        }

        private void applicationStream_Leave(object sender, EventArgs e)
        {
            getIndicators();
        }

        private void btnAnalysisDelete_Click(object sender, EventArgs e)
        {
            // delete application record and its Dependant job position, finance, Labour market factors, and business details record at same time
            using (CommonDataContext cdc = new CommonDataContext())
            {
                //1. delete application
                tblLMIAApplication la = cdc.tblLMIAApplications.Where(x => x.Id == GlobalData.CurrentApplicationId).Select(x => x).FirstOrDefault();
                cdc.tblLMIAApplications.DeleteOnSubmit(la);
                //2. delete job position
                tblLMIAPosition lp = cdc.tblLMIAPositions.Where(x => x.ApplicationId == GlobalData.CurrentApplicationId).Select(x => x).FirstOrDefault();
                if (lp != null) cdc.tblLMIAPositions.DeleteOnSubmit(lp);
                //3. delete finance 
                tblFinance finance = cdc.tblFinances.Where(x => x.ApplicationId == GlobalData.CurrentApplicationId).Select(x => x).FirstOrDefault();
                if (finance != null) cdc.tblFinances.DeleteOnSubmit(finance);
                //4. delete Labour market factors
                tblLMIA11Factor lmf = cdc.tblLMIA11Factors.Where(x => x.ApplicationId == GlobalData.CurrentApplicationId).Select(x => x).FirstOrDefault();
                if (lmf != null) cdc.tblLMIA11Factors.DeleteOnSubmit(lmf);
                //5. delete business details
                tblBusinessDetail bd = cdc.tblBusinessDetails.Where(x => x.ApplicationId == GlobalData.CurrentApplicationId).Select(x => x).FirstOrDefault();
                if (bd != null) cdc.tblBusinessDetails.DeleteOnSubmit(bd);
                
                if (MessageBox.Show("This operation will delete the current application and all its dependencies. Are you sure to delete it?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        cdc.SubmitChanges();
                        GlobalData.CurrentApplicationId = null;
                        GlobalData.CurrentApplicationIdReadOnly = false;
                        MessageBox.Show("The current application and its Dependant job position, finance, Labour market factors, and business details record has been deleted");
                    }
                    catch (Exception exc)
                    {

                        MessageBox.Show(exc.Message);
                    }
                }
            }
        }
    }
}

