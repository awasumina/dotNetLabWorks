using System.Text.RegularExpressions;

namespace loginWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textPassword.PasswordChar = '*'; // Set the password character to '*'
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Login button clicked");
            string username = textUsername.Text;
            string password = textPassword.Text;

            if (IsValidEmail(username))
            {
                if (!string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please enter a password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void textUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private bool IsValidEmail(string email)
        {
            // Simple email validation
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }
    }
}
