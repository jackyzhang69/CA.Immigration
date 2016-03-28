using System;
using System.Collections.Generic;
using System.Linq;
using CA.Immigration.Data;
using System.Drawing;
using CA.Immigration.Utility;
using System.Windows.Forms;
using System.Text;

namespace CA.Immigration.LMIA
{
    public class LMIAAnalysis
    {
        private static string _otherEmployerName { get; set; }
        private static string _jobTitle { get; set; }
        private static string _NOC { get; set; }
        private static int? _province { get; set; }
        private static double? _workingHours { get; set; }
        private static decimal? _hourlyRate { get; set; }
        private static decimal? _provincialMedian { get; set; }
        private static decimal? _localNOCMedian { get; set; }
        private static decimal? _localNOCLowest { get; set; }
        private static decimal? _localNOCHighest { get; set; }
        private static decimal? _samePlaceSamePositionLowest { get; set; }
        private static decimal? _samePlaceSamePositionHighest { get; set; }
        private static bool _noSamePosition { get; set; }
        private static int? _year1 { get; set; }
        private static decimal? _totalRevenue1 { get; set; }
        private static decimal? _cash1 { get; set; }
        private static decimal? _netIncome1 { get; set; }
        private static decimal? _retianedEarning1 { get; set; }
        private static decimal? _grossPayrol1 { get; set; }
        private static int? _t4Slips1 { get; set; }
        private static decimal? _Average1 { get; set; }

        private static int? _year2 { get; set; }
        private static decimal? _totalRevenue2 { get; set; }
        private static decimal? _cash2 { get; set; }
        private static decimal? _netIncome2 { get; set; }
        private static decimal? _retianedEarning2 { get; set; }
        private static decimal? _grossPayrol2 { get; set; }
        private static int? _t4Slips2 { get; set; }
        private static decimal? _Average2 { get; set; }

        private static double? _unemploymentRate { get; set; }
        private static int? _COPSRating { get; set; }
        private static int? _occupationProfile { get; set; }
        private static string _employerSituation { get; set; }
        private static string _situationImpact { get; set; }
        private static List<int> _lmFactors { get; set; }

        // Labour market factors
        private static bool _JobCreation { get; set; }
        private static bool _SkillTransfer { get; set; }
        private static bool _FillLabourShortage { get; set; }
        private static bool _PrevailingWageOffered { get; set; }
        private static bool _HireCanadianEffort { get; set; }
        private static bool _LabourDisputUnaffected { get; set; }
        private static bool _CommitmentFulfilled { get; set; }
        private static bool _BusinessEngagement { get; set; }
        private static bool _OfferConsistentwithDemand { get; set; }
        private static bool _AbletoFulfillTermofOffer { get; set; }
        private static bool _PastCompliance { get; set; }



        public static void getInput(LMIAForm lf)
        {
            _otherEmployerName = lf.txtAnotherEmployer.Text;
            _jobTitle = lf.jobPositionAdvisor.txtJobTitle.Text == string.Empty ? null : lf.jobPositionAdvisor.txtJobTitle.Text;
            _NOC = lf.jobPositionAdvisor.txtNoc.Text;
            _province = lf.jobPositionAdvisor.cmbProvince.SelectedIndex;
            _workingHours = getValue.getDoubleValue(lf.jobPositionAdvisor.txtWorkingHours.Text);
            _hourlyRate = getValue.getDecimalValue(lf.jobPositionAdvisor.txtHourlyRate.Text);
            _provincialMedian = getValue.getDecimalValue(lf.jobPositionAdvisor.txtProvincialMedian.Text);
            _localNOCMedian = getValue.getDecimalValue(lf.jobPositionAdvisor.txtLocalNOCMedian.Text);
            _localNOCLowest = getValue.getDecimalValue(lf.jobPositionAdvisor.txtLocalNocLowest.Text);
            _localNOCHighest = getValue.getDecimalValue(lf.jobPositionAdvisor.txtLocalNocHighest.Text);
            _samePlaceSamePositionLowest = getValue.getDecimalValue(lf.jobPositionAdvisor.txtSameLowest.Text);
            _samePlaceSamePositionHighest = getValue.getDecimalValue(lf.jobPositionAdvisor.txtSameHighest.Text);
            _noSamePosition = lf.jobPositionAdvisor.chkNoSame.Checked == true ? true : false;
            _year1 = getValue.getIntValue(lf.financialAdvisor.txtLast1Year.Text);
            _totalRevenue1 = getValue.getDecimalValue(lf.financialAdvisor.txtRevenue1.Text);
            _cash1 = getValue.getDecimalValue(lf.financialAdvisor.txtCash1.Text);
            _netIncome1 = getValue.getDecimalValue(lf.financialAdvisor.txtNetImcome1.Text);
            _retianedEarning1 = getValue.getDecimalValue(lf.financialAdvisor.txtRetainedEarning1.Text);
            _grossPayrol1 = getValue.getDecimalValue(lf.financialAdvisor.txtGrossPayroll1.Text);
            _t4Slips1 = getValue.getIntValue(lf.financialAdvisor.txtSlips1.Text);
            _Average1 = (_grossPayrol1 != null && _t4Slips1 != null && _t4Slips1 != 0) ? _grossPayrol1 / _t4Slips1 : null;
            _year2 = getValue.getIntValue(lf.financialAdvisor.txtLast2Year.Text);
            _totalRevenue2 = getValue.getDecimalValue(lf.financialAdvisor.txtRevenue2.Text);
            _cash2 = getValue.getDecimalValue(lf.financialAdvisor.txtCash2.Text);
            _netIncome2 = getValue.getDecimalValue(lf.financialAdvisor.txtNetImcome2.Text);
            _retianedEarning2 = getValue.getDecimalValue(lf.financialAdvisor.txtRetainedEarning2.Text);
            _grossPayrol2 = getValue.getDecimalValue(lf.financialAdvisor.txtGrossPayroll2.Text);
            _t4Slips2 = getValue.getIntValue(lf.financialAdvisor.txtSlips2.Text);
            _Average2 = (_grossPayrol2 != null && _t4Slips2 != null && _t4Slips2 != 0) ? _grossPayrol2 / _t4Slips2 : null;
            _unemploymentRate = getValue.getDoubleValue(lf.txtUnemployRate.Text);
            _COPSRating = getValue.getIntValue(lf.txtCOPSRating.Text);
            _occupationProfile = getValue.getIntValue(lf.txtOccupationProfile.Text);
            _employerSituation = lf.txtEmployerSituation.Text;
            _situationImpact = lf.txtSituationImpact.Text;
            _lmFactors = lf.ckbLmFactor.SelectedIndices.OfType<int>().ToList();
            _JobCreation = lf.ckbLmFactor.SelectedIndices.Contains(0);
            _SkillTransfer = lf.ckbLmFactor.SelectedIndices.Contains(1);
            _FillLabourShortage = lf.ckbLmFactor.SelectedIndices.Contains(2);
            _PrevailingWageOffered = lf.ckbLmFactor.SelectedIndices.Contains(3);
            _HireCanadianEffort = lf.ckbLmFactor.SelectedIndices.Contains(4);
            _LabourDisputUnaffected = lf.ckbLmFactor.SelectedIndices.Contains(5);
            _CommitmentFulfilled = lf.ckbLmFactor.SelectedIndices.Contains(6);
            _BusinessEngagement = lf.ckbLmFactor.SelectedIndices.Contains(7);
            _OfferConsistentwithDemand = lf.ckbLmFactor.SelectedIndices.Contains(8);
            _AbletoFulfillTermofOffer = lf.ckbLmFactor.SelectedIndices.Contains(9);
            _PastCompliance = lf.ckbLmFactor.SelectedIndices.Contains(10);

        }
        public static void loadFromDB(LMIAForm lf)
        {
            //Load Tab Analysis data
            using(CommonDataContext cdc = new CommonDataContext())
            {
                // load position record
                
                tblLMIAPosition lp = cdc.tblLMIAPositions.Where(x => x != null && x.ApplicationId == GlobalData.CurrentApplicationId).Select(x => x).FirstOrDefault();
                if(lp != null)
                {
                    _jobTitle = lp.JobTitle;
                    _NOC = lp.NOC;
                    _province = (int)lp.Province;
                    _workingHours = lp.WorkingHours;
                    _hourlyRate = lp.HourlyRate;
                    _provincialMedian = lp.ProvincialMedian;
                    _localNOCMedian = lp.LocalNOCMedian;
                    _localNOCLowest = lp.LocalNOCLowest;
                    _localNOCHighest = lp.LocalNOCHighest;
                    _samePlaceSamePositionLowest = lp.SamePlaceSamePositionLowest;
                    _samePlaceSamePositionHighest = lp.SamePlaceSamePositionHighest;
                    _noSamePosition = lp.NoSamePosition == null ? false : true;
                    _unemploymentRate = lp.UmemploymentRate;
                    _COPSRating = lp.COPSRating;
                    _occupationProfile = lp.OccupationProfile;
                    _employerSituation = lp.EmployerSituation;
                    _situationImpact = lp.EmployerImact;
                }
                // load financial record
                List<tblFinance> finance = cdc.tblFinances.Where(x => x != null && x.ApplicationId == GlobalData.CurrentApplicationId).Select(x => x).ToList();

                if(finance.Count >= 1)
                {
                    _year1 = finance[0].FiscalYear;
                    _totalRevenue1 = finance[0].TotalRevenue;
                    _cash1 = finance[0].Cash;
                    _netIncome1 = finance[0].NetIncome;
                    _retianedEarning1 = finance[0].RetainedEarning;
                    _grossPayrol1 = finance[0].GrossPayroll;
                    _t4Slips1 = finance[0].T4SlipsIssued;

                }
                if(finance.Count == 2)
                {
                    _year2 = finance[1].FiscalYear;
                    _totalRevenue2 = finance[1].TotalRevenue;
                    _cash2 = finance[1].Cash;
                    _netIncome2 = finance[1].NetIncome;
                    _retianedEarning2 = finance[1].RetainedEarning;
                    _grossPayrol2 = finance[1].GrossPayroll;
                    _t4Slips2 = finance[1].T4SlipsIssued;
                }
                tblLMIA11Factor factors = cdc.tblLMIA11Factors.Where(x => x != null && x.ApplicationId == GlobalData.CurrentApplicationId).Select(x => x).FirstOrDefault();
                if(factors != null)
                {
                    _JobCreation = factors.JobCreation == true ? true : false;
                    _SkillTransfer = factors.SkillTransfer == true ? true : false;
                    _FillLabourShortage = factors.FillLabourShortage == true ? true : false;
                    _PrevailingWageOffered = factors.PrevailingWageOffered == true ? true : false;
                    _HireCanadianEffort = factors.HireCanadianEffort == true ? true : false;
                    _LabourDisputUnaffected = factors.LabourDisputUnaffected == true ? true : false;
                    _CommitmentFulfilled = factors.CommitmentFulfilled == true ? true : false;
                    _BusinessEngagement = factors.BusinessEngagement == true ? true : false;
                    _OfferConsistentwithDemand = factors.OfferConsistentwithDemand == true ? true : false;
                    _AbletoFulfillTermofOffer = factors.AbletoFulfillTermofOffer == true ? true : false;
                    _PastCompliance = factors.PastCompliance == true ? true : false;
                }

            }
        }
        public static void clearForm(LMIAForm lf)
        {
            _otherEmployerName = null;
            _jobTitle = null;
            _NOC = null;
            _province = -1;
            _workingHours = null;
            _hourlyRate = null;
            _provincialMedian = null;
            _localNOCMedian = null;
            _localNOCLowest = null;
            _localNOCHighest = null;
            _samePlaceSamePositionLowest = null;
            _samePlaceSamePositionHighest = null;
            _noSamePosition = false;
            _year1 = null;
            _totalRevenue1 = null;
            _cash1 = null;
            _netIncome1 = null;
            _retianedEarning1 = null;
            _grossPayrol1 = null;
            _t4Slips1 = null;
            _Average1 = null;
            _year2 = null;
            _totalRevenue2 = null;
            _cash2 = null;
            _netIncome2 = null;
            _retianedEarning2 = null;
            _grossPayrol2 = null;
            _t4Slips2 = null;
            _Average2 = null;
            _unemploymentRate = null;
            _COPSRating = null;
            _occupationProfile = null;
            _employerSituation = string.Empty;
            _situationImpact = string.Empty;
            _lmFactors = null;
            fillForm(lf);
            getIndicators(lf);

        }
        public static void fillForm(LMIAForm lf)
        {
            lf.txtAnotherEmployer.Text = _otherEmployerName;
            lf.jobPositionAdvisor.txtJobTitle.Text = _jobTitle;
            lf.jobPositionAdvisor.txtNoc.Text = _NOC;
            lf.jobPositionAdvisor.cmbProvince.SelectedIndex = (int)_province;
            lf.jobPositionAdvisor.txtWorkingHours.Text = _workingHours.ToString();
            lf.jobPositionAdvisor.txtHourlyRate.Text = String.Format("{0:0.00}", _hourlyRate);
            lf.jobPositionAdvisor.txtProvincialMedian.Text = String.Format("{0:0.00}", _provincialMedian);
            lf.jobPositionAdvisor.txtLocalNOCMedian.Text = String.Format("{0:#,###.##}", _localNOCMedian);
            lf.jobPositionAdvisor.txtLocalNocLowest.Text = String.Format("{0:#,###.##}", _localNOCLowest);
            lf.jobPositionAdvisor.txtLocalNocHighest.Text = String.Format("{0:#,###.##}", _localNOCHighest);
            lf.jobPositionAdvisor.txtSameLowest.Text = String.Format("{0:#,###.##}", _samePlaceSamePositionLowest);
            lf.jobPositionAdvisor.txtSameHighest.Text = String.Format("{0:#,###.##}", _samePlaceSamePositionHighest);
            lf.jobPositionAdvisor.chkNoSame.Checked = _noSamePosition;
            lf.financialAdvisor.txtLast1Year.Text = _year1.ToString();
            lf.financialAdvisor.txtRevenue1.Text = String.Format("{0:#,###.##}", _totalRevenue1);
            lf.financialAdvisor.txtCash1.Text = String.Format("{0:#,###.##}", _cash1);
            lf.financialAdvisor.txtNetImcome1.Text = String.Format("{0:#,###.##}", _netIncome1);
            lf.financialAdvisor.txtRetainedEarning1.Text = String.Format("{0:#,###.##}", _retianedEarning1);
            lf.financialAdvisor.txtGrossPayroll1.Text = String.Format("{0:#,###.##}", _grossPayrol1);
            lf.financialAdvisor.txtSlips1.Text = _t4Slips1.ToString();
            lf.financialAdvisor.txtAverageWage1.Text = String.Format("{0:#,###.##}", _t4Slips1 != null ? String.Format("{0:#,###.##}", _grossPayrol1 / _t4Slips1) : "");
            lf.financialAdvisor.txtLast2Year.Text = _year2.ToString();
            lf.financialAdvisor.txtRevenue2.Text = String.Format("{0:#,###.##}", _totalRevenue2);
            lf.financialAdvisor.txtCash2.Text = String.Format("{0:#,###.##}", _cash2);
            lf.financialAdvisor.txtNetImcome2.Text = String.Format("{0:#,###.##}", _netIncome2);
            lf.financialAdvisor.txtRetainedEarning2.Text = String.Format("{0:#,###.##}", _retianedEarning2);
            lf.financialAdvisor.txtGrossPayroll2.Text = String.Format("{0:#,###.##}", _grossPayrol2);
            lf.financialAdvisor.txtSlips2.Text = _t4Slips2.ToString();
            lf.financialAdvisor.txtAverageWage2.Text = String.Format("{0:#,###.##}", _t4Slips2 != null ? String.Format("{0:#,###.##}", _grossPayrol2 / _t4Slips2) : "");
            lf.txtUnemployRate.Text = String.Format("{0:#,###.##}", _unemploymentRate);
            lf.txtCOPSRating.Text = _COPSRating.ToString();
            lf.txtOccupationProfile.Text = _occupationProfile.ToString();
            lf.txtEmployerSituation.Text = _employerSituation.ToString();
            lf.txtSituationImpact.Text = _situationImpact.ToString();
            lf.ckbLmFactor.SetItemChecked(0, _JobCreation);
            lf.ckbLmFactor.SetItemChecked(1, _SkillTransfer);
            lf.ckbLmFactor.SetItemChecked(2, _FillLabourShortage);
            lf.ckbLmFactor.SetItemChecked(3, _PrevailingWageOffered);
            lf.ckbLmFactor.SetItemChecked(4, _HireCanadianEffort);
            lf.ckbLmFactor.SetItemChecked(5, _LabourDisputUnaffected);
            lf.ckbLmFactor.SetItemChecked(6, _CommitmentFulfilled);
            lf.ckbLmFactor.SetItemChecked(7, _BusinessEngagement);
            lf.ckbLmFactor.SetItemChecked(8, _OfferConsistentwithDemand);
            lf.ckbLmFactor.SetItemChecked(9, _AbletoFulfillTermofOffer);
            lf.ckbLmFactor.SetItemChecked(10, _PastCompliance);
        }
        public static void analysisLoadInitialization(LMIAForm lf)
        {
            //get analysis data
            loadFromDB(lf);
            fillForm(lf);
            // get average wage based on data loaded from database
            // set up and display qualification indicator
            //lf.dgvQualificationIndicator.Rows.Add(5);
            getIndicators(lf);
        }
        public static void getIndicators(LMIAForm lf)
        {

            //decimal wage, provincialmedian, localnocmedian, lowestsameposition, highestsameposition;
            //wage = (lf.jobPositionAdvisor.txtHourlyRate.Text != null && lf.jobPositionAdvisor.txtHourlyRate.Text != string.Empty) ? decimal.Parse(lf.jobPositionAdvisor.txtHourlyRate.Text) : 0f;
            //provincialmedian = (lf.jobPositionAdvisor.txtProvincialMedian.Text != null && lf.jobPositionAdvisor.txtProvincialMedian.Text != string.Empty) ? decimal.Parse(lf.jobPositionAdvisor.txtProvincialMedian.Text) : 0f;
            //localnocmedian = (lf.jobPositionAdvisor.txtLocalNOCMedian.Text != null && lf.jobPositionAdvisor.txtLocalNOCMedian.Text != string.Empty) ? decimal.Parse(lf.jobPositionAdvisor.txtLocalNOCMedian.Text) : 0f;
            //lowestsameposition = (lf.jobPositionAdvisor.txtSameLowest.Text != null && lf.jobPositionAdvisor.txtSameLowest.Text != string.Empty) ? decimal.Parse(lf.jobPositionAdvisor.txtSameLowest.Text) : 0f;
            //highestsameposition = (lf.jobPositionAdvisor.txtSameHighest.Text != null && lf.jobPositionAdvisor.txtSameHighest.Text != string.Empty) ? decimal.Parse(lf.jobPositionAdvisor.txtSameHighest.Text) : 0f;
            getInput(lf);
            //Initialize Indicator rows as 5
            if(lf.dgvQualificationIndicator.RowCount < 5) lf.dgvQualificationIndicator.Rows.Add(5);

            switch(GlobalData.CurrentStreamId)
            {


                case 0: // High wage stream
                        // 1. Check if the position wage bigger than provincial median wage
                    if(_hourlyRate != 0 && _hourlyRate != null && _provincialMedian != null && _provincialMedian != 0)
                    {
                        lf.dgvQualificationIndicator.Rows[0].Cells[0].Value = (_hourlyRate >= _provincialMedian) ? "Wage >= Provincial Median " : "Wage < Provincial Median ";
                        lf.dgvQualificationIndicator.Rows[0].Cells[1].Value = (_hourlyRate >= _provincialMedian) ? "Eligible" : "Ineligible";
                        lf.dgvQualificationIndicator.Rows[0].DefaultCellStyle.ForeColor = (_hourlyRate >= _provincialMedian) ? Color.Green : Color.Red;

                    }
                    else {
                        lf.dgvQualificationIndicator.Rows[0].Cells[0].Value = "No comparing data yet";
                        lf.dgvQualificationIndicator.Rows[0].Cells[1].Value = "N/A";
                        lf.dgvQualificationIndicator.Rows[1].DefaultCellStyle.ForeColor = Color.Black;
                    }
                    //2. Check if the position wage bigger than local NOC median wage
                    if(_hourlyRate != 0 && _hourlyRate != null && _localNOCMedian != null && _localNOCMedian != 0)
                    {
                        lf.dgvQualificationIndicator.Rows[1].Cells[0].Value = (_hourlyRate >= _localNOCMedian) ? "Wage >= Local NOC Median " : "Wage < Local NOC Median ";
                        lf.dgvQualificationIndicator.Rows[1].Cells[1].Value = (_hourlyRate >= _localNOCMedian) ? "Eligible" : "Ineligible";
                        lf.dgvQualificationIndicator.Rows[1].DefaultCellStyle.ForeColor = (_hourlyRate >= _localNOCMedian) ? Color.Green : Color.Red;

                    }
                    else {
                        lf.dgvQualificationIndicator.Rows[1].Cells[0].Value = "No comparing data yet";
                        lf.dgvQualificationIndicator.Rows[1].Cells[1].Value = "N/A";
                        lf.dgvQualificationIndicator.Rows[1].DefaultCellStyle.ForeColor = Color.Black;
                    }
                    //3. check if the position wage between same place same position wage range
                    if(_hourlyRate != null && _hourlyRate != 0 && _localNOCLowest != null && _localNOCLowest != 0 && _localNOCHighest != null && _localNOCHighest != 0)
                    {
                        lf.dgvQualificationIndicator.Rows[2].Cells[0].Value = (_hourlyRate >= _localNOCLowest && _hourlyRate <= _localNOCHighest) ? "Wage in same position range " : "Wage not in same position range ";
                        lf.dgvQualificationIndicator.Rows[2].Cells[1].Value = (_hourlyRate >= _localNOCLowest && _hourlyRate <= _localNOCHighest) ? "Eligible" : "Ineligible";
                        lf.dgvQualificationIndicator.Rows[2].DefaultCellStyle.ForeColor = (_hourlyRate >= _localNOCLowest && _hourlyRate <= _localNOCHighest) ? Color.Green : Color.Red;
                    }
                    else
                    {
                        lf.dgvQualificationIndicator.Rows[2].Cells[0].Value = "No comparing data yet";
                        lf.dgvQualificationIndicator.Rows[2].Cells[1].Value = "N/A";
                        lf.dgvQualificationIndicator.Rows[2].DefaultCellStyle.ForeColor = Color.Black;
                    }
                    //4. Check if the position wage reasonable comparing to T4 summary (total paid divides by total pay slips)
                    if(_hourlyRate != null && _hourlyRate != null && _Average1 != null && _Average1 != null && _workingHours != null && _workingHours != null)
                    {
                        var annualwage = _hourlyRate * (Decimal)_workingHours * 365 / 7;
                        lf.dgvQualificationIndicator.Rows[3].Cells[0].Value = (annualwage >= _Average1) ? "Annual age >=Company Average" : "Annual age < Company Average ";
                        lf.dgvQualificationIndicator.Rows[3].Cells[1].Value = (annualwage >= _Average1) ? "Perfect" : "Reasonable?";
                        lf.dgvQualificationIndicator.Rows[3].DefaultCellStyle.ForeColor = (annualwage >= _Average1) ? Color.Green : Color.Red;
                    }
                    else
                    {
                        lf.dgvQualificationIndicator.Rows[3].Cells[0].Value = "No comparing data yet";
                        lf.dgvQualificationIndicator.Rows[3].Cells[1].Value = "N/A";
                        lf.dgvQualificationIndicator.Rows[3].DefaultCellStyle.ForeColor = Color.Black;

                    }
                    if(_COPSRating != null)
                    {
                        switch(_COPSRating)
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
            getInput(lf);

            StringBuilder msg = new StringBuilder();
            int? tempId=null;
            // Create a new Application 
            using(CommonDataContext cdc = new CommonDataContext())
            {
                // Validation check

                // 1. Insert data row to Table LMIAApplication
                tblLMIAApplication la = new tblLMIAApplication
                {
                    ProgramType = GlobalData.CurrentProgramId,
                    StreamType = GlobalData.CurrentStreamId,
                    EmployerId = GlobalData.CurrentEmployerId,
                    EmployeeId = GlobalData.CurrentPersonId==null?0:GlobalData.CurrentPersonId,
                    RCICId = GlobalData.CurrentRCICId,
                    CreatedDate = DateTime.Now,
                    SecondEmployer = _otherEmployerName != null ? _otherEmployerName : null,

                };
                try
                {
                    cdc.tblLMIAApplications.InsertOnSubmit(la);
                    cdc.SubmitChanges();
                    GlobalData.CurrentApplicationId = la.Id;
                    lf.btnAnalysisInsert.Visible = false;
                    msg.Append("Application has been created. Id= " + la.Id + "\n");
                }
                catch(Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }

                // 2. Create an empty benefit row for future use
                tblLMIABenefit lb = new tblLMIABenefit {
                    ApplicationId = GlobalData.CurrentApplicationId
                };
                  // 3. Create an empty working address row for future use
                tblCanadianAddress ca = new tblCanadianAddress
                {
                    City = null
                };
                try
                {
                    cdc.tblLMIABenefits.InsertOnSubmit(lb);
                    cdc.tblCanadianAddresses.InsertOnSubmit(ca);
                    cdc.SubmitChanges();
                    tempId=ca.Id;
                }
                catch(Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
                //4. Create a new record of position with the application Id
                tblLMIAPosition ps = new tblLMIAPosition
                {
                    ApplicationId = GlobalData.CurrentApplicationId,
                    workLocationId = tempId, // point to the address Id pre-reserved for working location
                    JobTitle = _jobTitle,
                    NOC = _NOC,
                    Province = _province,
                    WorkingHours = _workingHours,
                    HourlyRate = _hourlyRate,
                    ProvincialMedian = _provincialMedian,
                    LocalNOCMedian = _localNOCMedian,
                    LocalNOCLowest = _localNOCLowest,
                    LocalNOCHighest = _localNOCHighest,
                    SamePlaceSamePositionLowest = _samePlaceSamePositionLowest,
                    SamePlaceSamePositionHighest = _samePlaceSamePositionHighest,
                    NoSamePosition = (_otherEmployerName != null) ? true : false,
                    UmemploymentRate = _unemploymentRate,
                    COPSRating = _COPSRating,
                    OccupationProfile = _occupationProfile,
                    EmployerSituation = _employerSituation,
                    EmployerImact = _situationImpact
                };
                try
                {
                    cdc.tblLMIAPositions.InsertOnSubmit(ps);
                    cdc.SubmitChanges();
                    msg.Append("Position data has been created\n");
                }
                catch(Exception exc)
                {

                    MessageBox.Show(exc.Message);
                }
              
                //5. create a new record of financial analysis with application id
                tblFinance fn1 = new tblFinance
                {
                    ApplicationId = GlobalData.CurrentApplicationId,
                    FiscalYear = _year1,
                    TotalRevenue = _totalRevenue1,
                    Cash = _cash1,
                    NetIncome = _netIncome1,
                    RetainedEarning = _retianedEarning1,
                    GrossPayroll = _grossPayrol1,
                    T4SlipsIssued = _t4Slips1
                };
                try
                {
                    cdc.tblFinances.InsertOnSubmit(fn1);
                    cdc.SubmitChanges();
                    msg.Append(_year1+" Financial data has been created\n");
                }
                catch(Exception exc)
                {

                    MessageBox.Show(exc.Message);
                }
                tblFinance fn2 = new tblFinance
                {
                    ApplicationId = GlobalData.CurrentApplicationId,
                    FiscalYear = _year2,
                    TotalRevenue = _totalRevenue2,
                    Cash = _cash2,
                    NetIncome = _netIncome2,
                    RetainedEarning = _retianedEarning2,
                    GrossPayroll = _grossPayrol2,
                    T4SlipsIssued = _t4Slips2
                };
                try
                {
                    cdc.tblFinances.InsertOnSubmit(fn2);
                    cdc.SubmitChanges();
                    msg.Append(_year2+" Financial data has been created\n");
                }
                catch(Exception exc)
                {

                    MessageBox.Show(exc.Message);
                }
               //6. create a new record for 11 LMIA factors
                tblLMIA11Factor factor = new tblLMIA11Factor
                {
                    ApplicationId = GlobalData.CurrentApplicationId,
                    JobCreation =lf.ckbLmFactor.CheckedIndices.Contains(0) ? true : false,
                    SkillTransfer = lf.ckbLmFactor.CheckedIndices.Contains(1) ? true : false,
                    FillLabourShortage = lf.ckbLmFactor.CheckedIndices.Contains(2) ? true : false,
                    PrevailingWageOffered = lf.ckbLmFactor.CheckedIndices.Contains(3) ? true : false,
                    HireCanadianEffort = lf.ckbLmFactor.CheckedIndices.Contains(4) ? true : false,
                    LabourDisputUnaffected = lf.ckbLmFactor.CheckedIndices.Contains(5) ? true : false,
                    CommitmentFulfilled = lf.ckbLmFactor.CheckedIndices.Contains(6) ? true : false,
                    BusinessEngagement = lf.ckbLmFactor.CheckedIndices.Contains(7) ? true : false,
                    OfferConsistentwithDemand = lf.ckbLmFactor.CheckedIndices.Contains(8) ? true : false,
                    AbletoFulfillTermofOffer = lf.ckbLmFactor.CheckedIndices.Contains(9) ? true : false,
                    PastCompliance = lf.ckbLmFactor.CheckedIndices.Contains(10) ? true : false

                };
                try
                {
                    cdc.tblLMIA11Factors.InsertOnSubmit(factor);
                    cdc.SubmitChanges();
                    msg.Append("Labour market factors data has been created\n");

                }
                catch(Exception exc)
                {

                    MessageBox.Show(exc.Message);
                }

                //7 Create a new business details
                LMIABusinessDetail.getInput(lf);
                LMIABusinessDetail.Insert2DB(lf);
                //8 Create a new record of job offer
                tblJobOffer jo = new tblJobOffer
                {
                    applicationID = GlobalData.CurrentApplicationId
                };
                try
                {
                    cdc.tblJobOffers.InsertOnSubmit(jo);
                    cdc.SubmitChanges();
                    msg.Append("Job offer record has been created\n");
                }
                catch(Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
                MessageBox.Show(msg.ToString(), "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            lf.textChanged = true;
        }
        public static void updateApplication(LMIAForm lf)
        {
            //update application, finance, job position, labour market factors
            //1. update application record
            if(GlobalData.CurrentApplicationId != null)
            {
                getInput(lf);
                using(CommonDataContext cdc = new CommonDataContext())
                {
                    tblLMIAApplication la = cdc.tblLMIAApplications.Where(x => x.Id == GlobalData.CurrentApplicationId).Select(x => x).FirstOrDefault();
                    la.ProgramType = GlobalData.CurrentProgramId;
                    la.StreamType = GlobalData.CurrentStreamId;
                    la.EmployeeId = GlobalData.CurrentPersonId;
                    la.EmployerId = GlobalData.CurrentEmployerId;
                    la.RCICId = GlobalData.CurrentRCICId;
                    la.AnotherEmployerName = _otherEmployerName;
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
                        tf[0].FiscalYear = _year1;
                        tf[0].TotalRevenue = _totalRevenue1;
                        tf[0].Cash = _cash1;
                        tf[0].NetIncome = _netIncome1;
                        tf[0].RetainedEarning = _retianedEarning1;
                        tf[0].GrossPayroll = _grossPayrol1;
                        tf[0].T4SlipsIssued = _t4Slips1;
                    }
                    if(tf != null && tf.Count == 2)
                    {
                        tf[1].ApplicationId = GlobalData.CurrentApplicationId;
                        tf[1].FiscalYear = _year2;
                        tf[1].TotalRevenue = _totalRevenue2;
                        tf[1].Cash = _cash2;
                        tf[1].NetIncome = _netIncome2;
                        tf[1].RetainedEarning = _retianedEarning2;
                        tf[1].GrossPayroll = _grossPayrol2;
                        tf[1].T4SlipsIssued = _t4Slips2;
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
                    lp.JobTitle = _jobTitle;
                    lp.NOC = _NOC;
                    lp.Province = _province;
                    lp.WorkingHours = _workingHours;
                    lp.HourlyRate = _hourlyRate;
                    lp.ProvincialMedian = _provincialMedian;
                    lp.LocalNOCMedian = _localNOCMedian;
                    lp.LocalNOCLowest = _localNOCLowest;
                    lp.LocalNOCHighest = _localNOCHighest;
                    lp.SamePlaceSamePositionLowest = _samePlaceSamePositionLowest;
                    lp.SamePlaceSamePositionHighest = _samePlaceSamePositionHighest;
                    lp.NoSamePosition = _noSamePosition;
                    lp.UmemploymentRate = _unemploymentRate;
                    lp.COPSRating = _COPSRating;
                    lp.OccupationProfile = _occupationProfile;
                    lp.EmployerSituation = _employerSituation;
                    lp.EmployerImact = _situationImpact;
                    try
                    {
                        cdc.SubmitChanges();
                    }
                    catch(System.Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    //4. update Labour market factor
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

                    MessageBox.Show("Advisory analysis data has been updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else MessageBox.Show("There is no active application yet! Please insert first");
            lf.textChanged = false;

        }
        public static void deleteApplication(LMIAForm lf)
        {
            // delete application record and its Dependant job position, finance, Labour market factors, and business details record at same time
            using(CommonDataContext cdc = new CommonDataContext())
            {
                //1. delete application
                tblLMIAApplication la = cdc.tblLMIAApplications.Where(x => x.Id == GlobalData.CurrentApplicationId).Select(x => x).FirstOrDefault();
                if(la != null) cdc.tblLMIAApplications.DeleteOnSubmit(la);
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
                //6. Delete job offer 
                tblJobOffer jo = cdc.tblJobOffers.Where(x => x.applicationID == GlobalData.CurrentApplicationId).Select(x => x).FirstOrDefault();
                if(jo != null) cdc.tblJobOffers.DeleteOnSubmit(jo);
                //7. Delete benefits and working address
                JobAd.deleteRecord();
                if(MessageBox.Show("This operation will delete the current application and all its dependencies. Are you sure to delete it?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        cdc.SubmitChanges();
                        GlobalData.CurrentApplicationId = null;
                        GlobalData.CurrentApplicationIdReadOnly = false;
                        MessageBox.Show("The current application and its Dependant job position, finance, Labour market factors, business details record, job offer has been deleted");
                        lf.btnAnalysisInsert.Visible = true;
                    }
                    catch(Exception exc)
                    {

                        MessageBox.Show(exc.Message);
                    }
                }
                clearForm(lf);
                fillForm(lf);
            }
        }
        public static void buildupDict5602(ref Dictionary<string, string> dict)
        {
            dict.Add("EMP5602_E[0].Page3[0].txtF_Job_Title[0]", _jobTitle);

            //P4 Q14-15
            dict.Add("EMP5602_E[0].Page4[0].txtF_PerHour[0]", _hourlyRate.ToString());
            dict.Add("EMP5602_E[0].Page4[0].txtF_PerYear[0]", (_hourlyRate * (decimal)_workingHours * 365 / 7).ToString());
            dict.Add("EMP5602_E[0].Page4[0].txtF_NumberOfHours[0]", (_workingHours / 5).ToString());
            dict.Add("EMP5602_E[0].Page4[0].txtF_TotalNumberOfHoursPerWeek[0]", _workingHours.ToString());
            dict.Add("EMP5602_E[0].Page4[0].txtF_TotalNumberOfHoursPerMonth[0]", (_workingHours * 365 / 7 / 12).ToString());
            dict.Add("EMP5602_E[0].Page4[0].txtF_OtRate[0]", (_hourlyRate * (decimal)1.5).ToString());
            dict.Add("EMP5602_E[0].Page4[0].txtF_hoursOfWorkPerWeek[0]", _workingHours.ToString());
            dict.Add("EMP5602_E[0].Page4[0].chkB_no_employees[0]", _noSamePosition == true ? "1" : "0");
            if(_noSamePosition == false)
            {
                dict.Add("EMP5602_E[0].Page4[0].txtF_low_wage[0]", _samePlaceSamePositionLowest.ToString());
                dict.Add("EMP5602_E[0].Page4[0].txtF_high_wage[0]", _samePlaceSamePositionHighest.ToString());
            }



        }


    }
}
