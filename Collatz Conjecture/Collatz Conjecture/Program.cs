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
      string readTerm = Console.ReadLine();
      double useTerm = double.Parse(readTerm);
      CollatzTester(useTerm);

    }

    static void CollatzTester(double CollatzVal)
    {

      while (CollatzVal != 1)
        if (CollatzVal % 2 == 0)
        {
          CollatzVal = CollatzVal / 2;
        }

        else if (CollatzVal % 2 == 1)
        {
          CollatzVal = (3 * CollatzVal) + 1;
        }

        else
        {
          Console.WriteLine("Your number is invalad");
          break;
        }

      Console.WriteLine("Your Number Worked!" + " Here's the proof: " + CollatzVal);
    }


  }
}
