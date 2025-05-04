namespace timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            label1.Visible = true;  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label1.Visible = true;  //timer stops and stopped time keeps displayed

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
    }
}
