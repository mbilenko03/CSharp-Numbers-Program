using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
  internal class IntegerTester
  {
    #region Intiger Tester

    private static void Main(string[] args)
    {
      double number;
      do
      {
        Console.Write("Type in a number: ");
        string userNumber = Console.ReadLine();


        bool result = double.TryParse(userNumber, out number);
        if (result == true)
        {
          if (number%2 == 0 && number != 0)
          {
            Console.WriteLine(number + " is even.");
          }
          else if (number%2 == 1)
          {
            Console.WriteLine(number + " is odd.");
          }
          else if (number == 0)
          {
            Console.WriteLine(number + " ends the program.");
            return;
          }
          else
          {
            Console.WriteLine(number + " is not an integer");
          }
        }
        else
        {
          Console.WriteLine("It is not a number... You can't fool us!");
        }
      } while (true);
    }

    #endregion
  }
}