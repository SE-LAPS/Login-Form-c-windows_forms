using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "lapz" && txtpassword.Text == "lapz")
            {
                new Form2().Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Your Password or UserName Incorrect...Enter Correct Inputs");
                txtUsername.Clear();
                txtpassword.Clear();
                txtUsername.Focus();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtpassword.Clear();
            txtUsername.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

