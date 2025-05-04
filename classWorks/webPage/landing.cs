using calculatorWinform;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using loginWinform;
using Calculator;


namespace webPage
{
    public partial class landing : Form
    {
        public landing()
        {
            InitializeComponent();
        }
        private void LoadFormIntoPanel(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel3.Controls.Clear(); // optional: clears existing controls
            panel3.Controls.Add(form);
            panel3.Tag = form;
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calculator calculatorPage = new calculator();
            //calculatorPage.Show();
            LoadFormIntoPanel(calculatorPage);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginForm loginPage = new loginForm();
            LoadFormIntoPanel(loginPage);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            registerForm registerPage = new registerForm();
            LoadFormIntoPanel(registerPage);
        }

        private void enableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000; // Set the timer interval to 1 second (1000 milliseconds)
            timer1.Start(); // Start the timer
            timer1.Enabled = true; // Enable the timer
        }

        private void disableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop(); // Stop the timer
            timer1.Enabled = true; //timer stops and stopped time keeps displayed
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("hh:mm:ss tt");

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Or this.Close() if you just want to close the form
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
