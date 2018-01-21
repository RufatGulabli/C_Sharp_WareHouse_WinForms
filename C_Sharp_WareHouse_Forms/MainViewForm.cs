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

        public MainViewForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginForm.Close();
            //SaveLoadtoFile.SaveCustomerstoXml();
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
                addingCustomerForm = new CustomerAdding();
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
            dataGridView1.Rows.Clear();
            dataGridView1.Visible = true;
            btnAdd.Visible = true;
            btnDelete.Visible = true;
            btnUpdate.Visible = true;
            dataGridView1.Update();
            var list = Containers.GetCustomerList();
            foreach (var item in list)
            {
                string[] row = new string[]
                {
                    item.UniqueID.ToString(),
                    item.FirstName,
                    item.LastName,
                    item.Contact,
                    item.Email,
                    item.Address
                };
                dataGridView1.Rows.Add(row);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (addingCustomerForm == null)
            {
                addingCustomerForm = new CustomerAdding();
                addingCustomerForm.StartPosition = FormStartPosition.CenterParent;
                addingCustomerForm.FormClosed += AddingCustomerForm_FormClosed;
                addingCustomerForm.ShowDialog();
            }
            else
                addingCustomerForm.Activate();
            dataGridView1.Rows.Clear();
            dataGridView1.Visible = true;
            btnAdd.Visible = true;
            btnDelete.Visible = true;
            btnUpdate.Visible = true;
            dataGridView1.Update();
            var list = Containers.GetCustomerList();
            foreach (var item in list)
            {
                string[] row = new string[]
                {
                    item.UniqueID.ToString(),
                    item.FirstName,
                    item.LastName,
                    item.Contact,
                    item.Email,
                    item.Address
                };
                dataGridView1.Rows.Add(row);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            if(MessageBox.Show("Are you sure to remove selected item?","Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Containers.DeleteCustomer(id);
                MessageBox.Show("Removed","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Visible = true;
            btnAdd.Visible = true;
            btnDelete.Visible = true;
            btnUpdate.Visible = true;
            dataGridView1.Update();
            var list = Containers.GetCustomerList();
            foreach (var item in list)
            {
                string[] row = new string[]
                {
                    item.UniqueID.ToString(),
                    item.FirstName,
                    item.LastName,
                    item.Contact,
                    item.Email,
                    item.Address
                };
                dataGridView1.Rows.Add(row);
            }
            return;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            pnlUpdate.Visible = true;
            
            txtBxNameUpd.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtBxSurnameUpd.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtBoxEmailUpd.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            maskdTxtBxPhoneUpd.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            richTxtBxAddrUpd.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void btnSaveUpd_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            Containers.UpdateCustomer(index, txtBxNameUpd.Text, txtBxSurnameUpd.Text, txtBoxEmailUpd.Text,
                maskdTxtBxPhoneUpd.Text, richTxtBxAddrUpd.Text);
            MessageBox.Show("Successfully Updated", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            dataGridView1.Rows.Clear();
            dataGridView1.Visible = true;
            btnAdd.Visible = true;
            btnDelete.Visible = true;
            btnUpdate.Visible = true;
            dataGridView1.Update();
            var list = Containers.GetCustomerList();
            foreach (var item in list)
            {
                string[] row = new string[]
                {
                    item.UniqueID.ToString(),
                    item.FirstName,
                    item.LastName,
                    item.Contact,
                    item.Email,
                    item.Address
                };
                dataGridView1.Rows.Add(row);
            }
        }

        private void btnCanXUpd_Click(object sender, EventArgs e)
        {
            pnlUpdate.Visible = false;
        }
    }

}




