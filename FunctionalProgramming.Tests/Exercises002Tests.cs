using FluentAssertions;
using FunctionalProgramming.Tasks;

namespace FunctionalProgramming.Tests
{
    public class Exercises002Tests
    {
        [Fact]
        public void GetCoolPeople_ReturnsAListOfUserEmails()
        {
            List<string> test = new List<string>
        {
            "rich.neat@boardgamer.com",
            "poppy.mcdonnell@irishdancer.com",
            "neil.hughes@walkingoncustard.com",
            "alice.yang@midfielder.com",
            "pippa.austin@musician.com"
        };
            
            List<string> result = Exercises002.GetCoolPeople();

            result.Should().BeEquivalentTo(test);
        }
    }
}
