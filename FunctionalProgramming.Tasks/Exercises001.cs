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
    }
}
