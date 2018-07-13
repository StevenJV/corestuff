using NUnit.Framework;
using Line = Line.Line;

namespace UnitTests
{
  public class LineTests
  {
    private global::Line.Line myLine = new global::Line.Line();

    [SetUp]
    public void Setup()
    {

    }

    [Test]
    public void Test1()
    {
      myLine.setLength(6.0);
      Assert.AreEqual(6.0, myLine.getLength());
    }
  }
}