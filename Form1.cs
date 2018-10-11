using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoUsingGitHub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                int a = int.Parse(textBox1.Text);

            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse("10");

        }
    }
}
