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
    public partial class CustomerDataGridView : Form
    {
        Containers containers;
        CustomerAdding CustomerAddingForm;

        public CustomerDataGridView(Containers cont)
        {
            InitializeComponent();
            containers = cont;
            containers.ListUpdate += UpdateDataGrid;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CustomerAddingForm == null)
            {
                CustomerAddingForm = new CustomerAdding(containers);
                CustomerAddingForm.StartPosition = FormStartPosition.CenterParent;
                CustomerAddingForm.FormClosed += CustomerAddingForm_FormClosed;
                CustomerAddingForm.ShowDialog();
            }
            else
                CustomerAddingForm.Activate();
        }

        private void CustomerAddingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CustomerAddingForm = null;
        }

        private void CustomerDataGridView_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
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

        private void UpdateDataGrid()
        {
            dataGridView1.Rows.Clear();
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

        private void btnSaveUpd_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            containers.UpdateCustomer(index, txtBxNameUpd.Text, txtBxSurnameUpd.Text, txtBoxEmailUpd.Text,
                maskdTxtBxPhoneUpd.Text, richTxtBxAddrUpd.Text);
            MessageBox.Show("Successfully Updated", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                pnlUpdate.Visible = true;
                txtBxNameUpd.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtBxSurnameUpd.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtBoxEmailUpd.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                maskdTxtBxPhoneUpd.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                richTxtBxAddrUpd.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                dataGridView1.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Please Choose Customer to Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                pnlUpdate.Visible = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            if (MessageBox.Show("Are you sure to remove selected item?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                containers.DeleteCustomer(id);
                MessageBox.Show("Removed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return;
        }

        private void CustomerDataGridView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}
