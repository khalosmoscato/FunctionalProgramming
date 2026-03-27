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

        int result = Exercises001.SquareIt(input);

        result.Should().Be(expected);
    }

    [Fact]
    public void AddTen_ReturnsNumberPlusTen()
    {
        List<int> input = new List<int> { 4, 15, 55, 78, 12 };
        List<int> expected = new List<int> { 14, 25, 65, 88, 22 };
        List<int> result = new();

        foreach (int i in input)
        {
            int n = Exercises001.AddTen(i);
            result.Add(n);
        }
        
        result.Should().Equal(expected);
    }
}
