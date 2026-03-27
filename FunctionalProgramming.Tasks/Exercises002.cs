using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming.Tasks
{
    public class Exercises002
    {
        public static Func<List<string>> GetCoolPeople = () => new List<string>
        {
            "rich.neat@boardgamer.com",
            "poppy.mcdonnell@irishdancer.com",
            "neil.hughes@walkingoncustard.com",
            "alice.yang@midfielder.com",
            "pippa.austin@musician.com"
        };
    }
}
