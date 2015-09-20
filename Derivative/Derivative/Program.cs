using System;
using System.Linq;
using DerivativeClasses;

namespace Derivative
{
  internal class Program
  {
    private static void Main()
    {
      Console.WriteLine("Enter polynomial or trig");
      string choice = Console.ReadLine();

      FunctionBase func = null;
      if (choice == "polynomial" || choice == "Polynomial" || choice == "poly")
      {
        Console.WriteLine("Polynomial has been activated...");
        func = ReadPolynomial();
      }
      else if (choice == "trig" || choice == "Trig")
      {
        Console.WriteLine("Trig has been activated...");
        //activate trig method
      }
      else
      {
        Console.WriteLine("Your imput is invalid...");
      }

      if (func != null)
        Console.WriteLine("Derivative for " + func + " is " + func.Derive());
    }

    private static PolyFunction ReadPolynomial()
    {
      Console.WriteLine("Enter Highest Exponent");
      string readHighExp = Console.ReadLine();
      int highExp;
      bool result = int.TryParse(readHighExp, out highExp);
      if (result)
      {
        string[] readCoeArr = new string[highExp + 1];
        for (int i = 0; i <= highExp; i++)
        {
          //int askExp = highExp - i;
          Console.WriteLine("Enter Coeficcient for {0}", i);
          readCoeArr[i] = Console.ReadLine();
        }
        int[] coeArr = readCoeArr.Select(int.Parse).ToArray();
        return new PolyFunction(coeArr);
      }

      Console.WriteLine("Error... Please Enter Valid Exponent...");
      return null;
    }
  }
}