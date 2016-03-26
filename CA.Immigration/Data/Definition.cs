﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA.Immigration.Data
{
    public class Definition
    {
        public static Dictionary<int, string> LMIAEduLevel = new Dictionary<int, string>
        {
            {0,"Doctorate/PhD"},
            {1,"Doctor of Medicine"},
            {2,"Master's Degree"},
            {3,"Bachelor's Degree"},
            {4,"College level diploma/certificate"},
            {5,"Apprenticeship diploma/certificate"},
            {6,"Trade diploma/certificate"},
            {7,"Secondary school"},
            {8,"Vocational school diploma/certificate"},
            {9,"No formal education requirement"}
        };

        public static Dictionary<int, string> LMIABenefit = new Dictionary<int, string>
        {
            {0,"Disability insurance"},
            {1,"Dental insurance"},
            {2,"Pension"},
            {3,"Extended medical insurance"},
            {4,"Other"}
        };

        public static Dictionary<int, string> DurationUnit = new Dictionary<int, string>
        {
            { -1,"No Selection"},
            {0,"Days"},
            {1,"Weeks"},
            {2,"Months"},
            {3,"Years"},
            {4,"Permanent"},
        };

        public static Dictionary<int, string> AddressType = new Dictionary<int, string> {
            {-1,"No Selection"},
            { 0,"Residential" },
            {1,"Business" },
            {2,"Mailing" },
            {3,"Work Location"}
        };
        public static Dictionary<int, string> Gender = new Dictionary<int, string> {
             {-1,"No Selection"},
            {0,"Male" },
            {1,"Female" },
            {2,"Unknown" }
        };
        public static Dictionary<string, string> MarriageStatus = new Dictionary<string, string> {
            {"09", "Annulled Marriage" },
            {"03", "Common-Law" },
            {"04","Divorced" },
            {"05", "Legally Separated"},
            {"01", "Married"},
            {"02", "Single" },
            {"00","Unknown" },
            {"06", "Widowed" }
        };

        public static Dictionary<int, string> CompanyType = new Dictionary<int, string> {
             {-1,"No Selection"},
            { 0,"Incorporated" },
            { 1,"Partner" },
            { 2,"Solo Proprietor" },
            { 3,"Other" }
        };
        public static Dictionary<int, string> CndProvince = new Dictionary<int, string> {
            {-1,"No Selection"},
            {0,"AB"},
            {1,"BC"},
            {2,"MB"},
            {3,"NB"},
            {4,"NL"},
            {5,"NS"},
            {6,"NT"},
            {7,"NU"},
            {8,"ON"},
            {9,"PE"},
            {10,"QC"},
            {11,"SK"},
            {12,"YT" }
        };
        public static Dictionary<string, string> CanadaStatus = new Dictionary<string, string> {
            {"01", "Citizen" },
            {"02", "Permanent resident"},
            {"03", "Visitor"},
            {"04", "Worker"},
            {"05", "Student"},
            {"06", "Other"},
            {"07", "Protected Person"},
            {"08", "Refugee Claimant" }
        };

        public static Dictionary<int, string> ResidenceType = new Dictionary<int, string>
        {
            {-1,"No Selection"},
            { 0,"Current"},
            {1,"Previous"},
            {2,"Country where applying"}
        };
        public static Dictionary<int, string> LMIAStream = new Dictionary<int, string> {
        {0,"High Wage Stream"},
        {1,"Low Wage Stream"}
         };
        public static Dictionary<int, string> LMIA11Factors = new Dictionary<int, string>
       {
            {-1,"No Selection"},
            {0,"Job Creation / Job Retention of Canadians" },
            {1,"Development or Transfer of Skills and Knowledge" },
            {2,"Filling a Labour Shortage" },
            {3,"prevailing Wage Rate Offered"},
            {4,"Reasonable Efforts to Hire or Train Canadians"},
            {5,"Labour Dispute Settlements Unaffected" },
            {6,"Employer’s Commitments Fulfilled" },
            {7,"Employer is Actively Engaged in Business of Offered Position" },
            {8,"Offer is Consistent with Reasonable Employment Need" },
            {9,"Reasonably Able to Fulfill Terms of Offer" },
            {10,"Past Compliance" }
       };
    }
}