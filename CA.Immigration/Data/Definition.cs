using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA.Immigration.Data
{
    public class Definition
    {
        public static string[,] CompanyType = new string[,] {
            { "1","Incorporated" },
            { "2","Partner" },
            { "3","Solo Proprietor" }
        };

        public static string[,] CndProvince = new string[,] {

        {"AB","Alberta" },
        {"BC","British Columbia"},
        {"MB","Manitoba" },
        {"NB"," New Brunswick" },
        {"NL","Newfoundland and Labrador" },
        {"NS","Nova Scotia" },
        {"NT","Northwest Territories" },
        {"NU","Nunavut" },
        {"ON","Ontario"},
        {"PE","Prince Edward Island" },
        {"QC","Quebec" },
        {"SK","Saskatchewan" },
        {"YT","Yukon" }
        };
        public static string[,] LMIA11Factors = new string[,]
        {
            {"0","Job Creation / Job Retention of Canadians" },
            {"0","Development or Transfer of Skills and Knowledge" },
            {"0","Filling a Labour Shortage" },
            {"0","prevailing Wage Rate Offered"},
            {"0","Reasonable Efforts to Hire or Train Canadians"},
            {"0","Labour Dispute Settlements Unaffected" },
            {"0","Employer’s Commitments Fulfilled" },
            {"0","Employer is Actively Engaged in Business of Offered Position" },
            {"0","Offer is Consistent with Reasonable Employment Need" },
            {"0","Reasonably Able to Fulfill Terms of Offer" },
            {"0","Past Compliance" }
        };
    }
}
