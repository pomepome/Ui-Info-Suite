using System;

namespace UIInfoSuite.Extensions
{
    static class StringExtensions
    {


        public static Int32 SafeParseInt32(this String s)
        {
            Int32 result = 0;

            if (!String.IsNullOrWhiteSpace(s))
            {
                Int32.TryParse(s, out result);
            }

            return result;
        }

        public static Int64 SafeParseInt64(this String s)
        {
            Int64 result = 0;

            if (!String.IsNullOrWhiteSpace(s))
                Int64.TryParse(s, out result);

            return result;
        }

        public static bool SafeParseBool(this String s)
        {
            bool result = false;

            if (!String.IsNullOrWhiteSpace(s))
            {
                Boolean.TryParse(s, out result);
            }

            return result;
        }
    }
}
