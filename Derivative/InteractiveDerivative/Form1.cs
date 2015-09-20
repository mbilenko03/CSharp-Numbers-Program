using System;
using System.Windows.Forms;
using DerivativeClasses;

namespace InteractiveDerivative
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      try
      {
        PolyFunction function = PolyFunction.Parse(_origTextBox.Text);
        FunctionBase derivativeFunction = function.Derive();
        _derOutput.Text = derivativeFunction.ToString();
      }
      catch (FormatException)
      {
        _derOutput.Text = "Invalid Input";
      }
    }
  }
}
