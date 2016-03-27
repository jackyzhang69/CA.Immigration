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
        private static string _benefit;
        private static string _jobDuties;
        private static string _skillRequirement;
        private static string _education;
        private static string _workExperience;
        private static string _languageRequirement;
        private static string _contactInformation;

        private static string _workLocationPO;
        private static string _workLocationUnit;
        private static string _workLocationStreetNo;
        private static string _workLocationStreetName;
        private static string _workLocationCity;
        private static int _workLocationProvince;
        private static string _workLocationPostCode;





        public static void getInput(LMIAForm lf)
        {
            using (CommonDataContext cdc = new CommonDataContext())
            {
                tblEmployer emp = cdc.tblEmployers.Where(x => x.Id == GlobalData.CurrentEmployerId).Select(x => x).FirstOrDefault();
                tblLMIAPosition pos = cdc.tblLMIAPositions.Where(x => x.Id == GlobalData.CurrentApplicationId).Select(x => x).FirstOrDefault();
                _operatingNam = emp.OperatingName;
                _positionTitle = pos.JobTitle;
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

            _employmentTerm = lf.txtEmploymentTerm.Text;
            _wage =getValue.getDecimalValue(lf.jobPositionAdvisor.txtHourlyRate.Text);

             _jobDuties = lf.
           //  _benefit =

            //  _skillRequirement =
            //  _education =
            //  _workExperience =
            //_languageRequirement =
            // _contactInformation =






        }
        public static void loadFromDB(LMIAForm lf) { }
        public static void fillForm(LMIAForm lf) { }
        public static void clearForm(LMIAForm lf) { }
        public static void deleteRecord(LMIAForm lf) { }
        public static void SaveRecord(LMIAForm lf)
        {
            if (GlobalData.CurrentApplicationId != null)
            {
                getInput(lf);

            }
        }
        public static string getFullAddress(tblCanadianAddress ca)
        {
            if (ca.POBox != string.Empty && ca.Unit != string.Empty)
                return ca.POBox + ", " + ca.Unit + ", " + ca.StreetNo + " " + ca.StreetName + ca.City + "," + Definition.CndProvince[(int)ca.Province] + " " + ca.PostalCode;
            else if (ca.POBox != string.Empty) return ca.POBox + ", " + ca.StreetNo + " " + ca.StreetName + ca.City + "," + Definition.CndProvince[(int)ca.Province] + " " + ca.PostalCode;
            else if (ca.Unit != string.Empty) return ca.Unit + ", " + ca.StreetNo + " " + ca.StreetName + ca.City + "," + Definition.CndProvince[(int)ca.Province] + " " + ca.PostalCode;
            else return ca.StreetNo + " " + ca.StreetName + "," + ca.City + "," + Definition.CndProvince[(int)ca.Province] + " " + ca.PostalCode;

        }
        public static void generatePreview(LMIAForm lf) { }

    }
}
