using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    namespace UserRegistration
    {
        public class User
        {
            public static string Reg_pattern1 = "^[A-Z]{1}[A-Za-z]{2,}$";
            public static string Reg_pattern2 = "^[A-Z]{1}[A-Za-z]{2,}$";
            public static string Reg_pattern3 = "^(abc)(.[A-Za-z]+)?@(bl).(co)([.][a-z]{2,})?$";
            public static string Reg_pattern4 = "^[0-9]{2}\\s[0-9]{10}$";
            public static string Reg_pattern5 = "^[a-zA-Z]{8,}([0-9]+)?$";
            public static string Reg_pattern6 = "^[A-Z]{1,}[a-zA-Z]{7,}([0-9]+)?$";
            public static string Reg_pattern7 = "^(?=.*[A-Z])(?=.*[0-9])[A-Za-z0-9]{8,}([0-9]+)?$";
            public static string Reg_pattern8 = "^.*(?=.{8,})(?=.*[A-Z])(?=.*[0-9])(?=.*[@#$%^&+=]).*$";
            public static string Reg_pattern9 = "^[A-Za-z0-9]+([.+-][A-Za-z0-9]+)*@[A-Za-z0-9]+[.][a-z]{2,}([.][a-z]{2,})?$";


            //abc.xyz@bl.co.in


            public static bool validateName(string name)
            {
                return Regex.IsMatch(name, Reg_pattern1);

            }
            public static bool validateLastName(string lastname)
            {
                return Regex.IsMatch(lastname, Reg_pattern2);
            }

            public static bool validateEmailID(string email)
            {
                return Regex.IsMatch(email, Reg_pattern3);
            }
            public static bool validateMobileNumber(string Monumber)
            {
                return Regex.IsMatch(Monumber, Reg_pattern4);

            }

            public static bool validatePassword(string password)
            {
                return Regex.IsMatch(password, Reg_pattern5);

            }

            public static bool validatePassword1(string password)
            {
                return Regex.IsMatch(password, Reg_pattern6);

            }

            public static bool validatePassword2(string password)
            {
                return Regex.IsMatch(password, Reg_pattern7);

            }

            public static bool validatePassword3(string password)
            {
                return Regex.IsMatch(password, Reg_pattern8);

            }

            public static bool validateEmailID1(string email)
            {
                return Regex.IsMatch(email, Reg_pattern9);

            }
        }
    }
}


