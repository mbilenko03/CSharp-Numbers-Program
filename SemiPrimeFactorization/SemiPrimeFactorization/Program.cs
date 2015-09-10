using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemiPrimeFactorization
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter what term you want: ");
      int number;
      bool result = (int.TryParse(Console.ReadLine(), out number));
      if (result == true)
      {
        //improgress
      }
      else
      {
        Console.WriteLine("Your Imput {0} is Invalid", number);
      }
      
    }
  }
}
