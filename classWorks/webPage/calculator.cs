using webPage;

namespace calculatorWinform
{
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
            number1text.Text = "";
            number2text.Text = "";
            //number1text.KeyPress += number1text_KeyPress;
            //number2text.KeyPress += number2text_KeyPress;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(number1text.Text);
            int num2 = int.Parse(number2text.Text);
            int result = num1 + num2;
            answerText.Text = result.ToString();
        }

        private void number1text_TextChanged(object sender, EventArgs e)
        {

        }

        private void subtract_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(number1text.Text);
            int num2 = int.Parse(number2text.Text);
            int result = num1 - num2;
            answerText.Text = result.ToString();
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(number1text.Text);
            int num2 = int.Parse(number2text.Text);
            int result = num1 * num2;
            answerText.Text = result.ToString();
        }

        private void divide_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(number1text.Text);
                int num2 = int.Parse(number2text.Text);
                int result = num1 / num2;
                answerText.Text = result.ToString();

            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Cannot divide by zero");
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            number1text.Text = "";
            //number1text.Clear(); //it is also ok
            number2text.Text = "";
            answerText.Text = "";
        }
    }
}
