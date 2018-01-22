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
        OrderAdding addingOrderForm = null;
        Containers containers = new Containers();
        CustomerDataGridView customerDataGridForm = null;

        public MainViewForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginForm.Close();
            this.Close();
        }

        private void MainViewForm_FormClosed1(object sender, FormClosedEventArgs e)
        {
            SaveLoadtoFile.SaveCustomerstoXml();
        }

        private void MainViewForm_Load(object sender, EventArgs e)
        {
            SaveLoadtoFile.LoadCustomersFromXML();
            Product.IDCounter = Containers.GetLastProductID();
            Customer.IDCounter = Containers.GetLastCustomerID();
            Order.IDCounter = Containers.GetLastOrderID();
            loginForm = new Form1();
            loginForm.FormClosed += LoginForm_FormClosed;
            loginForm.ShowDialog();
            toolStripStatusLabel1.Text = $"Logged In as : {loginForm.Username}";
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginForm = null;
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
                MessageBox.Show("Please Fill All Details", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            else
                MessageBox.Show("Old Credentials are wrong!!!","ERROR",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (addingProductForm == null)
            {
                addingProductForm = new ProductAdding(containers);
                addingProductForm.StartPosition = FormStartPosition.CenterParent;
                addingProductForm.FormClosed += AddingProductForm_FormClosed;
                addingProductForm.ShowDialog();
            }
            else
                addingProductForm.Activate();
            
        }

        private void AddingProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            addingProductForm = null;
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(addingCustomerForm == null)
            {
                addingCustomerForm = new CustomerAdding(containers);
                addingCustomerForm.StartPosition = FormStartPosition.CenterParent;
                addingCustomerForm.FormClosed += AddingCustomerForm_FormClosed;
                addingCustomerForm.ShowDialog();
            }
            else
                addingCustomerForm.Activate();
        }

        private void AddingCustomerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            addingCustomerForm = null;
        }

        private void addNewOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (addingOrderForm == null)
            {
                addingOrderForm = new OrderAdding();
                addingOrderForm.StartPosition = FormStartPosition.CenterParent;
                addingOrderForm.FormClosed += AddingOrderForm_FormClosed;
                addingOrderForm.Show();
            }
            else
                addingOrderForm.Activate();
        }

        private void AddingOrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            addingOrderForm = null;
        }

        private void listOfCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (customerDataGridForm == null)
            {
                customerDataGridForm = new CustomerDataGridView(containers, addingCustomerForm);
                customerDataGridForm.StartPosition = FormStartPosition.CenterParent;
                customerDataGridForm.MdiParent = this;
                customerDataGridForm.FormClosed += AddingProductForm_FormClosed;
                customerDataGridForm.Show();
            }
            else
                customerDataGridForm.Activate();
        }

    }

}




