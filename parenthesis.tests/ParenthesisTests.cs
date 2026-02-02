namespace parenthesis.tests;

public class ParenthesisTests
{
    [Fact]
    public void Test1()
    {
        var is_valid = Parenthesis.IsValid("()");
        Assert.True(is_valid);
    }

    [Fact]
    public void Test2()
    {
        var is_valid = Parenthesis.IsValid("()[]{}");
        Assert.True(is_valid);
    }

    [Fact]
    public void Test3()
    {
        var is_valid = Parenthesis.IsValid("(]");
        Assert.False(is_valid);
    }

    [Fact]
    public void Test4()
    {
        var is_valid = Parenthesis.IsValid("([])");
        Assert.True(is_valid);
    }

    [Fact]
    public void Test5()
    {
        var is_valid = Parenthesis.IsValid("([)]");
        Assert.False(is_valid);
    }
}
