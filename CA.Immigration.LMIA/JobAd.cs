using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CA.Immigration.Data;
using CA.Immigration.Utility;
namespace CA.Immigration.LMIA
{
    public class JobAd
    {
        private static string _operatingNam;
        private static string _businessAddress;
        private static string _mailAddress;
        private static string _positionTitle;
        private static string _workLocation;
        private static string _employmentTerm;
        private static decimal? _wage;
        private static double? _workingHours;
        private static bool _Disability;
        private static bool _Dental;
        private static bool _Pension;
        private static bool _ExtendedMedical;
        private static bool _otherBenefitFlag;
        private static string _benefit;
        private static string _otherBenefit;
        private static string _jobDuties;
        private static string _skillRequirement;
        public static int _education;
        private static string _workExperience;
        private static string _languageRequirement;
        private static string _otherRequirement;
        private static string _contactInformation;

        private static string _workLocationUnit;
        private static string _workLocationStreetNo;
        private static string _workLocationStreetName;
        private static string _workLocationCity;
        private static int _workLocationProvince;
        private static string _workLocationPostCode;
        private static string _website;

        public static void getAllData(LMIAForm lf)
        {
            // 1. get information from database
            using(CommonDataContext cdc = new CommonDataContext())
            {
                tblEmployer emp = cdc.tblEmployers.Where(x => x.Id == GlobalData.CurrentEmployerId).Select(x => x).FirstOrDefault();
                _website = emp.Website;
                tblLMIAPosition pos = cdc.tblLMIAPositions.Where(x => x.Id == GlobalData.CurrentApplicationId).Select(x => x).FirstOrDefault();
                _operatingNam = emp.OperatingName;
                _positionTitle = pos.JobTitle;
                _workingHours = pos.WorkingHours;
                tblCanadianAddress cab = cdc.tblCanadianAddresses.Where(x => x.Id == emp.BizAddressId).Select(x => x).FirstOrDefault();
                _businessAddress = getFullAddress(cab);
                tblCanadianAddress cam = cdc.tblCanadianAddresses.Where(x => x.Id == emp.MailAddressId).Select(x => x).FirstOrDefault();
                _mailAddress = getFullAddress(cam);
            }

            _workLocationUnit = lf.txtJobAdUnit.Text;
            _workLocationStreetNo = lf.txtJobAdStreetNo.Text;
            _workLocationStreetName = lf.txtJobAdStreetName.Text;
            _workLocationCity = lf.txtJobAdCity.Text;
            _workLocationProvince = lf.canadaProvincesJobAd.cmbProvince.SelectedIndex;
            _workLocationPostCode = lf.txtJobAdPostCode.Text;
            _workLocation = getFullAddress();

            _employmentTerm = lf.txtEmploymentTerm.Text;
            _wage = getValue.getDecimalValue(lf.jobPositionAdvisor.txtHourlyRate.Text);

            _jobDuties = lf.txtPositionMainDuties.Text;
            foreach(int i in lf.chkJobAdBenefit.CheckedIndices) _benefit += Definition.LMIABenefit[i] + ",";
            _Disability = lf.chkJobAdBenefit.CheckedIndices.Contains(0) ? true : false;
            _Dental = lf.chkJobAdBenefit.CheckedIndices.Contains(1) ? true : false;
            _Pension = lf.chkJobAdBenefit.CheckedIndices.Contains(2) ? true : false;
            _ExtendedMedical = lf.chkJobAdBenefit.CheckedIndices.Contains(3) ? true : false;
            _benefit = (_benefit == string.Empty || _benefit == null) ? string.Empty : _benefit.Remove(_benefit.Length - 1);
            _otherBenefit = lf.txtOtherBenefit.Text;
            if(_otherBenefit != null && _otherBenefit != string.Empty) _otherBenefitFlag = true;

            _education = lf.cmbLMIAEduReq.SelectedIndex;

            _skillRequirement = lf.txtPositionSkillReq.Text;
            _workExperience = lf.txtPositionWorkExp.Text;
            _languageRequirement = lf.txtPositionLanguage.Text;
            _otherRequirement = lf.txtPositionOthers.Text;
            _contactInformation = lf.txtJobAdContactInfo.Text;

        }
        public static void getInput(LMIAForm lf)
        {
            _workLocationUnit = lf.txtJobAdUnit.Text;
            _workLocationStreetNo = lf.txtJobAdStreetNo.Text;
            _workLocationStreetName = lf.txtJobAdStreetName.Text;
            _workLocationCity = lf.txtJobAdCity.Text;
            _workLocationProvince = lf.canadaProvincesJobAd.cmbProvince.SelectedIndex;
            _workLocationPostCode = lf.txtJobAdPostCode.Text;
            _workLocation = getFullAddress();

            _employmentTerm = lf.txtEmploymentTerm.Text;
            _wage = getValue.getDecimalValue(lf.jobPositionAdvisor.txtHourlyRate.Text);

            _jobDuties = lf.txtPositionMainDuties.Text;
            foreach(int i in lf.chkJobAdBenefit.CheckedIndices) _benefit += Definition.LMIABenefit[i] + ",";
            _Disability = lf.chkJobAdBenefit.CheckedIndices.Contains(0) ? true : false;
            _Dental = lf.chkJobAdBenefit.CheckedIndices.Contains(1) ? true : false;
            _Pension = lf.chkJobAdBenefit.CheckedIndices.Contains(2) ? true : false;
            _ExtendedMedical = lf.chkJobAdBenefit.CheckedIndices.Contains(3) ? true : false;
            _benefit = _benefit.Remove(_benefit.Length - 1);
            _otherBenefit = lf.txtOtherBenefit.Text;

            _education = lf.cmbLMIAEduReq.SelectedIndex;

            _skillRequirement = lf.txtPositionSkillReq.Text;
            _workExperience = lf.txtPositionWorkExp.Text;
            _languageRequirement = lf.txtPositionLanguage.Text;
            _otherRequirement = lf.txtPositionOthers.Text;
            _contactInformation = lf.txtJobAdContactInfo.Text;
        }

        public static void loadFromDB(LMIAForm lf)
        {
            //1. load working address, benefits, and part of position data
            using(CommonDataContext cdc = new CommonDataContext())
            {
                //get data from position table
                tblLMIAPosition lp = cdc.tblLMIAPositions.Where(x => x.ApplicationId == GlobalData.CurrentApplicationId).Select(x => x).FirstOrDefault();
                _employmentTerm = lp.employmentTerm;
                _jobDuties = lp.jobDuties;
                _education = lp.educationRequirement == null ? -1 : (int)lp.educationRequirement;
                _skillRequirement = lp.skillRequirement;
                _workExperience = lp.workExperience;
                _languageRequirement = lp.languageRequirement;
                _otherRequirement = lp.otherRequirement;
                _contactInformation = lp.contactInformation;

                //get benefits from table
                tblLMIABenefit lb = cdc.tblLMIABenefits.Where(x => x.ApplicationId == GlobalData.CurrentApplicationId).Select(x => x).FirstOrDefault();
                _Disability = lb.Disability == true ? true : false;
                _Dental = lb.Dental == true ? true : false;
                _Pension = lb.Pension == true ? true : false;
                _ExtendedMedical = lb.ExtendedMedical == true ? true : false;
                _otherBenefit = lb.Other;

                // get working address data
                tblCanadianAddress ca = cdc.tblCanadianAddresses.Where(x => x.Id == lp.workLocationId).Select(x => x).FirstOrDefault();
                _workLocationUnit = ca.Unit;
                _workLocationStreetNo = ca.StreetNo;
                _workLocationStreetName = ca.StreetName;
                _workLocationCity = ca.City;
                _workLocationProvince = ca.Province == null ? -1 : (int)ca.Province;
                _workLocationPostCode = ca.PostalCode;
                _workLocation = getFullAddress();
            }
        }
        public static void fillForm(LMIAForm lf)
        {
            lf.txtJobAdUnit.Text = _workLocationUnit;
            lf.txtJobAdStreetNo.Text = _workLocationStreetNo;
            lf.txtJobAdStreetName.Text = _workLocationStreetName;
            lf.txtJobAdCity.Text = _workLocationCity;
            lf.canadaProvincesJobAd.cmbProvince.SelectedIndex = _workLocationProvince;
            lf.txtJobAdPostCode.Text = _workLocationPostCode;

            lf.txtEmploymentTerm.Text = _employmentTerm;
            lf.txtPositionMainDuties.Text = _jobDuties;

            lf.chkJobAdBenefit.SetItemChecked(0, _Disability);
            lf.chkJobAdBenefit.SetItemChecked(1, _Dental);
            lf.chkJobAdBenefit.SetItemChecked(2, _Pension);
            lf.chkJobAdBenefit.SetItemChecked(3, _ExtendedMedical);
            if(_otherBenefit != null && _otherBenefit != string.Empty) lf.chkJobAdBenefit.SetItemChecked(4, true);

            lf.txtOtherBenefit.Text = _otherBenefit;

            lf.cmbLMIAEduReq.SelectedIndex = _education;

            lf.txtPositionSkillReq.Text = _skillRequirement;
            lf.txtPositionWorkExp.Text = _workExperience;
            lf.txtPositionLanguage.Text = _languageRequirement;
            lf.txtPositionOthers.Text = _otherRequirement;
            lf.txtJobAdContactInfo.Text = _contactInformation;
        }
        public static void clearForm(LMIAForm lf)
        {
            _workLocationUnit = null;
            _workLocationStreetNo = null;
            _workLocationStreetName = null;
            _workLocationCity = null;
            _workLocationProvince = -1;
            _workLocationPostCode = null;
            _workLocation = null;

            _employmentTerm = null;
            _jobDuties = null;
            _benefit = null; ;
            _Disability = false;
            _Dental = false;
            _Pension = false;
            _ExtendedMedical = false;
            _otherBenefit = null;

            _education = -1;

            _skillRequirement = null;
            _workExperience = null;
            _languageRequirement = null;
            _otherRequirement = null;
            _contactInformation = null;
        }
        public static void deleteRecord()
        {

            using(CommonDataContext cdc = new CommonDataContext())
            {
                // delete the working address
                int? workaddId = cdc.tblLMIAPositions.Where(x => x.Id == GlobalData.CurrentApplicationId).Select(x => x.workLocationId).FirstOrDefault();
                if(workaddId != null)
                {
                    tblCanadianAddress ca = cdc.tblCanadianAddresses.Where(x => x.Id == workaddId).Select(x => x).FirstOrDefault();
                    cdc.tblCanadianAddresses.DeleteOnSubmit(ca);
                }
                //delete the benefits
                tblLMIABenefit lb = cdc.tblLMIABenefits.Where(x => x.Id == GlobalData.CurrentApplicationId).Select(x => x).FirstOrDefault();
                if(lb != null) cdc.tblLMIABenefits.DeleteOnSubmit(lb);
            }

        }
        public static void SaveRecord(LMIAForm lf)
        {
            if(GlobalData.CurrentApplicationId != null)
            {
                getInput(lf);
                //1. load working address, benefits, and part of position data
                using(CommonDataContext cdc = new CommonDataContext())
                {
                    //update data from position table
                    tblLMIAPosition lp = cdc.tblLMIAPositions.Where(x => x.ApplicationId == GlobalData.CurrentApplicationId).Select(x => x).FirstOrDefault();
                    lp.employmentTerm = _employmentTerm;
                    lp.jobDuties = _jobDuties;
                    lp.educationRequirement = _education;
                    lp.skillRequirement = _skillRequirement;
                    lp.workExperience = _workExperience;
                    lp.languageRequirement = _languageRequirement;
                    lp.otherRequirement = _otherRequirement;
                    lp.contactInformation = _contactInformation;

                    //update benefits from table
                    tblLMIABenefit lb = cdc.tblLMIABenefits.Where(x => x.ApplicationId == GlobalData.CurrentApplicationId).Select(x => x).FirstOrDefault();
                    lb.Disability = _Disability;
                    lb.Dental = _Dental;
                    lb.Pension = _Pension;
                    lb.ExtendedMedical = _ExtendedMedical;
                    lb.Other = _otherBenefit;

                    // update working address data
                    tblCanadianAddress ca = cdc.tblCanadianAddresses.Where(x => x.Id == lp.workLocationId).Select(x => x).FirstOrDefault();
                    ca.Unit = _workLocationUnit;
                    ca.StreetNo = _workLocationStreetNo;
                    ca.StreetName = _workLocationStreetName;
                    ca.City = _workLocationCity;
                    ca.Province = _workLocationProvince;
                    ca.PostalCode = _workLocationPostCode;

                    try
                    {
                        cdc.SubmitChanges();
                        MessageBox.Show("Job Position, benefits, and working address has been updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch(Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }

                }
            }
            else MessageBox.Show("There is no active application. Please create from Analysis");
        }
        public static string getFullAddress(tblCanadianAddress ca)
        {
            if(ca.POBox != string.Empty && ca.Unit != string.Empty)
                return ca.POBox + ", " + ca.Unit + ", " + ca.StreetNo + " " + ca.StreetName + ca.City + "," + Definition.CndProvince[(int)ca.Province] + " " + ca.PostalCode;
            else if(ca.POBox != string.Empty) return ca.POBox + ", " + ca.StreetNo + " " + ca.StreetName + ca.City + "," + Definition.CndProvince[(int)ca.Province] + " " + ca.PostalCode;
            else if(ca.Unit != string.Empty) return ca.Unit + ", " + ca.StreetNo + " " + ca.StreetName + ca.City + "," + Definition.CndProvince[(int)ca.Province] + " " + ca.PostalCode;
            else return ca.StreetNo + " " + ca.StreetName + "," + ca.City + "," + Definition.CndProvince[(int)ca.Province] + " " + ca.PostalCode;

        }
        public static string getFullAddress()
        {
            if(_workLocationProvince != -1)
            {
                if(_workLocationUnit != string.Empty && _workLocationUnit != null) return _workLocationUnit + ", " + _workLocationStreetNo + " " + _workLocationStreetName + _workLocationCity + "," + Definition.CndProvince[(int)_workLocationProvince] + " " + _workLocationPostCode;
                else return _workLocationStreetNo + " " + _workLocationStreetName + _workLocationCity + "," + Definition.CndProvince[(int)_workLocationProvince] + " " + _workLocationPostCode;
            }
            else return string.Empty;

        }
        public static string getStreetAddress()
        {
            if(_workLocationProvince != -1)
            {
                if(_workLocationUnit != string.Empty && _workLocationUnit != null) return _workLocationUnit + ", " + _workLocationStreetNo + " " + _workLocationStreetName;
                else return _workLocationStreetNo + " " + _workLocationStreetName;
            }
            else return string.Empty;

        }
        public static void generatePreview(LMIAForm lf)
        {
            getAllData(lf);
            StringBuilder sb = new StringBuilder();
            //Job Title
            sb.AppendLine(lf.jobPositionAdvisor.txtJobTitle.Text + "\n");
            // Term of employment
            sb.AppendLine("Term:" + _employmentTerm + "," + _workingHours + "hours/Week\n");
            // Salary
            sb.AppendLine("Salary: " + String.Format("{0:0.00}", _wage) + "\n");
            // Benefits
            sb.AppendLine("Benefits: " + _benefit + "\n");
            // Business Address
            sb.AppendLine("Business Address: " + _businessAddress + "\n");
            // Work location
            sb.AppendLine("Work Location:" + _workLocation + "\n");
            // Company Brief

            //Responsibilities
            sb.AppendLine("Responsibilities: \n" + _jobDuties + "\n");
            // Qualifications
            sb.AppendLine("Qualification:\n");
            if(_education == -1) sb.AppendLine("No education requirement");
            else sb.AppendLine(Definition.LMIAEduLevel[_education] + "\n");
            sb.AppendLine(_workExperience + "\n");
            sb.AppendLine(_skillRequirement + "\n");
            sb.AppendLine(_languageRequirement + "\n");
            // Contact Information
            sb.AppendLine(_contactInformation);
            sb.AppendLine("For more information about our company, please visit our website at " + _website);

            lf.txtJobAdPreview.Text = sb.ToString();
        }
        public static void buildupDict5593(ref Dictionary<string, string> dict)
        {
            dict.Add("EMP5593_E[0].Page3[0].txtF_LocationOfEmployment[0]", getStreetAddress());  // joboffer1.WorkLocation,
            dict.Add("EMP5593_E[0].Page4[0].txtF_City[0]", _workLocationCity);  // joboffer1.City,
            dict.Add("EMP5593_E[0].Page4[0].txtF_Province[0]", Definition.CndProvince[_workLocationProvince]);  // joboffer1.Province,
            dict.Add("EMP5593_E[0].Page4[0].txtF_PostalCode[0]", _workLocationPostCode);  // joboffer1.PostalCode, 
            dict.Add("EMP5593_E[0].Page4[0].txtF_MainDuties[0]", _jobDuties);  // joboffer1.Mainduties,
            switch(_education)
            {
                case 0:
                    dict.Add("EMP5593_E[0].Page4[0].chkB_DoctoratePhd[0]", "1");  // joboffer1.Doctorate_PHD.ToString(),
                    break;
                case 1:
                    dict.Add("EMP5593_E[0].Page4[0].chkB_DoctorOfMedicine[0]", "1");  // joboffer1.DoctorOfMdeicine.ToString(),
                    break;
                case 2:
                    dict.Add("EMP5593_E[0].Page4[0].chkB_MastersDegree[0]", "1");  // joboffer1.MasterDegree.ToString(),
                    break;
                case 3:
                    dict.Add("EMP5593_E[0].Page4[0].chkB_BachelorsDegree[0]", "1");  // joboffer1.Bachelor.ToString(),
                    break;
                case 4:
                    dict.Add("EMP5593_E[0].Page4[0].chkB_CollegeLevelDiploma[0]", "1");  // joboffer1.College.ToString(),
                    break;
                case 5:
                    dict.Add("EMP5593_E[0].Page4[0].chkB_Apprenticeship[0]", "1");  // joboffer1.Apprentice.ToString(),
                    break;
                case 6:
                    dict.Add("EMP5593_E[0].Page4[0].chkB_TradeDiploma[0]", "1");  // joboffer1.Trade.ToString(), // need check, two trade in nodes
                    break;
                case 7:
                    dict.Add("EMP5593_E[0].Page4[0].chkB_SecondarySchool[0]", "1");  // joboffer1.SecondarySchool.ToString(),
                    break;
                case 8:
                    dict.Add("EMP5593_E[0].Page4[0].chkB_VocationalSchool[0]", "1");  // joboffer1.Vocational.ToString(),
                    break;
                case 9:
                    dict.Add("EMP5593_E[0].Page4[0].chkB_TradeDiploma[1]", "1");  // joboffer1.NotRequired.ToString(), // need check 
                    break;

            }
            dict.Add("EMP5593_E[0].Page4[0].txtF_AdditionalInformation[0]","N/A");  // joboffer1.EduAdditionalInfo. FIX SOMEDAY
            dict.Add("EMP5593_E[0].Page4[0].txtF_MainDuties[1]", _skillRequirement);  // joboffer1.SkillRequirement,

            dict.Add("EMP5593_E[0].Page4[0].txtF_PerHour[0]", _wage.ToString());  // joboffer1.HourlyWage.ToString(),
            dict.Add("EMP5593_E[0].Page4[0].txtF_PerYear[0]", String.Format("{0:0.00}", Convert.ToString(_wage* (decimal)_workingHours*365/7)));  // joboffer1.YearlyWage.ToString(),
            dict.Add("EMP5593_E[0].Page4[0].txtF_OtRate[0]",String.Format("{0:0.00}",Convert.ToString((float)_wage*1.5)));  // joboffer1.OverTimeRate.ToString(),
            dict.Add("EMP5593_E[0].Page4[0].txtF_hoursOfWorkPerWeek[0]",_workingHours.ToString());  // joboffer1.OverTimeStart.ToString(),
            dict.Add("EMP5593_E[0].Page4[0].txtF_NumberOfHours[0]", (_workingHours/5).ToString());  // joboffer1.Dayhours.ToString(),
            dict.Add("EMP5593_E[0].Page4[0].txtF_TotalNumberOfHoursPerWeek[0]",_workingHours.ToString());  // joboffer1.WeeklyHours.ToString(),
            dict.Add("EMP5593_E[0].Page4[0].txtF_TotalNumberOfHoursPerMonth[0]",(_workingHours*365/7/12).ToString());  // joboffer1.MonthlyHours.ToString(),

        }

    }
}
