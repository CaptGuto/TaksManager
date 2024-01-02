using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace fProject
{
    internal class TextBoxCheck
    {
        static public bool checkEmpty(TextBox tb)
        {
            string text = tb.Text;
            if (string.IsNullOrEmpty(text))
            {
                return false; 
            }
            return true; 
        }
       static public Boolean validateEmail(TextBox tb)
        {
            string email = tb.Text.Trim();

            // Regular expression for a general email format
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (string.IsNullOrEmpty(email))
            {
                return false;
            }
            else if (Regex.IsMatch(email, emailPattern))
            {
                return true;
            }

            return false;
        }
        static public Boolean validateUserName(TextBox tb)
        {
            string text = tb.Text.Trim();

            // Check if the username is null or empty
            if (string.IsNullOrEmpty(text))
            {
                return false;
            }

            // Check if the username length is greater than 8 characters
            if (text.Length > 8)
            {
                return false;
            }


            // Check if the username contains any symbols
            if (HasSymbols(text))
            {
                return false;
            }

            // If all checks pass, the username is considered valid
            return true;
        }

        static public bool HasSymbols(string text)
        {
            // Check if the username contains any symbols
            foreach (char c in text)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return true; // Username contains symbols
                }
            }

            return false; // No symbols found in the username
        }

        public static bool ValidatePassword(TextBox tb)
        {
            string password = tb.Text.Trim();

            // Minimum length requirement
            if (password.Length < 8)
            {
                return false;
            }

            // Check for at least one uppercase letter
            if (!Regex.IsMatch(password, "[A-Z]"))
            {
                return false;
            }

            // Check for at least one lowercase letter
            if (!Regex.IsMatch(password, "[a-z]"))
            {
                return false;
            }

            // Check for at least one digit
            if (!Regex.IsMatch(password, "[0-9]"))
            {
                return false;
            }

            // Check for at least one special character
            if (!Regex.IsMatch(password, @"[!@#$%^&*()_+{}\[\]:;<>,.?~\\-]"))
            {
                return false;
            }

            // If all checks pass, the password is considered strong enough
            return true;
        }

        static public Boolean checkPasswordMatch(TextBox passwordBox1, TextBox passwordBox2)
        {
            string pass1 = passwordBox1.Text.Trim();
            string pass2 = passwordBox2.Text.Trim();

            if (!pass1.Equals(pass2))
            {
                return false;
            }
            return true;
        }
    }
}
