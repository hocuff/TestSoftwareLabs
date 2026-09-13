using WinFormsApp1.operations;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private double firstNum;
        private string operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void one_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void comma_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
            {
                textBox1.Text += ",";
            }
        }


        private void delete_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = String.Empty;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(textBox1.Text);
            operation = "+";
            textBox1.Clear();
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(textBox1.Text);
            operation = "-";
            textBox1.Clear();
        }

        private void division_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(textBox1.Text);
            operation = "/";
            textBox1.Clear();
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(textBox1.Text);
            operation = "*";
            textBox1.Clear();
        }

        private void equal_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBox1.Text) || textBox1.Text == "-")
            {
                return;
            }

            if(string.IsNullOrEmpty(operation))
            {
                return;
            }

            double secondNum = double.Parse(textBox1.Text);

            if(operation == "/" && secondNum == 0)
            {
                textBox1.Text = "На ноль делить нельзя";
                operation = "";
                return;
            }

            double result = Calculate(firstNum, secondNum, operation);

            textBox1.Text = result.ToString();

            firstNum = result;
            operation = "";
        }

        private double Calculate(double first, double second, string op)
        {
            switch (op)
            {
                case "+":
                    return new Addition().Calculate(first, second);

                case "-":
                    return new Subtraction().Calculate(first, second);

                case "*":
                    return new Multiplication().Calculate(first, second);

                case "/":
                    return new Division().Calculate(first, second);

                default:
                    return second;
            }
        }
    }
}