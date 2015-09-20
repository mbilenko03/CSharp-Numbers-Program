using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibinachi_Sequence
{
  internal class FibinachiSequence
  {
    private static void Main(string[] args)
    {
      Console.WriteLine("Enter what term you want: ");
      string readTerm = Console.ReadLine();
      int useTerm = int.Parse(readTerm);
      int[] printList = listFibi(useTerm);
      printFibi(printList);
      sumFibi(printList);
      phiFibi(useTerm, printList);
    }

    private static int[] listFibi(int useTerm)
    {
      int[] arrFibi = new int[useTerm];
      int initialCount = 1;
      int fibiCounter = 0;

      for (int i = 0; i < useTerm; i++)
      {
        int fibiHolder = initialCount + fibiCounter;
        arrFibi[i] = fibiHolder;
        fibiCounter = initialCount;
        initialCount = fibiHolder;
      }
      return arrFibi;
    }

    private static void printFibi(int[] arrFibi)
    {
      for (int i = 0; i < arrFibi.Length; i++)
      {
        int printNumber = arrFibi[i];
        Console.Write(printNumber + ", ");
      }
      Console.WriteLine();
    }

    private static void sumFibi(int[] arrFibi)
    {
      //Note this method is only for extra practice and has no purpose
      int fibiHolder = 0;

      for (int i = 0; i < arrFibi.Length; i++)
      {
        int addNumber = arrFibi[i];
        fibiHolder = addNumber + fibiHolder;
      }
      Console.WriteLine("The Numbers have a Sum of " + fibiHolder);
    }

    private static void phiFibi(int useTerm, int[] arrFibi)
    {
      int lastTerm = useTerm - 1;
      int secondLastTerm = useTerm - 2;

      try
      {
        int lastFibi = arrFibi[lastTerm];
        int secondLastFibi = arrFibi[secondLastTerm];
        double ratioFibi = (double) lastFibi/(double) secondLastFibi;
        Console.WriteLine("The phi ratio is " + ratioFibi);
      }
      catch (System.IndexOutOfRangeException)
      {
        Console.WriteLine("To little information is given to have a ratio.");
      }
    }
  }
}