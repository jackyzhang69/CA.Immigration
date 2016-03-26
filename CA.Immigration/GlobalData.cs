using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA.Immigration
{
    public static class GlobalData
    {
        // Global scope data
        public static int? CurrentPersonId;
        public static bool CurrentPersonIdReadOnly = false;
        public static int? CurrentEmployerId;
        public static bool CurrentEmployerIdReadOnly = false;
        public static int? CurrentCategoryId;
        public static bool CurrentCategoryReadOnly = false;
        public static int? CurrentProgramId;
        public static bool CurrentProgramIdReadOnly = false;
        public static int? CurrentStreamId;
        public static bool CurrentStreamIdReadOnly = false;
        public static int? CurrentApplicationId;
        public static bool CurrentApplicationIdReadOnly = false;
        public static string CurrentNOC;
        public static int? CurrentRCICId;
        public static bool CurrentRCICIdReadOnly = false;
       

        // For LMIA application data
        public static int? CurrentBusinessDetailId;
        public static int? CurrentJobOfferId;
        public static double? CurrentWorkingHours;
        public enum AppStream
        {

            LMIAPRSupportOnly = 0,
            LMIAPRandWP = 1,
            LMIAWPOnly = 2,
            BCPNPSW = 3,
            BCPNPEI = 4,
            BCPNPInternationalGraduate = 5
        }

    }
}
