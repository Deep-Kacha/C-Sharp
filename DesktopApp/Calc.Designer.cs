namespace DesktopApp
{
    partial class Calc
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox displayTextBox;

        private System.Windows.Forms.Button btnPercent, btnCE, btnC, btnBackspace;
        private System.Windows.Forms.Button btnInv, btnSquare, btnSqrt, btnDivide;
        private System.Windows.Forms.Button btn7, btn8, btn9, btnMultiply;
        private System.Windows.Forms.Button btn4, btn5, btn6, btnMinus;
        private System.Windows.Forms.Button btn1, btn2, btn3, btnPlus;
        private System.Windows.Forms.Button btnPlusMinus, btn0, btnDot, btnEquals;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            displayTextBox = new System.Windows.Forms.TextBox();

            btnPercent = new Button(); btnCE = new Button(); btnC = new Button(); btnBackspace = new Button();
            btnInv = new Button(); btnSquare = new Button(); btnSqrt = new Button(); btnDivide = new Button();
            btn7 = new Button(); btn8 = new Button(); btn9 = new Button(); btnMultiply = new Button();
            btn4 = new Button(); btn5 = new Button(); btn6 = new Button(); btnMinus = new Button();
            btn1 = new Button(); btn2 = new Button(); btn3 = new Button(); btnPlus = new Button();
            btnPlusMinus = new Button(); btn0 = new Button(); btnDot = new Button(); btnEquals = new Button();

            SuspendLayout();
            ClientSize = new System.Drawing.Size(290, 430);
            Name = "Calc";
            Text = "Calculator";

            displayTextBox.Location = new System.Drawing.Point(10, 10);
            displayTextBox.Name = "displayTextBox";
            displayTextBox.ReadOnly = true;
            displayTextBox.Size = new System.Drawing.Size(270, 40);
            displayTextBox.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            displayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            displayTextBox.Text = "0";

            int startX = 10, startY = 60, btnWidth = 60, btnHeight = 40, margin = 5;

            void SetupButton(Button btn, string text, int col, int row)
            {
                btn.Text = text;
                btn.Font = new System.Drawing.Font("Segoe UI", 10F);
                btn.Size = new System.Drawing.Size(btnWidth, btnHeight);
                btn.Location = new System.Drawing.Point(startX + col * (btnWidth + margin), startY + row * (btnHeight + margin));
                Controls.Add(btn);
            }

            // Row-wise layout
            SetupButton(btnPercent, "%", 0, 0);
            SetupButton(btnCE, "CE", 1, 0);
            SetupButton(btnC, "C", 2, 0);
            SetupButton(btnBackspace, "←", 3, 0);

            SetupButton(btnInv, "1/x", 0, 1);
            SetupButton(btnSquare, "x²", 1, 1);
            SetupButton(btnSqrt, "√", 2, 1);
            SetupButton(btnDivide, "÷", 3, 1);

            SetupButton(btn7, "7", 0, 2);
            SetupButton(btn8, "8", 1, 2);
            SetupButton(btn9, "9", 2, 2);
            SetupButton(btnMultiply, "×", 3, 2);

            SetupButton(btn4, "4", 0, 3);
            SetupButton(btn5, "5", 1, 3);
            SetupButton(btn6, "6", 2, 3);
            SetupButton(btnMinus, "−", 3, 3);

            SetupButton(btn1, "1", 0, 4);
            SetupButton(btn2, "2", 1, 4);
            SetupButton(btn3, "3", 2, 4);
            SetupButton(btnPlus, "+", 3, 4);

            SetupButton(btnPlusMinus, "±", 0, 5);
            SetupButton(btn0, "0", 1, 5);
            SetupButton(btnDot, ".", 2, 5);
            SetupButton(btnEquals, "=", 3, 5);

            Controls.Add(displayTextBox);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
