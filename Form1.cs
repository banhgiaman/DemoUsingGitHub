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


        private void button4_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("ban muon dong","thong Bao",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            Application.Exit();

        }
    }
}
