using System;
using System.Text.RegularExpressions;

namespace Utility
{
    public class Validation : IValidation
    {
        public (string, bool) ValidateName(string name)
        { 
            if(name == "")
            {
                return ("this field is required", false);
            }
            else
            {
                if (Char.IsDigit(name[0]))
                {
                    name = "name shouldnt begin with a number";
                    return new (name, false);
                }
                // this is used to change case of the upper
                name = name.Trim();
                char[] nam = name.ToCharArray();
                nam[0] = Char.ToUpper(nam[0]);
                name = "";
                for (int i = 0; i < nam.Length; i++) name += nam[i];
                return (name, true);
            }
        }

        public (string, bool) ValidatePassword(string password)
        {
            Regex Digit = new Regex(@"[0-9]+");
            Regex alpha = new Regex(@"[a-zA-Z]+");
            Regex special = new Regex(@"[@#$%^&!]+");
           
            int len = password.Length;
            if (password == "")
            {
                return ("this field is required !!!", false);
            }
            if (len > 5 && Digit.IsMatch(password) && alpha.IsMatch(password) && special.IsMatch(password))
            {
                return (password, true);
            }
            else
            {
                return ("must contain an alphabet, number and special char and greater than 6 character", false);
            }
           
        }

        public (string,bool) ValidateEmail(string Email)
        {
            if(Email == "")
            {
                Email = "this field is required";
                return (Email, false);
            }
            var exp = new Regex(@"\S+@\S+[.][a-zA-Z]");
            if (exp.IsMatch(Email))
                return (Email,true);

            Email = "Please enter a valid: omeni324@gmail.com";
            return(Email,false);
        }
    }
}
