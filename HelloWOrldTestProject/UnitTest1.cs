namespace HelloWOrldTestProject;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        int number = 1;
        int secondNumber = 2;
        
        Assert.AreEqual(number, secondNumber);
    }
}