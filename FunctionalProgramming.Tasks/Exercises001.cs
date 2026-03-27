using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace FunctionalProgramming.Tasks
{
    public class Exercises001
    {
        public static Func<int, int> SquareIt = x => x * x;
        public static Func<int, int> AddTen = x => x + 10;
        public static Func<string, string, int> SumIndices = (s1, s2) => s1.IndexOf('a') + s2.IndexOf('e');
        public static string CheckValidEmail(string email) 
        {
            Predicate<string> emailDomain = emailDom => emailDom.Contains("@northcoders.co.uk");
            Predicate<string> username = emailUsername => emailUsername.Split('@')[0].Length >= 5;
            if (emailDomain(email) && username(email))
            {
                return "Email domain and user valid, please continue";
            }
            else return "Email domain and user name invalid, please check your input";
        } 
    }
}
