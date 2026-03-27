using FluentAssertions;
using FunctionalProgramming.Tasks;

namespace FunctionalProgramming.Tests;

public class Exercises001Tests
{
    [Fact]
    public void SquareIt_ReturnsSquaredArg()
    {
        int input = 10;
        int expected = 100;

        int result = Exercises001.SquareIt(10);

        result.Should().Be(expected);
    }
}
