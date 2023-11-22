using System.Collections.Generic;
using System.Text;
using Xunit;

public class ThreeSumTests
{
    private readonly ThreeSumSolution _solution;

    public ThreeSumTests()
    {
        _solution = new ThreeSumSolution();
    }
    [Fact]
    public void NaiveThreeSum_WithMixedNumbers_ReturnsCorrectTriplets()
    {
        // Arrange
        var nums = new int[] { -1, 0, 1, 2, -1, -4 };
        var expected = new List<List<int>> {  new List<int> { -1, 0, 1 }, new List<int> { -1, -1, 2 } };

        // Act
        var result =    _solution.NaiveThreeSum(nums);
        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void NaiveThreeSum_WithNoZeroSum_ReturnsEmpty()
    {
        // Arrange
        var nums = new int[] { 0, 1, 1 };
        var expected = new List<List<int>>();

        // Act
        var result =   _solution.NaiveThreeSum(nums);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void NaiveThreeSum_WithAllZeros_ReturnsTripleZero()
    {
        // Arrange
        var nums = new int[] { 0, 0, 0 };
        var expected = new List<List<int>> { new List<int> { 0, 0, 0 } };

        // Act
        var result =   _solution.NaiveThreeSum(nums);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void NaiveThreeSum_LongSequences_ReturnCorrectTriplets()
    {
        //Arrange 
        string filePath =
            "/Users/hatiendat/RiderProjects/LeetCode/DebugLeetCodeLocally.Tests/TwoPointers/ThreeSumLongTestCase.txt";
        string text = File.ReadAllText(filePath, Encoding.UTF8);
        var nums = text.Split(",").Select(x => Int32.Parse(x)).ToArray();
        
        //Act
        var result = _solution.NaiveThreeSum(nums);
        
        // Arrange 
    }
}