using NUnit.Framework;
using Corestuff;

namespace UnitTests
{
  public class LineTests
  {
    private Line myLine = new Line();

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