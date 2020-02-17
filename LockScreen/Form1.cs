using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LockScreen
{
    public partial class Form1 : Form
    {
        bool closed = false;
        string password = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TopMost = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!closed)
                e.Cancel = true;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPassword.Clear();
                txtPassword.Visible = true;
                txtPassword.Focus();
            }
            else if (e.KeyChar == 27)
            {
                txtPassword.Clear();
                txtPassword.Visible = false;
                Focus();
            }
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                txtPassword.Visible = false;
                txtPassword.Clear();
                Focus();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtPassword.Text == "7942")
                {
                    closed = true;
                    Application.Exit();
                }
                else
                    txtPassword.Clear();
            }
        }
    }
}
