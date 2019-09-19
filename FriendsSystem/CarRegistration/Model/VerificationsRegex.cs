using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CarRegistration.Model
{
    public static class VerificationsRegex
    {
        private static Regex PlateVerificationRegex = new Regex
            (@"[a-z][a-z][a-z]-[0-9][0-9][0-9][0-9]");

        public static bool PlateCarVerify(string input)
        {
            return !PlateVerificationRegex.Match(input).Success;
        }
    }
}