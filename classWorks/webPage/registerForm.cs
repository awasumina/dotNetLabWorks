using webPage;
namespace Calculator
{
    public partial class registerForm : Form
    {
        public registerForm()
        {
            InitializeComponent();
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
    }
}
