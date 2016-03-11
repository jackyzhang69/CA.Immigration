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
    }
}
