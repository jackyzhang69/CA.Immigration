using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CA.Immigration.Data;
using CA.Immigration.Utility;

namespace CA.Immigration.Startup
{
    public class Employer
    {
        private static string _ESDCId;
        private static string _CRA_BN;
        private static string _legalName;
        private static string _operatingName;
        private static string _franchiseName;
        private static bool _franchiseAware;
        private static int _companyType;
        private static string _mailPO;
        private static string _mailUnit;
        private static string _mailStreetNo;
        private static string _mailStreetName;
        private static string _mailCity;
        private static int _mailProvince;
        private static string _mailingCountry;
        private static string _mailPostalCode;
        private static bool _chkBizSameAsMail;

        private static string _businessPO;
        private static string _businessUnit;
        private static string _businessStreetNo;
        private static string _businessStreetName;
        private static string _businessCity;
        private static int _businessProvince;
        private static string _businessCountry;
        private static string _businessPostalCode;
        private static string _bizTelephone;
        private static string _website;
        private static DateTime? _bizStartDate;
        private static string _bizActivity;
        private static string _contactFirstName;
        private static string _contactMiddleName;
        private static string _contactLastName;
        private static string _contactJobTitle;
        private static string _contactPhone;
        private static string _contactFax;
        private static string _contactEmail;
        private static string _theWitness;

        public static void getInput(StartupForm sf)
        {
            _ESDCId = sf.txtESDCId.Text;
            _CRA_BN = sf.txtCRABN.Text;
            _legalName = sf.txtLegalName.Text;
            _operatingName = sf.txtOperatingName.Text;
            _operatingName = sf.txtOperatingName.Text;
            _franchiseName = sf.txtFranchise.Text;
            _companyType = sf.BEIcompanyType.cmbCompanyType.SelectedIndex != -1 ? sf.BEIcompanyType.cmbCompanyType.SelectedIndex : -1; //index 0 is corporate
            _mailPO = sf.txtEBIPOBoxMail.Text;
            _mailUnit = sf.txtEBIAptMail.Text;
            _mailStreetNo = sf.txtEBIStreetNoMail.Text;
            _mailStreetName = sf.txtEBIStreetNameMail.Text;
            _mailCity = sf.txtEBIMailCity.Text;
            _mailProvince = sf.canadaProvincesMail.cmbProvince.SelectedIndex != -1 ? sf.canadaProvincesMail.cmbProvince.SelectedIndex : -1;
            _mailingCountry = sf.txtEBICountryMail.Text;
            _mailPostalCode = sf.txtEBIPostalMail.Text;
            _chkBizSameAsMail = sf.chkBizSameAsMail.Checked;
            if(_chkBizSameAsMail == false)
            {
                _businessPO = sf.txtEBIPOBoxBiz.Text;
                _businessUnit = sf.txtEBIAptBiz.Text;
                _businessStreetNo = sf.txtEBIStreetNoBiz.Text;
                _businessStreetName = sf.txtEBIStreetNameBiz.Text;
                _businessCity = sf.txtEBIBusinessCity.Text;
                _businessProvince = sf.canadaProvincesBusiness.cmbProvince.SelectedIndex != -1 ? sf.canadaProvincesBusiness.cmbProvince.SelectedIndex : -1;
                _businessCountry = sf.txtEBIBusinessCountry.Text;
                _businessPostalCode = sf.txtEBIPostalBusiness.Text;
            }
            else {
                _businessPO = _mailPO;
                _businessUnit = _mailUnit;
                _businessStreetNo = _mailStreetNo;
                _businessStreetName = _mailStreetName;
                _businessCity = _mailCity;
                _businessProvince = _mailProvince;
                _businessCountry = _mailingCountry;
                _businessPostalCode = _mailPostalCode;
            }
            _bizTelephone = sf.txtEBIPhone.Text;
            _website = sf.txtEBIWebsite.Text;
            _bizStartDate = sf.dtpBusinessStartDate.Value;
            _bizActivity = sf.txtEBIBusinessActivities.Text;
            _contactFirstName = sf.txtEBIFirstName.Text;
            _contactMiddleName = sf.txtEBIMiddleName.Text;
            _contactLastName = sf.txtEBILastName.Text;
            _contactJobTitle = sf.txtEBIJobTitle.Text;
            _contactPhone = sf.txtEBIPrimaryContactPhone.Text;
            _contactEmail = sf.txtEBIPrimaryContactEmail.Text;
            _contactFax = sf.txteBIPrimaryContactFax.Text;


        }
        public static void loadFromDB()
        {
            using(CommonDataContext cdc = new CommonDataContext())
            {
                if(GlobalData.CurrentEmployerId != null)
                {
                    tblEmployer emp = cdc.tblEmployers.Where(x => x.Id == GlobalData.CurrentEmployerId).Select(x => x).FirstOrDefault();
                    _ESDCId = emp.ESDCId;
                    _CRA_BN = emp.CRA_BN;
                    _legalName = emp.LegalName;
                    _operatingName = emp.OperatingName;
                    _franchiseName = emp.FranchiseName;
                    _companyType = emp.CompanyType == null ? -1 : (int)emp.CompanyType;

                    if(emp.MailAddressId == emp.BizAddressId)
                    {
                        if(emp.MailAddressId != null)
                        {
                            tblCanadianAddress ca = cdc.tblCanadianAddresses.Where(x => x.Id == emp.MailAddressId).Select(x => x).FirstOrDefault();
                            _mailPO = ca.POBox;
                            _mailUnit = ca.Unit;
                            _mailStreetNo = ca.StreetNo;
                            _mailStreetName = ca.StreetName;
                            _mailCity = ca.City;
                            _mailProvince = ca.Province == null ? 0 : (int)ca.Province;
                            _mailingCountry = "Canada";
                            _mailPostalCode = ca.PostalCode;
                            _businessPO = _mailPO;
                            _businessUnit = _mailUnit;
                            _businessStreetNo = _mailStreetNo;
                            _businessStreetName = _mailStreetName;
                            _businessCity = _mailCity; ;
                            _businessProvince = _mailProvince;
                            _businessCountry = "Canada";
                            _businessPostalCode = _mailPostalCode;
                        }
                    }
                    else {
                        if(emp.MailAddressId != null && emp.BizAddressId != null)
                        {
                            tblCanadianAddress ca = cdc.tblCanadianAddresses.Where(x => x.Id == emp.MailAddressId).Select(x => x).FirstOrDefault();
                            tblCanadianAddress caB = cdc.tblCanadianAddresses.Where(x => x.Id == emp.BizAddressId).Select(x => x).FirstOrDefault();
                            _mailPO = ca.POBox;
                            _mailUnit = ca.Unit;
                            _mailStreetNo = ca.StreetNo;
                            _mailStreetName = ca.StreetName;
                            _mailCity = ca.City;
                            _mailProvince = ca.Province == null ? 0 : (int)ca.Province;
                            _mailingCountry = "Canada";
                            _mailPostalCode = ca.PostalCode;
                            _businessPO = caB.POBox;
                            _businessUnit = caB.Unit;
                            _businessStreetNo = caB.StreetNo;
                            _businessStreetName = caB.StreetName;
                            _businessCity = caB.City; ;
                            _businessProvince = caB.Province == null ? 0 : (int)caB.Province;
                            _businessCountry = "Canada";
                            _businessPostalCode = caB.PostalCode;
                        }
                    }
                    _bizTelephone = emp.BizTelephone;
                    _website = emp.Website;
                    _bizStartDate = emp.BizStartDate == null ? null : emp.BizStartDate;
                    _bizActivity = emp.BizActivity;
                    _contactFirstName = emp.ContactFirstName;
                    _contactMiddleName = emp.ContactMiddleName;
                    _contactLastName = emp.ContactLastName;
                    _contactJobTitle = emp.ContactJobTitle;
                    _contactPhone = emp.ContactPhone;
                    _contactFax = emp.ContactFax;
                    _contactEmail = emp.ContactEmail;
                    if(_mailPO == _businessPO && _mailUnit == _businessUnit && _mailStreetNo == _businessStreetNo && _mailStreetName == _businessStreetName && _mailCity == _businessCity && _mailingCountry == _businessCountry && _mailPostalCode == _businessPostalCode && _mailProvince == _businessProvince) _chkBizSameAsMail = true;
                }

            }

        }
        public static void clearForm(StartupForm sf)
        {
            _ESDCId = null;
            _CRA_BN = null;
            _legalName = null;
            _operatingName = null;
            _franchiseName = null;
            _franchiseAware = false;
            _companyType = 0;
            _mailPO = null;
            _mailUnit = null;
            _mailStreetNo = null;
            _mailStreetName = null;
            _mailCity = null;
            _mailProvince = -1;
            _mailingCountry = null;
            _mailPostalCode = null;
            _chkBizSameAsMail = false;
            _businessPO = null;
            _businessUnit = null;
            _businessStreetNo = null;
            _businessStreetName = null;
            _businessCity = null;
            _businessProvince = -1;
            _businessCountry = null;
            _businessPostalCode = null;
            _bizTelephone = null;
            _website = null;
            _bizStartDate = DateTime.Today;
            _bizActivity = null;
            _contactFirstName = null;
            _contactMiddleName = null;
            _contactLastName = null;
            _contactJobTitle = null;
            _contactPhone = null;
            _contactFax = null;
            _contactEmail = null;
            _theWitness = null;
            fillForm(sf);

        }
        public static void fillForm(StartupForm sf)
        {
            sf.txtESDCId.Text = _ESDCId;
            sf.txtCRABN.Text = _CRA_BN;
            sf.txtLegalName.Text = _legalName;
            sf.txtOperatingName.Text = _operatingName;
            sf.txtOperatingName.Text = _operatingName;
            sf.txtFranchise.Text = _franchiseName;
            sf.BEIcompanyType.cmbCompanyType.SelectedIndex = _companyType;


            sf.txtEBIPOBoxMail.Text = _mailPO;
            sf.txtEBIAptMail.Text = _mailUnit;
            sf.txtEBIStreetNoMail.Text = _mailStreetNo;
            sf.txtEBIStreetNameMail.Text = _mailStreetName;
            sf.txtEBIMailCity.Text = _mailCity;
            sf.canadaProvincesMail.cmbProvince.SelectedIndex = _mailProvince;
            sf.txtEBICountryMail.Text = _mailingCountry;
            sf.txtEBIPostalMail.Text = _mailPostalCode;
            sf.chkBizSameAsMail.Checked = true;

            sf.txtEBIPOBoxBiz.Text = _businessPO;
            sf.txtEBIAptBiz.Text = _businessUnit;
            sf.txtEBIStreetNoBiz.Text = _businessStreetNo;
            sf.txtEBIStreetNameBiz.Text = _businessStreetName;
            sf.canadaProvincesBusiness.cmbProvince.SelectedIndex = _businessProvince;
            sf.txtEBIBusinessCountry.Text = _businessCountry;
            sf.txtEBIPostalBusiness.Text = _businessPostalCode;

            sf.txtEBIPhone.Text = _bizTelephone;
            sf.txtEBIWebsite.Text = _website;
            if(_bizStartDate == null) sf.dtpBusinessStartDate.CustomFormat = "";
            else sf.dtpBusinessStartDate.Value = (DateTime)_bizStartDate;
            sf.txtEBIBusinessActivities.Text = _bizActivity;
            sf.txtEBIFirstName.Text = _contactFirstName;
            sf.txtEBIMiddleName.Text = _contactMiddleName;
            sf.txtEBILastName.Text = _contactLastName;
            sf.txtEBIJobTitle.Text = _contactJobTitle;
            sf.txtEBIPrimaryContactPhone.Text = _contactPhone;
            sf.txtEBIPrimaryContactEmail.Text = _contactEmail;
            sf.txteBIPrimaryContactFax.Text = _contactFax;

        }
        public static void employerInsert(StartupForm sf)
        {
            // insert a row
            StringBuilder sb = new StringBuilder();
            int mailAddrssId;
            int businessAddressId;
            using(CommonDataContext cdc = new CommonDataContext())
            {
                getInput(sf);
                tblCanadianAddress cam = new tblCanadianAddress
                {
                    POBox = _mailPO,
                    Unit = _mailUnit,
                    StreetNo = _mailStreetNo,
                    StreetName = _mailStreetName,
                    City = _mailCity,
                    Province = _mailProvince,
                    PostalCode = _mailPostalCode,
                };
                tblCanadianAddress cab = new tblCanadianAddress
                {
                    POBox = _businessPO,
                    Unit = _businessUnit,
                    StreetNo = _businessStreetNo,
                    StreetName = _businessStreetName,
                    City = _businessCity,
                    Province = _businessProvince,
                    PostalCode = _businessPostalCode,
                };
                try
                {
                    cdc.tblCanadianAddresses.InsertOnSubmit(cam);
                    cdc.tblCanadianAddresses.InsertOnSubmit(cab);
                    cdc.SubmitChanges();
                    mailAddrssId = cam.Id;
                    businessAddressId = cab.Id;
                    sb.Append("Address has been saved \n");
                }
                catch(Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
                tblEmployer emp = new tblEmployer
                {
                    ESDCId = _ESDCId,
                    CRA_BN = _CRA_BN,
                    LegalName = _legalName,
                    OperatingName = _operatingName,
                    FranchiseName = _franchiseName,
                    CompanyType = _companyType, //index 0 is corporate

                    BizTelephone = _bizTelephone,
                    Website = _website,
                    BizStartDate = _bizStartDate,
                    BizActivity = _bizActivity,
                    ContactFirstName = _contactFirstName,
                    ContactMiddleName = _contactMiddleName,
                    ContactLastName = _contactLastName,
                    ContactJobTitle = _contactJobTitle,
                    ContactPhone = _contactPhone,
                    ContactEmail = _contactEmail,
                    ContactFax = _contactFax
                };
                try
                {
                    cdc.tblEmployers.InsertOnSubmit(emp);
                    cdc.SubmitChanges();
                    sb.Append("Employer basic information has been saved");
                    MessageBox.Show(sb.ToString());
                    sf.btnEBIInsert.Visible = false;

                }
                catch(Exception exc)
                {

                    MessageBox.Show(exc.Message);
                }

                // set up global data
                GlobalData.CurrentEmployerId = emp.Id;
            }
        }
        public static void employerUpdate(StartupForm sf)
        {
            using(CommonDataContext cdc = new CommonDataContext())
            {
                if(GlobalData.CurrentEmployerId != null)
                {
                    getInput(sf);
                    tblEmployer emp = cdc.tblEmployers.Where(x => x.Id == GlobalData.CurrentEmployerId).Select(x => x).FirstOrDefault();
                    emp.ESDCId = _ESDCId;
                    emp.CRA_BN = _CRA_BN;
                    emp.LegalName = _legalName;
                    emp.OperatingName = _operatingName;
                    emp.FranchiseName = _franchiseName;
                    emp.CompanyType = _companyType;
                    emp.MailingAddress = _MailingAddress;
                    emp.MailingCity = _mailCity;
                    emp.MailingProvince = _mailProvince;
                    emp.MailingCountry = _mailingCountry;
                    emp.MailingPostalCode = _mailPostalCode;
                    emp.BizAddress = _BizAddress;
                    emp.BizCity = _businessCity;
                    emp.BizProvince = _businessProvince;
                    emp.BizCountry = _businessCountry;
                    emp.BizPostalCode = _businessPostalCode;
                    emp.BizTelephone = _bizTelephone;
                    emp.Website = _website;
                    emp.BizStartDate = _bizStartDate;
                    emp.BizActivity = _bizActivity;
                    emp.ContactFirstName = _contactFirstName;
                    emp.ContactMiddleName = _contactMiddleName;
                    emp.ContactLastName = _contactLastName;
                    emp.ContactJobTitle = _contactJobTitle;
                    emp.ContactPhone = _contactPhone;
                    emp.ContactFax = _contactFax;
                    emp.ContactEmail = _contactEmail;
                    try
                    {
                        cdc.SubmitChanges();
                        MessageBox.Show("Your record has been updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch(Exception exc)
                    {

                        MessageBox.Show(exc.Message);
                    }
                }

            }
        }
        public static void employerDelete(StartupForm sf)
        {
            using(CommonDataContext cdc = new CommonDataContext())
            {

                tblEmployer emp = cdc.tblEmployers.Where(x => x.Id == GlobalData.CurrentEmployerId).Select(x => x).FirstOrDefault();

                if(MessageBox.Show("Do you really want to delete the record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        cdc.tblEmployers.DeleteOnSubmit(emp);
                        cdc.SubmitChanges();
                        MessageBox.Show("The record has been deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GlobalData.CurrentEmployerId = null;

                    }
                    catch(Exception exc)
                    {

                        MessageBox.Show(exc.Message);
                    }

                }

            }
        }

        // Build up emp5575 dictionary
        public static void buildupDict5575(ref Dictionary<string, string> dict)
        {
            loadFromDB();
            dict.Add("EMP5575_E[0].Page3[0].txtF_Employer_Name[0]", _contactFirstName + " " + _contactLastName);
            dict.Add("EMP5575_E[0].Page3[0].txtF_Employer_Address[0]", _BizAddress + ", " + _businessCity + ", " + Definition.CndProvince[(int)_businessProvince] + ", " + _businessPostalCode);
            dict.Add("EMP5575_E[0].Page3[0].txtF_Employer_Telephone[0]", _bizTelephone);
            dict.Add("EMP5575_E[0].Page3[0].txtF_Employer_Fax[0]", _contactFax == string.Empty ? "N/A" : _contactFax);
            dict.Add("EMP5575_E[0].Page3[0].txtF_Employer_Name[1]", "N/A");  // secondary contact
            dict.Add("EMP5575_E[0].Page3[0].txtF_Employer_Address[1]", "N/A");
            dict.Add("EMP5575_E[0].Page3[0].txtF_Employer_Telephone[1]", "N/A");
            dict.Add("EMP5575_E[0].Page3[0].txtF_Employer_Fax[1]", "N/A");
            dict.Add("EMP5575_E[0].Page3[0].txtF_Print_Name[0]", _contactFirstName + " " + _contactLastName);
            dict.Add("EMP5575_E[0].Page3[0].txtF_Today_Date_2[0]", String.Format("{0:yyyy-MM-dd}", DateTime.Today));
            dict.Add("EMP5575_E[0].Page3[0].txtF_Print_Name[2]", _theWitness);
            dict.Add("EMP5575_E[0].Page3[0].txtF_Today_Date_2[2]", String.Format("{0:yyyy-MM-dd}", DateTime.Today));
        }
        public static void buildupDict5602(ref Dictionary<string, string> dict)
        {
            loadFromDB();
            //Business Information
            //dict.Add("EMP5602_E[0].Page1[0].chkB_incorporated[0]");  // company type
            //dict.Add("EMP5602_E[0].Page1[0].chkB_partnership[0]");
            //dict.Add("EMP5602_E[0].Page1[0].chkB_sole_propietor[0]");
            //dict.Add("EMP5602_E[0].Page1[0].chkB_other[0]");
            //dict.Add("EMP5602_E[0].Page1[0].txtF_other[0]");
            dict.Add("EMP5602_E[0].Page1[0].No[0]", _franchiseName == string.Empty ? "1" : "0");
            dict.Add("EMP5602_E[0].Page1[0].Yes[0]", _franchiseName == string.Empty ? "0" : "1");
            dict.Add("EMP5602_E[0].Page1[0].txtF_name_of_corporation[0]", _franchiseName == string.Empty ? "" : _franchiseName);
            //dict.Add("EMP5602_E[0].Page1[0].Yes_E[0]");  // is franchise headquarter knows?
            //dict.Add("EMP5602_E[0].Page1[0].No_E[0]");
            dict.Add("EMP5602_E[0].Page1[0].txtF_Employer_Web_Address[0]", _website);
            dict.Add("EMP5602_E[0].Page1[0].txtF_Employer_Date_Business[0]", String.Format("{0:yyyy-MM-dd }", _bizStartDate));
            dict.Add("EMP5602_E[0].Page1[0].txtF_Business_Activity[0]", _bizActivity);
            dict.Add("EMP5602_E[0].Page1[0].txtF_Emp_ID[0]", _ESDCId);
            dict.Add("EMP5602_E[0].Page1[0].txtF_Bus_Number1[0]", _CRA_BN);
            dict.Add("EMP5602_E[0].Page1[0].txtF_Bus_Name[0]", _legalName);
            dict.Add("EMP5602_E[0].Page1[0].txtF_Emp_Legal[0]", _operatingName);
            dict.Add("EMP5602_E[0].Page1[0].txtF_Mail_Adress[0]", _MailingAddress);
            dict.Add("EMP5602_E[0].Page1[0].txtF_City[0]", _mailCity);
            dict.Add("EMP5602_E[0].Page1[0].txtF_City[1]", _bizTelephone);
            dict.Add("EMP5602_E[0].Page1[0].txtF_Country[0]", _mailingCountry);
            dict.Add("EMP5602_E[0].Page1[0].txtF_Postal_Code[0]", _mailPostalCode);
            dict.Add("EMP5602_E[0].Page1[0].txtF_Province[0]", _mailProvince != -1 ? Definition.CndProvince[_mailProvince] : "");
            dict.Add("EMP5602_E[0].Page1[0].txtF_City[2]", _businessCity);
            dict.Add("EMP5602_E[0].Page1[0].txtF_Province[1]", _businessProvince != -1 ? Definition.CndProvince[_businessProvince] : "");
            dict.Add("EMP5602_E[0].Page1[0].txtF_Country[1]", _businessCountry);
            dict.Add("EMP5602_E[0].Page1[0].txtF_Postal_Code[1]", _businessPostalCode);
            dict.Add("EMP5602_E[0].Page1[0].txtF_Emp_Buss_Adress[0]", _BizAddress);
            dict.Add("EMP5602_E[0].Page2[0].txtF_Prim_Contact_Name[0]", _contactFirstName);
            dict.Add("EMP5602_E[0].Page2[0].txtF_Prim_Contact_Middle[0]", _contactMiddleName);
            dict.Add("EMP5602_E[0].Page2[0].txtF_Prim_Contact_last_Name[0]", _contactLastName);
            dict.Add("EMP5602_E[0].Page2[0].txtF_Job_Title[0]", _contactJobTitle);
            dict.Add("EMP5602_E[0].Page2[0].txtF_Contact_Tel[0]", _contactPhone);
            dict.Add("EMP5602_E[0].Page2[0].txtF_Fax[0]", _contactFax == string.Empty ? "N/A" : _contactFax);
            dict.Add("EMP5602_E[0].Page2[0].txtF_Email[0]", _contactEmail);
            dict.Add("EMP5602_E[0].Page2[0].rb_language[0]", "1");

        }
    }
}

