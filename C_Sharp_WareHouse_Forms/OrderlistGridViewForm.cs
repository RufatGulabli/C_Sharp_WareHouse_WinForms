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
    public partial class OrderlistGridViewForm : Form
    {
        Containers container;
        OrderAdding addingOrderForm = null;
        public OrderlistGridViewForm(Containers cont)
        {
            InitializeComponent();
            container = cont;
            container.OrdersUpdate += UpdateDataGrid;
        }

        private void OrderlistGridViewForm_Load(object sender, EventArgs e)
        {
            DataTable table = ConvertToDataTable();
            dataGridView1.DataSource = table;
        }

        private void UpdateDataGrid()
        {
            DataTable table = ConvertToDataTable();
            dataGridView1.DataSource = table;
        }

        private void OrderlistGridViewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (addingOrderForm == null)
            {
                addingOrderForm = new OrderAdding(container);
                addingOrderForm.StartPosition = FormStartPosition.CenterParent;
                addingOrderForm.FormClosed += AddingOrderForm_FormClosed;
                addingOrderForm.ShowDialog();
            }
            else
                addingOrderForm.Activate();
        }

        private void AddingOrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            addingOrderForm = null;
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
                    container.DeleteOrder(id);
                    MessageBox.Show("Removed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return;
            }
            catch
            {
                MessageBox.Show("No any Order Selected", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable ConvertToDataTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add(new DataColumn("Order ID", typeof(int)));
            table.Columns.Add(new DataColumn("Client", typeof(Customer)));
            table.Columns.Add(new DataColumn("Product ID", typeof(Product)));
            table.Columns.Add(new DataColumn("Quantity", typeof(int)));
            table.Columns.Add(new DataColumn("Ordered Time", typeof(DateTime)));
            table.Columns.Add(new DataColumn("Order Status", typeof(OrderStatus)));
            var list = Containers.OrderList;
            foreach (Order item in list)
            {
                DataRow row = table.NewRow();
                row["Order ID"] = item.OrderID;
                row["Client"] = item.Client;
                row["Product ID"] = item.Product;
                row["Quantity"] = item.Quantity;
                row["Ordered Time"] = item.OrderedTime.ToShortDateString();
                row["Order Status"] = item.Status;
                table.Rows.Add(row);
            }
            return table;
        }
    }
}
