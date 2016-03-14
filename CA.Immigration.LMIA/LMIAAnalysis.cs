using System;
using System.Collections.Generic;
using System.Linq;
using CA.Immigration.Data;
using System.Drawing;
using CA.Immigration.Utility;
using System.Windows.Forms;

namespace CA.Immigration.LMIA
{
    public class LMIAAnalysis
    {
        public static void analysisLoadInitialization(LMIAForm lf)
        {
            //Load Tab Analysis data
            using(CommonDataContext cdc = new CommonDataContext())
            {
                // load position record
                tblLMIAPosition lp = cdc.tblLMIAPositions.Where(x => x != null && x.ApplicationId == GlobalData.CurrentApplicationId).Select(x => x).FirstOrDefault();
                if(lp != null)
                {
                    lf.jobPositionAdvisor.txtJobTitle.Text = lp.JobTitle;
                    lf.jobPositionAdvisor.txtNoc.Text = lp.NOC;
                    lf.jobPositionAdvisor.cmbProvince.SelectedIndex = (int)lp.Province;
                    lf.jobPositionAdvisor.txtWorkingHours.Text = lp.WorkingHours.ToString();
                    lf.jobPositionAdvisor.txtHourlyRate.Text = lp.HourlyRate.ToString();
                    lf.jobPositionAdvisor.txtProvincialMedian.Text = lp.ProvincialMedian.ToString();
                    lf.jobPositionAdvisor.txtLocalNOCMedian.Text = lp.LocalNOCMedian.ToString();
                    lf.jobPositionAdvisor.txtLocalNocLowest.Text = lp.LocalNOCLowest.ToString();
                    lf.jobPositionAdvisor.txtLocalNocHighest.Text = lp.LocalNOCHighest.ToString();
                    lf.jobPositionAdvisor.txtSameLowest.Text = lp.SamePlaceSamePositionLowest.ToString();
                    lf.jobPositionAdvisor.txtSameHighest.Text = lp.SamePlaceSamePositionHighest.ToString();
                    lf.jobPositionAdvisor.chkNoSame.Checked = lp.NoSamePosition == true ? true : false;
                    lf.txtUnemployRate.Text = lp.UmemploymentRate.ToString();
                    lf.txtCOPSRating.Text = lp.COPSRating.ToString();
                    lf.txtOccupationProfile.Text = lp.OccupationProfile.ToString();
                    lf.txtEmployerSituation.Text = lp.EmployerSituation;
                    lf.txtSituationImpact.Text = lp.EmployerImact;
                    lf.btnAnalysisInsert.Visible = false;  // Application existed, disable insert
                }
                // load financial record
                List<tblFinance> finance = cdc.tblFinances.Where(x => x != null && x.ApplicationId == GlobalData.CurrentApplicationId).Select(x => x).ToList();

                if(finance.Count >= 1)
                {
                    lf.financialAdvisor.txtLast1Year.Text = finance[0].FiscalYear.ToString();
                    lf.financialAdvisor.txtRevenue1.Text = finance[0].TotalRevenue.ToString();
                    lf.financialAdvisor.txtCash1.Text = finance[0].Cash.ToString();
                    lf.financialAdvisor.txtNetImcome1.Text = finance[0].NetIncome.ToString();
                    lf.financialAdvisor.txtRetainedEarning1.Text = finance[0].RetainedEarning.ToString();
                    lf.financialAdvisor.txtGrossPayroll1.Text = finance[0].GrossPayroll.ToString();
                    lf.financialAdvisor.txtSlips1.Text = finance[0].T4SlipsIssued.ToString();

                }
                if(finance.Count == 2)
                {
                    lf.financialAdvisor.txtLast2Year.Text = finance[1].FiscalYear.ToString();
                    lf.financialAdvisor.txtRevenue2.Text = finance[1].TotalRevenue.ToString();
                    lf.financialAdvisor.txtCash2.Text = finance[1].Cash.ToString();
                    lf.financialAdvisor.txtNetImcome2.Text = finance[1].NetIncome.ToString();
                    lf.financialAdvisor.txtRetainedEarning2.Text = finance[1].RetainedEarning.ToString();
                    lf.financialAdvisor.txtGrossPayroll2.Text = finance[1].GrossPayroll.ToString();
                    lf.financialAdvisor.txtSlips2.Text = finance[1].T4SlipsIssued.ToString();
                }
                tblLMIA11Factor factors = cdc.tblLMIA11Factors.Where(x => x != null && x.ApplicationId == GlobalData.CurrentApplicationId).Select(x => x).FirstOrDefault();
                if(factors != null)
                {
                    lf.ckbLmFactor.SetItemChecked(0, factors.JobCreation == true ? true : false);
                    lf.ckbLmFactor.SetItemChecked(1, factors.SkillTransfer == true ? true : false);
                    lf.ckbLmFactor.SetItemChecked(2, factors.FillLabourShortage == true ? true : false);
                    lf.ckbLmFactor.SetItemChecked(3, factors.PrevailingWageOffered == true ? true : false);
                    lf.ckbLmFactor.SetItemChecked(4, factors.HireCanadianEffort == true ? true : false);
                    lf.ckbLmFactor.SetItemChecked(5, factors.LabourDisputUnaffected == true ? true : false);
                    lf.ckbLmFactor.SetItemChecked(6, factors.CommitmentFulfilled == true ? true : false);
                    lf.ckbLmFactor.SetItemChecked(7, factors.BusinessEngagement == true ? true : false);
                    lf.ckbLmFactor.SetItemChecked(8, factors.OfferConsistentwithDemand == true ? true : false);
                    lf.ckbLmFactor.SetItemChecked(9, factors.AbletoFulfillTermofOffer == true ? true : false);
                    lf.ckbLmFactor.SetItemChecked(10, factors.PastCompliance == true ? true : false);
                }


            }
            // get average wage based on data loaded from database
            lf.financialAdvisor.txtAverageWage1.Text = lf.financialAdvisor.getAverage(lf.financialAdvisor.txtGrossPayroll1.Text, lf.financialAdvisor.txtSlips1.Text);
            lf.financialAdvisor.txtAverageWage2.Text = lf.financialAdvisor.getAverage(lf.financialAdvisor.txtGrossPayroll2.Text, lf.financialAdvisor.txtSlips2.Text);
            // set up and display qualification indicator
            lf.dgvQualificationIndicator.Rows.Add(5);
            getIndicators(lf);
        }
        public static void getIndicators(LMIAForm lf)
        {

            float wage, provincialmedian, localnocmedian, lowestsameposition, highestsameposition;
            wage = (lf.jobPositionAdvisor.txtHourlyRate.Text != null && lf.jobPositionAdvisor.txtHourlyRate.Text != string.Empty) ? float.Parse(lf.jobPositionAdvisor.txtHourlyRate.Text) : 0f;
            provincialmedian = (lf.jobPositionAdvisor.txtProvincialMedian.Text != null && lf.jobPositionAdvisor.txtProvincialMedian.Text != string.Empty) ? float.Parse(lf.jobPositionAdvisor.txtProvincialMedian.Text) : 0f;
            localnocmedian = (lf.jobPositionAdvisor.txtLocalNOCMedian.Text != null && lf.jobPositionAdvisor.txtLocalNOCMedian.Text != string.Empty) ? float.Parse(lf.jobPositionAdvisor.txtLocalNOCMedian.Text) : 0f;
            lowestsameposition = (lf.jobPositionAdvisor.txtSameLowest.Text != null && lf.jobPositionAdvisor.txtSameLowest.Text != string.Empty) ? float.Parse(lf.jobPositionAdvisor.txtSameLowest.Text) : 0f;
            highestsameposition = (lf.jobPositionAdvisor.txtSameHighest.Text != null && lf.jobPositionAdvisor.txtSameHighest.Text != string.Empty) ? float.Parse(lf.jobPositionAdvisor.txtSameHighest.Text) : 0f;



            switch(GlobalData.CurrentStreamId)
            {


                case 0: // High wage stream
                        // 1. Check if the position wage bigger than provincial median wage
                    if(wage != 0f && provincialmedian != 0)
                    {
                        lf.dgvQualificationIndicator.Rows[0].Cells[0].Value = (wage >= provincialmedian) ? "Wage >= Provincial Median " : "Wage < Provincial Median ";
                        lf.dgvQualificationIndicator.Rows[0].Cells[1].Value = (wage >= provincialmedian) ? "Eligible" : "Ineligible";
                        lf.dgvQualificationIndicator.Rows[0].DefaultCellStyle.ForeColor = (wage >= provincialmedian) ? Color.Green : Color.Red;

                    }
                    else {
                        lf.dgvQualificationIndicator.Rows[0].Cells[0].Value = "No comparing data yet";
                        lf.dgvQualificationIndicator.Rows[0].Cells[1].Value = "N/A";
                    }
                    //2. Check if the position wage bigger than local NOC median wage
                    if(wage != 0f && localnocmedian != 0)
                    {
                        lf.dgvQualificationIndicator.Rows[1].Cells[0].Value = (wage >= localnocmedian) ? "Wage >= Local NOC Median " : "Wage < Local NOC Median ";
                        lf.dgvQualificationIndicator.Rows[1].Cells[1].Value = (wage >= localnocmedian) ? "Eligible" : "Ineligible";
                        lf.dgvQualificationIndicator.Rows[1].DefaultCellStyle.ForeColor = (wage >= localnocmedian) ? Color.Green : Color.Red;

                    }
                    else {
                        lf.dgvQualificationIndicator.Rows[1].Cells[0].Value = "No comparing data yet";
                        lf.dgvQualificationIndicator.Rows[1].Cells[1].Value = "N/A";
                    }
                    //3. check if the position wage between same place same position wage range
                    if(wage != 0 && lowestsameposition != 0 && highestsameposition != 0)
                    {
                        lf.dgvQualificationIndicator.Rows[2].Cells[0].Value = (wage >= lowestsameposition && wage <= highestsameposition) ? "Wage in same position range " : "Wage not in same position range ";
                        lf.dgvQualificationIndicator.Rows[2].Cells[1].Value = (wage >= lowestsameposition && wage <= highestsameposition) ? "Eligible" : "Ineligible";
                        lf.dgvQualificationIndicator.Rows[2].DefaultCellStyle.ForeColor = (wage >= lowestsameposition && wage <= highestsameposition) ? Color.Green : Color.Red;
                    }
                    else
                    {
                        lf.dgvQualificationIndicator.Rows[2].Cells[0].Value = "No comparing data yet";
                        lf.dgvQualificationIndicator.Rows[2].Cells[1].Value = "N/A";
                    }
                    //4. Check if the position wage reasonable comparing to T4 summary (total paid divides by total pay slips)
                    if(wage != 0 && lf.financialAdvisor.txtAverageWage1.Text != string.Empty && Validation.IsFloat(lf.financialAdvisor.txtAverageWage1.Text) && lf.jobPositionAdvisor.txtWorkingHours.Text != string.Empty && Validation.IsFloat(lf.jobPositionAdvisor.txtWorkingHours.Text))
                    {
                        float average1 = float.Parse(lf.jobPositionAdvisor.txtWorkingHours.Text);
                        float annualwage = wage * average1 * 365 / 7;
                        lf.dgvQualificationIndicator.Rows[3].Cells[0].Value = (annualwage >= average1) ? "Annual age >=Company Average" : "Annual age < Company Average ";
                        lf.dgvQualificationIndicator.Rows[3].Cells[1].Value = (annualwage >= average1) ? "Perfect" : "Reasonable?";
                        lf.dgvQualificationIndicator.Rows[3].DefaultCellStyle.ForeColor = (wage >= lowestsameposition && wage <= highestsameposition) ? Color.Green : Color.Red;
                    }
                    else
                    {
                        lf.dgvQualificationIndicator.Rows[3].Cells[0].Value = "No comparing data yet";
                        lf.dgvQualificationIndicator.Rows[3].Cells[1].Value = "N/A";
                    }
                    if(lf.txtCOPSRating.Text != string.Empty && Validation.IsInt(lf.txtCOPSRating.Text))
                    {
                        switch(int.Parse(lf.txtCOPSRating.Text))
                        {
                            case 1:
                                lf.dgvQualificationIndicator.Rows[4].Cells[0].Value = "Labor market outlook is poor";
                                lf.dgvQualificationIndicator.Rows[4].Cells[1].Value = "Be careful";
                                lf.dgvQualificationIndicator.Rows[4].DefaultCellStyle.ForeColor = Color.Red;
                                break;
                            case 2:
                                lf.dgvQualificationIndicator.Rows[4].Cells[0].Value = "Labor market outlook is moderate";
                                lf.dgvQualificationIndicator.Rows[4].Cells[1].Value = "Ok";
                                lf.dgvQualificationIndicator.Rows[4].DefaultCellStyle.ForeColor = Color.Blue;
                                break;
                            case 3:
                                lf.dgvQualificationIndicator.Rows[4].Cells[0].Value = "Labor market outlook is positive";
                                lf.dgvQualificationIndicator.Rows[4].Cells[1].Value = "Go";
                                lf.dgvQualificationIndicator.Rows[4].DefaultCellStyle.ForeColor = Color.Green;
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
        public static void insertApplication(LMIAForm lf) // should check if global application id is existed
        {
            // Create a new Application 
            using(CommonDataContext cdc = new CommonDataContext())
            {
                // Validation check

                // Insert data row to Table LMIAApplication
                tblLMIAApplication la = new tblLMIAApplication
                {
                    LMIAType = GlobalData.CurrentProgramId,
                    StreamType = lf.cmbStream.SelectedIndex,
                    EmployerId = GlobalData.CurrentEmployerId,
                    EmployeeId = GlobalData.CurrentPersonId,
                    RCICId = GlobalData.CurrentRCICId,
                    CreatedDate = DateTime.Now,
                    SecondEmployer = (lf.ckbOtherEmployer.Checked == true) ? lf.txtAnotherEmployer.Text : null,

                };
                try
                {
                    cdc.tblLMIAApplications.InsertOnSubmit(la);
                    cdc.SubmitChanges();
                    GlobalData.CurrentApplicationId = la.Id;
                }
                catch(Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
                // Create a new record of position with the application Id
                tblLMIAPosition ps = new tblLMIAPosition
                {
                    ApplicationId = GlobalData.CurrentApplicationId,
                    JobTitle = lf.jobPositionAdvisor.txtJobTitle.Text,
                    NOC = lf.jobPositionAdvisor.txtNoc.Text,
                    Province = lf.jobPositionAdvisor.cmbProvince.SelectedIndex,
                    WorkingHours = double.Parse(lf.jobPositionAdvisor.txtWorkingHours.Text),
                    HourlyRate = decimal.Parse(lf.jobPositionAdvisor.txtHourlyRate.Text),
                    ProvincialMedian = decimal.Parse(lf.jobPositionAdvisor.txtProvincialMedian.Text),
                    LocalNOCMedian = decimal.Parse(lf.jobPositionAdvisor.txtLocalNOCMedian.Text),
                    LocalNOCLowest = decimal.Parse(lf.jobPositionAdvisor.txtLocalNocLowest.Text),
                    LocalNOCHighest = decimal.Parse(lf.jobPositionAdvisor.txtLocalNocHighest.Text),
                    SamePlaceSamePositionLowest = decimal.Parse(lf.jobPositionAdvisor.txtSameLowest.Text),
                    SamePlaceSamePositionHighest = decimal.Parse(lf.jobPositionAdvisor.txtSameHighest.Text),
                    NoSamePosition = (lf.jobPositionAdvisor.chkNoSame.Checked == true) ? true : false,
                    UmemploymentRate = float.Parse(lf.txtUnemployRate.Text),
                    COPSRating = int.Parse(lf.txtCOPSRating.Text),
                    OccupationProfile = int.Parse(lf.txtOccupationProfile.Text),
                    EmployerSituation = lf.txtEmployerSituation.Text,
                    EmployerImact = lf.txtSituationImpact.Text
                };
                try
                {
                    cdc.tblLMIAPositions.InsertOnSubmit(ps);
                    cdc.SubmitChanges();
                }
                catch(Exception exc)
                {

                    MessageBox.Show(exc.Message);
                }
                //create a new record of financial analysis with application id
                tblFinance fn1 = new tblFinance
                {
                    ApplicationId = GlobalData.CurrentApplicationId,
                    FiscalYear = Validation.IsIntInRange(lf.financialAdvisor.txtLast1Year.Text, 2000, 2050) ? int.Parse(lf.financialAdvisor.txtLast1Year.Text) : (int?)null,
                    TotalRevenue = Validation.IsFloat(lf.financialAdvisor.txtRevenue1.Text) ? decimal.Parse(lf.financialAdvisor.txtRevenue1.Text) : (decimal?)null,
                    Cash = Validation.IsFloat(lf.financialAdvisor.txtCash1.Text) ? decimal.Parse(lf.financialAdvisor.txtCash1.Text) : (decimal?)null,
                    NetIncome = Validation.IsFloat(lf.financialAdvisor.txtNetImcome1.Text) ? decimal.Parse(lf.financialAdvisor.txtNetImcome1.Text) : (decimal?)null,
                    RetainedEarning = Validation.IsFloat(lf.financialAdvisor.txtRetainedEarning1.Text) ? decimal.Parse(lf.financialAdvisor.txtRetainedEarning1.Text) : (decimal?)null,
                    GrossPayroll = Validation.IsFloat(lf.financialAdvisor.txtGrossPayroll1.Text) ? decimal.Parse(lf.financialAdvisor.txtGrossPayroll1.Text) : (decimal?)null,
                    T4SlipsIssued = Validation.IsInt(lf.financialAdvisor.txtSlips1.Text) ? int.Parse(lf.financialAdvisor.txtSlips1.Text) : (int?)null
                };
                tblFinance fn2 = new tblFinance
                {
                    ApplicationId = GlobalData.CurrentApplicationId,
                    FiscalYear = Validation.IsIntInRange(lf.financialAdvisor.txtLast2Year.Text, 2000, 2050) ? int.Parse(lf.financialAdvisor.txtLast2Year.Text) : (int?)null,
                    TotalRevenue = Validation.IsFloat(lf.financialAdvisor.txtRevenue2.Text) ? decimal.Parse(lf.financialAdvisor.txtRevenue2.Text) : (decimal?)null,
                    Cash = Validation.IsFloat(lf.financialAdvisor.txtCash2.Text) ? decimal.Parse(lf.financialAdvisor.txtCash2.Text) : (decimal?)null,
                    NetIncome = Validation.IsFloat(lf.financialAdvisor.txtNetImcome2.Text) ? decimal.Parse(lf.financialAdvisor.txtNetImcome2.Text) : (decimal?)null,
                    RetainedEarning = Validation.IsFloat(lf.financialAdvisor.txtRetainedEarning2.Text) ? decimal.Parse(lf.financialAdvisor.txtRetainedEarning2.Text) : (decimal?)null,
                    GrossPayroll = Validation.IsFloat(lf.financialAdvisor.txtGrossPayroll2.Text) ? decimal.Parse(lf.financialAdvisor.txtGrossPayroll2.Text) : (decimal?)null,
                    T4SlipsIssued = Validation.IsInt(lf.financialAdvisor.txtSlips2.Text) ? int.Parse(lf.financialAdvisor.txtSlips2.Text) : (int?)null
                };
                try
                {
                    cdc.tblFinances.InsertOnSubmit(fn1);
                    cdc.tblFinances.InsertOnSubmit(fn2);
                    cdc.SubmitChanges();
                }
                catch(Exception exc)
                {

                    MessageBox.Show(exc.Message);
                }
                // create a new record of 11 factors
                foreach(int indexchecked in lf.ckbLmFactor.CheckedIndices)
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
                catch(Exception exc)
                {

                    MessageBox.Show(exc.Message);
                }
            }
        }
        public static void UpdateApplication(LMIAForm lf)
        {
            //update application, finance, job position, labour market factors
            //1. update application record
            using(CommonDataContext cdc = new CommonDataContext())
            {
                tblLMIAApplication la = cdc.tblLMIAApplications.Where(x => x.Id == GlobalData.CurrentApplicationId).Select(x => x).FirstOrDefault();
                la.LMIAType = GlobalData.CurrentProgramId;
                la.StreamType = lf.cmbStream.SelectedIndex;
                la.EmployeeId = GlobalData.CurrentPersonId;
                la.EmployerId = GlobalData.CurrentEmployerId;
                la.RCICId = GlobalData.CurrentRCICId;
                la.AnotherEmployerName = lf.txtAnotherEmployer.Text;
                try
                {
                    cdc.SubmitChanges();
                }
                catch(System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //2. update finance
                List<tblFinance> tf = cdc.tblFinances.Where(x => x.ApplicationId == GlobalData.CurrentApplicationId).Select(x => x).ToList();
                if(tf != null && tf.Count >= 1)
                {
                    tf[0].ApplicationId = GlobalData.CurrentApplicationId;
                    tf[0].FiscalYear = Validation.IsIntInRange(lf.financialAdvisor.txtLast1Year.Text, 2000, 2050) ? int.Parse(lf.financialAdvisor.txtLast1Year.Text) : (int?)null;
                    tf[0].TotalRevenue = Validation.IsFloat(lf.financialAdvisor.txtRevenue1.Text) ? decimal.Parse(lf.financialAdvisor.txtRevenue1.Text) : (decimal?)null;
                    tf[0].Cash = Validation.IsFloat(lf.financialAdvisor.txtCash1.Text) ? decimal.Parse(lf.financialAdvisor.txtCash1.Text) : (decimal?)null;
                    tf[0].NetIncome = Validation.IsFloat(lf.financialAdvisor.txtNetImcome1.Text) ? decimal.Parse(lf.financialAdvisor.txtNetImcome1.Text) : (decimal?)null;
                    tf[0].RetainedEarning = Validation.IsFloat(lf.financialAdvisor.txtRetainedEarning1.Text) ? decimal.Parse(lf.financialAdvisor.txtRetainedEarning1.Text) : (decimal?)null;
                    tf[0].GrossPayroll = Validation.IsFloat(lf.financialAdvisor.txtGrossPayroll1.Text) ? decimal.Parse(lf.financialAdvisor.txtGrossPayroll1.Text) : (decimal?)null;
                    tf[0].T4SlipsIssued = Validation.IsInt(lf.financialAdvisor.txtSlips1.Text) ? int.Parse(lf.financialAdvisor.txtSlips1.Text) : (int?)null;
                }
                if(tf != null && tf.Count == 2)
                {
                    tf[1].ApplicationId = GlobalData.CurrentApplicationId;
                    tf[1].FiscalYear = Validation.IsIntInRange(lf.financialAdvisor.txtLast2Year.Text, 2000, 2050) ? int.Parse(lf.financialAdvisor.txtLast2Year.Text) : (int?)null;
                    tf[1].TotalRevenue = Validation.IsFloat(lf.financialAdvisor.txtRevenue2.Text) ? decimal.Parse(lf.financialAdvisor.txtRevenue2.Text) : (decimal?)null;
                    tf[1].Cash = Validation.IsFloat(lf.financialAdvisor.txtCash2.Text) ? decimal.Parse(lf.financialAdvisor.txtCash2.Text) : (decimal?)null;
                    tf[1].NetIncome = Validation.IsFloat(lf.financialAdvisor.txtNetImcome2.Text) ? decimal.Parse(lf.financialAdvisor.txtNetImcome2.Text) : (decimal?)null;
                    tf[1].RetainedEarning = Validation.IsFloat(lf.financialAdvisor.txtRetainedEarning2.Text) ? decimal.Parse(lf.financialAdvisor.txtRetainedEarning2.Text) : (decimal?)null;
                    tf[1].GrossPayroll = Validation.IsFloat(lf.financialAdvisor.txtGrossPayroll2.Text) ? decimal.Parse(lf.financialAdvisor.txtGrossPayroll2.Text) : (decimal?)null;
                    tf[1].T4SlipsIssued = Validation.IsInt(lf.financialAdvisor.txtSlips2.Text) ? int.Parse(lf.financialAdvisor.txtSlips2.Text) : (int?)null;
                }
                try
                {
                    cdc.SubmitChanges();
                }
                catch(System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //3. update job position
                tblLMIAPosition lp = cdc.tblLMIAPositions.Where(x => x.ApplicationId == GlobalData.CurrentApplicationId).Select(x => x).FirstOrDefault();
                lp.JobTitle = lf.jobPositionAdvisor.txtJobTitle.Text;
                lp.NOC = lf.jobPositionAdvisor.txtNoc.Text;
                lp.Province = lf.jobPositionAdvisor.cmbProvince.SelectedIndex;
                lp.WorkingHours = double.Parse(lf.jobPositionAdvisor.txtWorkingHours.Text);
                lp.HourlyRate = decimal.Parse(lf.jobPositionAdvisor.txtHourlyRate.Text);
                lp.ProvincialMedian = decimal.Parse(lf.jobPositionAdvisor.txtProvincialMedian.Text);
                lp.LocalNOCMedian = decimal.Parse(lf.jobPositionAdvisor.txtLocalNOCMedian.Text);
                lp.LocalNOCLowest = decimal.Parse(lf.jobPositionAdvisor.txtLocalNocLowest.Text);
                lp.LocalNOCHighest = decimal.Parse(lf.jobPositionAdvisor.txtLocalNocHighest.Text);
                lp.SamePlaceSamePositionLowest = decimal.Parse(lf.jobPositionAdvisor.txtSameLowest.Text);
                lp.SamePlaceSamePositionHighest = decimal.Parse(lf.jobPositionAdvisor.txtSameHighest.Text);
                lp.NoSamePosition = lf.jobPositionAdvisor.chkNoSame.Checked == true ? true : false;
                lp.UmemploymentRate = int.Parse(lf.txtUnemployRate.Text);
                lp.COPSRating = int.Parse(lf.txtCOPSRating.Text);
                lp.OccupationProfile = int.Parse(lf.txtOccupationProfile.Text);
                lp.EmployerSituation = lf.txtEmployerSituation.Text;
                lp.EmployerImact = lf.txtSituationImpact.Text;
                try
                {
                    cdc.SubmitChanges();
                }
                catch(System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //4. update labour market factor
                tblLMIA11Factor lmf = cdc.tblLMIA11Factors.Where(x => x.ApplicationId == GlobalData.CurrentApplicationId).Select(x => x).FirstOrDefault();
                lmf.JobCreation = lf.ckbLmFactor.CheckedIndices.Contains(0) ? true : false;
                lmf.SkillTransfer = lf.ckbLmFactor.CheckedIndices.Contains(1) ? true : false;
                lmf.FillLabourShortage = lf.ckbLmFactor.CheckedIndices.Contains(2) ? true : false;
                lmf.PrevailingWageOffered = lf.ckbLmFactor.CheckedIndices.Contains(3) ? true : false;
                lmf.HireCanadianEffort = lf.ckbLmFactor.CheckedIndices.Contains(4) ? true : false;
                lmf.LabourDisputUnaffected = lf.ckbLmFactor.CheckedIndices.Contains(5) ? true : false;
                lmf.CommitmentFulfilled = lf.ckbLmFactor.CheckedIndices.Contains(6) ? true : false;
                lmf.BusinessEngagement = lf.ckbLmFactor.CheckedIndices.Contains(7) ? true : false;
                lmf.OfferConsistentwithDemand = lf.ckbLmFactor.CheckedIndices.Contains(8) ? true : false;
                lmf.AbletoFulfillTermofOffer = lf.ckbLmFactor.CheckedIndices.Contains(9) ? true : false;
                lmf.PastCompliance = lf.ckbLmFactor.CheckedIndices.Contains(10) ? true : false;
                try
                {
                    cdc.SubmitChanges();
                }
                catch(System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        public static void deleteApplication()
        {
            // delete application record and its Dependant job position, finance, Labour market factors, and business details record at same time
            using(CommonDataContext cdc = new CommonDataContext())
            {
                //1. delete application
                tblLMIAApplication la = cdc.tblLMIAApplications.Where(x => x.Id == GlobalData.CurrentApplicationId).Select(x => x).FirstOrDefault();
                cdc.tblLMIAApplications.DeleteOnSubmit(la);
                //2. delete job position
                tblLMIAPosition lp = cdc.tblLMIAPositions.Where(x => x.ApplicationId == GlobalData.CurrentApplicationId).Select(x => x).FirstOrDefault();
                if(lp != null) cdc.tblLMIAPositions.DeleteOnSubmit(lp);
                //3. delete finance 
                tblFinance finance = cdc.tblFinances.Where(x => x.ApplicationId == GlobalData.CurrentApplicationId).Select(x => x).FirstOrDefault();
                if(finance != null) cdc.tblFinances.DeleteOnSubmit(finance);
                //4. delete Labour market factors
                tblLMIA11Factor lmf = cdc.tblLMIA11Factors.Where(x => x.ApplicationId == GlobalData.CurrentApplicationId).Select(x => x).FirstOrDefault();
                if(lmf != null) cdc.tblLMIA11Factors.DeleteOnSubmit(lmf);
                //5. delete business details
                tblBusinessDetail bd = cdc.tblBusinessDetails.Where(x => x.ApplicationId == GlobalData.CurrentApplicationId).Select(x => x).FirstOrDefault();
                if(bd != null) cdc.tblBusinessDetails.DeleteOnSubmit(bd);

                if(MessageBox.Show("This operation will delete the current application and all its dependencies. Are you sure to delete it?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        cdc.SubmitChanges();
                        GlobalData.CurrentApplicationId = null;
                        GlobalData.CurrentApplicationIdReadOnly = false;
                        MessageBox.Show("The current application and its Dependant job position, finance, Labour market factors, and business details record has been deleted");
                    }
                    catch(Exception exc)
                    {

                        MessageBox.Show(exc.Message);
                    }
                }
            }
        }

    }
}
