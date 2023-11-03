public class ProductExceptSelfTests
{
    [Fact]
    public void ProductExceptSelf_ArraysOfAllPositiveNumbers_Success()
    {
        //Arrange 
        int[] testArr = { 1, 2, 3, 4 };
        int[] expectedResult = { 24, 12, 8, 6 };
        //Act 
        var actualResult = new ProductExceptSelfSolution().ProductExceptSelf(testArr);
        //Assert
        Assert.Equal(expectedResult, actualResult);
    }
    
    [Fact]
    public void ProductExceptSelf_ArrayContainsAllKindsOfNumber_Success()
    {
        //Arrange 
        int[] testArr = { -1,1,0,-3,3 };
        int[] expectedResult = {0,0,9,0,0 };
        //Act 
        var actualResult = new ProductExceptSelfSolution().ProductExceptSelf(testArr);
        //Assert
        Assert.Equal(expectedResult, actualResult);
    }
}