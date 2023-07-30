using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class App1 : Form
    {
        public App1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "" || emailTextBox.Text == "" || passwordTextBox.Text == "")
            {
                MessageBox.Show("Please fill all fields");
            }
            else
            {
                var username = usernameTextBox.Text;
                MessageBox.Show("Logged in as" + "" + username);
                Homepage homepage = new Homepage();
                homepage.Show();
                this.Hide();
               
            }
        }
    }
}
