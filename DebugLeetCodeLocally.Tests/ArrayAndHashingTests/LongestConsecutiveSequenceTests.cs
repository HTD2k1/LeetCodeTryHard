public class LongestConsecutiveSequenceTests
{
    [Theory]
    [InlineData(new int[] { 100, 4, 200, 1, 3, 2 }, 4)]
    [InlineData(new int[] { 9, 1, 4, 7, 3, -2, 0, 6, 5, 2, 3 }, 8)]
    [InlineData(new int[] { 10, 5, 12, 3 }, 1)]
    [InlineData(new int[] {}, 0)]
    [InlineData(new int[] { 1 }, 1)]
    public void LongestConsecutiveSequence_HappyPath_ReturnSuccess(int[] nums, int expectedResult)
    {
        // Arrange 
        var sln = new LongestConsecutiveSequenceSolution();
        //Act
        var actualResult = sln.LongestConsecutive(nums);
        //Assert
        Assert.Equal(expectedResult, actualResult);
    }
}