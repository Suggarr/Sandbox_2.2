using System;
using System.Windows.Forms;

namespace Лаб._раб_2
{
    public partial class Form1 : Form
    {
        private double currentValue = 0;
        private string currentOperator = "";
        private bool isNewNumber = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            if (isNewNumber)
            {
                richTextBox1.Text = "";
                isNewNumber = false;
            }

            Button button = (Button)sender;
            richTextBox1.Text += button.Text;
        }
        private void DecimalButton_Click(object sender, EventArgs e)
        {
            if (!richTextBox1.Text.Contains(","))
            {
                richTextBox1.Text += ",";
            }
        }
        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string newOperator = button.Text;

            if (!string.IsNullOrEmpty(currentOperator))
            {
                Calculate();
            }

            currentValue = double.Parse(richTextBox1.Text);
            currentOperator = newOperator;
            isNewNumber = true;
        }

        private void Calculate()
        {
            double secondValue = double.Parse(richTextBox1.Text);

            switch (currentOperator)
            {
                case "+":
                    currentValue += secondValue;
                    break;
                case "-":
                    currentValue -= secondValue;
                    break;
                case "x":
                    currentValue *= secondValue;
                    break;
                case "/":
                    currentValue /= secondValue;
                    break;
                case "%":
                    currentValue = currentValue * secondValue / 100;
                    break;
            }

            richTextBox1.Text = currentValue.ToString();
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            Calculate();
            currentOperator = "";
            isNewNumber = true;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            currentValue = 0;
            currentOperator = "";
            richTextBox1.Text = "0";
            isNewNumber = true;
        }
    }
}