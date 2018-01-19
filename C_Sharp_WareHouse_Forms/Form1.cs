using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_WareHouse_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string Username = "username";
        public string Password = "password";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtBoxName.Text == Username && txtBoxPassw.Text == Password)
            {
                this.Visible = false;
            }
            else if (this.Controls.OfType<TextBox>().Any(x => string.IsNullOrEmpty(x.Text)))
            {
                MessageBox.Show("Please Fill All Details", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("WRONG CREDENTIALS", "ERROR GENERATED",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                    Environment.Exit(0);
                else
                    return;
            }
        }

        public void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        public void ChangeCredentials(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
