using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Derivative
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter polynomial or trig");
      string choice = Console.ReadLine();
      if (choice == "polynomial" || choice == "Polynomial" || choice == "poly")
      {
        Console.WriteLine("Polynomial has been activated...");
        ReadPolynomial();
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

    }

    static void ReadPolynomial()
    {
      Console.WriteLine("Enter Highest Exponent");
      string readHighExp = Console.ReadLine();
      int highExp;
      bool result = int.TryParse(readHighExp, out highExp);
      if (result == true)
      {
        string[] readCoeArr = new string[highExp + 1];
        for (int i = 0; i <= highExp; i++)
        {
          int askExp = highExp - i;
          Console.WriteLine("Enter Coeficcient for {0}", askExp);
          readCoeArr[i] = Console.ReadLine();
        }
        int[] coeArr = readCoeArr.Select(s => int.Parse(s)).ToArray();
        Polynomial(highExp, coeArr);
      }
      else
      {
        Console.WriteLine("Error... Please Enter Valid Exponent...");
      }


    }

    static void Polynomial(int highExp, int[] coeArr)
    {
      string[] terms = new string[highExp];
      int[] coeDer = new int[highExp];

      for (int i = 0; i < highExp; i++)
      {
        coeDer[i] = coeArr[i] * (highExp - i);
      }

      for (int i = 0; i < highExp; i++)
      {
        int newExponent = highExp - 1 - i;
        if (newExponent > 1)
          Console.Write("{0}x^{1} + ", coeDer[i], newExponent);
        else if (newExponent == 1)
          Console.Write("{0}x + ", coeDer[i]);
        else
          Console.WriteLine("{0}", coeDer[i]);
      }
    }
  }
}

