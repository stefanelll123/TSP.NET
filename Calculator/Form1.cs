using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private double PreviewsValue = 0;
        private double CurrentValue = 0;

        private bool alreadyComa = false;
        private double multiply = 0.1;
        private bool newOperation = true;
        private bool negation = false;

        private bool FirstAndNegate() => PreviewsValue == 0 && negation;

        private Func<double, double, double> operation = Default;

        public Form1()
        {
            InitializeComponent();
            input.Text = "";
            currentResult.Text = "";

            button_key_0.Click += CheckComma;
            button_key_1.Click += CheckComma;
            button_key_2.Click += CheckComma;
            button2.Click += CheckComma;
            button_key_4.Click += CheckComma;
            button_key_5.Click += CheckComma;
            button_key_6.Click += CheckComma;
            button_key_7.Click += CheckComma;
            button_key_8.Click += CheckComma;
            button_key_9.Click += CheckComma;
            button_key_0.Click += CheckComma;
        }

        private void CheckComma(object sender, System.EventArgs e)
        {
            if (alreadyComa)
            {
                multiply = multiply * 0.1;
            }
        }

        private void button_clear_Click(object sender, System.EventArgs e)
        {
            newOperation = true;
            ResetDefaultValue();
            CurrentValue = 0;
            currentResult.Text = "";
            operation = Default;
        }

        private void ResetDefaultValue()
        {
            alreadyComa = false;
            multiply = 0.1;
            PreviewsValue = 0;
            input.Text = "";
            negation = false;
        }

        private void buttonEqual_Click(object sender, System.EventArgs e)
        {
            CurrentValue = operation(CurrentValue, PreviewsValue);
            ResetDefaultValue();
            currentResult.Text = CurrentValue.ToString();
            operation = Default;
            newOperation = false;
        }

        private void button_key_1_Click(object sender, System.EventArgs e)
        {
            ChangeInput(1);
        }

        private void button_key_2_Click(object sender, System.EventArgs e)
        {
            ChangeInput(2);
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            ChangeInput(3);
        }

        private void button_key_4_Click(object sender, System.EventArgs e)
        {
            ChangeInput(4);
        }

        private void button_key_5_Click(object sender, System.EventArgs e)
        {
            ChangeInput(5);
        }

        private void button_key_6_Click(object sender, System.EventArgs e)
        {
            ChangeInput(6);
        }

        private void button_key_7_Click(object sender, System.EventArgs e)
        {
            ChangeInput(7);
        }

        private void button_key_8_Click(object sender, System.EventArgs e)
        {
            ChangeInput(8);
        }

        private void button_key_9_Click(object sender, System.EventArgs e)
        {
            ChangeInput(9);
        }

        private void button_key_0_Click(object sender, System.EventArgs e)
        {
            ChangeInput(0);
        }

        private void button_coma_Click(object sender, System.EventArgs e)
        {
            if (!alreadyComa)
            {
                PreviewsValue = PreviewsValue * 10 * 0.1;
                alreadyComa = true;
            }

            if (PreviewsValue == 0)
            {
                input.Text = (negation ? "-" : "") + "0.0";
            }
            else
            {
                input.Text = PreviewsValue.ToString();
            }
        }

        private void ChangeInput(int value)
        {
            if (!alreadyComa)
            {
                PreviewsValue = PreviewsValue * 10 + (negation ? -value : value);
            }
            else
            {
                PreviewsValue = PreviewsValue + multiply * (negation ? -value : value);
            }

            if (negation)
            {
                if (PreviewsValue > 0)
                {
                    PreviewsValue = -PreviewsValue;
                }
            }

            if (PreviewsValue == 0 && negation)
            {
                input.Text = "-0";
            }
            else
            {
                input.Text = PreviewsValue.ToString();
            }
        }

        private void ChangeOperation(Func<double, double, double> op)
        {
            if (newOperation)
            {
                CurrentValue = PreviewsValue;
            }

            currentResult.Text = CurrentValue.ToString();
            ResetDefaultValue();

            operation = op;
            newOperation = false;
        }

        private static double Add(double value1, double value2)
        {
            return value1 + value2;
        }

        private static double Substract(double value1, double value2)
        {
            return value1 - value2;
        }

        private static double Multiply(double value1, double value2)
        {
            return value1 * value2;
        }

        private static double Div(double value1, double value2)
        {
            return value1 / value2;
        }

        private static double Default(double value1, double value2)
        {
            return value2;
        }

        private void button_add_Click(object sender, System.EventArgs e)
        {
            lbOperation.Text = "+";
            ChangeOperation(Add);
        }

        private void button_substract_Click(object sender, EventArgs e)
        {
            lbOperation.Text = "-";
            ChangeOperation(Substract);
        }

        private void button_multiply_Click(object sender, EventArgs e)
        {
            lbOperation.Text = "*";
            ChangeOperation(Multiply);
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            lbOperation.Text = "/";
            ChangeOperation(Div);
        }

        private void buttonSetNegativeNumber_Click(object sender, EventArgs e)
        {
            if (PreviewsValue > 0)
            {
                PreviewsValue = -PreviewsValue;
                input.Text = PreviewsValue.ToString();
            }

            negation = true;
        }

        private void buttonSetPositiveNumber_Click(object sender, EventArgs e)
        {
            negation = false;
            if (PreviewsValue < 0)
            {
                PreviewsValue = -PreviewsValue;
                input.Text = PreviewsValue.ToString();
            }
        }
    }
}
