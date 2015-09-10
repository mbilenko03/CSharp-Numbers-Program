using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collatz_Theory
{
  class Collatz
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter what number you want tested: ");
      double number;
      if (double.TryParse(Console.ReadLine(), out number))
      {
        testCollatz(number);
      }
    }

    static void testCollatz(double collatzVal)
    {
      int i = 1;
      bool success = true;
      double orig = collatzVal;

      while (collatzVal != 1)
      {
        if (collatzVal % 2 == 0)
        {
          collatzVal = collatzVal / 2;
          Console.WriteLine("[math:{0}] collatzVal / two ==> {1}", i, collatzVal);
        }

        else if (collatzVal % 2 == 1)
        {
          collatzVal = (3 * collatzVal) + 1;
          Console.WriteLine("[math:{0}] (collatzVal * three) + one ==> {1}", i, collatzVal);
        }
        else
        {
          success = false;
          break;
        }

        i++;
      }

      if (success)
      {
        i = i - 1;
        Console.WriteLine("The number {0} worked, taking {1} steps to get to {2}.", orig, i, collatzVal);
      }
      else
      {
        Console.WriteLine("The number {0} is invalid. Please enter a positive integer!", orig);
      }
    }
  }
 }
