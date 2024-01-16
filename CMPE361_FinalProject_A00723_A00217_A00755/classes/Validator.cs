using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPE361_FinalProject_A00723_A00217_A00755.classes
{
    public class Validator
    {
        public static bool ValidateEmail(string email)
        {
            if (email.Contains('@') && (email.EndsWith(".com") || email.EndsWith(".net"))) {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public static bool ValidatePassword(string password) {
            return password.Length >= 8 &&
               password.Any(char.IsDigit) &&
               password.Any(char.IsUpper) &&
               password.Any(char.IsLower) &&
               password.Any(c => !char.IsLetterOrDigit(c));
        }
    }
}
