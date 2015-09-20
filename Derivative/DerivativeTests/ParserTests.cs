using System;
using DerivativeClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DerivativeTests
{
  [TestClass]
  public class ParserTests
  {
    [TestMethod]
    public void NormalParserTest()
    {
      string testFunction = "3x^2+5x-3";
      PolyFunction function = PolyFunction.Parse(testFunction);

      Assert.IsNotNull(function);
      Assert.AreEqual(testFunction, function.ToString());
    }

    [TestMethod]
    public void AddTermsTest()
    {
      string testFunction = "3x^2+5x^2-2";
      PolyFunction function = PolyFunction.Parse(testFunction);

      Assert.IsNotNull(function);

      string answer = "8x^2-2";
      Assert.AreEqual(answer, function.ToString());
    }
  }
}