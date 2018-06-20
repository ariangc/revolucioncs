using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Utils {
    public class DataValidation {
        public static bool ValidField(string pattern, string text, ref bool flagOK) {
            Regex regex;
            Match match;
            regex = new Regex(pattern);
            match = regex.Match(text);
            if (!match.Success) flagOK = match.Success;
            return match.Success;
        }
    }
}
