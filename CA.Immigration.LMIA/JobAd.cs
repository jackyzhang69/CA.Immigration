using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CA.Immigration.Data;
namespace CA.Immigration.LMIA
{
    public class JobAd
    {
        private static string _operatingNam;
        private static string _businessAddress;
        private static string _positionTitle;
        private static string _workLocation;
        private static string _employmentTerm;
        private static decimal _wage;
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

        private static string _businessPO;
        private static string _businessUnit;
        private static string _businessStreetNo;
        private static string _businessStreetName;
        private static string _businessCity;
        private static int _businessProvince;

        private static string _mailPO;
        private static string _mailUnit;
        private static string _mailStreetNo;
        private static string _mailStreetName;
        private static string _mailCity;
        private static int _mailProvince;


        public static void getInput(LMIAForm lf) { }
        public static void loadFromDB(LMIAForm lf) { }
        public static void fillForm(LMIAForm lf) { }
        public static void clearForm(LMIAForm lf) { }
        public static void deleteRecord(LMIAForm lf) { }
        public static void SaveRecord(LMIAForm lf)
        {
            if(GlobalData.CurrentApplicationId!=null)
            {
                getInput(lf);
                using(CommonDataContext cdc=new CommonDataContext())
                {
                    int? mailAddId = cdc.tblEmployers.Where(x => x.Id == GlobalData.CurrentEmployerId).Select(x => x.MailAddressId).FirstOrDefault();
                    int? bizAddId= cdc.tblEmployers.Where(x => x.Id == GlobalData.CurrentEmployerId).Select(x => x.BizAddressId).FirstOrDefault();
                    if(mailAddId != null) {
                        tblCanadianAddress ca = cdc.tblCanadianAddresses.Where(x => x.Id == mailAddId).Select(x => x).FirstOrDefault();
                        ca.POBox = _mailPO;
                        ca.Unit = _mailUnit;
                        ca.StreetNo = _mailStreetNo;
                        ca.StreetName = _mailStreetName;
                        ca.City = _mailCity;
                        ca.Province = _mailProvince;
                        try
                        {
                            cdc.SubmitChanges();
                            MessageBox.Show("Mail address has been saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch(Exception exc)
                        {
                            MessageBox.Show(exc.Message);
                        }

                    }
                    else MessageBox.Show("There is no mail address record existing");
                    if(bizAddId != null)
                    {
                        tblCanadianAddress ca = cdc.tblCanadianAddresses.Where(x => x.Id == bizAddId).Select(x => x).FirstOrDefault();
                        ca.POBox = _businessPO;
                        ca.Unit = _businessUnit;
                        ca.StreetNo = _businessStreetNo;
                        ca.StreetName = _businessStreetName;
                        ca.City = _businessCity;
                        ca.Province = _businessProvince;
                        try
                        {
                            cdc.SubmitChanges();
                            MessageBox.Show("Business address has been saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch(Exception exc)
                        {
                            MessageBox.Show(exc.Message);
                        }

                    }
                    else MessageBox.Show("There is no business address record existing");

                    // update work location address based on LIMA application
                    int? workAddId = cdc.tblLMIAApplications.Where(x => x.Id == GlobalData.CurrentApplicationId).Select(x => x.WorkLocationId).FirstOrDefault();
                    if(workAddId != null)
                    {
                        tblCanadianAddress ca = cdc.tblCanadianAddresses.Where(x => x.Id == workAddId).Select(x => x).FirstOrDefault();
                        ca.POBox = _workLocationPO;
                        ca.Unit = _workLocationUnit;
                        ca.StreetNo = _workLocationStreetNo;
                        ca.StreetName = _workLocationStreetName;
                        ca.City = _workLocationCity;
                        ca.Province = _workLocationProvince;
                        try
                        {
                            cdc.SubmitChanges();
                            MessageBox.Show("Work location address has been saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch(Exception exc)
                        {
                            MessageBox.Show(exc.Message);
                        }

                    }
                    else MessageBox.Show("There is no work location address record existing");
                }
            }
        }
        public static void generatePreview(LMIAForm lf) { }

    }
}
