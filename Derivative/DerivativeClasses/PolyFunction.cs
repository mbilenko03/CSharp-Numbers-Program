using System;
using System.Collections.Generic;
using System.Text;

namespace DerivativeClasses
{
  public class PolyFunction : FunctionBase
  {
    private readonly int[] _coef;

    public PolyFunction(int[] coef)
    {
      _coef = coef;
    }

    public override FunctionBase Derive()
    {
      int[] derived = new int[_coef.Length - 1];

      for (int i = 1; i < _coef.Length; i++)
      {
        derived[i - 1] = i*_coef[i];
      }

      return new PolyFunction(derived);
    }

    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();

      for (int i = _coef.Length - 1; i >= 0; i--)
      {
        if (_coef[i] == 0) continue;
        if (sb.Length > 0 && _coef[i] > 0)
          sb.Append('+');

        if (_coef[i] != 1 && _coef[i] != -1)
          sb.Append(_coef[i]);

        if (_coef[i] == -1)
          sb.Append('-');

        if (i > 1)
          sb.Append("x^" + i);
        else if (i == 1)
          sb.Append("x");
      }
      return sb.ToString();
    }

    #region PolynomialParser

    public static PolyFunction Parse(string input)
    {
      List<Term> terms = new List<Term>();
      string sTerm = String.Empty;

      for (int i = 0; i < input.Length; i++)
      {
        if ((input[i] == '+' || input[i] == '-') && sTerm != String.Empty)
        {
          terms.Add(new Term(sTerm));
          sTerm = input[i].ToString();
        }

        else
        {
          sTerm += input[i].ToString();
        }
      }
      if (sTerm != String.Empty)
        terms.Add(new Term(sTerm));

      int maxPower = 0;
      foreach (var term in terms)
      {
        if (term.Power > maxPower)
          maxPower = term.Power;
      }

      int[] coef = new int[maxPower + 1];
      for (int i = 0; i < coef.Length; i++)
        coef[i] = 0;

      foreach (var term in terms)
      {
        coef[term.Power] += term.Coef;
      }

      return new PolyFunction(coef);
    }

    #endregion
  }
}