using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemiPrimeFactorization
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      Console.WriteLine("Enter what term you want: ");
      int number;
      bool result = (int.TryParse(Console.ReadLine(), out number));
      if (result == true)
      {
        //develope primes from 0<p<sqrt(n)
        //test them
      }
      else
      {
        Console.WriteLine("Your Imput {0} is Invalid", number);
      }
    }
  }
}