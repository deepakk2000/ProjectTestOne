using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigninLib
{
    public class SignIn
    {
        public static string Authenticate(string username,string password)
        {
            string result;
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                result = "You must provide username and password";
            }
            else if(username == "sam" && password == "sam@123")
            {
                result = "valid user ";
            }
            else
            {
                result = "invalid user credential";
            }
            return result;
        }
    }
}
