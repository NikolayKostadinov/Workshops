namespace Tests;

using DemoChainOfResponsibility;
using Xunit;

public class UnitTests
{
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(3, 4, 7)]
    [InlineData(1.2, 2.3, 3.5)]
    [InlineData(0, 1, 1)]
    public void ShouldReturnCorrectAddition(decimal first, decimal second, decimal expected)
    {
        // Act
        var result = Program.CalculateResult(first, second, "+");

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(2, 1, 1)]
    [InlineData(4, 2, 2)]
    [InlineData(2.4, 1.2, 1.2)]
    [InlineData(1, 0, 1)]
    public void ShouldReturnCorrectSubtraction(decimal first, decimal second, decimal expected)
    {
        // Act
        var result = Program.CalculateResult(first, second, "-");

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(2, 1, 2)]
    [InlineData(4, 2, 8)]
    [InlineData(2.4, 1.2, 2.88)]
    [InlineData(1, 0, 0)]
    public void ShouldReturnCorrectMultiplication(decimal first, decimal second, decimal expected)
    {
        // Act
        var result = Program.CalculateResult(first, second, "*");

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(1, 2, 0.5)]
    [InlineData(2, 1, 2)]
    [InlineData(4, 2, 2)]
    [InlineData(2.4, 1.2, 2)]
    [InlineData(0, 1, 0)]
    public void ShouldReturnCorrectDivision(decimal first, decimal second, decimal expected)
    {
        // Act
        var result = Program.CalculateResult(first, second, "/");

        // Assert
        Assert.Equal(expected, result);
    }

    // [Theory]
    // [InlineData(1, 2, 1)]
    // [InlineData(3, 2, 1)]
    // [InlineData(0, 1, 0)]
    // public void ShouldReturnCorrectModulus(decimal first, decimal second, decimal expected)
    // {
    //     // Act
    //     var result = Program.CalculateResult(first, second, "%");
    //
    //     // Assert
    //     Assert.Equal(expected, result);
    // }
}
