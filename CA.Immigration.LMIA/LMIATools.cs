using CA.Immigration.Utility;

namespace CA.Immigration.LMIA
{
   public class LMIATools
    {
        public static int? getIntValue(string input)
        {
            int? value = null;
            if (Validation.IsInt(input)) value = int.Parse(input);
            if (input == string.Empty) value = null;
            return value;
        }
        public static float? getFloatValue(string input)
        {
            float? value = null;
            if (Validation.IsFloat(input)) value = float.Parse(input);
            if (input == string.Empty) value = null;
            return value;
        }

        public static decimal? getDecimalValue(string input)
        {
            decimal? value = null;
            if (Validation.IsDecimal(input)) value = decimal.Parse(input);
            if (input == string.Empty) value = null;
            return value;
        }
        public static double? getDoubleValue(string input)
        {
            double? value = null;
            if(Validation.IsDouble(input)) value = double.Parse(input);
            if(input == string.Empty) value = null;
            return value;
        }
    }
}
