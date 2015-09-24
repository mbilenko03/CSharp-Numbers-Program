using System;

namespace DerivativeClasses
{
  public class Term
  {
    public int Coef { get; set; }
    public int Power { get; set; }

    public Term(string sTerm)
    {
      int pos = sTerm.IndexOf('x');
      if (pos < 0)
      {
        Power = 0;
        Coef = int.Parse(sTerm);
        return;
      }

      string sCoef = sTerm.Substring(0, pos);
      Coef = int.Parse(sCoef);

      if (pos + 1 < sTerm.Length)
      {
        string sPower = sTerm.Substring(pos + 1);
        if (!sPower.StartsWith("^") || sPower.Length == 1)
          throw new FormatException("Invalid term " + sTerm);

        sPower = sPower.Substring(1);
        Power = int.Parse(sPower);
      }
      else
      {
        Power = 1;
      }
    }
  }
}