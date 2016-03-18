﻿using System;
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
            _unemploymentRate = getValue.getIntValue(lf.txtUnemployRate.Text);
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
                // if business details is existed, load from database and fill the form
                tblBusinessDetail bd = cdc.tblBusinessDetails.Where(x => x != null && x.ApplicationId == GlobalData.CurrentApplicationId).Select(x => x).FirstOrDefault();
                if(bd != null)
                {
                    LMIABusinessDetail.loadFromDB(lf);
                    LMIABusinessDetail.fillForm(lf);
                    lf.btnInsertBD.Visible = false;
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
            lf.jobPositionAdvisor.txtHourlyRate.Text = _hourlyRate.ToString();
            lf.jobPositionAdvisor.txtProvincialMedian.Text = _provincialMedian.ToString();
            lf.jobPositionAdvisor.txtLocalNOCMedian.Text = _localNOCMedian.ToString();
            lf.jobPositionAdvisor.txtLocalNocLowest.Text = _localNOCLowest.ToString();
            lf.jobPositionAdvisor.txtLocalNocHighest.Text = _localNOCHighest.ToString();
            lf.jobPositionAdvisor.txtSameLowest.Text = _samePlaceSamePositionLowest.ToString();
            lf.jobPositionAdvisor.txtSameHighest.Text = _samePlaceSamePositionHighest.ToString();
            lf.jobPositionAdvisor.chkNoSame.Checked = _noSamePosition;
            lf.financialAdvisor.txtLast1Year.Text = _year1.ToString();
            lf.financialAdvisor.txtRevenue1.Text = _totalRevenue1.ToString();
            lf.financialAdvisor.txtCash1.Text = _cash1.ToString();
            lf.financialAdvisor.txtNetImcome1.Text = _netIncome1.ToString();
            lf.financialAdvisor.txtRetainedEarning1.Text = _retianedEarning1.ToString();
            lf.financialAdvisor.txtGrossPayroll1.Text = _grossPayrol1.ToString();
            lf.financialAdvisor.txtSlips1.Text = _t4Slips1.ToString();
            lf.financialAdvisor.txtAverageWage1.Text = _Average1.ToString();
            lf.financialAdvisor.txtLast2Year.Text = _year2.ToString();
            lf.financialAdvisor.txtRevenue2.Text = _totalRevenue2.ToString();
            lf.financialAdvisor.txtCash2.Text = _cash2.ToString();
            lf.financialAdvisor.txtNetImcome2.Text = _netIncome2.ToString();
            lf.financialAdvisor.txtRetainedEarning2.Text = _retianedEarning2.ToString();
            lf.financialAdvisor.txtGrossPayroll2.Text = _grossPayrol2.ToString();
            lf.financialAdvisor.txtSlips2.Text = _t4Slips2.ToString();
            lf.financialAdvisor.txtAverageWage2.Text = _Average2.ToString();
            lf.txtUnemployRate.Text = _unemploymentRate.ToString();
            lf.txtCOPSRating.Text = _COPSRating.ToString();
            lf.txtOccupationProfile.Text = _occupationProfile.ToString();
            lf.txtEmployerSituation.Text = _employerSituation.ToString();
            lf.txtSituationImpact.Text = _situationImpact.ToString();
            //lf.ckbLmFactor.SelectedIndices= _lmFactors;

        }
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
                // if business details is existed, load from database and fill the form
                tblBusinessDetail bd = cdc.tblBusinessDetails.Where(x => x != null && x.ApplicationId == GlobalData.CurrentApplicationId).Select(x => x).FirstOrDefault();
                if(bd != null)
                {
                    LMIABusinessDetail.loadFromDB(lf);
                    LMIABusinessDetail.fillForm(lf);
                    lf.btnInsertBD.Visible = false;
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

            //decimal wage, provincialmedian, localnocmedian, lowestsameposition, highestsameposition;
            //wage = (lf.jobPositionAdvisor.txtHourlyRate.Text != null && lf.jobPositionAdvisor.txtHourlyRate.Text != string.Empty) ? decimal.Parse(lf.jobPositionAdvisor.txtHourlyRate.Text) : 0f;
            //provincialmedian = (lf.jobPositionAdvisor.txtProvincialMedian.Text != null && lf.jobPositionAdvisor.txtProvincialMedian.Text != string.Empty) ? decimal.Parse(lf.jobPositionAdvisor.txtProvincialMedian.Text) : 0f;
            //localnocmedian = (lf.jobPositionAdvisor.txtLocalNOCMedian.Text != null && lf.jobPositionAdvisor.txtLocalNOCMedian.Text != string.Empty) ? decimal.Parse(lf.jobPositionAdvisor.txtLocalNOCMedian.Text) : 0f;
            //lowestsameposition = (lf.jobPositionAdvisor.txtSameLowest.Text != null && lf.jobPositionAdvisor.txtSameLowest.Text != string.Empty) ? decimal.Parse(lf.jobPositionAdvisor.txtSameLowest.Text) : 0f;
            //highestsameposition = (lf.jobPositionAdvisor.txtSameHighest.Text != null && lf.jobPositionAdvisor.txtSameHighest.Text != string.Empty) ? decimal.Parse(lf.jobPositionAdvisor.txtSameHighest.Text) : 0f;
            getInput(lf);
            //Initialize Indicator rows as 5
            if(lf.dgvQualificationIndicator.RowCount<5) lf.dgvQualificationIndicator.Rows.Add(5);

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
                        lf.dgvQualificationIndicator.Rows[1].DefaultCellStyle.ForeColor = Color.Black;
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
                        lf.dgvQualificationIndicator.Rows[1].DefaultCellStyle.ForeColor = Color.Black;

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
            // Create a new Application 
            using(CommonDataContext cdc = new CommonDataContext())
            {
                // Validation check

                // Insert data row to Table LMIAApplication
                tblLMIAApplication la = new tblLMIAApplication
                {
                    LMIAType = GlobalData.CurrentProgramId,
                    StreamType = GlobalData.CurrentStreamId,
                    EmployerId = GlobalData.CurrentEmployerId,
                    EmployeeId = GlobalData.CurrentPersonId,
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
                // Create a new record of position with the application Id
                tblLMIAPosition ps = new tblLMIAPosition
                {
                    ApplicationId = GlobalData.CurrentApplicationId,
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
                //create a new record of financial analysis with application id
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
                    cdc.tblFinances.InsertOnSubmit(fn1);
                    cdc.tblFinances.InsertOnSubmit(fn2);
                    cdc.SubmitChanges();
                    msg.Append("Financial data has been created\n");
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
                    msg.Append("Labour market factors data has been created\n");

                }
                catch(Exception exc)
                {

                    MessageBox.Show(exc.Message);
                }
                //Create a new record of job offer
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
        }
        public static void updateApplication(LMIAForm lf)
        {
            //update application, finance, job position, labour market factors
            //1. update application record
            getInput(lf);
            using(CommonDataContext cdc = new CommonDataContext())
            {
                tblLMIAApplication la = cdc.tblLMIAApplications.Where(x => x.Id == GlobalData.CurrentApplicationId).Select(x => x).FirstOrDefault();
                la.LMIAType = GlobalData.CurrentProgramId;
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
                    tf[0].FiscalYear = _year2;
                    tf[0].TotalRevenue = _totalRevenue2;
                    tf[0].Cash = _cash2;
                    tf[0].NetIncome = _netIncome2;
                    tf[0].RetainedEarning = _retianedEarning2;
                    tf[0].GrossPayroll = _grossPayrol2;
                    tf[0].T4SlipsIssued = _t4Slips2;
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
                tblJobOffer jo=cdc.tblJobOffers.Where(x => x.applicationID == GlobalData.CurrentApplicationId).Select(x => x).FirstOrDefault();
                if(jo!=null) cdc.tblJobOffers.DeleteOnSubmit(jo);
                if(MessageBox.Show("This operation will delete the current application and all its dependencies. Are you sure to delete it?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        cdc.SubmitChanges();
                        GlobalData.CurrentApplicationId = null;
                        GlobalData.CurrentApplicationIdReadOnly = false;
                        MessageBox.Show("The current application and its Dependant job position, finance, Labour market factors, business details record, job offer has been deleted");
                        lf.btnAnalysisInsert.Visible = true;
                        lf.btnInsertBD.Visible = true;
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
