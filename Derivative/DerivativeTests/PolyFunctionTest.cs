using DerivativeClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DerivativeTests
{
  [TestClass]
  public class PolyFunctionTest
  {
    [TestMethod]
    public void ToStringReturnsCorrectResult()
    {
      PolyFunction testFunc = new PolyFunction(new[] {5, 0, 1, 3});

      var str = testFunc.ToString();
      Assert.AreEqual("3x^3+x^2+5", str);
    }

    [TestMethod]
    public void ToStringNegReturnsCorrectResult()
    {
      PolyFunction testFunc = new PolyFunction(new[] {-5, 0, -1, -3});

      var str = testFunc.ToString();
      Assert.AreEqual("-3x^3-x^2-5", str);
    }

    [TestMethod]
    public void DeriveReturnsCorrectResult()
    {
      PolyFunction testFunc = new PolyFunction(new[] {5, 0, 1, 3});
      var derivedFunc = testFunc.Derive();
      string str = derivedFunc.ToString();
      Assert.AreEqual("9x^2+2x", str);
    }
  }
}
