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
    public partial class MainViewForm : Form
    {
        Form1 loginForm = new Form1();
        ProductAdding addingProductForm = null;
        CustomerAdding addingCustomerForm = null;

        public MainViewForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginForm.Close();
            this.Close();
        }

        private void MainViewForm_Load(object sender, EventArgs e)
        {
            loginForm = new Form1();
            loginForm.ShowDialog();
            toolStripStatusLabel1.Text = $"Logged In as : {loginForm.Username}";
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            textBxOldUserNm.Clear();
            textBxNewUsernm.Clear();
            textBxOldPass.Clear();
            textBxNewPass.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aborted","Cancel",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            panel1.Visible = false;
            return;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (textBxOldUserNm.Text == loginForm.Username && textBxOldPass.Text == loginForm.Password)
            {
                loginForm.ChangeCredentials(textBxNewUsernm.Text, textBxNewPass.Text);
                MessageBox.Show("Successfully Changed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                panel1.Visible = false;
            }
            else if(panel1.Controls.OfType<TextBox>().Any(x => string.IsNullOrEmpty(x.Text)))
            {
                MessageBox.Show("Please Fill All Details", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Old Credentials are wrong!!!","ERROR",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (addingProductForm == null)
            {
                addingProductForm = new ProductAdding();
                addingProductForm.StartPosition = FormStartPosition.CenterParent;
                addingProductForm.ShowDialog();
            }
            else
                addingProductForm.Activate();
            addingProductForm = null;
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(addingCustomerForm == null)
            {
                addingCustomerForm = new CustomerAdding();
                addingCustomerForm.StartPosition = FormStartPosition.CenterParent;
                addingCustomerForm.ShowDialog();
            }
            else
                addingCustomerForm.Activate();
            addingCustomerForm = null;
        }
    }
}




