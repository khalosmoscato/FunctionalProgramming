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

        [Fact]
        public void GetUsernames_ReturnsAListOfUsernamesFromListOfEmails()
        {
            List<string> emails = Exercises002.GetCoolPeople();
            Action act = () => emails.ForEach(Exercises002.GetUsernames);
            act.Should().NotThrow();
        }
    }
}
