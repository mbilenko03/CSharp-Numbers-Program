using System;
using DerivativeClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DerivativeTests
{
  [TestClass]
  public class TermTests
  {
    [TestMethod]
    public void TestTermWithPowers()
    {
      string sTerm = "123x^3";
      Term term = new Term(sTerm);

      Assert.AreEqual(123, term.Coef);
      Assert.AreEqual(3, term.Power);
    }

    [TestMethod]
    public void TestTermWithNoPower()
    {
      string sTerm = "123x";
      Term term = new Term(sTerm);

      Assert.AreEqual(123, term.Coef);
      Assert.AreEqual(1, term.Power);
    }

    [TestMethod]
    public void TestTermConstant()
    {
      string sTerm = "58";
      Term term = new Term(sTerm);

      Assert.AreEqual(58, term.Coef);
      Assert.AreEqual(0, term.Power);
    }

    [TestMethod]
    public void TestTermWithNegitiveCoef()
    {
      string sTerm = "-123x^3";
      Term term = new Term(sTerm);

      Assert.AreEqual(-123, term.Coef);
      Assert.AreEqual(3, term.Power);
    }
    
    [TestMethod]
    public void TestTermWithNegitivePowers()
    {
      string sTerm = "123x^-3";
      Term term = new Term(sTerm);

      Assert.AreEqual(123, term.Coef);
      Assert.AreEqual(-3, term.Power);
    }

    [TestMethod]
    [ExpectedException(typeof(FormatException))]
    public void TestInvalidInput()
    {
      string sTerm = "3889sjow";
      Term term = new Term(sTerm);
    }


  }
}
