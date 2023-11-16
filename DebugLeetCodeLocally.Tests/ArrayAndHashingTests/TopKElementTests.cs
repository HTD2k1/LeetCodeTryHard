namespace DebugLeetCodeLocally.Tests.ArrayAndHashing;

public class TopKElementTests
{
    [Fact]
    public void TopKElement_ArraysOfInts_ReturnsPassedArray()
    {
        //Arrange 
        int[] testNums = { 3, 0, 1, 0 };
        int testK = 1;
        // Act 
        var solution = new TopKElementsSolution();
        var result = solution.TopKFrequent(testNums, testK);
        //Assert
        Assert.Equal(new[] { 0 }, result);
    }
    
    [Fact]
    public void TopKElement_ArraysOfTwoUniquelements_ReturnsPassedArray()
    {
        //Arrange 
        int[] testNums = { 1,2 };
        int testK = 2;
        // Act 
        var solution = new TopKElementsSolution();
        var result = solution.TopKFrequent(testNums, testK);
        Array.Sort(result);
        //Assert
        Assert.Equal(new[] { 1,2 }, result);
    }
    [Fact]
    public void TopKElement_ArraysThatContainsNegativeNumbers_ReturnsPassedArray()
    {
        //Arrange 
        int[] testNums = {4,1,-1,2,-1,2,3};
        int testK = 2; 
        int[] expectedResult =  { -1, 2 };
        // Act 
        var solution = new TopKElementsSolution();
        var actualResult = solution.TopKFrequent(testNums, testK);
        Array.Sort(actualResult);
        //Assert
        Assert.Equal(expectedResult, actualResult);
    }
}