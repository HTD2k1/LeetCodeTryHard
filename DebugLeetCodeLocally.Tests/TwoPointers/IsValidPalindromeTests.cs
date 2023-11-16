
public class IsValidPalindromeTests
{
    private readonly IsValidPalindromeSolution _solution;

    public IsValidPalindromeTests()
    {
        _solution = new IsValidPalindromeSolution();
    }

    [Theory]
    [InlineData("A man, a plan, a canal, Panama", true)]
    [InlineData("No lemon, no melon", true)]
    [InlineData("Hello, World!", false)]
    [InlineData("Racecar", true)]
    [InlineData("", true)]
    [InlineData(" ", true)]
    public void IsPalindrome_ReturnsExpectedResult(string input, bool expected)
    {
        // Act
        var result = _solution.IsPalindrome(input);

        // Assert
        Assert.Equal(expected, result);
    }
}