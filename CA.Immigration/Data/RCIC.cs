using System.Windows.Forms;
using CA.Immigration.Data;
using System.Linq;
using System.Drawing;
using CA.Immigration.Utility;
using System.Collections.Generic;
using System;

namespace CA.Immigration.CICDict
{
    public static class RCIC
    {
        public static string FirstName { get; set; }
        public static string MiddleName { get; set; }
        public static string LastName { get; set; }
        public static string JobTitle { get; set; }
        public static string Telephone { get; set; }
        public static string FaxNumber { get; set; }
        public static string Email { get; set; }
        public static string MembershipID { get; set; }
        public static string BusinessOperatingName { get; set; }
        public static string CRABN { get; set; }
        public static string BusinessLegalName { get; set; }
        public static string ESDCThirdPartyID { get; set; }
        public static string MailingAddress { get; set; }
        public static string BusinessAddress { get; set; }
        public static string City { get; set; }
        public static int Province { get; set; }
        public static string Country { get; set; }
        public static string PostalCode { get; set; }
        public static string MainBizActivities { get; set; }
        public static Image theSignature { get; set; }
        public static string MailPO { get; set; }
        public static string MailAptUnit { get; set; }
        public static string MailStreetNo { get; set; }
        public static string MailStreetName { get; set; }

        public static void loadFromDB()
        {
            if(GlobalData.CurrentRCICId != null)
            {
                using(CommonDataContext cdc = new CommonDataContext())
                {
                    tblRCIC rcic = cdc.tblRCICs.Where(x => x.Id == GlobalData.CurrentRCICId).Select(x => x).FirstOrDefault();
                    FirstName = rcic.FirstName;
                    MiddleName = rcic.MiddleName;
                    LastName = rcic.LastName;
                    JobTitle = rcic.JobTitle;
                    Telephone = rcic.Telephone;
                    FaxNumber = rcic.FaxNumber;
                    Email = rcic.Email;
                    MembershipID = rcic.MembershipID;
                    BusinessOperatingName = rcic.BusinessOperatingName;
                    CRABN = rcic.CRABN;
                    BusinessLegalName = rcic.BusinessLegalName;
                    ESDCThirdPartyID = rcic.ESDCThirdPartyID;
                    MailingAddress = rcic.MailingAddress;
                    BusinessAddress = rcic.BusinessAddress;
                    City = rcic.City;
                    Province = rcic.Province==null?-1:(int)rcic.Province;
                    Country = rcic.Country;
                    PostalCode = rcic.PostalCode;
                    MainBizActivities = rcic.MainBizActivities;
                    theSignature = rcic.theSignature!=null?ImageWork.ByteArrayToImage(rcic.theSignature.ToArray()):null;
                    MailPO = rcic.MailPO;
                    MailAptUnit = rcic.MailAptUnit;
                    MailStreetNo = rcic.MailStreetNo;
                    MailStreetName = rcic.MailStreetName;
                }


            }
            else MessageBox.Show("There is no RCIC assigned");

        }
        public static void buildupDict5575(ref Dictionary<string,string> dict)
        {
            loadFromDB();
            // Add RCIC company information
            dict.Add("EMP5575_E[0].Page1[0].txtF_Emp_ID[0]", ESDCThirdPartyID);
            dict.Add("EMP5575_E[0].Page1[0].txtF_Bus_Number1[0]", CRABN);
            dict.Add("EMP5575_E[0].Page1[0].txtF_Bus_Name[0]", BusinessOperatingName);
            dict.Add("EMP5575_E[0].Page1[0].txtF_Emp_Legal[0]", BusinessLegalName);
            dict.Add("EMP5575_E[0].Page1[0].txtF_Mail_Adress[0]", MailingAddress);
            dict.Add("EMP5575_E[0].Page1[0].txtF_City[0]", City);
            dict.Add("EMP5575_E[0].Page1[0].txtF_City[3]", MainBizActivities);
            dict.Add("EMP5575_E[0].Page1[0].txtF_Province[2]", Definition.CndProvince[(int)Province]);
            dict.Add("EMP5575_E[0].Page1[0].txtF_Province[3]", Country);
            dict.Add("EMP5575_E[0].Page1[0].txtF_Country[1]", PostalCode);
            // Add RCIC personal information
            dict.Add("EMP5575_E[0].Page2[0].Page2[0].txtF_Prim_Contact_Name[0]", FirstName);
            dict.Add("EMP5575_E[0].Page2[0].Page2[0].txtF_Prim_Contact_Middle[0]", MiddleName);
            dict.Add("EMP5575_E[0].Page2[0].Page2[0].txtF_Prim_Contact_last_Name[0]", LastName);
            dict.Add("EMP5575_E[0].Page2[0].Page2[0].txtF_Job_Title[0]", JobTitle);
            dict.Add("EMP5575_E[0].Page2[0].Page2[0].txtF_Contact_Tel[0]", Telephone);
            dict.Add("EMP5575_E[0].Page2[0].Page2[0].txtF_Fax[0]", FaxNumber);
            dict.Add("EMP5575_E[0].Page2[0].Page2[0].txtF_Email[0]", Email);
            dict.Add("EMP5575_E[0].Page2[0].Page2[0].rb_language[0]", "1");
            dict.Add("EMP5575_E[0].Page2[0].Page2[0].txtF_Third_Party_Print_Name[0]", FirstName + " " + LastName);
            dict.Add("EMP5575_E[0].Page2[0].Page2[0].txtF_Today_Date_2[0]", String.Format("{0:yyyy-MM-dd}", DateTime.Today));
            dict.Add("EMP5575_E[0].Page2[0].Page2[0].cb_1[0]", "1");  // Paid RCIC
            dict.Add("EMP5575_E[0].Page2[0].Page2[0].txtF_membership_ID1[0]", MembershipID);
            
        }

        public static void buildupDict5602(ref Dictionary<string, string> dict)
        {
            loadFromDB();
           
            // Add Third party information. Default is no recruiter and have RCIC
            dict.Add("EMP5602_E[0].Page2[0].txtF_Name_of_third_party_rep[0]", FirstName+" "+ LastName);
            dict.Add("EMP5602_E[0].Page2[0].No[0]","1");  // did hire 3rd party recruiter?
            dict.Add("EMP5602_E[0].Page2[0].Yes[0]","0");
            dict.Add("EMP5602_E[0].Page2[0].txtF_Name_of_third_party_recruiter[0]","N/A");
            dict.Add("EMP5602_E[0].Page2[0].txtF_Registration_Number[0]","N/A");
            dict.Add("EMP5602_E[0].Page2[0].No[1]","0");  // did you hire 3rd party representatvie?  YES
            dict.Add("EMP5602_E[0].Page2[0].Yes[1]","1");
            dict.Add("EMP5602_E[0].Page2[0].Yes_E[0]","0");  // Did you charge TFW for hiring him/her?
            dict.Add("EMP5602_E[0].Page2[0].No_E[0]","1");

        }
        public static void buildupDict5593(ref Dictionary<string, string> dict)
        {
            loadFromDB();

        }

    }
}
