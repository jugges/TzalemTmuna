using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TzalemTmuna.Utilities
{
    public static class ValidateTools
    {
        public static bool IsEmail(string txt)
        {
            return Regex.IsMatch(txt, @"^[\d\w]+@[\d\w]+\.[\w]+$");
        }

        public static bool IsUsername(string txt)
        {
            return Regex.IsMatch(txt, @"^[a-zA-Z0-9_]+$") && txt.Length <= 12;
        }

        public static bool IsPassword(string txt)
        {
            return txt.Length >= 5;
        }

        public static bool IsURL(string txt)
        {
            return Regex.IsMatch(txt, @"https?:\/\/(www\.)?[-a-zA-Z0-9@:%._\+~#=]{1,256}\.[a-zA-Z0-9()]{1,6}\b([-a-zA-Z0-9()@:%_\+.~#?&//=]*)");
        }
    }
}
