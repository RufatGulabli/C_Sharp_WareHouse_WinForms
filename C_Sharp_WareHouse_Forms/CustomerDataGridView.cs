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
            containers.CustomersUpdate += UpdateDataGrid;
            
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
            DataTable table  = ConvertToDataTable(Containers.CustomerList);
            dataGridView1.DataSource = table;
        }

        private void UpdateDataGrid()
        {
            DataTable table = ConvertToDataTable(Containers.CustomerList);
            dataGridView1.DataSource = table;
        }

        private void btnSaveUpd_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            containers.UpdateCustomer(index, txtBxNameUpd.Text, txtBxSurnameUpd.Text, txtBoxEmailUpd.Text,
                maskdTxtBxPhoneUpd.Text, richTxtBxAddrUpd.Text);
            MessageBox.Show("Successfully Updated", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.Enabled = true;
            pnlUpdate.Visible = false;
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                pnlUpdate.Visible = true;
                txtBxNameUpd.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtBxSurnameUpd.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtBoxEmailUpd.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                maskdTxtBxPhoneUpd.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                richTxtBxAddrUpd.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                txtboxNameSearch.Enabled = false;
                txtBxSurnameSearch.Enabled = false;
                txtBxEmailSearch.Enabled = false;
                msktxtBxSearch.Enabled = false;
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
            try
            {
                if (dataGridView1.SelectedRows is null || dataGridView1.SelectedRows[0].Cells[0].Value == null)
                    throw new Exception("No any element to remove");
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                if (MessageBox.Show("Are you sure to remove selected item?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    containers.DeleteCustomer(id);
                    MessageBox.Show("Removed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return;
            }
            catch
            {
                MessageBox.Show("No any Customer Selected", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CustomerDataGridView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }

        private void btnCanXUpd_Click(object sender, EventArgs e)
        {
            pnlUpdate.Visible = false;
            dataGridView1.Enabled = true;
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            txtboxNameSearch.Enabled = true;
            txtBxSurnameSearch.Enabled = true;
            txtBxEmailSearch.Enabled = true;
            msktxtBxSearch.Enabled = true;
        }

        public static DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }

        private void txtboxNameSearch_Leave(object sender, EventArgs e)
        {
            if (txtboxNameSearch.Text == "")
            {
                txtboxNameSearch.Text = "Search by Name";
                txtboxNameSearch.ForeColor = Color.Silver;
            }
        }

        private void txtBxSurnameSearch_Leave(object sender, EventArgs e)
        {
            if (txtBxSurnameSearch.Text == "")
            {
                txtBxSurnameSearch.ForeColor = Color.Silver;
                txtBxSurnameSearch.Text = "Search by Surname";
            }

        }

        private void txtBxEmailSearch_Leave(object sender, EventArgs e)
        {
            if (txtBxEmailSearch.Text == "")
            {
                txtBxEmailSearch.ForeColor = Color.Silver;
                txtBxEmailSearch.Text = "Search by Email";
            }
        }

        private void txtboxNameSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string keyword = txtboxNameSearch.Text;
            var matchedItems = (int.TryParse(keyword, out int digit) ?
                 throw new Exception("Please type only letters"):
                 Containers.CustomerList.FindAll(item => item.FirstName.IndexOf
                 (keyword, 0,StringComparison.OrdinalIgnoreCase) == 0)).ToList();
            DataTable table = ConvertToDataTable(matchedItems);
            dataGridView1.DataSource = table;
        }

        private void txtBxSurnameSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string keyword = txtBxSurnameSearch.Text;
            var matchedItems = (int.TryParse(keyword, out int digit) ?
                 throw new Exception("Please type only letters") :
                 Containers.CustomerList.FindAll(item => item.LastName.IndexOf
                 (keyword, 0, StringComparison.OrdinalIgnoreCase) == 0)).ToList();
            DataTable table = ConvertToDataTable(matchedItems);
            dataGridView1.DataSource = table;
        }

        private void txtBxEmailSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string keyword = txtBxEmailSearch.Text;
            var matchedItems = (int.TryParse(keyword, out int digit) ?
                 throw new Exception("Please type only letters") :
                 Containers.CustomerList.FindAll(item => item.Email.IndexOf
                 (keyword, 0, StringComparison.OrdinalIgnoreCase) == 0)).ToList();
            DataTable table = ConvertToDataTable(matchedItems);
            dataGridView1.DataSource = table;
        }

        private void ClearText(object sender, EventArgs e)
        {
            var txtBxSearch = (sender as TextBox);
            if (txtBxSearch.Text.Contains("Search by "))
            {
                txtBxSearch.Text = "";
                txtBxSearch.ForeColor = Color.Black;
            }
        }

        private void msktxtBxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            var matchedItems = Containers.CustomerList.FindAll(item => item.Contact.Equals(msktxtBxSearch.Text));
            //var matchedItems = Containers.CustomerList.FindAll(item => item.Contact.IndexOf
            //(msktxtBxSearch.Text, 0, StringComparison.OrdinalIgnoreCase) == 0).ToList();
            DataTable table = ConvertToDataTable(matchedItems);
            dataGridView1.DataSource = table;
        }

        private void msktxtBxSearch_Enter(object sender, EventArgs e)
        {
            msktxtBxSearch.ForeColor = Color.Black;
            msktxtBxSearch.Text = "";
        }
    }
}
