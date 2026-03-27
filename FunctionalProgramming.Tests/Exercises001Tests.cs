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

    [Fact]
    public void SumIndices_ReturnsSumOfIndexesOfSelectedCharsInStringOneAndTwo()
    {
        string s1 = "start";
        string s2 = "pale";
        int expected = 5;

        int result = Exercises001.SumIndices(s1, s2);

        result.Should().Be(expected);
    }
    
    [Fact]
    public void CheckValidEmail_ReturnsSuccessMEssage_WhenEmailIsValid()
    {
        string email = "khalos@northcoders.co.uk";
        string expected = "Email domain and user valid, please continue";

        string result = Exercises001.CheckValidEmail(email);

        result.Should().Be(expected);
    }
}
