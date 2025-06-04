//using FormInheritance;
using System.Reflection;
using webPage;
using webPage.Models;
using webPage.Service;
namespace Calculator

{
    public partial class registerForm : Form
    {
        public registerForm()
        {
            InitializeComponent();
            getAllUsers();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void getAllUsers()
        {
            DatabaseService databaseService = new DatabaseService();
            var result = databaseService.getAllUsers();
            if (result != null)
            {
                registerFormBindingSource.DataSource = result;
            }
            else
            {
                MessageBox.Show("Error: ");
            }

        }


        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    var province = comboBox1.SelectedItem.ToString();
        //    comboBox2.Items.Clear();

        //    switch (province)
        //    {
        //        case "Bagmati":
        //            comboBox2.Items.Add("Kathmandu");
        //            comboBox2.Items.Add("Bhaktapur");
        //            comboBox2.Items.Add("Lalitpur");
        //            break;
        //        case "Gandaki":
        //            comboBox2.Items.Add("Kaski");
        //            comboBox2.Items.Add("Lamjung");
        //            comboBox2.Items.Add("Manang");
        //            break;
        //        default:
        //            comboBox2.Items.Clear();
        //            break;
        //    }
        //}

        //above is one by one item add, rather than below have list and add range
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var province = comboBox1.SelectedItem.ToString();
            List<string> bagmatiDistricts = new List<string> { "Kathmandu", "Bhaktapur", "Lalitpur" };
            List<string> gandakiDistricts = new List<string> { "Kaski", "Lamjung", "Manang" };

            comboBox2.Items.Clear();

            switch (province)
            {
                case "Bagmati":
                    comboBox2.Items.AddRange(bagmatiDistricts.ToArray());
                    break;
                case "Gandaki":
                    comboBox2.Items.AddRange(gandakiDistricts.ToArray());
                    break;
                default:
                    comboBox2.Items.Clear();
                    break;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //display a message saying registered:
            MessageBox.Show("Register button is clicked");
            //DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //textBox1.Text==""?0:Convert.ToInt32(textBox1.Text);
            //string name = textBox1.Text;
            //int age = (int)numericUpDown1.Value;
            //string Province = comboBox1.Text.Trim();

            string name = textBox1.Text.Trim();
            int age = (int)numericUpDown1.Value;
            string province = comboBox1.Text.Trim();
            string district = comboBox2.Text.Trim();
            //bool hasSkill = checkedListBox1.CheckedItems.Count > 0;

            // Determine selected gender
            //string gender = "";
            //if (radioButton1.Checked)
            //    gender = "Male";
            //else
            //    gender = "Female";


            //// Validation check
            if (string.IsNullOrEmpty(name) || age <= 16 || string.IsNullOrEmpty(province) ||
                string.IsNullOrEmpty(district))
            {
                MessageBox.Show("Please fill all the fields properly, select a gender, and choose at least one skill.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Pass gender to Reg form if needed (not shown here)
                //Reg welcomeForm = new Reg();
                //welcomeForm.Show();
                //this.Hide();
            }
            RegisterForm register = new RegisterForm()
            {
                Name = name,
                Age = age,
                //Gender = gender,
                District = district,
                Province = province,
            };
            DatabaseService databaseService = new DatabaseService();
            string message = databaseService.load_register(register);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}