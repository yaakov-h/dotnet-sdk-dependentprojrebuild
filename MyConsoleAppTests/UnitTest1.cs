namespace MyConsoleAppTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
        var x = typeof(Program);
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
}