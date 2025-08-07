using System;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class Calc : Form
    {
        private double currentValue = 0;
        private double lastValue = 0;
        private string lastOperator = "";
        private bool newEntry = true;

        public Calc()
        {
            InitializeComponent();

            foreach (var btn in new[] { btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 })
                btn.Click += Digit_Click;

            btnDot.Click += BtnDot_Click;

            foreach (var btn in new[] { btnPlus, btnMinus, btnMultiply, btnDivide })
                btn.Click += Operator_Click;

            btnEquals.Click += BtnEquals_Click;
            btnC.Click += BtnClear_Click;
            btnCE.Click += BtnClearEntry_Click;
            btnBackspace.Click += BtnBackspace_Click;
            btnPlusMinus.Click += BtnPlusMinus_Click;
            btnPercent.Click += BtnPercent_Click;
            btnSquare.Click += BtnSquare_Click;
            btnSqrt.Click += BtnSqrt_Click;
            btnInv.Click += BtnInv_Click;
        }

        private void Digit_Click(object sender, EventArgs e)
        {
            string digit = ((Button)sender).Text;
            displayTextBox.Text = newEntry || displayTextBox.Text == "0" ? digit : displayTextBox.Text + digit;
            newEntry = false;
        }

        private void BtnDot_Click(object sender, EventArgs e)
        {
            if (newEntry)
                displayTextBox.Text = "0.";
            else if (!displayTextBox.Text.Contains("."))
                displayTextBox.Text += ".";
            newEntry = false;
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(displayTextBox.Text, out currentValue))
            {
                displayTextBox.Text = "Error";
                return;
            }

            if (!string.IsNullOrEmpty(lastOperator))
                Calculate();
            else
                lastValue = currentValue;

            lastOperator = ((Button)sender).Text;
            newEntry = true;
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(displayTextBox.Text, out currentValue))
            {
                displayTextBox.Text = "Error";
                return;
            }

            Calculate();
            lastOperator = "";
            newEntry = true;
        }

        private void Calculate()
        {
            switch (lastOperator)
            {
                case "+": lastValue += currentValue; break;
                case "−":
                case "-": lastValue -= currentValue; break;
                case "×":
                case "*": lastValue *= currentValue; break;
                case "÷":
                case "/":
                    if (currentValue == 0)
                    {
                        displayTextBox.Text = "Cannot divide by zero";
                        newEntry = true;
                        lastOperator = "";
                        return;
                    }
                    lastValue /= currentValue;
                    break;
            }
            displayTextBox.Text = lastValue.ToString();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            displayTextBox.Text = "0";
            currentValue = lastValue = 0;
            lastOperator = "";
            newEntry = true;
        }

        private void BtnClearEntry_Click(object sender, EventArgs e)
        {
            displayTextBox.Text = "0";
            newEntry = true;
        }

        private void BtnBackspace_Click(object sender, EventArgs e)
        {
            if (!newEntry && displayTextBox.Text.Length > 1)
                displayTextBox.Text = displayTextBox.Text[..^1];
            else
                displayTextBox.Text = "0";
        }

        private void BtnPlusMinus_Click(object sender, EventArgs e)
        {
            if (double.TryParse(displayTextBox.Text, out double val))
                displayTextBox.Text = (-val).ToString();
        }

        private void BtnPercent_Click(object sender, EventArgs e)
        {
            if (double.TryParse(displayTextBox.Text, out double val))
                displayTextBox.Text = (val / 100).ToString();
        }

        private void BtnSquare_Click(object sender, EventArgs e)
        {
            if (double.TryParse(displayTextBox.Text, out double val))
            {
                displayTextBox.Text = (val * val).ToString();
                newEntry = true;
            }
        }

        private void BtnSqrt_Click(object sender, EventArgs e)
        {
            if (double.TryParse(displayTextBox.Text, out double val))
            {
                displayTextBox.Text = val < 0 ? "Invalid input" : Math.Sqrt(val).ToString();
                newEntry = true;
            }
        }

        private void BtnInv_Click(object sender, EventArgs e)
        {
            if (double.TryParse(displayTextBox.Text, out double val))
            {
                displayTextBox.Text = val == 0 ? "Cannot divide by zero" : (1 / val).ToString();
                newEntry = true;
            }
        }
    }
}
