using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA.Immigration.Utility
{
    public class DateOps
    {
        public static int age(DateTime dob)
        {

            DateTime zeroTime = new DateTime(1, 1, 1);

            TimeSpan span = DateTime.Today - dob;
            // because we start at year 1 for the Gregorian 
            // calendar, we must subtract a year here.
            return (zeroTime + span).Year - 1;

        }
        public static DateTime? getDate(object input)
        {
            if (input != null)
            {
                DateTime expectedDate;
                if (!DateTime.TryParse(input.ToString(), out expectedDate))
                {
                    MessageBox.Show("Some of date format are invalid. Null assigned to them!");
                    return null;
                }
                else return expectedDate;
            }
            else return null;
        }
        public static bool isValidDate(object input)
        {
            DateTime expectedDate;
            if (input != null)
            {
                if (!DateTime.TryParse(input.ToString(), out expectedDate))
                {
                    return false;
                }
                else return true;
            }
            else return false;
        }
    }

}
