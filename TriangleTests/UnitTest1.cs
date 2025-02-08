        
        // NAME : CLILUKURI SRIKANTH
using NUnit.Framework;
using TriangleApp;
namespace TriangleTests{
    [TestFixture]
public class TriangleTests
{
    [Test]
    public void TestIsosceles()
    {
        Console.WriteLine("TestExecuted by Chilukuri Srikanth");
        Assert.That(Triangle.IsIsosceles(4, 5, 4),Is.True);  

    }
     [Test]
    public void Test_NoteIsosceles()
    {
        Console.WriteLine("TestExecuted by Chilukuri Srikanth");
        Assert.That(Triangle.IsIsosceles(4, 5,6),Is.False);  
    }
     [Test]
    public void TestEquilateral()
    {
        Console.WriteLine("TestExecuted by Chilukuri Srikanth");
        Assert.That(Triangle.IsIsosceles(4, 4, 4),Is.True);  
    }
}
}
