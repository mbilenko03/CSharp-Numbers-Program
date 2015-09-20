namespace InteractiveDerivative
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.label1 = new System.Windows.Forms.Label();
      this._origTextBox = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this._derOutput = new System.Windows.Forms.TextBox();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.button1 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(23, 27);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(86, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Original function:";
      // 
      // _origTextBox
      // 
      this._origTextBox.Location = new System.Drawing.Point(132, 24);
      this._origTextBox.Name = "_origTextBox";
      this._origTextBox.Size = new System.Drawing.Size(200, 20);
      this._origTextBox.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(23, 71);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(58, 13);
      this.label2.TabIndex = 0;
      this.label2.Text = "Derivative:";
      // 
      // _derOutput
      // 
      this._derOutput.Location = new System.Drawing.Point(132, 68);
      this._derOutput.Name = "_derOutput";
      this._derOutput.ReadOnly = true;
      this._derOutput.Size = new System.Drawing.Size(200, 20);
      this._derOutput.TabIndex = 1;
      this._derOutput.TabStop = false;
      // 
      // comboBox1
      // 
      this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Items.AddRange(new object[] {
            "Polynomial",
            "Trigonometric"});
      this.comboBox1.Location = new System.Drawing.Point(362, 24);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(108, 21);
      this.comboBox1.TabIndex = 2;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(207, 110);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 3;
      this.button1.Text = "Derive";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(489, 150);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.comboBox1);
      this.Controls.Add(this._derOutput);
      this.Controls.Add(this._origTextBox);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.Text = "Derivative";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox _origTextBox;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox _derOutput;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.Button button1;
  }
}

