public class mCodecTests
{
    [Fact]
    public void ExecuteUsingNonASCIICharacters_HappyPath_Success()
    {   
        //Arrange 
        var strs = new List<string> { "Hello", "World" };
        //Act
        Codec test = new Codec();
        var result = test.ExecuteUsingNonASCIICharacters(strs);
        //Assert
        Assert.Equal(result, strs);
    }
}