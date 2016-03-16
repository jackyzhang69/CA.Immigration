using CA.Immigration.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA.Immigration.Startup
{
    public class Employer
    {
        private static string _ESDCId { get; set; }
        private static string _CRA_BN { get; set; }
        private static string _LegalName { get; set; }
        private static string _OperatingName { get; set; }
        private static string _FranchiseName { get; set; }
        private static bool _FranchiseAware { get; set; }
        private static int _CompanyType { get; set; }
        private static string _MailingAddress { get; set; }
        private static string _MailingCity { get; set; }
        private static int _MailingProvince { get; set; }
        private static string _MailingCountry { get; set; }
        private static string _MailingPostalCode { get; set; }
        private static string _BizAddress { get; set; }
        private static string _BizCity { get; set; }
        private static int _BizProvince { get; set; }
        private static string _BizCountry { get; set; }
        private static string _BizPostalCode { get; set; }
        private static string _BizTelephone { get; set; }
        private static string _Website { get; set; }
        private static DateTime? _BizStartDate { get; set; }
        private static string _BizActivity { get; set; }
        private static string _ContactFirstName { get; set; }
        private static string _ContactMiddleName { get; set; }
        private static string _ContactLastName { get; set; }
        private static string _ContactJobTitle { get; set; }
        private static string _ContactPhone { get; set; }
        private static string _ContactFax { get; set; }
        private static string _ContactEmail { get; set; }
        private static string _theWitness { get; set; }

        public static void getInput(StartupForm sf)
        {
            _ESDCId = sf.txtESDCId.Text;
            _CRA_BN = sf.txtCRABN.Text;
            _LegalName = sf.txtLegalName.Text;
            _OperatingName = sf.txtOperatingName.Text;
            _OperatingName = sf.txtOperatingName.Text;
            _FranchiseName = sf.txtFranchise.Text;
            _CompanyType = sf.BEIcompanyType.cmbCompanyType.SelectedIndex != -1 ? sf.BEIcompanyType.cmbCompanyType.SelectedIndex + 1 : -1; //index 0 is corporate
            _MailingAddress = sf.txtMailAddress.Text;
            _MailingCity = sf.txtMailCity.Text;
            _MailingProvince = sf.canadaProvincesMail.cmbProvince.SelectedIndex != -1 ? sf.canadaProvincesMail.cmbProvince.SelectedIndex : -1;
            _MailingCountry = sf.txtCountryMail.Text;
            _MailingPostalCode = sf.txtPostalMail.Text;
            _BizAddress = sf.txtBusinessAddress.Text;
            _BizProvince = sf.canadaProvincesBusiness.cmbProvince.SelectedIndex != -1 ? sf.canadaProvincesBusiness.cmbProvince.SelectedIndex : -1;
            _BizCountry = sf.txtBusinessCountry.Text;
            _BizPostalCode = sf.txtPostalBusiness.Text;
            _BizTelephone = sf.txtEBIPhone.Text;
            _Website = sf.txtEBIWebsite.Text;
            _BizStartDate = sf.dtpBusinessStartDate.Value;
            _BizActivity = sf.txtEBIBusinessActivities.Text;
            _ContactFirstName = sf.txtEBIFirstName.Text;
            _ContactMiddleName = sf.txtEBIMiddleName.Text;
            _ContactLastName = sf.txtEBILastName.Text;
            _ContactJobTitle = sf.txtEBIJobTitle.Text;
            _ContactPhone = sf.txtEBIPrimaryContactPhone.Text;
            _ContactEmail = sf.txtEBIPrimaryContactEmail.Text;
            _ContactFax = sf.txteBIPrimaryContactFax.Text;


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
                    _LegalName = emp.LegalName;
                    _OperatingName = emp.OperatingName;
                    _FranchiseName = emp.FranchiseName;
                    _CompanyType = emp.CompanyType == null ? 0 : (int)emp.CompanyType;
                    _MailingAddress = emp.MailingAddress;
                    _MailingCity = emp.MailingCity;
                    _MailingProvince = emp.MailingProvince == null ? 0 : (int)emp.MailingProvince;
                    _MailingCountry = emp.MailingCountry;
                    _MailingPostalCode = emp.MailingPostalCode;
                    _BizAddress = emp.BizAddress;
                    _BizCity = emp.BizCity;
                    _BizProvince = emp.BizProvince == null ? 0 : (int)emp.BizProvince;
                    _BizCountry = emp.BizCountry;
                    _BizPostalCode = emp.BizPostalCode;
                    _BizTelephone = emp.BizTelephone;
                    _Website = emp.Website;
                    _BizStartDate = emp.BizStartDate == null ? null : emp.BizStartDate;
                    _BizActivity = emp.BizActivity;
                    _ContactFirstName = emp.ContactFirstName;
                    _ContactMiddleName = emp.ContactMiddleName;
                    _ContactLastName = emp.ContactLastName;
                    _ContactJobTitle = emp.ContactJobTitle;
                    _ContactPhone = emp.ContactPhone;
                    _ContactFax = emp.ContactFax;
                    _ContactEmail = emp.ContactEmail;
                }

            }

        }
        public static void clearForm(StartupForm sf)
        {
            _ESDCId = null;
            _CRA_BN = null;
            _LegalName = null;
            _OperatingName = null;
            _FranchiseName = null;
            _FranchiseAware = false;
            _CompanyType = 1;
            _MailingAddress = null;
            _MailingCity = null;
            _MailingProvince = -1;
            _MailingCountry = null;
            _MailingPostalCode = null;
            _BizAddress = null;
            _BizCity = null;
            _BizProvince = -1;
            _BizCountry = null;
            _BizPostalCode = null;
            _BizTelephone = null;
            _Website = null;
            _BizStartDate = DateTime.Today;
            _BizActivity = null;
            _ContactFirstName = null;
            _ContactMiddleName = null;
            _ContactLastName = null;
            _ContactJobTitle = null;
            _ContactPhone = null;
            _ContactFax = null;
            _ContactEmail = null;
            _theWitness = null;
            fillForm(sf);

        }
        public static void fillForm(StartupForm sf)
        {
            sf.txtESDCId.Text = _ESDCId;
            sf.txtCRABN.Text = _CRA_BN;
            sf.txtLegalName.Text = _LegalName;
            sf.txtOperatingName.Text = _OperatingName;
            sf.txtOperatingName.Text = _OperatingName;
            sf.txtFranchise.Text = _FranchiseName;
            sf.BEIcompanyType.cmbCompanyType.SelectedIndex = _CompanyType - 1;
            sf.txtMailAddress.Text = _MailingAddress;
            sf.txtMailCity.Text = _MailingCity;
            sf.canadaProvincesMail.cmbProvince.SelectedIndex = _MailingProvince;
            sf.txtCountryMail.Text = _MailingCountry;
            sf.txtPostalMail.Text = _MailingPostalCode;
            sf.txtBusinessAddress.Text = _BizAddress;
            sf.canadaProvincesBusiness.cmbProvince.SelectedIndex = _BizProvince;
            sf.txtBusinessCountry.Text = _BizCountry;
            sf.txtPostalBusiness.Text = _BizPostalCode;
            sf.txtEBIPhone.Text = _BizTelephone;
            sf.txtEBIWebsite.Text = _Website;
            if(_BizStartDate == null) sf.dtpBusinessStartDate.CustomFormat = "";
            else sf.dtpBusinessStartDate.Value = (DateTime)_BizStartDate;
            sf.txtEBIBusinessActivities.Text = _BizActivity;
            sf.txtEBIFirstName.Text = _ContactFirstName;
            sf.txtEBIMiddleName.Text = _ContactMiddleName;
            sf.txtEBILastName.Text = _ContactLastName;
            sf.txtEBIJobTitle.Text = _ContactJobTitle;
            sf.txtEBIPrimaryContactPhone.Text = _ContactPhone;
            sf.txtEBIPrimaryContactEmail.Text = _ContactEmail;
            sf.txteBIPrimaryContactFax.Text = _ContactFax;

        }
        public static void employerInsert(StartupForm sf)
        {
            // insert a row
            using(CommonDataContext cdc = new CommonDataContext())
            {
                getInput(sf);
                tblEmployer emp = new tblEmployer
                {
                    ESDCId = _ESDCId,
                    CRA_BN = _CRA_BN,
                    LegalName = _LegalName,
                    OperatingName = _OperatingName,
                    FranchiseName = _FranchiseName,
                    CompanyType = _CompanyType, //index 0 is corporate
                    MailingAddress = _MailingAddress,
                    MailingCity = _MailingCity,
                    MailingProvince = _MailingProvince,
                    MailingCountry = _MailingCountry,
                    MailingPostalCode = _MailingPostalCode,
                    BizAddress = _BizAddress,
                    BizCity = _BizCity,
                    BizProvince = _BizProvince,
                    BizCountry = _BizCountry,
                    BizPostalCode = _BizPostalCode,
                    BizTelephone = _BizTelephone,
                    Website = _Website,
                    BizStartDate = _BizStartDate,
                    BizActivity = _BizActivity,
                    ContactFirstName = _ContactFirstName,
                    ContactMiddleName = _ContactMiddleName,
                    ContactLastName = _ContactLastName,
                    ContactJobTitle = _ContactJobTitle,
                    ContactPhone = _ContactPhone,
                    ContactEmail = _ContactEmail,
                    ContactFax = _ContactFax
                };
                try
                {
                    cdc.tblEmployers.InsertOnSubmit(emp);
                    cdc.SubmitChanges();
                    MessageBox.Show("Record has been saved into Database!");
                    sf.btnEBIInsert.Visible = false;
                    if(GlobalData.CurrentEmployerIdReadOnly == true) GlobalData.CurrentEmployerId = emp.Id;
                    else MessageBox.Show("There are someone working with employer, please quit that application");

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
                    tblEmployer emp = cdc.tblEmployers.Where(x => x.Id == GlobalData.CurrentEmployerId).Select(x => x).FirstOrDefault();
                    emp.ESDCId = _ESDCId;
                    emp.CRA_BN = _CRA_BN;
                    emp.LegalName = _LegalName;
                    emp.OperatingName = _OperatingName;
                    emp.FranchiseName = _FranchiseName;
                    emp.CompanyType = _CompanyType;
                    emp.MailingAddress = _MailingAddress;
                    emp.MailingCity = _MailingCity;
                    emp.MailingProvince = _MailingProvince;
                    emp.MailingCountry = _MailingCountry;
                    emp.MailingPostalCode = _MailingPostalCode;
                    emp.BizAddress = _BizAddress;
                    emp.BizCity = _BizCity;
                    emp.BizProvince = _BizProvince;
                    emp.BizCountry = _BizCountry;
                    emp.BizPostalCode = _BizPostalCode;
                    emp.BizTelephone = _BizTelephone;
                    emp.Website = _Website;
                    emp.BizStartDate = _BizStartDate;
                    emp.BizActivity = _BizActivity;
                    emp.ContactFirstName = _ContactFirstName;
                    emp.ContactMiddleName = _ContactMiddleName;
                    emp.ContactLastName = _ContactLastName;
                    emp.ContactJobTitle = _ContactJobTitle;
                    emp.ContactPhone = _ContactPhone;
                    emp.ContactFax = _ContactFax;
                    emp.ContactEmail = _ContactEmail;

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
            dict.Add("EMP5575_E[0].Page3[0].txtF_Employer_Name[0]", _ContactFirstName + " " + _ContactLastName);
            dict.Add("EMP5575_E[0].Page3[0].txtF_Employer_Address[0]", _BizAddress + ", " + _BizCity + ", " + Definition.CndProvince[(int)_BizProvince, 0] + ", " + _BizPostalCode);
            dict.Add("EMP5575_E[0].Page3[0].txtF_Employer_Telephone[0]", _BizTelephone);
            dict.Add("EMP5575_E[0].Page3[0].txtF_Employer_Name[1]", "N/A");  // secondary contact
            dict.Add("EMP5575_E[0].Page3[0].txtF_Print_Name[0]", _ContactFirstName + " " + _ContactLastName);
            dict.Add("EMP5575_E[0].Page3[0].txtF_Today_Date_2[0]", String.Format("{0:yyyy-MM-dd}", DateTime.Today));
            dict.Add("EMP5575_E[0].Page3[0].txtF_Print_Name[2]", _theWitness);
            dict.Add("EMP5575_E[0].Page3[0].txtF_Today_Date_2[2]", String.Format("{0:yyyy-MM-dd}", DateTime.Today));
        }
    }
}

