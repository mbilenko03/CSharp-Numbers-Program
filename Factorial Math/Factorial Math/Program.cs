using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialPractice
{
  internal class FactorialPracticeProgram
  {
    private static void Main(string[] args)
    {
      Console.WriteLine("Enter a number:");
      string imFactorial = Console.ReadLine();
      int valFactorial = int.Parse(imFactorial);
      Stopwatch sw = new Stopwatch();
      sw.Start();
      double printFactorial = FactorialOpperation(valFactorial);
      sw.Stop();
      Console.WriteLine(printFactorial.ToString("#"));
      Console.WriteLine("Time Elapsed is " + sw.Elapsed);
    }

    private static double FactorialOpperation(int numFactorial)
    {
      double ansFactorial = 1;
      for (int i = 2; i <= numFactorial; i++)
      {
        ansFactorial = ansFactorial*i;
      }
      return ansFactorial;
    }
  }
}